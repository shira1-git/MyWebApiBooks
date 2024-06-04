using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserWithIDDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
    }
}
