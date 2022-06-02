using GamingCenter.Data;
using GamingCenter.Data.Models;
using GamingCenter.Data.Services;
using GamingCenter.Data.ViewModels;
using Moq;
using NUnit.Framework;

namespace GaminCenterTests
{
    public class Tests
    {
        private Mock<AppDbContext> _context;
        private ClientsServices _clientServices;

        [SetUp]
        public void Setup()
        {
            _context = new Mock<AppDbContext>();
            _clientServices = new ClientsServices(_context.Object);
        }

        [Test]
        public void Test1()
        {
            var client = new Clients();
            
            _context.Setup(x => x.Clients.Add(client));
            _context.Setup(x => x.SaveChanges());

            _clientServices.AddClient(new ClientsVM());

            Assert.IsTrue(true);
        }
    }
}