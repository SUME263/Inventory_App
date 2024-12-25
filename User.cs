using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Rental_System__Assignment_
{
    public class User
    {
        public string? Id { get; set; }
        public string? Password { get; set; }
        public bool isAdmin { get; set; }
        public bool isCustomer { get; set; }
    }
    
}
