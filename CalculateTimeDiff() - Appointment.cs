public class Appointment
{
    public int AppointmentID { get; set; }
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime AppointmentDateStart { get; set; }
    public DateTime AppointmentDateEnd { get; set; }
    public string Room { get; set; }
    public string Detail { get; set; }
    public string Status { get; set; }
    public DateTime? CancellationDate { get; set; }

    public Appointment(int appointmentID, int userID, string firstName, string lastName, DateTime appointmentDateStart, DateTime appointmentDateEnd, string room, string detail, string status, DateTime? cancellationDate)
    {
        AppointmentID = appointmentID;
        UserID = userID;
        FirstName = firstName;
        LastName = lastName;
        AppointmentDateStart = appointmentDateStart;
        AppointmentDateEnd = appointmentDateEnd;
        Room = room;
        Detail = detail;
        Status = status;
        CancellationDate = cancellationDate;
    }
}
