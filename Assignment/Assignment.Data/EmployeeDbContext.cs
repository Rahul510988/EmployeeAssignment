using Assignment.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class EmployeeDbContext : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeesAddress { get; set; }
        public virtual DbSet<EmployeePhone> EmployeesPhone { get; set; }


        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }

        protected EmployeeDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=myServerName\\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;");
            optionsBuilder.UseSqlServer("Server=(local);Database=myDataBase;Trusted_Connection=True;Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasKey(e => e.EmployeeId);
                e.Property(e => e.EmployeeNumber).IsRequired();
                e.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
                e.Property(e => e.LastName).IsRequired().HasMaxLength(30);
                e.Property(e=> e.HireDate).IsRequired();
            });

            modelBuilder.Entity<EmployeeAddress>(e =>
            {
                e.HasKey(e => e.EmployeeAddressId);
                e.Property(e => e.EmployeeId).IsRequired();
                e.Property(e => e.Address1).IsRequired().HasMaxLength(100);
                e.Property(e => e.Address2).IsRequired().HasMaxLength(100);
                e.Property(e => e.City).IsRequired().HasMaxLength(50);
                e.Property(e => e.State).IsRequired().HasMaxLength(50);
                e.Property(e => e.ZipCode).IsRequired().HasMaxLength(5);

            });

            modelBuilder.Entity<EmployeePhone>(e =>
            {
                e.HasKey(e => e.EmployeePhoneId);
                e.Property(e => e.EmployeeId).IsRequired();
                e.Property(e => e.PhoneNumber).IsRequired();
                e.Property(e => e.PhoneType).IsRequired().HasMaxLength(10);

            });

            base.OnModelCreating(modelBuilder);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
