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
   
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
      

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            TmrSplash.Start();
            PctLogo.BackColor = Color.Transparent;

        }

        int timercount = 0;

        private void TmrSplash_Tick(object sender, EventArgs e)
        {
            timercount++;
                Rectangle van = PtcVan.Bounds;
                Rectangle house = PtcHouse.Bounds;

            if (!van.IntersectsWith( house))
            {
                PtcVan.Left += 2;
                
            }
            else
            {
                Forms.FrmLogin move = new Forms.FrmLogin();
                this.Hide();
                move.Show();
                TmrSplash.Stop();
            }






        }
    }
}
