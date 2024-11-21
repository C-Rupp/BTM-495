using System;

public class ParticipantRegistration
{
    public int UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public float Weight { get; set; }
    public float Height { get; set; }
    public string EmergencyContactNumber { get; set; }
    public string EmergencyContactPerson { get; set; }

    public ParticipantRegistration(int userID, string firstName, string lastName, string gender, DateTime dateOfBirth, string email, string password, float weight, float height, string emergencyContactNumber, string emergencyContactPerson)
    {
        UserID = userID;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        DateOfBirth = dateOfBirth;
        Email = email;
        Password = password;
        Weight = weight;
        Height = height;
        EmergencyContactNumber = emergencyContactNumber;
        EmergencyContactPerson = emergencyContactPerson;
    }
}

public class RegistrationSystem
{
    private static ParticipantRegistration[] participants = new ParticipantRegistration[100]; // Array to hold up to 100 participants
    private static int currentIndex = 0; // Tracks the current position in the array

    public string CreateParticipantProfile(int userID, string firstName, string lastName, string gender, DateTime dateOfBirth, string email, string password, float weight, float height, string emergencyContactNumber, string emergencyContactPerson)
    {
        // Check if email already exists in the array
        for (int i = 0; i < currentIndex; i++)
        {
            if (participants[i] != null && participants[i].Email == email)
            {
                return "Error: A profile with this email already exists.";
            }
        }

        // Check if array is full
        if (currentIndex >= participants.Length)
        {
            return "Error: Registration system is full. Cannot add more participants.";
        }

        // Create a new participant profile and add to the array
        ParticipantRegistration participant = new ParticipantRegistration(userID, firstName, lastName, gender, dateOfBirth, email, password, weight, height, emergencyContactNumber, emergencyContactPerson);
        participants[currentIndex] = participant;
        currentIndex++;

        return "Participant profile successfully registered.";
    }
}

class Program
{
    static void Main(string[] args)
    {
        RegistrationSystem registrationSystem = new RegistrationSystem();

        Console.WriteLine("Welcome to the Participant Registration System!");
        Console.WriteLine("Please enter your details below.");

        // Collect inputs
        Console.Write("Enter User ID: ");
        int userID = int.Parse(Console.ReadLine());

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter Date of Birth (yyyy-MM-dd): ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter Weight (kg): ");
        float weight = float.Parse(Console.ReadLine());

        Console.Write("Enter Height (cm): ");
        float height = float.Parse(Console.ReadLine());

        Console.Write("Enter Emergency Contact Number: ");
        string emergencyContactNumber = Console.ReadLine();

        Console.Write("Enter Emergency Contact Person: ");
        string emergencyContactPerson = Console.ReadLine();

        // Register the participant
        string result = registrationSystem.CreateParticipantProfile(userID, firstName, lastName, gender, dateOfBirth, email, password, weight, height, emergencyContactNumber, emergencyContactPerson);

        // Display the result
        Console.WriteLine(result);
    }
}
