namespace Coursework_WinForm_
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.headMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenu_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.headeMenu_Data_AdminPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenu_Data_LogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.headerMenu_Data_SingIn = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStartPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.headMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME 2048";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(248, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 80);
            this.panel1.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.Location = new System.Drawing.Point(222, 236);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(159, 50);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LOG  IN";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(422, 236);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(159, 50);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "SIGN  IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminPanel.ForeColor = System.Drawing.Color.White;
            this.btnAdminPanel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdminPanel.Image")));
            this.btnAdminPanel.Location = new System.Drawing.Point(300, 292);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(203, 50);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "ADMIN PANEL";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.BtnAdminPanel_Click);
            // 
            // headMenu
            // 
            this.headMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headMenu_File,
            this.headerMenu_Data});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(800, 24);
            this.headMenu.TabIndex = 3;
            this.headMenu.Text = "menuStrip1";
            // 
            // headMenu_File
            // 
            this.headMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.headMenu_File.Name = "headMenu_File";
            this.headMenu_File.Size = new System.Drawing.Size(37, 20);
            this.headMenu_File.Text = "File";
            this.headMenu_File.Click += new System.EventHandler(this.HeadMenu_File_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // headerMenu_Data
            // 
            this.headerMenu_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headeMenu_Data_AdminPanel,
            this.headerMenu_Data_LogIn,
            this.headerMenu_Data_SingIn});
            this.headerMenu_Data.Name = "headerMenu_Data";
            this.headerMenu_Data.Size = new System.Drawing.Size(43, 20);
            this.headerMenu_Data.Text = "&Data";
            // 
            // headeMenu_Data_AdminPanel
            // 
            this.headeMenu_Data_AdminPanel.Name = "headeMenu_Data_AdminPanel";
            this.headeMenu_Data_AdminPanel.Size = new System.Drawing.Size(142, 22);
            this.headeMenu_Data_AdminPanel.Text = "&Admin Panel";
            this.headeMenu_Data_AdminPanel.Click += new System.EventHandler(this.HeadeMenu_Data_AdminPanel_Click);
            // 
            // headerMenu_Data_LogIn
            // 
            this.headerMenu_Data_LogIn.Name = "headerMenu_Data_LogIn";
            this.headerMenu_Data_LogIn.Size = new System.Drawing.Size(142, 22);
            this.headerMenu_Data_LogIn.Text = "&Log In";
            this.headerMenu_Data_LogIn.Click += new System.EventHandler(this.HeaderMenu_Data_LogIn_Click);
            // 
            // headerMenu_Data_SingIn
            // 
            this.headerMenu_Data_SingIn.Name = "headerMenu_Data_SingIn";
            this.headerMenu_Data_SingIn.Size = new System.Drawing.Size(142, 22);
            this.headerMenu_Data_SingIn.Text = "&Sing In";
            this.headerMenu_Data_SingIn.Click += new System.EventHandler(this.HeaderMenu_Data_SingIn_Click);
            // 
            // buttonStartPlay
            // 
            this.buttonStartPlay.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartPlay.ForeColor = System.Drawing.Color.White;
            this.buttonStartPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartPlay.Image")));
            this.buttonStartPlay.Location = new System.Drawing.Point(300, 180);
            this.buttonStartPlay.Name = "buttonStartPlay";
            this.buttonStartPlay.Size = new System.Drawing.Size(203, 50);
            this.buttonStartPlay.TabIndex = 2;
            this.buttonStartPlay.Text = "PLAY";
            this.buttonStartPlay.UseVisualStyleBackColor = true;
            this.buttonStartPlay.Click += new System.EventHandler(this.ButtonStartPlay_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartPlay);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headMenu);
            this.MainMenuStrip = this.headMenu;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game - 2048 - game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem headMenu_File;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headerMenu_Data;
        private System.Windows.Forms.ToolStripMenuItem headeMenu_Data_AdminPanel;
        private System.Windows.Forms.ToolStripMenuItem headerMenu_Data_LogIn;
        private System.Windows.Forms.ToolStripMenuItem headerMenu_Data_SingIn;
        private System.Windows.Forms.Button buttonStartPlay;
    }
}

