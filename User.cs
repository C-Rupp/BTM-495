using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Mgmt_System___BTM495
{
    public class User
    {
        public int UserId { get; set; }
        public required string Role { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public required string DateOfBirth { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
