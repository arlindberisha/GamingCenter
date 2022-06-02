using GamingCenter.Data.Models;
using GamingCenter.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GamingCenter.Data.Services
{
    public class WorkersServices
    {
        private AppDbContext _context;
        public WorkersServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddWorkers(WorkersVM worker)
        {
            var _worker = new Workers()
            {
                Name = worker.Name,
                Gender = worker.Gender,
                DateStarted = DateTime.Now,
                SectorsId=worker.SectorId
            };
            _context.Workers.Add(_worker);
            _context.SaveChanges();
        }
        public List<Workers> GetAllWorkers() => _context.Workers.ToList();
        public WorkersWithSectorsVM GetWorkerById(int workerId)
        {
            var _workerWithSector = _context.Workers.Where(n=>n.Id==workerId).Select(worker => new WorkersWithSectorsVM()
            {
                Name = worker.Name,
                Gender = worker.Gender,
                SectorName = worker.Sectors.Name
            }).FirstOrDefault();
            return _workerWithSector;
        }
        public Workers UpdateWorkerById(int workerId,WorkersVM worker)
        {
            var _worker=_context.Workers.FirstOrDefault(n=>n.Id==workerId);
            if (_worker != null)
            {
                _worker.Name=worker.Name;
                _worker.Gender=worker.Gender;
                _worker.SectorsId=worker.SectorId;
                _context.SaveChanges();
            }
            return _worker;
        }
        public void DeleteWorkerById(int workerId)
        {
            var _worker = _context.Workers.FirstOrDefault(n => n.Id == workerId);
            if(_worker != null)
            {
                _context.Workers.Remove(_worker);
                _context.SaveChanges();
            }
        }

    }
}
