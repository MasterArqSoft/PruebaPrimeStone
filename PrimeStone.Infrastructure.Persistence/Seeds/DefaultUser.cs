using Microsoft.EntityFrameworkCore;
using PrimeStone.Core.Enumerations;
using PrimeStone.Core.Models;
using System;

namespace PrimeStone.Infrastructure.Persistence.Seeds
{
    public static class DefaultUser
    {
        public static void SeedDefaultUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Security>().HasData(
                    new Security()
                    {
                        Id = 1,
                        User = "Erwing Candelario",
                        UserName = "Erwing",
                        Password = "123",
                        Role = RoleType.Administrator,
                        EstaBorrado = false,
                        FechaActualizacion = DateTime.Now,
                        FechaCreacion = DateTime.Now,
                    }
                );
            modelBuilder.Entity<User>().HasData(
                   new User()
                   {
                        Id= 1,
                        FirstName ="Erwing",
                        LastName = "Candelario",
                        Email    = "ingeniero_79@Hotmail.com",
                        DateOfBirth = new DateTime(1979, 10, 2, 7, 0, 0),
                        Telephone = "3013893448",
                        IsActive  = true,
                  }
            );
        }
    }
}
