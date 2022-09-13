using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using VehicleAPI.Context;
using VehicleAPI.Controllers;
using VehicleAPI.Interfaces;
using VehicleAPI.Models;
using VehicleAPI.Services;

namespace VehicleTest
{
    public class Tests
    {
        private Mock<IVehicleService> _vehicleService;
        //private static DbContextOptions<VehicleDbContext> dbContextOptions = new DbContextOptions<VehicleDbContext>();
        private VehicleDbContext context;
        private VehicleController vehicleController;
        private VehicleService vehicleService;

        [SetUp]
        public void Setup()
        {
            _vehicleService = new Mock<IVehicleService>();
            var options = new DbContextOptionsBuilder<VehicleDbContext>().Options;
            context = new VehicleDbContext(options);
            //context.Database.EnsureCreated();
            //vehicleService = new VehicleService(context);

            vehicleController = new VehicleController(_vehicleService.Object);

        }

        [Test]
        public void Vehicles()
        {
            List<Vehicle> v = new List<Vehicle>();

            //_vehicleService.Setup(vs => vs.Vehicles()).Returns(v);
            var result = vehicleController.Vehicles();
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);


            // _vehicleService.Setup(vs => )
            //  var result = vehicleService.Vehicles();

            //Assert.That(result.Count, Is.Not.EqualTo(0));

        }
        [Test]
        public void VehiclesByType_WithResponse_Test()
        {
            List<Vehicle> v = new List<Vehicle>();

            //_vehicleService.Setup(vs => vs.VehiclesByType("SUV")).Returns(v);
            var result = vehicleController.VehiclesByType("SUV");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void VehicleByType_WithoutResponse_Test()
        {
            var result = vehicleController.VehiclesByType("");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void UpdateVehicle_WithResponse_Test()
        {
            Vehicle v = new Vehicle();
            var result = vehicleController.UpdateVehicle(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void UpdateVehicle_WithoutResponse_Test()
        {
            Vehicle v = new Vehicle();
            var result = vehicleController.UpdateVehicle(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void VehicleByRegistrationNo_WithResponse_Test()
        {
            List<Vehicle> v = new List<Vehicle>();
            var result = vehicleController.VehicleByRegistrationNo("AP02CD0202");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void VehicleByRegistrationNo_WithoutResponse_Test()
        {
            var result = vehicleController.VehicleByRegistrationNo("");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void AddVehicle_WithResponse_Test()
        {
            Vehicle v = new Vehicle();
            var result = vehicleController.AddVehicle(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void AddVehicle_WithoutResponse_Test()
        {
            Vehicle v = new Vehicle();
            var result = vehicleController.AddVehicle(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void DeleteVehicle_WithResponse_Test()
        {

            var result = vehicleController.DeleteVehicle("AP02CD0202");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void DeleteVehicle_WithoutResponse_Test()
        {

            var result = vehicleController.DeleteVehicle("");
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
    }
}