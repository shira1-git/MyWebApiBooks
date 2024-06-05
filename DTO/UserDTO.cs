using Entities;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 288bcff (add configuration)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
<<<<<<< HEAD
        public string? UserName { get; set; } 
=======
        public string UserName { get; set; } = null!;
>>>>>>> 288bcff (add configuration)

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

<<<<<<< HEAD
        public string? Password { get; set; } 

        [EmailAddress(ErrorMessage = "invalid email")]
        public string? Email { get; set; }
=======
        public string Password { get; set; } = null!;

        public string? Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
>>>>>>> 288bcff (add configuration)
    }
}
