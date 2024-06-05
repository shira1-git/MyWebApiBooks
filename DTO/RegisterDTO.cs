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
    public class RegisterDTO
    {
        public string UserName { get; set; } = null!;

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string Password { get; set; } = null!;

<<<<<<< HEAD
        [EmailAddress(ErrorMessage ="invalid email")]
=======
>>>>>>> 288bcff (add configuration)
        public string? Email { get; set; }
    }
}
