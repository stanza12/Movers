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
    public partial class FrmJobRequest : Form
    {
        public FrmJobRequest()
        {
            InitializeComponent();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmJobRequest_Load(object sender, EventArgs e)
        {
            Lblunderline1.Select();
            SetupBedrooms();
        }

        public void defaultfontstyle(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Font = new Font(label.Font, FontStyle.Regular);
            }
        }
        private void defaultfont(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = SystemColors.ControlText;
            }
        }

        public void hidevalues(params NumericUpDown[] controls)
        {
            foreach (var control in controls)
            {
                control.Visible = false;
            }
        }
        public void hideunderline(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Visible = false;
            }
        }
        public void showunderline(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.Visible = true;
            }
        }
        public void showAdd(params PictureBox[] pictureBoxes)
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = true;
            }
        }
        public void hideAdd(params PictureBox[] pictureBoxes)
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Visible = false;
            }
        }

        public void ResizeFormToFitControls(Form form, int padding)
        {
            if (form == null) throw new ArgumentNullException();

            int maxHeight = 0;

            foreach (Control control in form.Controls)
            {
                if (control.Visible)
                {
                    int controlBottom = control.Top + control.Height;
                    if (controlBottom > maxHeight)
                    {
                        maxHeight = controlBottom;
                    }
                }
            }
            form.Height = maxHeight + padding;
        }





        public void SetupBedrooms()
        {
            LblItem1.Text = "Single bed + Mattress";
            LblItem2.Text = "Double bed + Mattress";
            LblItem3.Text = "Kingsize Bed + Mattress";
            LblItem4.Text = "Single Wardrobe";
            LblItem5.Text = "Double Wardrobe";
            LblItem6.Text = "Chest of Drawers";
            LblItem7.Text = "Bedside Table";
            LblItem9.Text = "Dressing Table";
            LblItem10.Text = "Television";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            LblBedrooms.ForeColor = Color.Blue;

            Font font = new Font(LblBedrooms.Font, FontStyle.Underline);
            LblBedrooms.Font = font;



            defaultfontstyle(LblDining, LblBathrooms, LblGarden, LblLiving, LblOffice, LblKitchen);
            defaultfont(LblDining, LblBathrooms, LblGarden, LblLiving, LblOffice, LblKitchen);

            hidevalues(NItem1Living, NItem1Kitchen, NItem1Dine, NItem1Bath, NItem1Gard, NItem1Office);
            hidevalues(NItem2Live, NItem2Kitchen, NItem2Dine, NItem2Bath, NItem2Gard, NItem2Office);
            hidevalues(NItem3Live, NItem3Kitchen, NItem3Dine, NItem3Bath, NItem3Gard, NItem3Office);
            hidevalues(NItem4Live, NItem4Kitchen, NItem4Dine, NItem4Bath, NItem4Gard, NItem4Office);
            hidevalues(NItem5Live, NItem5Kitchen, NItem5Dine, NItem5Bath, NItem5Gard, NItem5Office);
            hidevalues(NItem6Live, NItem6Kitchen, NItem6Dine, NItem6Bath, NItem6Gard, NItem6Office);
            hidevalues(NItem7Live, NItem7Kitchen, NItem7Dine, NItem7Bath, NItem7Gard, NItem7Office);
            hidevalues(NItem9Live, NItem9Kitchen, NItem9Dine, NItem9Bath, NItem9Gard, NItem9Office);
            hidevalues(NItem10Live, NItem10Kitchen, NItem10Dine, NItem10Bath, NItem10Gard, NItem10Office);

            if (NItem1Bed.Value > 0)
            {
                NItem1Bed.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Bed.Visible = false;
            }


            if (NItem2Bed.Value > 0)
            {
                NItem2Bed.Visible = true;
                PctAdd2.Visible = false;
            }

            else
            {
                PctAdd2.Visible = true;
                NItem2Bed.Visible = false;
            }

            if (NItem3Bed.Value > 0)
            {
                NItem3Bed.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Bed.Visible = false;
            }

            if (NItem4Bed.Value > 0)
            {
                NItem4Bed.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Bed.Visible = false;
            }
            if (NItem5Bed.Value > 0)
            {
                NItem5Bed.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Bed.Visible = false;
            }
            if (NItem6Bed.Value > 0)
            {
                NItem6Bed.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Bed.Visible = false;
            }
            if (NItem7Bed.Value > 0)
            {
                NItem7Bed.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Bed.Visible = false;
            }
            if (NItem9Bed.Value > 0)
            {
                NItem9Bed.Visible = true;
                PctAdd9.Visible = false;
            }

            else
            {
                PctAdd9.Visible = true;
                NItem9Bed.Visible = false;
            }

            if (NItem10Bed.Value > 0)
            {
                NItem10Bed.Visible = true;
                PctAdd10.Visible = false;
            }

            else
            {
                PctAdd10.Visible = true;
                NItem10Bed.Visible = false;
            }
        }

        public void SetupLiving()
        {
            LblItem1.Text = "Two Seater sofa";
            LblItem2.Text = "Three Seater Sofa";
            LblItem3.Text = "Four Seater Sofa";
            LblItem4.Text = "Armchair";
            LblItem5.Text = "Coffee Table";
            LblItem6.Text = "Television";
            LblItem7.Text = "TV Stand";
            LblItem9.Text = "Bookcase";
            LblItem10.Text = "Rug";
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            Font font = new Font(LblLiving.Font, FontStyle.Underline);
            LblLiving.Font = font;

            LblLiving.ForeColor = Color.Blue;
            defaultfontstyle(LblDining, LblBathrooms, LblGarden, LblBedrooms, LblOffice, LblKitchen);
            defaultfont(LblDining, LblBathrooms, LblGarden, LblBedrooms, LblOffice, LblKitchen);

            hidevalues(NItem1Bed, NItem1Kitchen, NItem1Dine, NItem1Bath, NItem1Gard, NItem1Office);
            hidevalues(NItem2Bed, NItem2Kitchen, NItem2Dine, NItem2Bath, NItem2Gard, NItem2Office);
            hidevalues(NItem3Bed, NItem3Kitchen, NItem3Dine, NItem3Bath, NItem3Gard, NItem3Office);
            hidevalues(NItem4Bed, NItem4Kitchen, NItem4Dine, NItem4Bath, NItem4Gard, NItem4Office);
            hidevalues(NItem5Bed, NItem5Kitchen, NItem5Dine, NItem5Bath, NItem5Gard, NItem5Office);
            hidevalues(NItem6Bed, NItem6Kitchen, NItem6Dine, NItem6Bath, NItem6Gard, NItem6Office);
            hidevalues(NItem7Bed, NItem7Kitchen, NItem7Dine, NItem7Bath, NItem7Gard, NItem7Office);
            hidevalues(NItem9Bed, NItem9Kitchen, NItem9Dine, NItem9Bath, NItem9Gard, NItem9Office);
            hidevalues(NItem10Bed, NItem10Kitchen, NItem10Dine, NItem10Bath, NItem10Gard, NItem10Office);

            if (NItem1Living.Value > 0)
            {
                NItem1Living.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Living.Visible = false;
            }


            if (NItem2Live.Value > 0)
            {
                NItem2Live.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Live.Visible = false;
            }


            if (NItem3Live.Value > 0)
            {
                NItem3Live.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Live.Visible = false;
            }


            if (NItem4Live.Value > 0)
            {
                NItem4Live.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Live.Visible = false;
            }


            if (NItem5Live.Value > 0)
            {
                NItem5Live.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Live.Visible = false;
            }


            if (NItem6Live.Value > 0)
            {
                NItem6Live.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Live.Visible = false;
            }

            if (NItem7Live.Value > 0)
            {
                NItem7Live.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Live.Visible = false;
            }

            if (NItem9Live.Value > 0)
            {
                NItem9Live.Visible = true;
                PctAdd9.Visible = false;
            }

            else
            {
                PctAdd9.Visible = true;
                NItem9Live.Visible = false;
            }

            if (NItem10Live.Value > 0)
            {
                NItem10Live.Visible = true;
                PctAdd10.Visible = false;
            }

            else
            {
                PctAdd10.Visible = true;
                NItem10Live.Visible = false;
            }






        }

        public void SetupDining()
        {
            LblItem1.Text = "6 Seater Dining Table";
            LblItem2.Text = "8 Seater Dining Table";
            LblItem3.Text = "Dining Chair";
            LblItem4.Text = "Display Cabinet";
            LblItem5.Text = "Rug";
            LblItem6.Text = "";
            LblItem7.Text = "";
            LblItem9.Text = "";
            LblItem10.Text = "";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            hideunderline(Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            hideAdd(PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            LblDining.ForeColor = Color.Blue;

            Font font = new Font(LblDining.Font, FontStyle.Underline);
            LblDining.Font = font;

            defaultfontstyle(LblBedrooms, LblBathrooms, LblGarden, LblLiving, LblOffice, LblKitchen);
            defaultfont(LblBedrooms, LblBathrooms, LblGarden, LblLiving, LblOffice, LblKitchen);


            hidevalues(NItem1Bed, NItem1Kitchen, NItem1Living, NItem1Bath, NItem1Gard, NItem1Office);
            hidevalues(NItem2Bed, NItem2Kitchen, NItem2Live, NItem2Bath, NItem2Gard, NItem2Office);
            hidevalues(NItem3Bed, NItem3Kitchen, NItem3Live, NItem3Bath, NItem3Gard, NItem3Office);
            hidevalues(NItem4Bed, NItem4Kitchen, NItem4Live, NItem4Bath, NItem4Gard, NItem4Office);
            hidevalues(NItem5Bed, NItem5Kitchen, NItem5Live, NItem5Bath, NItem5Gard, NItem5Office);
            hidevalues(NItem6Bed, NItem6Kitchen, NItem6Live, NItem6Bath, NItem6Gard, NItem6Office);
            hidevalues(NItem7Bed, NItem7Kitchen, NItem7Live, NItem7Bath, NItem7Gard, NItem7Office);
            hidevalues(NItem9Bed, NItem9Kitchen, NItem9Live, NItem9Bath, NItem9Gard, NItem9Office);
            hidevalues(NItem10Bed, NItem10Kitchen, NItem10Live, NItem10Bath, NItem10Gard, NItem10Office);


            if (NItem1Dine.Value > 0)
            {
                NItem1Dine.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Dine.Visible = false;
            }


            if (NItem2Dine.Value > 0)
            {
                NItem2Dine.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Dine.Visible = false;
            }


            if (NItem3Dine.Value > 0)
            {
                NItem3Dine.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Dine.Visible = false;
            }


            if (NItem4Dine.Value > 0)
            {
                NItem4Dine.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Dine.Visible = false;
            }


            if (NItem5Dine.Value > 0)
            {
                NItem5Dine.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Dine.Visible = false;
            }




        }

        public void SetupKitchen()
        {
            LblItem1.Text = "Fridge Freezer";
            LblItem2.Text = "Washing Machine";
            LblItem3.Text = "Tumble Dryer";
            LblItem4.Text = "Microwave";
            LblItem5.Text = "Oven";
            LblItem6.Text = "Dishwaher";
            LblItem7.Text = "Kitchen Table";
            LblItem9.Text = "Dining chair";
            LblItem10.Text = "Bin";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            LblKitchen.ForeColor = Color.Blue;

            Font font = new Font(LblKitchen.Font, FontStyle.Underline);
            LblKitchen.Font = font;

            defaultfontstyle(LblDining, LblBathrooms, LblGarden, LblLiving, LblOffice, LblBedrooms);
            defaultfont(LblDining, LblBathrooms, LblGarden, LblLiving, LblOffice, LblBedrooms);


            hidevalues(NItem1Bed, NItem1Dine, NItem1Living, NItem1Bath, NItem1Gard, NItem1Office);
            hidevalues(NItem2Bed, NItem2Dine, NItem2Live, NItem2Bath, NItem2Gard, NItem2Office);
            hidevalues(NItem3Bed, NItem3Dine, NItem3Live, NItem3Bath, NItem3Gard, NItem3Office);
            hidevalues(NItem4Bed, NItem4Dine, NItem4Live, NItem4Bath, NItem4Gard, NItem4Office);
            hidevalues(NItem5Bed, NItem5Dine, NItem5Live, NItem5Bath, NItem5Gard, NItem5Office);
            hidevalues(NItem6Bed, NItem6Dine, NItem6Live, NItem6Bath, NItem6Gard, NItem6Office);
            hidevalues(NItem7Bed, NItem7Dine, NItem7Live, NItem7Bath, NItem7Gard, NItem7Office);
            hidevalues(NItem9Bed, NItem9Dine, NItem9Live, NItem9Bath, NItem9Gard, NItem9Office);
            hidevalues(NItem10Bed, NItem10Dine, NItem10Live, NItem10Bath, NItem10Gard, NItem10Office);

            if (NItem1Kitchen.Value > 0)
            {
                NItem1Kitchen.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Kitchen.Visible = false;
            }


            if (NItem2Kitchen.Value > 0)
            {
                NItem2Kitchen.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Kitchen.Visible = false;
            }


            if (NItem3Kitchen.Value > 0)
            {
                NItem3Kitchen.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Kitchen.Visible = false;
            }


            if (NItem4Kitchen.Value > 0)
            {
                NItem4Kitchen.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Kitchen.Visible = false;
            }


            if (NItem5Kitchen.Value > 0)
            {
                NItem5Kitchen.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Kitchen.Visible = false;
            }


            if (NItem6Kitchen.Value > 0)
            {
                NItem6Kitchen.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Kitchen.Visible = false;
            }

            if (NItem7Kitchen.Value > 0)
            {
                NItem7Kitchen.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Kitchen.Visible = false;
            }

            if (NItem9Kitchen.Value > 0)
            {
                NItem9Kitchen.Visible = true;
                PctAdd9.Visible = false;
            }

            else
            {
                PctAdd9.Visible = true;
                NItem9Kitchen.Visible = false;
            }

            if (NItem10Kitchen.Value > 0)
            {
                NItem10Kitchen.Visible = true;
                PctAdd10.Visible = false;
            }

            else
            {
                PctAdd10.Visible = true;
                NItem10Kitchen.Visible = false;
            }
        }

        public void SetupOffice()
        {
            LblItem1.Text = "Office Chair";
            LblItem2.Text = "Office Desk";
            LblItem3.Text = "Lamp";
            LblItem4.Text = "Display Cabinet";
            LblItem5.Text = "Printer";
            LblItem6.Text = "Filing Cabinet";
            LblItem7.Text = "Computer";
            LblItem9.Text = "";
            LblItem10.Text = "";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            hideunderline(Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            hideAdd(PctAdd9, PctAdd10);
            LblOffice.ForeColor = Color.Blue;
            Font font = new Font(LblOffice.Font, FontStyle.Underline);
            LblOffice.Font = font;

            defaultfontstyle(LblDining, LblBathrooms, LblGarden, LblLiving, LblBedrooms, LblKitchen);
            defaultfont(LblDining, LblBathrooms, LblGarden, LblLiving, LblBedrooms, LblKitchen);

            hidevalues(NItem1Bed, NItem1Dine, NItem1Living, NItem1Bath, NItem1Gard, NItem1Kitchen);
            hidevalues(NItem2Bed, NItem2Dine, NItem2Live, NItem2Bath, NItem2Gard, NItem2Kitchen);
            hidevalues(NItem3Bed, NItem3Dine, NItem3Live, NItem3Bath, NItem3Gard, NItem3Kitchen);
            hidevalues(NItem4Bed, NItem4Dine, NItem4Live, NItem4Bath, NItem4Gard, NItem4Kitchen);
            hidevalues(NItem5Bed, NItem5Dine, NItem5Live, NItem5Bath, NItem5Gard, NItem5Kitchen);
            hidevalues(NItem6Bed, NItem6Dine, NItem6Live, NItem6Bath, NItem6Gard, NItem6Kitchen);
            hidevalues(NItem7Bed, NItem7Dine, NItem7Live, NItem7Bath, NItem7Gard, NItem7Kitchen);
            hidevalues(NItem9Bed, NItem9Dine, NItem9Live, NItem9Bath, NItem9Gard, NItem9Kitchen);
            hidevalues(NItem10Bed, NItem10Dine, NItem10Live, NItem10Bath, NItem10Gard, NItem10Kitchen);


            if (NItem1Office.Value > 0)
            {
                NItem1Office.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Office.Visible = false;
            }


            if (NItem2Office.Value > 0)
            {
                NItem2Office.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Office.Visible = false;
            }


            if (NItem3Office.Value > 0)
            {
                NItem3Office.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Office.Visible = false;
            }


            if (NItem4Office.Value > 0)
            {
                NItem4Office.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Office.Visible = false;
            }


            if (NItem5Office.Value > 0)
            {
                NItem5Office.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Office.Visible = false;
            }


            if (NItem6Office.Value > 0)
            {
                NItem6Office.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Office.Visible = false;
            }

            if (NItem7Office.Value > 0)
            {
                NItem7Office.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Office.Visible = false;
            }



        }

        public void SetupBathrooms()
        {
            LblItem1.Text = "Large Mirror";
            LblItem2.Text = "Small Mirror";
            LblItem3.Text = "Rug";
            LblItem4.Text = "Bathroom Cabinet";
            LblItem5.Text = "Bath Tub";
            LblItem6.Text = "Shower Shelf";
            LblItem7.Text = "Bin";
            LblItem9.Text = "";
            LblItem10.Text = "";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            hideunderline(Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            hideAdd(PctAdd9, PctAdd10);
            LblBathrooms.ForeColor = Color.Blue;
            Font font = new Font(LblBathrooms.Font, FontStyle.Underline);
            LblBathrooms.Font = font;

            defaultfontstyle(LblDining, LblBedrooms, LblGarden, LblLiving, LblOffice, LblKitchen);
            defaultfont(LblDining, LblBedrooms, LblGarden, LblLiving, LblOffice, LblKitchen);

            hidevalues(NItem1Bed, NItem1Dine, NItem1Living, NItem1Office, NItem1Gard, NItem1Kitchen);
            hidevalues(NItem2Bed, NItem2Dine, NItem2Live, NItem2Office, NItem2Gard, NItem2Kitchen);
            hidevalues(NItem3Bed, NItem3Dine, NItem3Live, NItem3Office, NItem3Gard, NItem3Kitchen);
            hidevalues(NItem4Bed, NItem4Dine, NItem4Live, NItem4Office, NItem4Gard, NItem4Kitchen);
            hidevalues(NItem5Bed, NItem5Dine, NItem5Live, NItem5Office, NItem5Gard, NItem5Kitchen);
            hidevalues(NItem6Bed, NItem6Dine, NItem6Live, NItem6Office, NItem6Gard, NItem6Kitchen);
            hidevalues(NItem7Bed, NItem7Dine, NItem7Live, NItem7Office, NItem7Gard, NItem7Kitchen);
            hidevalues(NItem9Bed, NItem9Dine, NItem9Live, NItem9Office, NItem9Gard, NItem9Kitchen);
            hidevalues(NItem10Bed, NItem10Dine, NItem10Live, NItem10Office, NItem10Gard, NItem10Kitchen);


            if (NItem1Bath.Value > 0)
            {
                NItem1Bath.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Bath.Visible = false;
            }


            if (NItem2Bath.Value > 0)
            {
                NItem2Bath.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Bath.Visible = false;
            }


            if (NItem3Bath.Value > 0)
            {
                NItem3Bath.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Bath.Visible = false;
            }


            if (NItem4Bath.Value > 0)
            {
                NItem4Bath.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Bath.Visible = false;
            }


            if (NItem5Bath.Value > 0)
            {
                NItem5Bath.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Bath.Visible = false;
            }


            if (NItem6Bath.Value > 0)
            {
                NItem6Bath.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Bath.Visible = false;
            }

            if (NItem7Bath.Value > 0)
            {
                NItem7Bath.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Bath.Visible = false;
            }

        }
        public void SetupGarden()
        {
            LblItem1.Text = "Garden Table";
            LblItem2.Text = "Garden Chair";
            LblItem3.Text = "Lawn Mover";
            LblItem4.Text = "Tool Box";
            LblItem5.Text = "Bench";
            LblItem6.Text = "Parasol";
            LblItem7.Text = "Bicycle";
            LblItem9.Text = "";
            LblItem10.Text = "";
            showunderline(Lblunderline1, Lblunderline2, Lblunderline3, Lblunderline4, Lblunderline5, Lblunderline6, Lblunderline7, Lblunderline9, Lblunderline10);
            hideunderline(Lblunderline9, Lblunderline10);
            showAdd(PctAdd1, PctAdd2, PctAdd3, PctAdd4, PctAdd5, PctAdd6, PctAdd7, PctAdd9, PctAdd10);
            hideAdd(PctAdd9, PctAdd10);
            LblGarden.ForeColor = Color.Blue;
            Font font = new Font(LblGarden.Font, FontStyle.Underline);
            LblGarden.Font = font;

            defaultfontstyle(LblDining, LblBathrooms, LblBedrooms, LblLiving, LblOffice, LblKitchen);
            defaultfont(LblDining, LblBathrooms, LblBedrooms, LblLiving, LblOffice, LblKitchen);


            hidevalues(NItem1Bed, NItem1Dine, NItem1Living, NItem1Office, NItem1Bath, NItem1Kitchen);
            hidevalues(NItem2Bed, NItem2Dine, NItem2Live, NItem2Office, NItem2Bath, NItem2Kitchen);
            hidevalues(NItem3Bed, NItem3Dine, NItem3Live, NItem3Office, NItem3Bath, NItem3Kitchen);
            hidevalues(NItem4Bed, NItem4Dine, NItem4Live, NItem4Office, NItem4Bath, NItem4Kitchen);
            hidevalues(NItem5Bed, NItem5Dine, NItem5Live, NItem5Office, NItem5Bath, NItem5Kitchen);
            hidevalues(NItem6Bed, NItem6Dine, NItem6Live, NItem6Office, NItem6Bath, NItem6Kitchen);
            hidevalues(NItem7Bed, NItem7Dine, NItem7Live, NItem7Office, NItem7Bath, NItem7Kitchen);
            hidevalues(NItem9Bed, NItem9Dine, NItem9Live, NItem9Office, NItem9Bath, NItem9Kitchen);
            hidevalues(NItem10Bed, NItem10Dine, NItem10Live, NItem10Office, NItem10Bath, NItem10Kitchen);


            if (NItem1Gard.Value > 0)
            {
                NItem1Gard.Visible = true;
                PctAdd1.Visible = false;
            }

            else
            {
                PctAdd1.Visible = true;
                NItem1Gard.Visible = false;
            }


            if (NItem2Gard.Value > 0)
            {
                NItem2Gard.Visible = true;
                PctAdd2.Visible = false;
            }


            else
            {
                PctAdd2.Visible = true;
                NItem2Gard.Visible = false;
            }


            if (NItem3Gard.Value > 0)
            {
                NItem3Gard.Visible = true;
                PctAdd3.Visible = false;
            }
            else
            {
                PctAdd3.Visible = true;
                NItem3Gard.Visible = false;
            }


            if (NItem4Gard.Value > 0)
            {
                NItem4Gard.Visible = true;
                PctAdd4.Visible = false;
            }
            else
            {
                PctAdd4.Visible = true;
                NItem4Gard.Visible = false;
            }


            if (NItem5Gard.Value > 0)
            {
                NItem5Gard.Visible = true;
                PctAdd5.Visible = false;
            }
            else
            {
                PctAdd5.Visible = true;
                NItem5Gard.Visible = false;
            }


            if (NItem6Gard.Value > 0)
            {
                NItem6Gard.Visible = true;
                PctAdd6.Visible = false;
            }
            else
            {
                PctAdd6.Visible = true;
                NItem6Gard.Visible = false;
            }

            if (NItem7Gard.Value > 0)
            {
                NItem7Gard.Visible = true;
                PctAdd7.Visible = false;
            }

            else
            {
                PctAdd7.Visible = true;
                NItem7Gard.Visible = false;
            }

        }


        private void PctAdd1_Click(object sender, EventArgs e)
        {
            PctAdd1.Visible = false;
            if (LblItem1.Text == "Single bed + Mattress")
            {
                NItem1Bed.Visible = true;
                NItem1Bed.Value = 1;
            }
            if (LblItem1.Text == "Two Seater sofa")
            {
                NItem1Living.Visible = true;
                NItem1Living.Value = 1;
            }
            if (LblItem1.Text == "6 Seater Dining Table")
            {
                NItem1Dine.Visible = true;
                NItem1Dine.Value = 1;
            }
            if (LblItem1.Text == "Fridge Freezer")
            {
                NItem1Kitchen.Visible = true;
                NItem1Kitchen.Value = 1;
            }
            if (LblItem1.Text == "Office Chair")
            {
                NItem1Office.Visible = true;
                NItem1Office.Value = 1;
            }
            if (LblItem1.Text == "Large Mirror")
            {
                NItem1Bath.Visible = true;
                NItem1Bath.Value = 1;
            }
            if (LblItem1.Text == "Garden Table")
            {
                NItem1Gard.Visible = true;
                NItem1Gard.Value = 1;
            }



        }


        private void PctAdd2_Click(object sender, EventArgs e)
        {
            PctAdd2.Visible = false;
            if (LblItem2.Text == "Double bed + Mattress")
            {
                NItem2Bed.Visible = true;
                NItem2Bed.Value = 1;
            }
            if (LblItem2.Text == "Three Seater Sofa")
            {
                NItem2Live.Visible = true;
                NItem2Live.Value = 1;
            }
            if (LblItem2.Text == "8 Seater Dining Table")
            {
                NItem2Dine.Visible = true;
                NItem2Dine.Value = 1;
            }
            if (LblItem2.Text == "Washing Machine")
            {
                NItem2Kitchen.Visible = true;
                NItem2Kitchen.Value = 1;
            }
            if (LblItem2.Text == "Office Desk")
            {
                NItem2Office.Visible = true;
                NItem2Office.Value = 1;
            }
            if (LblItem2.Text == "Small Mirror")
            {
                NItem2Bath.Visible = true;
                NItem2Bath.Value = 1;
            }
            if (LblItem2.Text == "Garden Chair")
            {
                NItem2Gard.Visible = true;
                NItem2Gard.Value = 1;
            }



        }

        private void PctAdd3_Click(object sender, EventArgs e)
        {
            PctAdd3.Visible = false;
            if (LblItem3.Text == "Kingsize Bed + Mattress")
            {
                NItem3Bed.Visible = true;
                NItem3Bed.Value = 1;
            }
            if (LblItem3.Text == "Four Seater Sofa")
            {
                NItem3Live.Visible = true;
                NItem3Live.Value = 1;
            }
            if (LblItem3.Text == "Dining Chair")
            {
                NItem3Dine.Visible = true;
                NItem3Dine.Value = 1;
            }
            if (LblItem3.Text == "Tumble Dryer")
            {
                NItem3Kitchen.Visible = true;
                NItem3Kitchen.Value = 1;
            }
            if (LblItem3.Text == "Lamp")
            {
                NItem3Office.Visible = true;
                NItem3Office.Value = 1;
            }
            if (LblItem3.Text == "Rug")
            {
                NItem3Bath.Visible = true;
                NItem3Bath.Value = 1;
            }
            if (LblItem3.Text == "Lawn Mover")
            {
                NItem3Gard.Visible = true;
                NItem3Gard.Value = 1;
            }
        }

        private void PctAdd4_Click(object sender, EventArgs e)
        {
            PctAdd4.Visible = false;
            if (LblItem4.Text == "Single Wardrobe")
            {
                NItem4Bed.Visible = true;
                NItem4Bed.Value = 1;
            }
            if (LblItem4.Text == "Armchair")
            {
                NItem4Live.Visible = true;
                NItem4Live.Value = 1;
            }
            if (LblItem4.Text == "Display Cabinet")
            {
                NItem4Dine.Visible = true;
                NItem4Dine.Value = 1;
            }
            if (LblItem4.Text == "Microwave")
            {
                NItem4Kitchen.Visible = true;
                NItem4Kitchen.Value = 1;
            }
            if (LblItem4.Text == "Bathroom Cabinet")
            {
                NItem4Office.Visible = true;
                NItem4Office.Value = 1;
            }
            if (LblItem4.Text == "Display Cabinet")
            {
                NItem4Bath.Visible = true;
                NItem4Bath.Value = 1;
            }
            if (LblItem4.Text == "Tool Box")
            {
                NItem4Gard.Visible = true;
                NItem4Gard.Value = 1;
            }
        }

        private void PctAdd5_Click(object sender, EventArgs e)
        {
            PctAdd5.Visible = false;
            if (LblItem5.Text == "Double Wardrobe")
            {
                NItem5Bed.Visible = true;
                NItem5Bed.Value = 1;
            }
            if (LblItem5.Text == "Coffee Table")
            {
                NItem5Live.Visible = true;
                NItem5Live.Value = 1;
            }
            if (LblItem5.Text == "Rug")
            {
                NItem5Dine.Visible = true;
                NItem5Dine.Value = 1;
            }
            if (LblItem5.Text == "Oven")
            {
                NItem5Kitchen.Visible = true;
                NItem5Kitchen.Value = 1;
            }
            if (LblItem5.Text == "Printer")
            {
                NItem5Office.Visible = true;
                NItem5Office.Value = 1;
            }
            if (LblItem5.Text == "Bath Tub")
            {
                NItem5Bath.Visible = true;
                NItem5Bath.Value = 1;
            }
            if (LblItem5.Text == "Bench")
            {
                NItem5Gard.Visible = true;
                NItem5Gard.Value = 1;
            }
        }

        private void PctAdd6_Click(object sender, EventArgs e)
        {
            PctAdd6.Visible = false;
            if (LblItem6.Text == "Chest of Drawers")
            {
                NItem6Bed.Visible = true;
                NItem6Bed.Value = 1;
            }
            if (LblItem6.Text == "Television")
            {
                NItem6Live.Visible = true;
                NItem6Live.Value = 1;
            }
            //   if (LblItem6.Text == "")
            //    {
            //      NItem6Dine.Visible = true;
            //       NItem6Dine.Value = 1;
            //  }
            if (LblItem6.Text == "Dishwaher")
            {
                NItem6Kitchen.Visible = true;
                NItem6Kitchen.Value = 1;
            }
            if (LblItem6.Text == "Filing Cabinet")
            {
                NItem6Office.Visible = true;
                NItem6Office.Value = 1;
            }
            if (LblItem6.Text == "Shower Shelf")
            {
                NItem6Bath.Visible = true;
                NItem6Bath.Value = 1;
            }
            if (LblItem6.Text == "Parasol")
            {
                NItem6Gard.Visible = true;
                NItem6Gard.Value = 1;
            }
        }

        private void PctAdd7_Click(object sender, EventArgs e)
        {
            PctAdd7.Visible = false;
            if (LblItem7.Text == "Bedside Table")
            {
                NItem7Bed.Visible = true;
                NItem7Bed.Value = 1;
            }
            if (LblItem7.Text == "TV Stand")
            {
                NItem7Live.Visible = true;
                NItem7Live.Value = 1;
            }
            //   if (LblItem6.Text == "")
            //    {
            //      NItem6Dine.Visible = true;
            //       NItem6Dine.Value = 1;
            //  }
            if (LblItem7.Text == "Kitchen Table")
            {
                NItem7Kitchen.Visible = true;
                NItem7Kitchen.Value = 1;
            }
            if (LblItem7.Text == "Computer")
            {
                NItem7Office.Visible = true;
                NItem7Office.Value = 1;
            }
            if (LblItem7.Text == "Bin")
            {
                NItem7Bath.Visible = true;
                NItem7Bath.Value = 1;
            }
            if (LblItem7.Text == "Bicycle")
            {
                NItem7Gard.Visible = true;
                NItem7Gard.Value = 1;
            }
        }

        private void PctAdd9_Click(object sender, EventArgs e)
        {
            PctAdd9.Visible = false;
            if (LblItem9.Text == "Dressing Table")
            {
                NItem9Bed.Visible = true;
                NItem9Bed.Value = 1;
            }
            if (LblItem9.Text == "Bookcase")
            {
                NItem9Live.Visible = true;
                NItem9Live.Value = 1;
            }

            if (LblItem9.Text == "Dining chair")
            {
                NItem7Kitchen.Visible = true;
                NItem7Kitchen.Value = 1;
            }
        }

        private void PctAdd10_Click(object sender, EventArgs e)
        {
            if (LblItem10.Text == "Television")
            {
                NItem10Bed.Visible = true;
                NItem10Bed.Value = 1;
            }
            if (LblItem10.Text == "Rug")
            {
                NItem10Live.Visible = true;
                NItem10Live.Value = 1;
            }

            if (LblItem10.Text == "Bin")
            {
                NItem10Kitchen.Visible = true;
                NItem10Kitchen.Value = 1;
            }
        }

        private void NItem1_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Bed.Value == 0)
            {
                NItem1Bed.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem2_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Bed.Value == 0)
            {
                NItem2Bed.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem3_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Bed.Value == 0)
            {
                NItem3Bed.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem4_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Bed.Value == 0)
            {
                NItem4Bed.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem5_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Bed.Value == 0)
            {
                NItem5Bed.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem6_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Bed.Value == 0)
            {
                NItem6Bed.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem7_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Bed.Value == 0)
            {
                NItem7Bed.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem9_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Bed.Value == 0)
            {
                NItem9Bed.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem10_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Bed.Value == 0)
            {
                NItem10Bed.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void PtcLiving_Click(object sender, EventArgs e)
        {
            SetupLiving();

            ResizeFormToFitControls(this, 30); // Adjust with 30px padding


        }

        private void PctBedrooms_Click(object sender, EventArgs e)
        {
            SetupBedrooms();
            ResizeFormToFitControls(this, 30);
        }

        private void PtcKitchen_Click(object sender, EventArgs e)
        {
            SetupKitchen();
            ResizeFormToFitControls(this, 30);
        }

        private void PctOffice_Click(object sender, EventArgs e)
        {
            SetupOffice();
            ResizeFormToFitControls(this, 30);
        }

        private void PctBathrooms_Click(object sender, EventArgs e)
        {
            SetupBathrooms();
            ResizeFormToFitControls(this, 30);
        }

        private void PtcDining_Click(object sender, EventArgs e)
        {
            SetupDining();
            ResizeFormToFitControls(this, 30);
        }

        private void PctGarden_Click(object sender, EventArgs e)
        {
            SetupGarden();
            ResizeFormToFitControls(this, 30);
        }

        private void NItem1Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Gard.Value == 0)
            {
                NItem1Gard.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem1Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Dine.Value == 0)
            {
                NItem1Dine.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem1Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Bath.Value == 0)
            {
                NItem1Bath.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem1Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Office.Value == 0)
            {
                NItem1Office.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem1Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Kitchen.Value == 0)
            {
                NItem1Kitchen.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem1Living_ValueChanged(object sender, EventArgs e)
        {
            if (NItem1Living.Value == 0)
            {
                NItem1Living.Visible = false;
                PctAdd1.Visible = true;
            }
        }

        private void NItem2Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Gard.Value == 0)
            {
                NItem2Gard.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem2Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Office.Value == 0)
            {
                NItem2Office.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem2Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Kitchen.Value == 0)
            {
                NItem2Kitchen.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem2Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Bath.Value == 0)
            {
                NItem2Bath.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem2Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Dine.Value == 0)
            {
                NItem2Dine.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem2Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem2Live.Value == 0)
            {
                NItem2Live.Visible = false;
                PctAdd2.Visible = true;
            }
        }

        private void NItem3Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Gard.Value == 0)
            {
                NItem3Gard.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem3Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Office.Value == 0)
            {
                NItem3Office.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem3Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Kitchen.Value == 0)
            {
                NItem3Kitchen.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem3Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Bath.Value == 0)
            {
                NItem3Bath.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem3Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Dine.Value == 0)
            {
                NItem3Dine.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem3Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem3Live.Value == 0)
            {
                NItem3Live.Visible = false;
                PctAdd3.Visible = true;
            }
        }

        private void NItem4Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Office.Value == 0)
            {
                NItem4Office.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem4Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Kitchen.Value == 0)
            {
                NItem4Kitchen.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem4Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Bath.Value == 0)
            {
                NItem4Bath.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem4Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Live.Value == 0)
            {
                NItem4Live.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem4Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Dine.Value == 0)
            {
                NItem4Dine.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem4Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem4Gard.Value == 0)
            {
                NItem4Gard.Visible = false;
                PctAdd4.Visible = true;
            }
        }

        private void NItem5Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Office.Value == 0)
            {
                NItem5Office.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem5Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Kitchen.Value == 0)
            {
                NItem5Kitchen.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem5Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Gard.Value == 0)
            {
                NItem5Gard.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem5Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Dine.Value == 0)
            {
                NItem5Dine.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem5Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Live.Value == 0)
            {
                NItem5Live.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void NItem5Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem5Bath.Value == 0)
            {
                NItem5Bath.Visible = false;
                PctAdd5.Visible = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void NItem6Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Gard.Value == 0)
            {
                NItem6Gard.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem6Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Kitchen.Value == 0)
            {
                NItem6Kitchen.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem6Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Office.Value == 0)
            {
                NItem6Office.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem6Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Bath.Value == 0)
            {
                NItem6Bath.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem6Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Dine.Value == 0)
            {
                NItem6Dine.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem6Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem6Live.Value == 0)
            {
                NItem6Live.Visible = false;
                PctAdd6.Visible = true;
            }
        }

        private void NItem7Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Bath.Value == 0)
            {
                NItem7Bath.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem7Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Office.Value == 0)
            {
                NItem7Office.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem7Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Dine.Value == 0)
            {
                NItem7Dine.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem7Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Gard.Value == 0)
            {
                NItem7Gard.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem7Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Kitchen.Value == 0)
            {
                NItem7Kitchen.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem7Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem7Live.Value == 0)
            {
                NItem7Live.Visible = false;
                PctAdd7.Visible = true;
            }
        }

        private void NItem9Gard_VisibleChanged(object sender, EventArgs e)
        {
            if (NItem9Gard.Value == 0)
            {
                NItem9Gard.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem9Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Dine.Value == 0)
            {
                NItem9Dine.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem9Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Bath.Value == 0)
            {
                NItem9Bath.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem9Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Kitchen.Value == 0)
            {
                NItem9Kitchen.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem9Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Office.Value == 0)
            {
                NItem9Office.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem9Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem9Live.Value == 0)
            {
                NItem9Live.Visible = false;
                PctAdd9.Visible = true;
            }
        }

        private void NItem10Gard_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Gard.Value == 0)
            {
                NItem10Gard.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void NItem10Dine_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Dine.Value == 0)
            {
                NItem10Dine.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void NItem10Bath_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Bath.Value == 0)
            {
                NItem10Bath.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void NItem10Office_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Office.Value == 0)
            {
                NItem10Office.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void NItem10Kitchen_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Kitchen.Value == 0)
            {
                NItem10Kitchen.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void NItem10Live_ValueChanged(object sender, EventArgs e)
        {
            if (NItem10Live.Value == 0)
            {
                NItem10Live.Visible = false;
                PctAdd10.Visible = true;
            }
        }

        private void BtnAddDimensions_Click(object sender, EventArgs e)
        {
            {
                string length, width, height;
                DialogResult result = InputBox.Show("Enter Dimensions", "Please enter the dimensions of the item(cm):", out length , out width , out height);

                if (result == DialogResult.OK)
                {
                    if (!string.IsNullOrEmpty(length) || !string.IsNullOrEmpty(width) || !string.IsNullOrEmpty(height)) 
                    {

                        string additem = "Name of item: " + TxtAddItem.Text + " " + "Quantity of item(s): " + NItemExtra.Value + " " + "Dimensions of item(s): " + length + ", " + width + ", " + height + "\n";
                        RTBItems.AppendText(additem);
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid dimensions.", "Dimensions error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 } 
            }
        }

        private void TxtAddItem_TextChanged(object sender, EventArgs e)
        {
            if(TxtAddItem.Text == "")
            {
                BtnAddDimensions.Enabled = false;
                NItemExtra.Enabled = false;
            }
            else
            {
                NItemExtra.Enabled = true;
            }
        }

        private void NItemExtra_ValueChanged(object sender, EventArgs e)
        {
            if(NItemExtra.Value == 0)
            {
                BtnAddDimensions.Enabled = false;
            }
            else
            {
                BtnAddDimensions.Enabled = true;
            }
        }




















    }
}
