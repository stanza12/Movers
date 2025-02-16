using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR_Movers_coursework.Forms
{
    public partial class LblID : Form
    {
        public LblID()
        {
            InitializeComponent();
        }


        private string originalForename;
        private string originalSurname;
        private string originalEmail;
        private string originalTelephoneNumber;
        private string originalPrimaryRole;
        private string originalSecondaryRole;
        private string originalPassword;
        private string originalStatus;
        private string originalHours;





        private void updatetime()
        {
            LblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            updatetime();
        }

        private string Secondrole;
        private string firstrole;

        private void FrmAddStaff_Load(object sender, EventArgs e)
        {
            updatetime();
            hourswork[0] = "1";
            hourswork[1] = "0";
            hourswork[2] = "1";
            hourswork[3] = "0";
            hourswork[4] = "1";
            hourswork[5] = "0";
            hourswork[6] = "1";
            hourswork[7] = "0";
            hourswork[8] = "1";
            hourswork[9] = "0";
            roles(CBRole, CBSecondRole);
            roles(CBRoleEdit, CBSecondRoleEdit);
            CBSecondRoleEdit.SelectedItem = Secondrole;
            CBRole.SelectedIndex = -1;
            CBSecondRole.SelectedIndex = -1;
            this.Size = new Size(802, 565);
            this.Location = new Point(0, 0);

            Size panelSize = new Size(787, 488);
            Point panelLocation = new Point(-1, 39);

            PnlAddStaff.Size = panelSize;
            PnlAddStaff.Location = panelLocation;

            PnlEdit.Size = panelSize;
            PnlEdit.Location = panelLocation;


            PtcMondayRight.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PtcMondayRight.Refresh();
            PtcTuesdayRight.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PtcTuesdayRight.Refresh();
            PtcWednesdayRight.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PtcWednesdayRight.Refresh();
            PtcThursdayRight.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PtcThursdayRight.Refresh();
            PtcFridayRight.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PtcFridayRight.Refresh();

            TxtCurrentPassword.UseSystemPasswordChar = true;
        }

        public void Addstaffresize()
        {

            PnlAddStaff.BringToFront();


        }

        public void Editstaffresize()
        {
            PnlEdit.BringToFront();
        }
        private void Ptctick_Click(object sender, EventArgs e)
        {

        }

        private void TxtForename_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Forename = TxtForename.Text;

            if (customer.errors.Any())
            {

                LblForenameErrors.Text = customer.errors[0];
                ptcX.Visible = true;
                Ptctick.Visible = false;
                LblForenameErrors.Visible = true;
            }
            else
            {
                LblForenameErrors.Text = "";
                LblForenameErrors.Visible = false;
                Ptctick.Visible = true;
                ptcX.Visible = false;
                TxtSurname.Visible = true;
                LblSurname.Visible = true;
            }
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Surname = TxtSurname.Text;

            if (customer.errors.Any())
            {
                LblSurnameErrors.Text = customer.errors[0];
                LblSurnameErrors.Visible = true;

                PtcX1.Visible = true;
                PtcTick1.Visible = false;

            }
            else
            {
                LblSurnameErrors.Text = "";
                LblSurnameErrors.Visible = false;
                PtcTick1.Visible = true;
                PtcX1.Visible = false;
                TxtEmail.Visible = true;
                LblEmail.Visible = true;
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Email = TxtEmail.Text;

            if (customer.errors.Any())
            {
                LblEmailErrors.Text = customer.errors[0];
                LblEmailErrors.Visible = true;

                PtcX2.Visible = true;
                PtcTick2.Visible = false;
            }
            else
            {

                LblEmailErrors.Text = "";
                LblEmailErrors.Visible = false;
                PtcTick2.Visible = true;
                PtcX2.Visible = false;
                TxtPhoneNo.Visible = true;
                LblPhoneNo.Visible = true;
            }
        }

        private void TxtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.TelephoneNumber = TxtPhoneNo.Text;

            if (customer.errors.Any())
            {
                LblPhoneNoErrors.Text = customer.errors[0];
                LblPhoneNoErrors.Visible = true;

                PtcX3.Visible = true;
                PtcTick3.Visible = false;
            }
            else
            {

                PtcTick3.Visible = true;
                PtcX3.Visible = false;
                LblPhoneNoErrors.Text = "";
                LblPhoneNoErrors.Visible = false;
                LblJob.Visible = true;
                CBRole.Visible = true;
            }
        }

        private void CBRole_TextChanged(object sender, EventArgs e)
        {




        }

        private void TxtForename_Enter(object sender, EventArgs e)
        {
            if (TxtForename.Text == "Enter Forename")
            {
                TxtForename.Text = "";
                TxtForename.ForeColor = Color.Black;
            }
        }

        private void TxtForename_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtForename.Text))
            {
                TxtForename.Text = "Enter Forename";
                TxtForename.ForeColor = Color.Gray;
            }
        }

        private void TxtSurname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurname.Text))
            {
                TxtSurname.Text = "Enter Surname";
                TxtSurname.ForeColor = Color.Gray;
            }
        }

        private void TxtSurname_Enter(object sender, EventArgs e)
        {
            if (TxtSurname.Text == "Enter Surname")
            {
                TxtSurname.Text = "";
                TxtSurname.ForeColor = Color.Black;

            }
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "Enter Email")
            {
                TxtEmail.Text = "";
                TxtEmail.ForeColor = Color.Black;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                TxtEmail.Text = "Enter Email";
                TxtEmail.ForeColor = Color.Gray;
            }
        }

        private void TxtPhoneNo_Enter(object sender, EventArgs e)
        {
            if (TxtPhoneNo.Text == "Enter Telephone Number")
            {
                TxtPhoneNo.Text = "";
                TxtPhoneNo.ForeColor = Color.Black;
            }
        }

        private void TxtPhoneNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPhoneNo.Text))
            {
                TxtPhoneNo.Text = "Enter Email";
                TxtPhoneNo.ForeColor = Color.Gray;
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            Classes.Models.MStaff NewStaff = new Classes.Models.MStaff
            {
                Forename = TxtForename.Text,
                Surname = TxtSurname.Text,
                Email = TxtEmail.Text,
                TelephoneNumber = TxtPhoneNo.Text,
                Status = "1"
                
            };

            string password = TxtPassword.Text;
            string confirmPassword = TxtPasswordConfirm.Text;
            string primaryRole = CBRole.SelectedItem != null ? CBRole.SelectedItem.ToString() : null;
            string secondaryRole = CBSecondRole.SelectedItem != null ? CBSecondRole.SelectedItem.ToString() : null;

            string hoursworkString = string.Join("", hourswork);
            MessageBox.Show(hoursworkString, "Hours Work Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (string.IsNullOrEmpty(primaryRole))
            {
                MessageBox.Show("Please select a primary role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Please ensure passwords are the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                NewStaff.RoleID = getid(primaryRole);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {

                Classes.AccessClasses.AStaff aStaff = new Classes.AccessClasses.AStaff();
                int staffID = aStaff.AddStaff(NewStaff, password, primaryRole, secondaryRole);
                aStaff.Hours(staffID, hourswork);


                MessageBox.Show("Staff successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error adding staff: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        public void roles(ComboBox CBRole, ComboBox CBSecondaryRole)
        {
            List<string> roles = getroles();

            CBRole.DataSource = new List<string>(roles);
            CBRole.SelectedIndexChanged += (s, e) => updaterole(CBRole, CBSecondaryRole, roles);
            //  CBRole.SelectedIndex = -1;

            //   CBSecondaryRole.DataSource = null;
            //    CBSecondaryRole.Visible = false;
            //  CBSecondaryRole.SelectedIndex = -1;
        }







        private List<string> getroles()
        {
            List<string> roles = new List<string>();

            using (SqlConnection connection = new SqlConnection(Classes.AccessClasses.AStaff.connectionString))
            {
                connection.Open();
                string query = "SELECT RoleName FROM RoleTable";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roles.Add(reader["RoleName"].ToString());
                        }
                    }
                }
            }
            return roles;
        }





        private void updaterole(ComboBox CBRole, ComboBox CBSecondRole, List<string> roles)
        {
            if (CBRole.SelectedItem != null)
            {
                string primaryRole = CBRole.SelectedItem.ToString();


                CBSecondRole.DataSource = new List<string>(roles);
                CBSecondRole.SelectedIndex = -1;
            }
            else
            {
                CBSecondRole.DataSource = null;
            }
        }







        private int getid(string roleName)
        {

            using (SqlConnection conn = new SqlConnection(SR_Movers_coursework.Classes.AccessClasses.AStaff.connectionString))
            {
                conn.Open();
                string query = "SELECT RoleID FROM RoleTable WHERE RoleName = @RoleName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoleName", roleName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        throw new Exception(string.Format("Role '{0}' not found in RoleTable.", roleName));
                    }
                }
            }
        }







        string[] hourswork = new string[10];
        private void PtcMondayLeft_Click(object sender, EventArgs e)
        {

            switch (LblMondayHours.Text)
            {
                case "7-12am":
                    LblMondayHours.Text = "N/A";
                    hourswork[0] = "0";
                    hourswork[1] = "0";
                    break;
                case "N/A":
                    LblMondayHours.Text = "7am-5pm";
                    hourswork[0] = "1";
                    hourswork[1] = "1";
                    break;
                case "7am-5pm":
                    LblMondayHours.Text = "12-5pm";
                    hourswork[0] = "0";
                    hourswork[1] = "1";
                    break;
                case "12-5pm":
                    LblMondayHours.Text = "7-12am";
                    hourswork[0] = "1";
                    hourswork[1] = "0";
                    break;
            }

        }

        private void PtcMondayRight_Click(object sender, EventArgs e)
        {
            switch (LblMondayHours.Text)
            {
                case "7-12am":
                    LblMondayHours.Text = "12-5pm";
                    hourswork[0] = "0";
                    hourswork[1] = "1";
                    break;
                case "12-5pm":
                    LblMondayHours.Text = "7am-5pm";
                    hourswork[0] = "1";
                    hourswork[1] = "1";
                    break;
                case "7am-5pm":
                    LblMondayHours.Text = "N/A";
                    hourswork[0] = "0";
                    hourswork[1] = "0";
                    break;
                case "N/A":
                    LblMondayHours.Text = "7-12am";
                    hourswork[0] = "1";
                    hourswork[1] = "0";
                    break;
            }
        }

        private void PtcTuesdayLeft_Click(object sender, EventArgs e)
        {
            switch (LblTuesdayHours.Text)
            {
                case "7-12am":
                    LblTuesdayHours.Text = "N/A";
                    hourswork[2] = "0";
                    hourswork[3] = "0";
                    break;
                case "N/A":
                    LblTuesdayHours.Text = "7am-5pm";
                    hourswork[2] = "1";
                    hourswork[3] = "1";
                    break;
                case "7am-5pm":
                    LblTuesdayHours.Text = "12-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;
                case "12-5pm":
                    LblTuesdayHours.Text = "7am-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;

            }
        }

        private void PtcTuesdayRight_Click(object sender, EventArgs e)
        {
            switch (LblTuesdayHours.Text)
            {
                case "7-12am":
                    LblTuesdayHours.Text = "12-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;
                case "12-5pm":
                    LblTuesdayHours.Text = "7am-5pm";
                    hourswork[2] = "1";
                    hourswork[3] = "1";

                    break;
                case "7am-5pm":
                    LblTuesdayHours.Text = "N/A";
                    hourswork[2] = "0";
                    hourswork[3] = "0";
                    break;
                case "N/A":
                    LblTuesdayHours.Text = "7-12am";
                    hourswork[2] = "1";
                    hourswork[3] = "0";

                    break;
            }
        }

        private void PtcWednesdayLeft_Click(object sender, EventArgs e)
        {
            switch (LblWednesdayHours.Text)
            {
                case "7-12am":
                    LblWednesdayHours.Text = "N/A";
                    hourswork[4] = "0";
                    hourswork[5] = "0";
                    break;
                case "N/A":
                    LblWednesdayHours.Text = "7am-5pm";
                    hourswork[4] = "1";
                    hourswork[5] = "1";
                    break;
                case "7am-5pm":
                    LblWednesdayHours.Text = "12-5pm";
                    hourswork[4] = "0";
                    hourswork[5] = "1";
                    break;
                case "12-5pm":
                    LblWednesdayHours.Text = "7-12am";
                    hourswork[4] = "1";
                    hourswork[5] = "0";
                    break;
            }
        }

        private void PtcWednesdayRight_Click(object sender, EventArgs e)
        {
            switch (LblWednesdayHours.Text)
            {
                case "7-12am":
                    LblWednesdayHours.Text = "12-5pm";
                    hourswork[4] = "0";
                    hourswork[5] = "1";
                    break;
                case "12-5pm":
                    LblWednesdayHours.Text = "7am-5pm";
                    hourswork[4] = "1";
                    hourswork[5] = "1";
                    break;
                case "7am-5pm":
                    LblWednesdayHours.Text = "N/A";
                    hourswork[4] = "0";
                    hourswork[5] = "0";
                    break;
                case "N/A":
                    LblWednesdayHours.Text = "7-12am";
                    hourswork[4] = "1";
                    hourswork[5] = "0";
                    break;
            }
        }

        private void PtcThursdayLeft_Click(object sender, EventArgs e)
        {
            switch (LblThursdayHours.Text)
            {
                case "7-12am":
                    LblThursdayHours.Text = "N/A";
                    hourswork[6] = "0";
                    hourswork[7] = "0";
                    break;
                case "N/A":
                    LblThursdayHours.Text = "7am-5pm";
                    hourswork[6] = "1";
                    hourswork[7] = "1";
                    break;
                case "7am-5pm":
                    LblThursdayHours.Text = "12-5pm";
                    hourswork[6] = "0";
                    hourswork[7] = "1";
                    break;
                case "12-5pm":
                    LblThursdayHours.Text = "7-12am";
                    hourswork[6] = "1";
                    hourswork[7] = "0";
                    break;
            }
        }

        private void PtcThursdayRight_Click(object sender, EventArgs e)
        {
            switch (LblThursdayHours.Text)
            {
                case "7-12am":
                    LblThursdayHours.Text = "12-5pm";
                    hourswork[6] = "0";
                    hourswork[7] = "1";
                    break;
                case "12-5pm":
                    LblThursdayHours.Text = "7am-5pm";
                    hourswork[6] = "1";
                    hourswork[7] = "1";
                    break;
                case "7am-5pm":
                    LblThursdayHours.Text = "N/A";
                    hourswork[6] = "0";
                    hourswork[7] = "0";
                    break;
                case "N/A":
                    LblThursdayHours.Text = "7-12am";
                    hourswork[6] = "1";
                    hourswork[7] = "0";
                    break;
            }
        }

        private void PtcFridayLeft_Click(object sender, EventArgs e)
        {
            switch (LblFridayHours.Text)
            {
                case "7-12am":
                    LblFridayHours.Text = "N/A";
                    hourswork[8] = "0";
                    hourswork[9] = "0";
                    break;
                case "N/A":
                    LblFridayHours.Text = "7am-5pm";
                    hourswork[8] = "1";
                    hourswork[9] = "1";
                    break;
                case "7am-5pm":
                    LblFridayHours.Text = "12-5pm";
                    hourswork[8] = "0";
                    hourswork[9] = "1";
                    break;
                case "12-5pm":
                    LblFridayHours.Text = "7-12am";
                    hourswork[8] = "1";
                    hourswork[9] = "0";
                    break;
            }
        }

        private void PtcFridayRight_Click(object sender, EventArgs e)
        {
            switch (LblFridayHours.Text)
            {
                case "7-12am":
                    LblFridayHours.Text = "12-5pm";
                    hourswork[8] = "0";
                    hourswork[9] = "1";
                    break;
                case "12-5pm":
                    LblFridayHours.Text = "7am-5pm";
                    hourswork[8] = "1";
                    hourswork[9] = "1";
                    break;
                case "7am-5pm":
                    LblFridayHours.Text = "N/A";
                    hourswork[8] = "0";
                    hourswork[9] = "0";
                    break;
                case "N/A":
                    LblFridayHours.Text = "7-12am";
                    hourswork[8] = "1";
                    hourswork[9] = "0";
                    break;
            }
        }

        private void PtcSaturdayLeft_Click(object sender, EventArgs e)
        {

        }

        private void PtcSaturdayRight_Click(object sender, EventArgs e)
        {

        }



        public void Populate(string id, string forename, string surname, string email, string telephoneNumber, string status, string password, string primaryRole, string secondaryRole, string hours)
        {

            LblIDDisplay.Text = id.ToString();
            TxtForenameEdit.Text = originalForename = forename;
            TxtSurnameEdit.Text = originalSurname =  surname;
            TxtEmailEdit.Text = originalEmail = email;
            TxtPhoneNoEdit.Text =originalTelephoneNumber = telephoneNumber;
            TxtForenameEdit.ReadOnly = true;
            TxtSurnameEdit.ReadOnly = true;
            TxtEmailEdit.ReadOnly = true;
            TxtPhoneNoEdit.ReadOnly = true;
            originalStatus = status;
            originalHours = hours;

            if (status == "0")
            {
                CBstatus.SelectedItem = "Active";
            }
            else
            {
                CBstatus.SelectedItem = "Inactive";
            }

            TxtCurrentPassword.Text = password;
            originalPassword = password;
            MessageBox.Show(primaryRole);
            MessageBox.Show(secondaryRole);
            if (secondaryRole == "")
            {
                RBNoEdit.Select();
            }
            else
            {

            }

            Secondrole = secondaryRole;
            primaryRole = firstrole;

            CBRoleEdit.SelectedIndexChanged -= (s, e) => updaterole(CBRoleEdit, CBSecondRoleEdit, getroles());


            roles(CBRoleEdit, CBSecondRoleEdit);
            CBRoleEdit.SelectedItem =originalPrimaryRole = primaryRole;


            //  CBSecondRoleEdit.Visible = true;


            List<string> rolesList = getroles();
            if (rolesList.Contains(secondaryRole))
            {
                CBSecondRoleEdit.SelectedItem =originalSecondaryRole = secondaryRole;
                RBYesEdit.Checked = true;
            }
            else
            {
                CBSecondRoleEdit.Text = originalSecondaryRole =secondaryRole;
            }


            CBRoleEdit.SelectedIndexChanged += (s, e) => updaterole(CBRoleEdit, CBSecondRoleEdit, rolesList);





            var days = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < days.Length; i++)
            {
                string workingHours = hours.Substring(i * 2, 2);
                string schedule = "";
                switch (workingHours)
                {
                    case "00":
                        schedule = "N/A";
                        break;
                    case "10":
                        schedule = "7-12am";
                        break;
                    case "01":
                        schedule = "12-5pm";
                        break;
                    case "11":
                        schedule = "7am-5pm";
                        break;


                }

                switch (days[i])
                {
                    case "Monday":
                        LblMondayHoursEdit.Text = schedule;
                        break;
                    case "Tuesday":
                        LblTuesdayHoursEdit.Text = schedule;
                        break;
                    case "Wednesday":
                        LblWednesdayHoursEdit.Text = schedule;
                        break;
                    case "Thursday":
                        LblThursdayHoursEdit.Text = schedule;
                        break;
                    case "Friday":
                        LblFridayHoursEdit.Text = schedule;
                        break;
                }
            }






            TxtForenameEdit.ForeColor = Color.Black;
            TxtSurnameEdit.ForeColor = Color.Black;
            TxtEmailEdit.ForeColor = Color.Black;
            TxtPhoneNoEdit.ForeColor = Color.Black;



        }

        public void AddSetup()
        {
            LblIDDisplay.Visible = false;
        }

        private void CBPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPasswordConfirm.PasswordChar == '*')
            {
                TxtPasswordConfirm.PasswordChar = '\0';
                CBPasswordConfirm.Text = "Hide Password";
            }
            else
            {
                TxtPasswordConfirm.PasswordChar = '*';
                CBPasswordConfirm.Text = "Show Password";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            FrmLogin move = new FrmLogin();
            this.Hide();
            move.Show();
        }

        private void CBCurrentpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!TxtCurrentPassword.UseSystemPasswordChar)
            {
                TxtCurrentPassword.UseSystemPasswordChar = true;

                CBCurrentpassword.Text = "Show password";
            }
            else if (TxtCurrentPassword.UseSystemPasswordChar)
            {
                TxtCurrentPassword.UseSystemPasswordChar = false;
                CBCurrentpassword.Text = "Hide password";

            }
        }

        private void CBNewPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (!TxtNewPassword.UseSystemPasswordChar)
            {
                TxtNewPassword.UseSystemPasswordChar = true;

                CBNewPassword.Text = "Show password";
            }
            else if (TxtNewPassword.UseSystemPasswordChar)
            {
                TxtNewPassword.UseSystemPasswordChar = false;
                CBNewPassword.Text = "Hide password";

            }
        }

        private void CBPasswordConfirmEdit_CheckedChanged(object sender, EventArgs e)
        {

            if (!TxtConfirmPasswordEdit.UseSystemPasswordChar)
            {
                TxtConfirmPasswordEdit.UseSystemPasswordChar = true;

                CBPasswordConfirmEdit.Text = "Show password";
            }
            else if (TxtConfirmPasswordEdit.UseSystemPasswordChar)
            {
                TxtConfirmPasswordEdit.UseSystemPasswordChar = false;

                CBPasswordConfirmEdit.Text = "Hide password";

            }
        }

        private void CBPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '*')
            {
                TxtPassword.PasswordChar = '\0';
                CBPassword.Text = "Hide Password";
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                CBPassword.Text = "Show Password";
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string updatedForename = TxtForenameEdit.Text.Trim();
            string updatedSurname = TxtSurnameEdit.Text.Trim();
            string updatedEmail = TxtEmailEdit.Text.Trim();
            string updatedTelephoneNumber = TxtPhoneNoEdit.Text.Trim();
            string updatedPrimaryRole = CBRoleEdit.SelectedItem.ToString();
            string updatedSecondaryRole = CBSecondRoleEdit.SelectedItem != null ? CBSecondRoleEdit.SelectedItem.ToString() : string.Empty;
            string updatedPassword = TxtNewPassword.Text.Trim();
            string updatedStatus;


            if (CBstatus.SelectedItem == "Active")
            {
                 updatedStatus = "0";
            }
            else
            {
                 updatedStatus = "1";
            }

            string updatedHours = hourswork.ToString();


            bool isUpdated = false;

            if (updatedForename != originalForename) isUpdated = true;
            if (updatedSurname != originalSurname) isUpdated = true;
            if (updatedEmail != originalEmail) isUpdated = true;
            if (updatedTelephoneNumber != originalTelephoneNumber) isUpdated = true;
            if (updatedPrimaryRole != originalPrimaryRole) isUpdated = true;
            if (updatedSecondaryRole != originalSecondaryRole) isUpdated = true;
            if (updatedPassword != originalPassword) isUpdated = true;
            if (updatedStatus != originalStatus) isUpdated = true;

             if (updatedPassword != TxtConfirmPasswordEdit.Text )
                {
                    MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
         

            

                if (isUpdated)
                {
                    try
                    {
                        int staffID = Convert.ToInt32(LblIDDisplay.Text);
                        Classes.AccessClasses.AStaff astaff = new Classes.AccessClasses.AStaff();
                        Classes.Models.MStaff staff = new Classes.Models.MStaff

                      {
                          Forename = updatedForename,
                          Surname = updatedSurname,
                          Email = updatedEmail,
                          TelephoneNumber = updatedTelephoneNumber,
                          RoleID = astaff.GetRoleID(updatedPrimaryRole),
                          Status = updatedStatus
                      };
                        if (string.IsNullOrEmpty(updatedPassword) || string.IsNullOrEmpty(TxtConfirmPasswordEdit.Text))
                        {
                            updatedPassword = originalPassword;
                        }

                        astaff.UpdateStaff(staffID, staff, updatedPassword, updatedPrimaryRole, updatedSecondaryRole);
                        

                        MessageBox.Show("Staff member updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmDashBoard move = new FrmDashBoard();
                        this.Hide();
                        move.Show();


                        
                       
                        

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No changes detected.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        


        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

            string error = Classes.Models.MStaff.ValidatePassword(TxtPassword.Text);

            if (error == null)
            {
                Console.WriteLine("Password is valid!");
                PtcTick4.Visible = true;
                PtcX4.Visible = false;

                LblPasswordErrors.Visible = false;
                CBPassword.Visible = true;
            }
            else
            {
                Console.WriteLine("Password is invalid:");
                LblPasswordErrors.Text = string.Format("- {0}", error);



                LblPasswordErrors.Visible = true;
                PtcX4.Visible = true;
                PtcTick4.Visible = false;

                CBPassword.Visible = false;
            }
        }





        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                TxtPassword.Text = "Enter Password";
                TxtPassword.ForeColor = Color.Gray;
                PtcX4.Visible = false;
                PtcTick4.Visible = false;

            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtForename.Text == "Enter Password")
            {
                TxtForename.Text = "";
                TxtForename.ForeColor = Color.Black;
            }
        }

        private void TxtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

            string error = Classes.Models.MStaff.ValidatePassword(TxtPasswordConfirm.Text);

            if (error == null)
            {
                Console.WriteLine("Password is valid!");
                PtcTick5.Visible = true;
                PtcX5.Visible = false;

                LblCPasswordErrors.Visible = false;
                CBPasswordConfirm.Visible = true;
            }
            else
            {
                Console.WriteLine("Password is invalid:");
                LblCPasswordErrors.Text = string.Format("- {0}", error);



                LblCPasswordErrors.Visible = true;
                PtcX5.Visible = true;
                PtcTick5.Visible = false;

                CBPasswordConfirm.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CBSecondRole.DataSource = new List<string>(getroles());
            CBSecondRole.Visible = true;
            CBSecondRole.SelectedIndex = -1;
        }

        private void RBNo_CheckedChanged(object sender, EventArgs e)
        {
            CBSecondRole.DataSource = null;
            CBSecondRole.Visible = false;
            CBSecondRole.Items.Clear();
        }

        private void TxtForenameEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Forename = TxtForenameEdit.Text;

            if (customer.errors.Any())
            {

                LblForenameErrorsEdit.Text = customer.errors[0];
                PtcXEdit.Visible = true;
                PtctickEdit.Visible = false;
                LblForenameErrorsEdit.Visible = true;
                BtnEditEdit.Visible = false;
            }
            else
            {
                LblForenameErrorsEdit.Text = "";
                LblForenameErrorsEdit.Visible = false;
                PtctickEdit.Visible = true;
                PtcXEdit.Visible = false;
                BtnEditEdit.Visible = true;

            }
        }

        private void TxtForenameEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtForenameEdit.Text))
            {
                TxtForenameEdit.Text = "Enter Forename";
                TxtForenameEdit.ForeColor = Color.Gray;
            }
        }

        private void TxtForenameEdit_Enter(object sender, EventArgs e)
        {
            if (TxtForenameEdit.Text == "Enter Forename")
            {
                TxtForenameEdit.Text = "";
                TxtForenameEdit.ForeColor = Color.Black;
            }
        }

        private void TxtSurnameEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Surname = TxtSurnameEdit.Text;

            if (customer.errors.Any())
            {
                LblSurnameErrorsEdit.Text = customer.errors[0];
                LblSurnameErrorsEdit.Visible = true;

                PtcXEdit2.Visible = true;
                PtctickEdit2.Visible = false;
                BtnEditEdit2.Visible = false;

            }
            else
            {
                LblSurnameErrorsEdit.Text = "";
                LblSurnameErrorsEdit.Visible = false;
                PtctickEdit2.Visible = true;
                PtcXEdit2.Visible = false;
                BtnEditEdit2.Visible = false;

            }
        }

        private void RBYesEdit_CheckedChanged(object sender, EventArgs e)
        {
            CBSecondRoleEdit.DataSource = new List<string>(getroles());
            CBSecondRoleEdit.Visible = true;
            CBSecondRoleEdit.SelectedIndex = -1;
            label22.Visible = true;


        }

        private void RBNoEdit_CheckedChanged(object sender, EventArgs e)
        {
            CBSecondRoleEdit.DataSource = null;
            CBSecondRoleEdit.Visible = false;
            label22.Visible = false;

            CBSecondRoleEdit.Items.Clear();
        }

        private void BtnEditEdit_Click(object sender, EventArgs e)
        {
            TxtForenameEdit.ReadOnly = false;
        }

        private void BtnEditEdit2_Click(object sender, EventArgs e)
        {
            TxtSurnameEdit.ReadOnly = false;
        }

        private void BtnEditEdit3_Click(object sender, EventArgs e)
        {
            TxtEmailEdit.ReadOnly = false;
        }

        private void BtnEditEdit4_Click(object sender, EventArgs e)
        {
            TxtPhoneNoEdit.ReadOnly = false;
        }

        private void TxtEmailEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.Models.MStaff customer = new Classes.Models.MStaff();
            customer.Email = TxtEmailEdit.Text;

            if (customer.errors.Any())
            {
                LblEmailErrorsEdit.Text = customer.errors[0];
                LblEmailErrorsEdit.Visible = true;

                PtcXEdit3.Visible = true;
                PtctickEdit3.Visible = false;
                BtnEditEdit3.Visible = false;
            }
            else
            {

                LblEmailErrorsEdit.Text = "";
                LblEmailErrorsEdit.Visible = false;
                PtctickEdit3.Visible = true;
                PtcXEdit3.Visible = false;
                TxtPhoneNoEdit.Visible = true;
                //  LblPhoneNoEdit.Visible = true;
                BtnEditEdit3.Visible = true;
            }
        }

        private void PtcMondayLeftEdit_Click(object sender, EventArgs e)
        {
            switch (LblMondayHoursEdit.Text)
            {
                case "7-12am":
                    LblMondayHoursEdit.Text = "N/A";
                    hourswork[0] = "0";
                    hourswork[1] = "0";
                    break;
                case "N/A":
                    LblMondayHoursEdit.Text = "7am-5pm";
                    hourswork[0] = "1";
                    hourswork[1] = "1";
                    break;
                case "7am-5pm":
                    LblMondayHoursEdit.Text = "12-5pm";
                    hourswork[0] = "0";
                    hourswork[1] = "1";
                    break;
                case "12-5pm":
                    LblMondayHoursEdit.Text = "7-12am";
                    hourswork[0] = "1";
                    hourswork[1] = "0";
                    break;
            }
        }

        private void PtcMondayRightEdit_Click(object sender, EventArgs e)
        {
            switch (LblMondayHoursEdit.Text)
            {
                case "7-12am":
                    LblMondayHoursEdit.Text = "12-5pm";
                    hourswork[0] = "0";
                    hourswork[1] = "1";
                    break;
                case "12-5pm":
                    LblMondayHoursEdit.Text = "7am-5pm";
                    hourswork[0] = "1";
                    hourswork[1] = "1";
                    break;
                case "7am-5pm":
                    LblMondayHoursEdit.Text = "N/A";
                    hourswork[0] = "0";
                    hourswork[1] = "0";
                    break;
                case "N/A":
                    LblMondayHoursEdit.Text = "7-12am";
                    hourswork[0] = "1";
                    hourswork[1] = "0";
                    break;
            }
        }

        private void PtcTuesdayLeftEdit_Click(object sender, EventArgs e)
        {
            switch (LblTuesdayHoursEdit.Text)
            {
                case "7-12am":
                    LblTuesdayHoursEdit.Text = "N/A";
                    hourswork[2] = "0";
                    hourswork[3] = "0";
                    break;
                case "N/A":
                    LblTuesdayHoursEdit.Text = "7am-5pm";
                    hourswork[2] = "1";
                    hourswork[3] = "1";
                    break;
                case "7am-5pm":
                    LblTuesdayHoursEdit.Text = "12-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;
                case "12-5pm":
                    LblTuesdayHoursEdit.Text = "7am-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;

            }
        }

        private void PtcTuesdayRightEdit_Click(object sender, EventArgs e)
        {
            switch (LblTuesdayHoursEdit.Text)
            {
                case "7-12am":
                    LblTuesdayHoursEdit.Text = "12-5pm";
                    hourswork[2] = "0";
                    hourswork[3] = "1";
                    break;
                case "12-5pm":
                    LblTuesdayHoursEdit.Text = "7am-5pm";
                    hourswork[2] = "1";
                    hourswork[3] = "1";

                    break;
                case "7am-5pm":
                    LblTuesdayHoursEdit.Text = "N/A";
                    hourswork[2] = "0";
                    hourswork[3] = "0";
                    break;
                case "N/A":
                    LblTuesdayHoursEdit.Text = "7-12am";
                    hourswork[2] = "1";
                    hourswork[3] = "0";

                    break;
            }
        }

        private void PtcWednesdayLeftEdit_Click(object sender, EventArgs e)
        {
            switch (LblWednesdayHoursEdit.Text)
            {
                case "7-12am":
                    LblWednesdayHoursEdit.Text = "N/A";
                    hourswork[4] = "0";
                    hourswork[5] = "0";
                    break;
                case "N/A":
                    LblWednesdayHoursEdit.Text = "7am-5pm";
                    hourswork[4] = "1";
                    hourswork[5] = "1";
                    break;
                case "7am-5pm":
                    LblWednesdayHoursEdit.Text = "12-5pm";
                    hourswork[4] = "0";
                    hourswork[5] = "1";
                    break;
                case "12-5pm":
                    LblWednesdayHoursEdit.Text = "7-12am";
                    hourswork[4] = "1";
                    hourswork[5] = "0";
                    break;
            }
        }

        private void PtcWednesdayRightEdit_Click(object sender, EventArgs e)
        {
            switch (LblWednesdayHoursEdit.Text)
            {
                case "7-12am":
                    LblWednesdayHoursEdit.Text = "12-5pm";
                    hourswork[4] = "0";
                    hourswork[5] = "1";
                    break;
                case "12-5pm":
                    LblWednesdayHoursEdit.Text = "7am-5pm";
                    hourswork[4] = "1";
                    hourswork[5] = "1";
                    break;
                case "7am-5pm":
                    LblWednesdayHoursEdit.Text = "N/A";
                    hourswork[4] = "0";
                    hourswork[5] = "0";
                    break;
                case "N/A":
                    LblWednesdayHoursEdit.Text = "7-12am";
                    hourswork[4] = "1";
                    hourswork[5] = "0";
                    break;
            }
        }

        private void PtcThursdayLeftEdit_Click(object sender, EventArgs e)
        {
            switch (LblThursdayHoursEdit.Text)
            {
                case "7-12am":
                    LblThursdayHoursEdit.Text = "N/A";
                    hourswork[6] = "0";
                    hourswork[7] = "0";
                    break;
                case "N/A":
                    LblThursdayHoursEdit.Text = "7am-5pm";
                    hourswork[6] = "1";
                    hourswork[7] = "1";
                    break;
                case "7am-5pm":
                    LblThursdayHoursEdit.Text = "12-5pm";
                    hourswork[6] = "0";
                    hourswork[7] = "1";
                    break;
                case "12-5pm":
                    LblThursdayHoursEdit.Text = "7-12am";
                    hourswork[6] = "1";
                    hourswork[7] = "0";
                    break;
            }
        }

        private void PtcThursdayRightEdit_Click(object sender, EventArgs e)
        {
            switch (LblThursdayHours.Text)
            {
                case "7-12am":
                    LblThursdayHoursEdit.Text = "12-5pm";
                    hourswork[6] = "0";
                    hourswork[7] = "1";
                    break;
                case "12-5pm":
                    LblThursdayHoursEdit.Text = "7am-5pm";
                    hourswork[6] = "1";
                    hourswork[7] = "1";
                    break;
                case "7am-5pm":
                    LblThursdayHoursEdit.Text = "N/A";
                    hourswork[6] = "0";
                    hourswork[7] = "0";
                    break;
                case "N/A":
                    LblThursdayHoursEdit.Text = "7-12am";
                    hourswork[6] = "1";
                    hourswork[7] = "0";
                    break;
            }
        }

        private void PtcFridayLeftEdit_Click(object sender, EventArgs e)
        {
            switch (LblFridayHoursEdit.Text)
            {
                case "7-12am":
                    LblFridayHoursEdit.Text = "N/A";
                    hourswork[8] = "0";
                    hourswork[9] = "0";
                    break;
                case "N/A":
                    LblFridayHoursEdit.Text = "7am-5pm";
                    hourswork[8] = "1";
                    hourswork[9] = "1";
                    break;
                case "7am-5pm":
                    LblFridayHoursEdit.Text = "12-5pm";
                    hourswork[8] = "0";
                    hourswork[9] = "1";
                    break;
                case "12-5pm":
                    LblFridayHoursEdit.Text = "7-12am";
                    hourswork[8] = "1";
                    hourswork[9] = "0";
                    break;
            }



        }

        private void PtcFridayRightEdit_Click(object sender, EventArgs e)
        {
            switch (LblFridayHoursEdit.Text)
            {
                case "7-12am":
                    LblFridayHoursEdit.Text = "12-5pm";
                    hourswork[8] = "0";
                    hourswork[9] = "1";
                    break;
                case "12-5pm":
                    LblFridayHoursEdit.Text = "7am-5pm";
                    hourswork[8] = "1";
                    hourswork[9] = "1";
                    break;
                case "7am-5pm":
                    LblFridayHoursEdit.Text = "N/A";
                    hourswork[8] = "0";
                    hourswork[9] = "0";
                    break;
                case "N/A":
                    LblFridayHoursEdit.Text = "7-12am";
                    hourswork[8] = "1";
                    hourswork[9] = "0";
                    break;
            }
        }

        private void PnlEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtConfirmPasswordEdit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        


        


    
