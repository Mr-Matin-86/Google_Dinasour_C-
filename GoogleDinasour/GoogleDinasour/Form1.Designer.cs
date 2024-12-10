namespace GoogleDinasour
{
    partial class FRMMain
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
            this.PNLDown = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PCBDani = new System.Windows.Forms.PictureBox();
            this.PCBcactus = new System.Windows.Forms.PictureBox();
            this.PNLTop = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PCBDani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBcactus)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLDown
            // 
            this.PNLDown.BackColor = System.Drawing.Color.Black;
            this.PNLDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNLDown.Location = new System.Drawing.Point(0, 285);
            this.PNLDown.Name = "PNLDown";
            this.PNLDown.Size = new System.Drawing.Size(1436, 100);
            this.PNLDown.TabIndex = 1;
            this.PNLDown.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLDown_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PCBDani
            // 
            this.PCBDani.BackColor = System.Drawing.Color.Transparent;
            this.PCBDani.Image = global::GoogleDinasour.Properties.Resources.dinosaur_game_seeklogo;
            this.PCBDani.Location = new System.Drawing.Point(133, 207);
            this.PCBDani.Name = "PCBDani";
            this.PCBDani.Size = new System.Drawing.Size(74, 78);
            this.PCBDani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBDani.TabIndex = 0;
            this.PCBDani.TabStop = false;
            this.PCBDani.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PCBcactus
            // 
            this.PCBcactus.BackColor = System.Drawing.Color.Transparent;
            this.PCBcactus.Image = global::GoogleDinasour.Properties.Resources._1;
            this.PCBcactus.Location = new System.Drawing.Point(1173, 207);
            this.PCBcactus.Name = "PCBcactus";
            this.PCBcactus.Size = new System.Drawing.Size(57, 78);
            this.PCBcactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBcactus.TabIndex = 2;
            this.PCBcactus.TabStop = false;
            this.PCBcactus.Click += new System.EventHandler(this.PCBcactus_Click);
            // 
            // PNLTop
            // 
            this.PNLTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNLTop.Location = new System.Drawing.Point(0, 0);
            this.PNLTop.Name = "PNLTop";
            this.PNLTop.Size = new System.Drawing.Size(1436, 101);
            this.PNLTop.TabIndex = 3;
            this.PNLTop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PNLTop_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1436, 385);
            this.Controls.Add(this.PCBDani);
            this.Controls.Add(this.PNLTop);
            this.Controls.Add(this.PCBcactus);
            this.Controls.Add(this.PNLDown);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRMMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Dinasour";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRMMain_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FRMMain_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PCBDani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBcactus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PCBDani;
        private System.Windows.Forms.Panel PNLDown;
        private System.Windows.Forms.PictureBox PCBcactus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PNLTop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

