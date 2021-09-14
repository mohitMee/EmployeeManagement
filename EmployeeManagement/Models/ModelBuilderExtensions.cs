using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Mohit",
                    Department = Dept.IT,
                    Email = "mohit@gmail.com"
                }
              );
        }
    }
}
