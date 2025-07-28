namespace Jungle_Math
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblQuestionName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pcbx = new System.Windows.Forms.PictureBox();
            this.BtnEntry = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtUserName.Font = new System.Drawing.Font("Fredoka", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(454, 320);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(621, 89);
            this.TxtUserName.TabIndex = 0;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblQuestionName
            // 
            this.LblQuestionName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblQuestionName.AutoSize = true;
            this.LblQuestionName.BackColor = System.Drawing.Color.Transparent;
            this.LblQuestionName.Font = new System.Drawing.Font("Fredoka", 59.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestionName.ForeColor = System.Drawing.Color.White;
            this.LblQuestionName.Location = new System.Drawing.Point(350, 160);
            this.LblQuestionName.Name = "LblQuestionName";
            this.LblQuestionName.Size = new System.Drawing.Size(881, 100);
            this.LblQuestionName.TabIndex = 1;
            this.LblQuestionName.Text = "Hola, ¿Como te llamas?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-104, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 775);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Pcbx
            // 
            this.Pcbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcbx.BackColor = System.Drawing.Color.Transparent;
            this.Pcbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pcbx.Image = ((System.Drawing.Image)(resources.GetObject("Pcbx.Image")));
            this.Pcbx.Location = new System.Drawing.Point(792, -137);
            this.Pcbx.Name = "Pcbx";
            this.Pcbx.Size = new System.Drawing.Size(799, 775);
            this.Pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcbx.TabIndex = 4;
            this.Pcbx.TabStop = false;
            // 
            // BtnEntry
            // 
            this.BtnEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntry.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntry.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntry.Image")));
            this.BtnEntry.Location = new System.Drawing.Point(1150, 504);
            this.BtnEntry.Name = "BtnEntry";
            this.BtnEntry.Size = new System.Drawing.Size(251, 250);
            this.BtnEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnEntry.TabIndex = 5;
            this.BtnEntry.TabStop = false;
            this.BtnEntry.Click += new System.EventHandler(this.BtnEntry_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1118, 488);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(307, 307);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1517, 780);
            this.Controls.Add(this.BtnEntry);
            this.Controls.Add(this.LblQuestionName);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pcbx);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vally";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblQuestionName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Pcbx;
        private System.Windows.Forms.PictureBox BtnEntry;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}