using GamingCenter.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingCenter.Tests.MockData
{
    public class WorkersMockData
    {
        public static List<Workers> GetWorkers()
        {
            return new List<Workers>
            {
                new Workers
                {
                    Id = 1,
                    Name = "ArlindBerisha",
                    Gender = true,
                    DateStarted = DateTime.Now.AddDays(-5),
                    SectorsId = 1
                },
                new Workers
                {
                    Id = 2,
                    Name = "LindBerisha",
                    Gender = true,
                    DateStarted = DateTime.Now.AddDays(-3),
                    SectorsId = 2
                },
                new Workers
                {
                    Id = 3,
                    Name = "OsadBerisha",
                    Gender = false,
                    DateStarted = DateTime.Now,
                    SectorsId = 2
                }
            };
        }
    }
}
