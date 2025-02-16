using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR_Movers_coursework.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }
       // Classes.MCustomer NewCustomer = new Classes.MCustomer();
           // NewCustomer.Forename = TxtForename.Text;
         //   NewCustomer.Surname = TxtSurname.Text;
          //  NewCustomer.Email = TxtEmail.Text;
          //  NewCustomer.TelephoneNo = TxtTeleNo.Text;
           // NewCustomer.BillingAddress = TxtBillingAddress.Text;
           // Classes.AccessClasses.ACustomer.AddCustomer(NewCustomer);
        private void FrmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void TxtStaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int staffID;

            if (!int.TryParse(TxtStaffID.Text, out staffID))
            {
                MessageBox.Show("Please enter a valid Staff ID.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = TxtPassword.Text;
            Classes.AccessClasses.ALogin alogin = new Classes.AccessClasses.ALogin();

            if (alogin.checkpassword(staffID, password))
            {
                Classes.AccessClasses.AStaff staffAccess = new Classes.AccessClasses.AStaff();
                Classes.Models.MStaff currentStaff = staffAccess.LoadStaffDetails(staffID);
                   
                if (currentStaff != null)
                {
                    Classes.Models.MCurrentStaff.CurrentStaff = new Classes.Models.MCurrentStaff
                    {
                        StaffID = currentStaff.StaffID,
                        Forename = currentStaff.Forename,
                        Surname = currentStaff.Surname,
                        Email = currentStaff.Email,
                        TelephoneNumber = currentStaff.TelephoneNumber,
                        Roles = string.Join(",", currentStaff.Roles),
                        Status = int.Parse(currentStaff.Status),
                        Hours = int.Parse(currentStaff.Hours ?? "0")
                    };
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
                    FrmDashBoard dashboard = new FrmDashBoard();
                    dashboard.Show();
                    this.Hide();  
                }
                else
                {
                    MessageBox.Show("Failed to load staff details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Staff ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CBshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if(!TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = true;
              
                CBshowpass.Text = "Show password";
            }
            else if(TxtPassword.UseSystemPasswordChar)
            {
                TxtPassword.UseSystemPasswordChar = false;
                CBshowpass.Text = "Hide password";
               
            }

        }




    }
}
