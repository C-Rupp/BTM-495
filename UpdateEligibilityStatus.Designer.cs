using System.Diagnostics;
using System.Windows.Forms;

namespace Appointment_Mgmt_System___BTM495
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    partial class UpdateEligibilityStatus
    {
        public System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserId = new Label();
            lblEligibilityStatus = new Label();
            txtUserId = new TextBox();
            cmbEligibilityStatus = new ComboBox();
            btnUpdate = new Button();
            btnHome = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pbMenuBar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuBar).BeginInit();
            SuspendLayout();
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserId.ForeColor = Color.Black;
            lblUserId.Location = new Point(137, 113);
            lblUserId.Name = "lblUserID";
            lblUserId.Size = new Size(65, 21);
            lblUserId.TabIndex = 5;
            lblUserId.Text = "User ID";
            // 
            // lblEligibilityStatus
            // 
            lblEligibilityStatus.AutoSize = true;
            lblEligibilityStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEligibilityStatus.ForeColor = Color.Black;
            lblEligibilityStatus.Location = new Point(584, 113);
            lblEligibilityStatus.Name = "lblEligibilityStatus";
            lblEligibilityStatus.Size = new Size(152, 21);
            lblEligibilityStatus.TabIndex = 9;
            lblEligibilityStatus.Text = "Eligibility Status:";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(137, 159);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(226, 23);
            txtUserId.TabIndex = 3;
            // 
            // cmbEligibilityStatus
            // 
            cmbEligibilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEligibilityStatus.FormattingEnabled = true;
            cmbEligibilityStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEligibilityStatus.ForeColor = Color.Black;
            cmbEligibilityStatus.Items.AddRange(new object[] { "Eligible", "Ineligible" });
            cmbEligibilityStatus.Location = new Point(584, 159);
            cmbEligibilityStatus.Name = "cmbEligibilityStatus";
            cmbEligibilityStatus.Size = new Size(152, 23);
            cmbEligibilityStatus.TabIndex = 10;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(237, 27, 47);
            btnUpdate.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(537, 611);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(344, 42);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnHome
            //
            btnHome.BackColor = Color.FromArgb(237, 27, 47);
            btnHome.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.Control;
            btnHome.Location = new Point(1325, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(75, 23);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(237, 27, 47);
            label1.Font = new Font("Garamond", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 18;
            label1.Text = "McGill";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(237, 27, 47);
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(153, 49);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pbMenuBar
            // 
            pbMenuBar.BackColor = Color.Black;
            pbMenuBar.Location = new Point(-1, 0);
            pbMenuBar.Name = "pbMenuBar";
            pbMenuBar.Size = new Size(1412, 49);
            pbMenuBar.TabIndex = 16;
            pbMenuBar.TabStop = false;
            // 
            // FormUpdateEligibility
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1410, 721);
            Controls.Add(lblUserId);
            Controls.Add(txtUserId);
            Controls.Add(lblEligibilityStatus);
            Controls.Add(cmbEligibilityStatus);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pbMenuBar);
            Controls.Add(btnHome);
            Name = "FormUpdateEligibility";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Eligibility Status";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenuBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public Label lblUserId;
        public Label lblEligibilityStatus;
        public TextBox txtUserId;
        public ComboBox cmbEligibilityStatus;
        public Button btnUpdate;
        public Button btnHome;
        public TextBox txtHome;
        public Label label1;
        public PictureBox pbMenuBar;
        public PictureBox pictureBox2;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
#endregion