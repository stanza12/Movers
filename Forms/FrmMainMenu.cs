using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SR_Movers_coursework.Forms
{
    public partial class FrmDashBoard : Form
    {
         



        public FrmDashBoard()
        {
            InitializeComponent();


        }


      




        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sRMoversDataSet3.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.sRMoversDataSet3.Customer);
            // TODO: This line of code loads data into the 'sRMoversDataSet.Staff' table. You can move, or remove it, as needed.

          //  this.CenterToScreen();


           this.staffTableAdapter.Fill(this.sRMoversDataSet.Staff);
            DateOfJob.MinDate = DateTime.Today.AddDays(3); //??????
            DateOfJob.MaxDate = DateTime.Today.AddMonths(1);

            this.Size = new Size(660, 430); //396
          //  this.Location = new Point(1, -1);
            updatetime();
            Size panelSize = new Size(644, 314); //314
            Point panelLocation = new Point(1, 81);

            PnlBooking.Size = panelSize;
           PnlBooking.Location = panelLocation;

            PnlJobs.Size = panelSize;     
            PnlJobs.Location = panelLocation;

            PnlStaff.Size = panelSize;
            PnlStaff.Location = panelLocation;

            PnlAccount.Size = panelSize;
           PnlAccount.Location = panelLocation;

            PnlDashboard.Size = panelSize;
           PnlDashboard.Location = panelLocation;

           PnlCustomers.Size = panelSize;
           PnlCustomers.Location = panelLocation;

           
            PnlDashboard.Visible = true;
            PnlDashboard.BringToFront();
            PnlBooking.Visible = false;
            PnlJobs.Visible = false;
            PnlStaff.Visible = false;
            PnlAccount.Visible = false;
            PnlCustomers.Visible = false;

             search();
            ComboAMPM.Visible = false;
            MessageBox.Show(Classes.Models.MCurrentStaff.CurrentStaff.TelephoneNumber);
            LblForenameDisplay.Text = Classes.Models.MCurrentStaff.CurrentStaff.Forename;
            LblSurnameDisplay.Text = Classes.Models.MCurrentStaff.CurrentStaff.Surname;
            LblTitle.Text = "Welcome back " + Classes.Models.MCurrentStaff.CurrentStaff.Forename + " " + Classes.Models.MCurrentStaff.CurrentStaff.Surname;
            TxtPhoneNoDisplay.Text = Classes.Models.MCurrentStaff.CurrentStaff.TelephoneNumber;
            TxtEmailDisplay.Text = Classes.Models.MCurrentStaff.CurrentStaff.Email;
            LblRole.Text = "Role(s) " + Classes.Models.MCurrentStaff.CurrentStaff.Roles;
            LblRoleDash.Text = "Role(s) " + Classes.Models.MCurrentStaff.CurrentStaff.Roles;
            LblWelcome.Text = "Welcome back " + Classes.Models.MCurrentStaff.CurrentStaff.Forename + " " + Classes.Models.MCurrentStaff.CurrentStaff.Surname;

        }

      


        private void updatetime()
        {
            LblDate.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void Underline(object sender)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {

                switch (clickedLabel.Name)
                {
                    case "LblBooking":
                        Lblunderline.Visible = true;
                        Lblunderline2.Visible = false;
                        Lblunderline3.Visible = false;
                        Lblunderline4.Visible = false;
                        LblUnderline5.Visible = false;
                        PnlBooking.Visible = true;
                        PnlJobs.Visible = false;
                        PnlStaff.Visible = false;
                        PnlAccount.Visible = false;
                        PnlDashboard.Visible = false;
                        PnlCustomers.Visible = false;
                        PnlBooking.BringToFront();
              //          this.CenterToScreen();

                        break;

                    case "LblJobs":
                        Lblunderline.Visible = false;
                        Lblunderline2.Visible = true;
                        Lblunderline3.Visible = false;
                        Lblunderline4.Visible = false;
                        LblUnderline5.Visible = false;
                        PnlBooking.Visible = false;
                        PnlJobs.Visible = true;
                        PnlStaff.Visible = false;
                        PnlAccount.Visible = false;
                        PnlDashboard.Visible = false;
                        PnlCustomers.Visible = false;
                   //     this.CenterToScreen();
                        PnlJobs.BringToFront();

                        break;

                    case "LblStaff":
                        Lblunderline.Visible = false;
                        Lblunderline2.Visible = false;
                        Lblunderline3.Visible = true;
                        Lblunderline4.Visible = false;
                        LblUnderline5.Visible = false;
                        PnlBooking.Visible = false;
                        PnlJobs.Visible = false;
                        PnlStaff.Visible = true;
                        PnlAccount.Visible = false;
                        PnlDashboard.Visible = false;
                        PnlCustomers.Visible = false;
                        PnlStaff.BringToFront();
                 //       this.CenterToScreen();
                        break;

                    case "LblAccount":
                        Lblunderline.Visible = false;
                        Lblunderline2.Visible = false;
                        Lblunderline3.Visible = false;
                        Lblunderline4.Visible = true;
                        LblUnderline5.Visible = false;
                        PnlBooking.Visible = false;
                        PnlJobs.Visible = false;
                        PnlStaff.Visible = false;
                        PnlAccount.Visible = true;
                        PnlDashboard.Visible = false;
                        PnlCustomers.Visible = false;
                        PnlAccount.BringToFront();
                //        this.CenterToScreen();
                        break;
                    case "LblCustomer":
                        Lblunderline.Visible = false;
                        Lblunderline2.Visible = false;
                        Lblunderline3.Visible = false;
                        Lblunderline4.Visible = false;
                        LblUnderline5.Visible = true;
                        PnlBooking.Visible = false;
                        PnlJobs.Visible = false;
                        PnlStaff.Visible = false;
                        PnlAccount.Visible = false;
                        PnlDashboard.Visible = false;
                        PnlAccount.Visible = false;
                        PnlCustomers.Visible = true;
                        PnlCustomers.BringToFront();
              
                        break;
                    
                }

            }
        }



        private void TmrDatetime_Tick(object sender, EventArgs e)
        {
            updatetime();
        }

        private void LblBooking_Click(object sender, EventArgs e)
        {
            Underline(LblBooking);
        }

        private void LblJobs_Click(object sender, EventArgs e)
        {
            Underline(LblJobs);
        }

        private void LblStaff_Click(object sender, EventArgs e)
        {
            Underline(LblStaff);
        }

        private void LblAccount_Click(object sender, EventArgs e)
        {
            Underline(LblAccount);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RBYes_CheckedChanged(object sender, EventArgs e)
        {
            DateOfJob.Visible = true;
            
            BtnContinue.Visible = false;
        }

        private void RBNo_CheckedChanged(object sender, EventArgs e)
        {
            DateOfJob.Visible = false;
            ComboAMPM.Visible = false;
            BtnContinue.Visible = true;
        }

        private void PnlBooking_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtCurrentAddress_TextChanged(object sender, EventArgs e)
        {
            RTBErrors.Clear();
            if (TxtCurrentAddress.Text != "Enter Postcode")
            {
                int position = TxtCurrentAddress.SelectionStart;
                TxtCurrentAddress.Text = TxtCurrentAddress.Text.ToUpper();
                TxtCurrentAddress.SelectionStart = position;
            }
            if (PostcodeValidation(TxtCurrentAddress.Text))
            {
                PctGreenTick.Visible = true;
                PctRedX.Visible = false;
                TxtNewAddress.Visible = true;
                LblDelivery.Visible = true;
                TxtCurrentAddress.ReadOnly = true;
              
                BtnEdit.Visible = true;
                RTBErrors.Visible = false;
                LblErrorsList.Visible = false;
            }
            else
            {
                PctRedX.Visible = true;
                PctGreenTick.Visible = false;
                RTBErrors.Visible = true;
                LblErrorsList.Visible = true;
            }




           
        }

        private void LblDashboard_Click(object sender, EventArgs e)
        {

            Underline(LblDashboard);
        }

        private void PnlAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            FrmLogin move = new FrmLogin();
            this.Hide();
            move.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void TmrLogout_Tick(object sender, EventArgs e)
        {

        }

        private void TxtCurrentAddress_Enter(object sender, EventArgs e)
        {
            if (TxtCurrentAddress.Text == "Enter Postcode")
            {
                TxtCurrentAddress.Text = "";
                TxtCurrentAddress.ForeColor = Color.Black;
            }



        }

        private void TxtCurrentAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCurrentAddress.Text))
            {
                TxtCurrentAddress.Text = "Enter Postcode";
                TxtCurrentAddress.ForeColor = Color.Gray;
            }
        }

      

        private void TxtNewAddress_Enter(object sender, EventArgs e)
        {
            if (TxtNewAddress.Text == "Enter Postcode")
            {
                TxtNewAddress.Text = "";
                TxtNewAddress.ForeColor = Color.Black;
            }

        }

        private void TxtNewAddress_Leave(object sender, EventArgs e)
        {
           

            if (string.IsNullOrWhiteSpace(TxtNewAddress.Text))
            {
                TxtNewAddress.Text = "Enter Postcode";
                TxtNewAddress.ForeColor = Color.Gray;
            }
        }

        public bool PostcodeValidation(string postcode)
        {
            RTBErrors.Clear();
            bool isvalid = true;
            if (!postcode.ToUpper().StartsWith("BT"))
            {
                RTBErrors.AppendText("Error:\nPostcode must start with 'BT'. ");
                return false;
            }


            string checkdigits = @"^BT\d{1,2}";
            if(!Regex.IsMatch(postcode.ToUpper(), checkdigits))
            {
                RTBErrors.AppendText("Error:\nPostcode must have 1-2 digits after 'BT'. \n");
                return  false;
            }



            string checkspace = @"BT\d{1,2}\s";
            if (!Regex.IsMatch(postcode.ToUpper(), checkspace))
            {
                RTBErrors.AppendText("Error:\nPostcode must have a space after the digits. \n");
                return false;
            }

            string checksecondpart = @"BT\d{1,2}\s\d[A-Z]{2}$";
            if(!Regex.IsMatch(postcode.ToUpper(), checksecondpart))
            {
                RTBErrors.AppendText("Error:\nPostcode must end with one digit followed by two letters. \n");
                return false;
            }
            return isvalid;

        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {


            FrmNewCustomer move = new FrmNewCustomer();
            move.AddCustoemrresize();
            this.Hide();
            move.Show();
            




        }

        private void TxtNewAddress_TextChanged(object sender, EventArgs e)
        {
            RTBErrors.Clear();
            if (TxtNewAddress.Text != "Enter Postcode")
            {
                int position = TxtNewAddress.SelectionStart;
                TxtNewAddress.Text = TxtNewAddress.Text.ToUpper();
                TxtNewAddress.SelectionStart = position;
            }

            if (PostcodeValidation(TxtNewAddress.Text))
            {
                PctGreenTick2.Visible = true;
                PtcRedX2.Visible = false;
                LblQuestion.Visible = true;
                RBYes.Visible = true;
                RBNo.Visible = true;
                TxtNewAddress.ReadOnly = true;
                TxtNewAddress.BackColor = SystemColors.Control;
                BtnEdit2.Visible = true;
                RTBErrors.Visible = false;
                LblErrorsList.Visible = false;
            }
            else
            {
                PtcRedX2.Visible = true;
                PctGreenTick2.Visible = false;
                RTBErrors.Visible = true;
                LblErrorsList.Visible = true;
            }

        }

        private void DateOfJob_ValueChanged(object sender, EventArgs e)
        {
            ComboAMPM.Visible = true;
        }

        private void ComboAMPM_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void ComboAMPM_SelectedValueChanged(object sender, EventArgs e)
        {
            BtnContinue.Visible = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtCurrentAddress.ReadOnly = false;
            TxtCurrentAddress.ForeColor = Color.Black;
        }

        private void BtnEdit2_Click(object sender, EventArgs e)
        {
            TxtNewAddress.ReadOnly = false;
            TxtNewAddress.ForeColor = Color.Black;
            TxtNewAddress.BackColor = SystemColors.Window;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Lblunderline.Visible = false;
            Lblunderline2.Visible = false;
            Lblunderline3.Visible = false;
            Lblunderline4.Visible = false;
            PnlBooking.Visible = false;
            PnlJobs.Visible = false;
            PnlStaff.Visible = false;
            PnlAccount.Visible = false;
            PnlDashboard.Visible = true;
            PnlDashboard.BringToFront();
        }

        private Classes.AccessClasses.AStaff aStaff = new Classes.AccessClasses.AStaff();

        private void search()
        {
          
            List<string> columns = aStaff.sortstaff();

       
            CBSearchStaff.Items.Clear();

         
            foreach (string column in columns)
            {
                CBSearchStaff.Items.Add(column);
            }

            if (CBSearchStaff.Items.Count > 0)
            {
                CBSearchStaff.SelectedIndex = 0; 
            }
        }


        private void DGVStaffDisplay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = DGVStaffDisplay.CurrentRow.Cells[0].Value.ToString();
            string forename = DGVStaffDisplay.CurrentRow.Cells[1].Value.ToString();
            string surname = DGVStaffDisplay.CurrentRow.Cells[2].Value.ToString();
            string email = DGVStaffDisplay.CurrentRow.Cells[3].Value.ToString();
            string TelephoneNumber = DGVStaffDisplay.CurrentRow.Cells[4].Value.ToString();
            string rolingID = DGVStaffDisplay.CurrentRow.Cells[5].Value.ToString();
            string status = DGVStaffDisplay.CurrentRow.Cells[6].Value.ToString();

            Classes.AccessClasses.AStaff astaff = new Classes.AccessClasses.AStaff();
            string password = astaff.getpass(ID);
            string jobs = astaff.getrole(ID, rolingID);
            string Contract = astaff.returncontract(ID);

            List<string> roleIDs = astaff.GetAllRoleIDsForStaff(ID); 

            string primaryRole = "";
            string secondaryRole = "";

            if (roleIDs.Count > 0)
            {
                primaryRole = astaff.getrole(ID, roleIDs[0]);  
            }

            if (roleIDs.Count > 1)
            {
                secondaryRole = astaff.getrole(ID, roleIDs[1]);  
            }

            LblID detailsForm = new LblID();
            detailsForm.Populate(ID, forename, surname, email, TelephoneNumber, status, password, primaryRole, secondaryRole, Contract);
         //   detailsForm.TxtPassword.Text = password;
            detailsForm.Editstaffresize();
            detailsForm.Show();
            this.Hide();





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            LblID detailsForm = new LblID();
            detailsForm.Addstaffresize();
            detailsForm.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
             
                    
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtSearchStaff.Clear();
            search();
            DGVStaffDisplay.Update();
        }

        private void PctSearch_Click(object sender, EventArgs e)
        {
            string selectedColumn = CBSearchStaff.SelectedItem.ToString();
            string searchText = TxtSearchStaff.Text;

            if (string.IsNullOrEmpty(selectedColumn) || string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable results = aStaff.searchstaff(selectedColumn, searchText);
            DGVStaffDisplay.DataSource = results;
        }


        private void DGVStaffDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(DGVStaffDisplay.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedStaff = Convert.ToInt32(DGVStaffDisplay.SelectedRows[0].Cells[0].Value);
                    DialogResult conform = MessageBox.Show( "Are you sure you want to delete this staff member?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if(conform == DialogResult.Yes)
                    {
                        Classes.AccessClasses.AStaff staff = new Classes.AccessClasses.AStaff();
                        aStaff.DeleteStaff(selectedStaff);
                        MessageBox.Show("Staff member deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.staffTableAdapter.Fill(this.sRMoversDataSet.Staff);
                        DGVStaffDisplay.Update();
                       
                        
                        
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmNewCustomer move = new FrmNewCustomer();
            move.AddCustoemrresize();
            this.Hide();
            move.Show();
        }

        private void LblCustomer_Click(object sender, EventArgs e)
        {
            Underline(LblCustomer);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (DGVCustomerDisplay.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedCustomer = Convert.ToInt32(DGVCustomerDisplay.SelectedRows[0].Cells[0].Value);
                    DialogResult conform = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (conform == DialogResult.Yes)
                    {
                        Classes.AccessClasses.ACustomer aCustomer = new Classes.AccessClasses.ACustomer();
                        aCustomer.DeleteCustomer(selectedCustomer);
                        MessageBox.Show("Customer deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.customerTableAdapter.Fill(this.sRMoversDataSet3.Customer);
                        DGVCustomerDisplay.Update();




                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DGVCustomerDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = DGVCustomerDisplay.CurrentRow.Cells[0].Value.ToString();
            string forename = DGVCustomerDisplay.CurrentRow.Cells[1].Value.ToString();
            string surname = DGVCustomerDisplay.CurrentRow.Cells[2].Value.ToString();
            string email = DGVCustomerDisplay.CurrentRow.Cells[3].Value.ToString();
            string TelephoneNumber = DGVCustomerDisplay.CurrentRow.Cells[4].Value.ToString();
            string BillingAdd = DGVCustomerDisplay.CurrentRow.Cells[5].Value.ToString();



            FrmNewCustomer detailsForm = new FrmNewCustomer();
            detailsForm.Populate(ID, forename, surname, email, TelephoneNumber, BillingAdd);
            detailsForm.EditCustomerresize();
            detailsForm.Show();
            this.Hide();
        }





    }
}


    

