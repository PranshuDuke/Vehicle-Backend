using Microsoft.EntityFrameworkCore;
using VehicleAPI.Models;

namespace VehicleAPI.Context
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options):base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                RegistrationNo = "AP02CD0202",
                ModelName = "Chevrolet Tavera",
                VehicleType = "SUV",
                NumberOfSeat = 9,
                AcAvailable = "No"

            });
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle

            {
                RegistrationNo = "KL03EF0303",
                ModelName = "Chevrolet Enjoy",
                VehicleType = "SUV",
                NumberOfSeat = 7,
                AcAvailable = "Yes"

            });
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                RegistrationNo = "KA04GH0404",
                ModelName = "Mahindra Tourister",
                VehicleType = "Van",
                NumberOfSeat = 15,
                AcAvailable = "Yes"

            });
            modelBuilder.Entity<Vehicle>().HasData(new Vehicle
            {
                RegistrationNo = "TN01AB0202",
                ModelName = "Chevrolet Tavera",
                VehicleType = "SUV",
                NumberOfSeat = 9,
                AcAvailable = "Yes"

            });
        }
    }
}
