using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Mgmt_System___BTM495
{
    public class Participant : User
    {
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public required string EmergencyContactName { get; set; }
        public required string EmergencyContactPhone { get; set; }
        public required Boolean EligiblityStatus { get; set; }
    }
}
