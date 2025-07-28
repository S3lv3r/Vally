namespace Jungle_Math
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSumForm = new System.Windows.Forms.PictureBox();
            this.BtnSubsForm = new System.Windows.Forms.PictureBox();
            this.BtnMultForm = new System.Windows.Forms.PictureBox();
            this.BtnDivForm = new System.Windows.Forms.PictureBox();
            this.BtnExitApp = new System.Windows.Forms.PictureBox();
            this.BtnMinApp = new System.Windows.Forms.PictureBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblDailyPhrase = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSumForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSubsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMultForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDivForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BtnSumForm
            // 
            resources.ApplyResources(this.BtnSumForm, "BtnSumForm");
            this.BtnSumForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnSumForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSumForm.Name = "BtnSumForm";
            this.BtnSumForm.TabStop = false;
            this.BtnSumForm.Click += new System.EventHandler(this.BtnSumForm_Click_1);
            // 
            // BtnSubsForm
            // 
            resources.ApplyResources(this.BtnSubsForm, "BtnSubsForm");
            this.BtnSubsForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnSubsForm.Name = "BtnSubsForm";
            this.BtnSubsForm.TabStop = false;
            this.BtnSubsForm.Click += new System.EventHandler(this.BtnSubsForm_Click);
            // 
            // BtnMultForm
            // 
            resources.ApplyResources(this.BtnMultForm, "BtnMultForm");
            this.BtnMultForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnMultForm.Name = "BtnMultForm";
            this.BtnMultForm.TabStop = false;
            this.BtnMultForm.Click += new System.EventHandler(this.BtnMultForm_Click);
            // 
            // BtnDivForm
            // 
            resources.ApplyResources(this.BtnDivForm, "BtnDivForm");
            this.BtnDivForm.BackColor = System.Drawing.Color.Transparent;
            this.BtnDivForm.Name = "BtnDivForm";
            this.BtnDivForm.TabStop = false;
            this.BtnDivForm.Click += new System.EventHandler(this.BtnDivForm_Click);
            // 
            // BtnExitApp
            // 
            resources.ApplyResources(this.BtnExitApp, "BtnExitApp");
            this.BtnExitApp.BackColor = System.Drawing.Color.Transparent;
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.TabStop = false;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // BtnMinApp
            // 
            resources.ApplyResources(this.BtnMinApp, "BtnMinApp");
            this.BtnMinApp.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinApp.Name = "BtnMinApp";
            this.BtnMinApp.TabStop = false;
            this.BtnMinApp.Click += new System.EventHandler(this.BtnMinApp_Click);
            // 
            // LblUserName
            // 
            resources.ApplyResources(this.LblUserName, "LblUserName");
            this.LblUserName.BackColor = System.Drawing.Color.Transparent;
            this.LblUserName.ForeColor = System.Drawing.Color.White;
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.DoubleClick += new System.EventHandler(this.LblUserName_DoubleClick);
            // 
            // LblDailyPhrase
            // 
            resources.ApplyResources(this.LblDailyPhrase, "LblDailyPhrase");
            this.LblDailyPhrase.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyPhrase.ForeColor = System.Drawing.Color.Transparent;
            this.LblDailyPhrase.Name = "LblDailyPhrase";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblDailyPhrase);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.BtnMinApp);
            this.Controls.Add(this.BtnExitApp);
            this.Controls.Add(this.BtnMultForm);
            this.Controls.Add(this.BtnDivForm);
            this.Controls.Add(this.BtnSubsForm);
            this.Controls.Add(this.BtnSumForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSumForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSubsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMultForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDivForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExitApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnSumForm;
        private System.Windows.Forms.PictureBox BtnSubsForm;
        private System.Windows.Forms.PictureBox BtnMultForm;
        private System.Windows.Forms.PictureBox BtnDivForm;
        private System.Windows.Forms.PictureBox BtnExitApp;
        private System.Windows.Forms.PictureBox BtnMinApp;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblDailyPhrase;
    }
}