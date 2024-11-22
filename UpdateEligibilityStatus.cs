namespace Appointment_Mgmt_System___BTM495
{
    public partial class UpdateEligibilityStatus : Form
    {
        public UpdateEligibilityStatus(Appointment_Mgmt_System appointmentMgmtSystem)
        {
            InitializeComponent();
        }

        public UpdateEligibilityStatus(FormMainMenu formMainMenu)
        {
        }

        public void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve inputs
            if (int.TryParse(txtUserId.Text, out int userId))
            {
                if (cmbEligibilityStatus.SelectedItem != null)
                {
                    // Convert the selected dropdown option to a boolean
                    string selectedStatus = cmbEligibilityStatus.SelectedItem.ToString();
                    bool eligibilityStatus = selectedStatus == "Eligible";

                    try
                    {
                        // Call the method to update eligibility
                        Appointment_Mgmt_System.UpdateEligibilityStatus(userId, eligibilityStatus);

                        // Success message
                        MessageBox.Show("Eligibility status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear inputs after update
                        txtUserId.Clear();
                        cmbEligibilityStatus.SelectedIndex = -1; // Reset dropdown
                    }
                    catch (Exception ex)
                    {
                        // Handle database or unexpected errors
                        MessageBox.Show($"An error occurred while updating eligibility status: {ex.Message}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an eligibility status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnHome_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            FormMainMenu mainMenu = new FormMainMenu(null); // Pass null or modify constructor to not require an email
            mainMenu.Show(); // Show the main menu
            this.Close(); // Close the current form
        }
    }
}