using DriversAPI.Context;
using DriversAPI.Controllers;
using DriversAPI.Interfaces;
using DriversAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;



namespace DriverTest
    {
        public class Tests
        {
            private Mock<IDriverServices> _driverService;
            private DriverDbContext context;
            private DriversController driverController;
            [SetUp]
            public void Setup()
            {
                _driverService = new Mock<IDriverServices>();
                var options = new DbContextOptionsBuilder<DriverDbContext>().Options;
                context = new DriverDbContext(options);
                driverController = new DriversController(_driverService.Object);
            }

            [Test]
            public void Drivers()
            {
                List<Driver> v = new List<Driver>();
                var result = driverController.Drivers();
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);

            }
            public void DriversByVehicleType_WithResponse_Test()
            {
                List<Driver> v = new List<Driver>();
                var result = driverController.DriversByVehicleType("SUV");
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }
            [Test]
            public void DriversByVehicleType_WithoutResponse_Test()
            {
                var result = driverController.DriversByVehicleType("");
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }
            [Test]
            public void AddDriver_WithResponse_Test()
            {
                Driver v = new Driver();
                var result = driverController.AddDriver(v);
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }

            [Test]
            public void AddDriver_WithoutResponse_Test()
            {
                Driver v = new Driver();
                var result = driverController.AddDriver(v);
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }
            [Test]
            public void DeleteDriver_WithResponse_Test()
            {

                var result = driverController.DeleteDriver("AP02CD0202");
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }

            [Test]
            public void DeleteDriver_WithoutResponse_Test()
            {

                var result = driverController.DeleteDriver("");
                var resultStatusCode = result as OkObjectResult;
                Assert.AreEqual(200, resultStatusCode.StatusCode);
            }
        }
    }