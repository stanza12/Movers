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
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        private void TxtSubmit_Click(object sender, EventArgs e)
        {
            
}
        public void AddCustoemrresize()
        {
            PnlAddCustomer.BringToFront();
        }
        public void EditCustomerresize()
        {
            PnlEditCustomer.BringToFront();
        }

        private void TxtForename_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Forename = TxtForename.Text;

            if (customer.errors.Any())
            {
               
                LblForenameErrors.Text = customer.errors[0];
                LblForenameErrors.Visible = true;
                ptcX.Visible = true;
                Ptctick.Visible = false;
                BtnEdit.Visible = false;
            }
            else
            {
          
                LblForenameErrors.Text = "";
                LblForenameErrors.Visible = false;
                Ptctick.Visible = true;
                BtnEdit.Visible = true;
                ptcX.Visible = false;
                TxtSurname.Visible = true;
                lblsurname.Visible = true;
            }


        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Surname = TxtSurname.Text;

            if(customer.errors.Any())
            {
            
                ptcX2.Visible = true;
                PtcTick2.Visible = false;
                LblSurnameErrors.Text = customer.errors[0];
                LblSurnameErrors.Visible = true;
                BtnEdit2.Visible = false;
            }
            else
            {
                LblSurnameErrors.Visible = false;
                LblSurnameErrors.Text = "";
               
                PtcTick2.Visible = true;
                ptcX2.Visible = false;
                TxtEmail.Visible = true;
                lblemail.Visible = true;
                BtnEdit2.Visible = true;
            }

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Email = TxtEmail.Text;

            if(customer.errors.Any())
            {
             
                LblEmailErrors.Text = customer.errors[0];
                LblEmailErrors.Visible = true;
                BtnEdit3.Visible = false;
                ptcX3.Visible = true;
                PtcTick3.Visible = false;
            }
            else
            {
                LblEmailErrors.Visible = false;
                LblEmailErrors.Text = "";
                
                PtcTick3.Visible = true;
                ptcX3.Visible = false;
                TxtTeleNo.Visible = true;
                lblteleNo.Visible = true;
                BtnEdit3.Visible = true;
            }
        }

        private void TxtTeleNo_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.TelephoneNo = TxtTeleNo.Text;

            if(customer.errors.Any())
            {
              
                LblPhoneErrors.Text = customer.errors[0];
                LblPhoneErrors.Visible = true;
                ptcX4.Visible = true;
                PtcTick4.Visible = false;
                BtnEdit4.Visible = false;
            }
            else
            {
                LblPhoneErrors.Visible = false;
                LblPhoneErrors.Text = "";
                BtnEdit4.Visible = true;
         
                PtcTick4.Visible = true;
                ptcX4.Visible = false;
                lblbillingadd.Visible = true;
                TxtBillingAdd.Visible = true;
            }
        }

        private void TxtBillingAdd_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.BillingAddress = TxtBillingAdd.Text;

            if (customer.errors.Any())
            {
                LblAddressErrors.Text = customer.errors[0];
                LblAddressErrors.Visible = true;
                BtnEdit5.Visible = false;
         
                ptcX5.Visible = true;
                PtcTick5.Visible = false;
            }
            else
            {
                LblAddressErrors.Text = "";
                LblAddressErrors.Visible = false;
                BtnEdit5.Visible = true;
                PtcTick5.Visible = true;
                ptcX5.Visible = false;
                BtnSubmit.Visible = true;
                
            }
        }

        private void updatetime()
        {
            LblDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Classes.MCustomer NewCustomer = new Classes.MCustomer();
            NewCustomer.Forename = TxtForename.Text;
            NewCustomer.Surname = TxtSurname.Text;
            NewCustomer.Email = TxtEmail.Text;
            NewCustomer.TelephoneNo = TxtTeleNo.Text;
            NewCustomer.BillingAddress = TxtBillingAdd.Text;
            Classes.AccessClasses.ACustomer.AddCustomer(NewCustomer);

            if (NewCustomer.errors.Count > 0)
            {

                MessageBox.Show(string.Join("\n", NewCustomer.errors), "Input Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("User added");
                FrmJobRequest move = new FrmJobRequest();
                this.Hide();
                move.Show();
                
            }


            Classes.AccessClasses.ACustomer.AddCustomer(NewCustomer);
        }

        private void TxtForename_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtForename.Text))
            {
                TxtForename.Text = "Enter Forename";
                TxtForename.ForeColor = Color.Gray;
                ptcX.Visible = false;
                Ptctick.Visible = false;
                BtnEdit.Visible = false;
            }
        }

        private void TxtForename_Enter(object sender, EventArgs e)
        {
            if (TxtForename.Text == "Enter Forename")
            {
                TxtForename.Text = "";
                TxtForename.ForeColor = Color.Black;
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

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                TxtEmail.Text = "Enter Email";
                TxtEmail.ForeColor = Color.Gray;
            }
        }

        private void TxtTeleNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTeleNo.Text))
            {
                TxtTeleNo.Text = "Enter Telephone Number";
                TxtTeleNo.ForeColor = Color.Gray;
            }
        }

        private void TxtBillingAdd_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBillingAdd.Text))
            {
                TxtBillingAdd.Text = "Enter Postcode";
                TxtBillingAdd.ForeColor = Color.Gray;
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

        private void TxtTeleNo_Enter(object sender, EventArgs e)
        {
            if (TxtTeleNo.Text == "Enter Telephone Number")
            {
                TxtTeleNo.Text = "";
                TxtTeleNo.ForeColor = Color.Black;
            }
        }

        private void TxtBillingAdd_Enter(object sender, EventArgs e)
        {
            if (TxtBillingAdd.Text == "Enter Billing Address")
            {
                TxtBillingAdd.Text = "";
                TxtBillingAdd.ForeColor = Color.Black;
            }
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            updatetime();
            this.Size = new Size(548, 490);
            this.Location = new Point(0, 0);
            
            Size panelSize = new Size(527, 413);
            Point panelLocation = new Point(-1, 39);

            PnlAddCustomer.Size = panelSize;
            PnlAddCustomer.Location = panelLocation;

            PnlEditCustomer.Size = panelSize;
            PnlEditCustomer.Location = panelLocation;



        }

        private void TmrDateTime_Tick(object sender, EventArgs e)
        {
            updatetime();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TxtForename.ReadOnly = false;
        }

        private void BtnEdit2_Click(object sender, EventArgs e)
        {
            TxtSurname.ReadOnly = false;
        }

        private void BtnEdit3_Click(object sender, EventArgs e)
        {
            TxtEmail.ReadOnly = false;
        }

        private void BtnEdit4_Click(object sender, EventArgs e)
        {
            TxtTeleNo.ReadOnly = false;
        }

        private void BtnEdit5_Click(object sender, EventArgs e)
        {
            TxtBillingAdd.ReadOnly = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {


            FrmDashBoard move = new FrmDashBoard();
            this.Hide();
            move.Show();
        }

        private void TxtForenameEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Forename = TxtForenameEdit.Text;

            if (customer.errors.Any())
            {

                LblForenameErrorsEdit.Text = customer.errors[0];
                LblForenameErrorsEdit.Visible = true;
                ptcXEdit.Visible = true;
                PtctickEdit.Visible = false;
                BtnEditEdit.Visible = false;
            }
            else
            {

                LblForenameErrorsEdit.Text = "";
                LblForenameErrorsEdit.Visible = false;
                PtctickEdit.Visible = true;
                BtnEditEdit.Visible = true;
                ptcXEdit.Visible = false;
 
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

        private void TxtForenameEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtForenameEdit.Text))
            {
                TxtForenameEdit.Text = "Enter Forename";
                TxtForenameEdit.ForeColor = Color.Gray;
                ptcXEdit.Visible = false;
                PtctickEdit.Visible = false;
                BtnEditEdit.Visible = false;
            }
        }

        private void TxtSurnameEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Surname = TxtSurnameEdit.Text;

            if (customer.errors.Any())
            {

                ptcX2Edit.Visible = true;
                PtcTickEdit2.Visible = false;
                LblSurnameErrorsEdit.Text = customer.errors[0];
                LblSurnameErrorsEdit.Visible = true;
                BtnEditEdit2.Visible = false;
            }
            else
            {
                LblSurnameErrorsEdit.Visible = false;
                LblSurnameErrorsEdit.Text = "";

                PtcTickEdit2.Visible = true;
                ptcX2Edit.Visible = false;
                TxtEmailEdit.Visible = true;
               // lblemail.Visible = true;
                BtnEdit2.Visible = true;
            }
        }

        private void TxtSurnameEdit_Enter(object sender, EventArgs e)
        {
            if (TxtSurnameEdit.Text == "Enter Surname")
            {
                TxtSurnameEdit.Text = "";
                TxtSurnameEdit.ForeColor = Color.Black;

            }
            if (BtnEditEdit.Visible)
            {
                TxtForenameEdit.ReadOnly = true;
            }

        }

        private void TxtSurnameEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSurnameEdit.Text))
            {
                TxtSurnameEdit.Text = "Enter Surname";
                TxtSurnameEdit.ForeColor = Color.Gray;
            }
        }

        private void TxtEmailEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.Email = TxtEmailEdit.Text;

            if (customer.errors.Any())
            {

                LblEmailErrorsEdit.Text = customer.errors[0];
                LblEmailErrorsEdit.Visible = true;
                BtnEdit3.Visible = false;
                ptcX3.Visible = true;
                PtcTick3.Visible = false;
            }
            else
            {
                LblEmailErrorsEdit.Visible = false;
                LblEmailErrorsEdit.Text = "";

                PtcTickEdit3.Visible = true;
                ptcX3Edit.Visible = false;
                TxtTeleNoEdit.Visible = true;
             
                BtnEditEdit3.Visible = true;
            }
        }

        private void TxtEmailEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                TxtEmailEdit.Text = "Enter Email";
                TxtEmailEdit.ForeColor = Color.Gray;
            }
        }

        private void TxtEmailEdit_Enter(object sender, EventArgs e)
        {
            if (TxtEmailEdit.Text == "Enter Email")
            {
                TxtEmailEdit.Text = "";
                TxtEmailEdit.ForeColor = Color.Black;
            }
        }

        private void TxtTeleNoEdit_TextChanged(object sender, EventArgs e)
        {
            Classes.MCustomer customer = new Classes.MCustomer();
            customer.TelephoneNo = TxtTeleNoEdit.Text;

            if (customer.errors.Any())
            {

                LblPhoneErrorsEdit.Text = customer.errors[0];
                LblPhoneErrorsEdit.Visible = true;
                ptcX4Edit.Visible = true;
                PtcTickEdit4.Visible = false;
                BtnEditEdit4.Visible = false;
            }
            else
            {
                LblPhoneErrorsEdit.Visible = false;
                LblPhoneErrorsEdit.Text = "";
                BtnEditEdit4.Visible = true;

                PtcTickEdit4.Visible = true;
                ptcX4Edit.Visible = false;
                
            }
        }

        private void TxtTeleNoEdit_Enter(object sender, EventArgs e)
        {

            if (TxtTeleNoEdit.Text == "Enter Telephone Number")
            {
                TxtTeleNoEdit.Text = "";
                TxtTeleNoEdit.ForeColor = Color.Black;
            }
        }

        private void TxtTeleNoEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTeleNoEdit.Text))
            {
                TxtTeleNoEdit.Text = "Enter Telephone Number";
                TxtTeleNoEdit.ForeColor = Color.Gray;
            }
        }

        private void TxtBillingAddEdit_TextChanged(object sender, EventArgs e)
        {

            Classes.MCustomer customer = new Classes.MCustomer();
            customer.BillingAddress = TxtBillingAddEdit.Text;

            if (customer.errors.Any())
            {
                LblAddressErrorsEdit.Text = customer.errors[0];
                LblAddressErrorsEdit.Visible = true;
                BtnEditEdit5.Visible = false;

                ptcX5Edit.Visible = true;
                PtcTickEdit5.Visible = false;
            }
            else
            {
                LblAddressErrorsEdit.Text = "";
                LblAddressErrorsEdit.Visible = false;
                BtnEditEdit5.Visible = true;
                PtcTickEdit5.Visible = true;
                ptcX5Edit.Visible = false;
                BtnUpdate.Visible = true;

            }
        }

        private void TxtBillingAddEdit_Enter(object sender, EventArgs e)
        {
            if (TxtBillingAddEdit.Text == "Enter Billing Address")
            {
                TxtBillingAddEdit.Text = "";
                TxtBillingAddEdit.ForeColor = Color.Black;
            }
        }

        private void TxtBillingAddEdit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBillingAddEdit.Text))
            {
                TxtBillingAddEdit.Text = "Enter Postcode";
                TxtBillingAddEdit.ForeColor = Color.Gray;
            }
        }

         public void Populate(string id, string forename, string surname, string email, string telephoneNumber, string billingAdd)
         {
             LblID.Text = id;
             TxtForenameEdit.Text = forename;
             TxtSurnameEdit.Text = surname;
             TxtEmailEdit.Text = email;
             TxtTeleNoEdit.Text = telephoneNumber;
             TxtBillingAddEdit.Text = billingAdd;
             PnlEditCustomer.BringToFront();
             TxtForenameEdit.ForeColor = Color.Black;
             TxtSurnameEdit.ForeColor = Color.Black;
             TxtEmailEdit.ForeColor = Color.Black;
             TxtTeleNoEdit.ForeColor = Color.Black;
             TxtBillingAddEdit.ForeColor = Color.Black;

         }

         private void BtnUpdate_Click(object sender, EventArgs e)
         {
            string updatedForename = TxtForenameEdit.Text.Trim();
            string updatedSurname = TxtSurnameEdit.Text.Trim();
            string updatedEmail = TxtEmailEdit.Text.Trim();
            string updatedTelephoneNumber = TxtTeleNoEdit.Text.Trim();
            string updatedBillingAdd = TxtBillingAdd.Text.Trim();
            

                    try
                    {
                        int staffID = Convert.ToInt32(LblID.Text);
                        Classes.AccessClasses.ACustomer acustomer = new Classes.AccessClasses.ACustomer();


                        acustomer.UpdateCustomer(Convert.ToInt32(LblID.Text) ,updatedForename,updatedSurname,updatedEmail,updatedTelephoneNumber,updatedBillingAdd);


                        MessageBox.Show("Staff member updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Classes.Models.MCurrentStaff currentStaff = Classes.Models.MCurrentStaff.CurrentStaff;
                        FrmDashBoard move = new FrmDashBoard();
                        this.Hide();
                        move.Show();


                        
                       
                        

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            }
         }






