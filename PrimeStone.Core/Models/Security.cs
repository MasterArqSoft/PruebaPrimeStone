using PrimeStone.Core.Common;
using PrimeStone.Core.Enumerations;

namespace PrimeStone.Core.Models
{
    public class Security : Entidad
    {
        public string User { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public RoleType Role { get; set; }
    }
}
