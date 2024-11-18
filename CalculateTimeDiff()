using System;
using System.Collections.Generic;
using System.Net.Mail;
using Microsoft.Data.SqlClient;

namespace Appointment_Mgmt_System___BTM495
{
    public class AppointmentManagementSystem
    {
        private readonly string connectionString = "Data Source=DESKTOP-MN\\SQLEXPRESS;Initial Catalog=\"BTM495 DB\";Integrated Security=True;Encrypt=True;Trust Server Certificate=True"; // Replace with your actual connection string

        public void CalculateTimeDiff()
        {
            var appointments = RequestAPTInfo();
            Console.WriteLine("Fetched appointments.");

            foreach (var appointment in appointments)
            {
                DateTime today = DateTime.Now;
                TimeSpan timeDiff = appointment.AppointmentDateStart - today;
                Console.WriteLine($"Checking appointment {appointment.AppointmentID} with time difference: {timeDiff.TotalHours} hours.");

                if (timeDiff.TotalHours <= 24 && timeDiff.TotalHours > 23) // Adding range for 24 hours condition
                {
                    var userInfo = RequestUserInfo(appointment.User.UserID);
                    Console.WriteLine($"Sending email to: {userInfo.Email}");
                    SendEmail(userInfo.FirstName, userInfo.LastName, userInfo.Email, appointment);
                }
            }
        }

        // Method to request appointment information
        private List<Appointment> RequestAPTInfo()
        {
            List<Appointment> appointments = new List<Appointment>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT a.AppointmentID, a.AppointmentDateStart, a.AppointmentDateEnd, a.Room, a.Detail, a.Status, a.CancellationDate, " +
                    "u.UserID, u.FirstName, u.LastName, u.Email " +
                    "FROM Appointments a INNER JOIN Users u ON a.UserID = u.UserID",
                    connection
                );

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new Users(
                        (int)reader["UserID"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Email"].ToString()
                    );

                    var appointment = new Appointment(
                        (int)reader["AppointmentID"],
                        user.UserID, // Assuming 'user' is an object with a 'UserID' property
                        user.FirstName, // Assuming 'user' has a 'FirstName' property
                        user.LastName, // Assuming 'user' has a 'LastName' property
                        (DateTime)reader["AppointmentDateStart"],
                        (DateTime)reader["AppointmentDateEnd"],
                        reader["Room"].ToString(),
                        reader["Detail"].ToString(),
                        reader["Status"].ToString(),
                        reader["CancellationDate"] as DateTime?
                    );

                    appointments.Add(appointment);
                }
            }
            return appointments;
        }

        // Method to request user information
        private Users RequestUserInfo(int userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT UserID, FirstName, LastName, Email FROM Users WHERE UserID = @UserID",
                    connection
                );

                command.Parameters.AddWithValue("@UserID", userID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Users(
                        (int)reader["UserID"],
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["Email"].ToString()
                    );
                }
            }
            throw new Exception("User not found");
        }

        // Method to send email notification
        private void SendEmail(string firstName, string lastName, string email, Appointment appointment)
        {
            string subject = "Appointment Reminder";
            string body = $"Dear {firstName} {lastName},\n\nThis is a reminder for your appointment scheduled on {appointment.AppointmentDateStart} in {appointment.Room}.\n\nBest regards,\nBiosignal Analysis Laboratory of McGill";

            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");

                mailMessage.From = new MailAddress("Biosignal.labBTM495@gmail.com");
                mailMessage.To.Add(email);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential("Biosignal.labBTM495@gmail.com", "vwhk hosp wfty ahdu");
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                Console.WriteLine($"Email sent successfully to: {email}");
            }
            catch (SmtpException smtpEx)
            {
                Console.WriteLine($"SMTP Error: {smtpEx.Message}\n{smtpEx.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}
