using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Mgmt_System___BTM495
{
    public class Appointment_Mgmt_System
    {
        public required string currentTime { get; set; }
        public required string differenceTime { get; set; }
        public required string currentDate { get; set; }
        public required string differenceDate { get; set; }
        public required Appointment Appointment { get; set; } //Navigation Property
        public required User User { get; set; } //Navigation Property
    }
}
