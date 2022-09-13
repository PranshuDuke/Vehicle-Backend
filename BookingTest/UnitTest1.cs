using BookingAPI.Context;
using BookingAPI.Controllers;
using BookingAPI.Interfaces;
using BookingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BookingTest
{
    public class Tests
    {
        private BookingController bookingController;
        private Mock<IBookingService> _bookingService;
        [SetUp]
        public void Setup()
        {
            _bookingService = new Mock<IBookingService>();
            bookingController = new BookingController(_bookingService.Object);
        }

        [Test]
        public void GetAllBookings()
        {
            List<Booking> b = new List<Booking>();

            //_vehicleService.Setup(vs => vs.Vehicles()).Returns(v);
            var result = bookingController.GetAllBookings();
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void UpdateBooking_WithResponse_Test()
        {
            Booking v = new Booking();
            var result = bookingController.UpdateBooking(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void UpdateVehicle_WithoutResponse_Test()
        {
            Booking v = new Booking();
            var result = bookingController.UpdateBooking(v);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void AddBooking_WithResponse_Test()
        {
            Booking b = new Booking();
            var result = bookingController.AddBooking(b);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }

        [Test]
        public void AddBooking_WithoutResponse_Test()
        {
            Booking b = new Booking();
            var result = bookingController.AddBooking(b);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void GetBookingById_WithResonse_Test()
        {
            var result = bookingController.GetBookingById(1);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void GetBookingById_WithoutResonse_Test()
        {
            var result = bookingController.GetBookingById(0);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void GetBookingsByDateTime_WithResponse_Test()
        {
            var d = new DateTime(2008, 5, 1, 8, 30, 52);
            var result = bookingController.GetBookingsByDateTime(d, d);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
        [Test]
        public void GetBookingsByDateTime_WithoutResponse_Test()
        {
            var d = new DateTime(2008, 5, 1, 8, 30, 52);
            var result = bookingController.GetBookingsByDateTime(d, d);
            var resultStatusCode = result as OkObjectResult;
            Assert.AreEqual(200, resultStatusCode.StatusCode);
        }
    }
}