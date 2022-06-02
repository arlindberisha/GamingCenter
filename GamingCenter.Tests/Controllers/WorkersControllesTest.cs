using FluentAssertions;
using GamingCenter.Controllers;
using GamingCenter.Data.Services;
using GamingCenter.Tests.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GamingCenter.Tests.Controllers
{
    public class WorkersControllesTest
    {
        public WorkersServices _workersServices;
        public WorkersControllesTest(WorkersServices workersServices)
        {
            _workersServices = workersServices;
        }
        [Fact]
        public void GetWorkers_ShouldReturn200Status()
        {
            //Arrange
            var _workersService = new Mock<WorkersServices>();
            _workersService.Setup(n=>n.GetAllWorkers()).Returns(WorkersMockData.GetWorkers());
            var sut = new WorkersController(_workersService.Object);

            //act
            var result = sut.GetWorkers();

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
//      Castle.DynamicProxy.InvalidProxyConstructorArgumentsException : Can not instantiate proxy of class: GamingCenter.Data.Services.WorkersServices.
//      Could not find a parameterless constructor.