namespace SR_Movers_coursework.Forms
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.TmrSplash = new System.Windows.Forms.Timer(this.components);
            this.PtcHouse = new System.Windows.Forms.PictureBox();
            this.PtcVan = new System.Windows.Forms.PictureBox();
            this.PctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtcHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtcVan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrSplash
            // 
            this.TmrSplash.Interval = 1;
            this.TmrSplash.Tick += new System.EventHandler(this.TmrSplash_Tick);
            // 
            // PtcHouse
            // 
            this.PtcHouse.Image = ((System.Drawing.Image)(resources.GetObject("PtcHouse.Image")));
            this.PtcHouse.Location = new System.Drawing.Point(598, 375);
            this.PtcHouse.Name = "PtcHouse";
            this.PtcHouse.Size = new System.Drawing.Size(144, 107);
            this.PtcHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtcHouse.TabIndex = 2;
            this.PtcHouse.TabStop = false;
            // 
            // PtcVan
            // 
            this.PtcVan.Image = ((System.Drawing.Image)(resources.GetObject("PtcVan.Image")));
            this.PtcVan.Location = new System.Drawing.Point(2, 399);
            this.PtcVan.Name = "PtcVan";
            this.PtcVan.Size = new System.Drawing.Size(149, 70);
            this.PtcVan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtcVan.TabIndex = 1;
            this.PtcVan.TabStop = false;
            // 
            // PctLogo
            // 
            this.PctLogo.Image = ((System.Drawing.Image)(resources.GetObject("PctLogo.Image")));
            this.PctLogo.Location = new System.Drawing.Point(12, 12);
            this.PctLogo.Name = "PctLogo";
            this.PctLogo.Size = new System.Drawing.Size(721, 357);
            this.PctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctLogo.TabIndex = 0;
            this.PctLogo.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(754, 481);
            this.Controls.Add(this.PtcHouse);
            this.Controls.Add(this.PtcVan);
            this.Controls.Add(this.PctLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtcHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtcVan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TmrSplash;
        private System.Windows.Forms.PictureBox PctLogo;
        private System.Windows.Forms.PictureBox PtcVan;
        private System.Windows.Forms.PictureBox PtcHouse;
    }
}

