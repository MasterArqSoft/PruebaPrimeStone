using PrimeStone.Core.Common;
using System;

namespace PrimeStone.Core.Models
{
    public class User : Entidad
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Telephone { get; set; }
        public bool IsActive { get; set; }
    }
}
