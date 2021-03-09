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
                        User = "ecandelario",
                        UserName = "Erwing",
                        Password = "10000.Dd6gA0wpNFa758a0ENRsKA==.l4OGUevuJYQJ1B1VmTakI8c6u3jtolUZVB4Dqdzr4P4=",
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
