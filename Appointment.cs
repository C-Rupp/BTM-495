using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_Mgmt_System___BTM495
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public required string AppointmentDate { get; set; }
        public required string AppointmentTimeStart { get; set; }
        public required string AppointmentTimeEnd { get; set; }
        public required string Room { get; set; }
        public required string Detail { get; set; }
        public required string Status { get; set; }
        public required string CancellationDate { get; set; }
    }
}
