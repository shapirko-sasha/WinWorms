namespace Coursework_WinForm_
{
    partial class ChangeAccSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAccSettingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.image_user = new System.Windows.Forms.PictureBox();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btnChangAccSet = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCnageSettings = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMoiblePhone = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonShowYourRezalts = new System.Windows.Forms.Button();
            this.buttonShowTableLeader = new System.Windows.Forms.Button();
            this.panelYourRezalt = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_user)).BeginInit();
            this.panelCnageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelYourRezalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 417);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.image_user);
            this.panel2.Controls.Add(this.buttonStartGame);
            this.panel2.Controls.Add(this.buttonShowTableLeader);
            this.panel2.Controls.Add(this.buttonShowYourRezalts);
            this.panel2.Controls.Add(this.btnDelAcc);
            this.panel2.Controls.Add(this.btnChangAccSet);
            this.panel2.Controls.Add(this.label_name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(21, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 379);
            this.panel2.TabIndex = 1;
            // 
            // image_user
            // 
            this.image_user.Image = ((System.Drawing.Image)(resources.GetObject("image_user.Image")));
            this.image_user.Location = new System.Drawing.Point(143, 0);
            this.image_user.Name = "image_user";
            this.image_user.Size = new System.Drawing.Size(98, 97);
            this.image_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_user.TabIndex = 1;
            this.image_user.TabStop = false;
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAcc.ForeColor = System.Drawing.Color.White;
            this.btnDelAcc.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAcc.Image")));
            this.btnDelAcc.Location = new System.Drawing.Point(4, 275);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(238, 35);
            this.btnDelAcc.TabIndex = 1;
            this.btnDelAcc.Text = "Delete Account";
            this.btnDelAcc.UseVisualStyleBackColor = true;
            this.btnDelAcc.Click += new System.EventHandler(this.BtnDelAcc_Click);
            // 
            // btnChangAccSet
            // 
            this.btnChangAccSet.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangAccSet.ForeColor = System.Drawing.Color.White;
            this.btnChangAccSet.Image = ((System.Drawing.Image)(resources.GetObject("btnChangAccSet.Image")));
            this.btnChangAccSet.Location = new System.Drawing.Point(4, 111);
            this.btnChangAccSet.Name = "btnChangAccSet";
            this.btnChangAccSet.Size = new System.Drawing.Size(238, 35);
            this.btnChangAccSet.TabIndex = 1;
            this.btnChangAccSet.Text = "Change Account Settings";
            this.btnChangAccSet.UseVisualStyleBackColor = true;
            this.btnChangAccSet.Click += new System.EventHandler(this.BtnChangAccSet_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(2, 43);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(105, 31);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "someone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "_________________";
            // 
            // panelCnageSettings
            // 
            this.panelCnageSettings.BackColor = System.Drawing.Color.Teal;
            this.panelCnageSettings.Controls.Add(this.panelYourRezalt);
            this.panelCnageSettings.Controls.Add(this.btnCancel);
            this.panelCnageSettings.Controls.Add(this.btnSave);
            this.panelCnageSettings.Controls.Add(this.imageUser);
            this.panelCnageSettings.Controls.Add(this.btnChoosePhoto);
            this.panelCnageSettings.Controls.Add(this.groupBox6);
            this.panelCnageSettings.Controls.Add(this.groupBox3);
            this.panelCnageSettings.Controls.Add(this.groupBox2);
            this.panelCnageSettings.Controls.Add(this.groupBox1);
            this.panelCnageSettings.Location = new System.Drawing.Point(326, 12);
            this.panelCnageSettings.Name = "panelCnageSettings";
            this.panelCnageSettings.Size = new System.Drawing.Size(439, 417);
            this.panelCnageSettings.TabIndex = 1;
            this.panelCnageSettings.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(71, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(220, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // imageUser
            // 
            this.imageUser.Image = ((System.Drawing.Image)(resources.GetObject("imageUser.Image")));
            this.imageUser.Location = new System.Drawing.Point(14, 91);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(200, 101);
            this.imageUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUser.TabIndex = 1;
            this.imageUser.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChoosePhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnChoosePhoto.Image")));
            this.btnChoosePhoto.Location = new System.Drawing.Point(14, 199);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(200, 27);
            this.btnChoosePhoto.TabIndex = 1;
            this.btnChoosePhoto.Text = "Choose Photo";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.BtnChoosePhoto_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Teal;
            this.groupBox6.Controls.Add(this.txtPasswd);
            this.groupBox6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(220, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 64);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Password";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(6, 25);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(188, 26);
            this.txtPasswd.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Teal;
            this.groupBox3.Controls.Add(this.txtMoiblePhone);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(220, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mobile Phone";
            // 
            // txtMoiblePhone
            // 
            this.txtMoiblePhone.Location = new System.Drawing.Point(6, 25);
            this.txtMoiblePhone.Name = "txtMoiblePhone";
            this.txtMoiblePhone.Size = new System.Drawing.Size(188, 26);
            this.txtMoiblePhone.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.txtLastName);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(220, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(6, 27);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(188, 26);
            this.txtLastName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 26);
            this.txtName.TabIndex = 0;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.White;
            this.buttonStartGame.Image = ((System.Drawing.Image)(resources.GetObject("buttonStartGame.Image")));
            this.buttonStartGame.Location = new System.Drawing.Point(4, 152);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(238, 35);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.ButtonStartGame_Click);
            // 
            // buttonShowYourRezalts
            // 
            this.buttonShowYourRezalts.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowYourRezalts.ForeColor = System.Drawing.Color.White;
            this.buttonShowYourRezalts.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowYourRezalts.Image")));
            this.buttonShowYourRezalts.Location = new System.Drawing.Point(4, 193);
            this.buttonShowYourRezalts.Name = "buttonShowYourRezalts";
            this.buttonShowYourRezalts.Size = new System.Drawing.Size(238, 35);
            this.buttonShowYourRezalts.TabIndex = 1;
            this.buttonShowYourRezalts.Text = "All Your Rezalts";
            this.buttonShowYourRezalts.UseVisualStyleBackColor = true;
            this.buttonShowYourRezalts.Click += new System.EventHandler(this.ButtonShowYourRezalts_Click);
            // 
            // buttonShowTableLeader
            // 
            this.buttonShowTableLeader.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowTableLeader.ForeColor = System.Drawing.Color.White;
            this.buttonShowTableLeader.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowTableLeader.Image")));
            this.buttonShowTableLeader.Location = new System.Drawing.Point(4, 234);
            this.buttonShowTableLeader.Name = "buttonShowTableLeader";
            this.buttonShowTableLeader.Size = new System.Drawing.Size(238, 35);
            this.buttonShowTableLeader.TabIndex = 1;
            this.buttonShowTableLeader.Text = "Table Leader";
            this.buttonShowTableLeader.UseVisualStyleBackColor = true;
            this.buttonShowTableLeader.Click += new System.EventHandler(this.ButtonShowTableLeader_Click);
            // 
            // panelYourRezalt
            // 
            this.panelYourRezalt.Controls.Add(this.dataGridView1);
            this.panelYourRezalt.Controls.Add(this.listView1);
            this.panelYourRezalt.Controls.Add(this.label3);
            this.panelYourRezalt.Location = new System.Drawing.Point(0, 0);
            this.panelYourRezalt.Name = "panelYourRezalt";
            this.panelYourRezalt.Size = new System.Drawing.Size(439, 417);
            this.panelYourRezalt.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(27, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 335);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Your Score";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsEmail,
            this.UsScore});
            this.dataGridView1.Location = new System.Drawing.Point(27, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 335);
            this.dataGridView1.TabIndex = 2;
            // 
            // UsEmail
            // 
            this.UsEmail.HeaderText = "Email";
            this.UsEmail.Name = "UsEmail";
            this.UsEmail.Width = 170;
            // 
            // UsScore
            // 
            this.UsScore.HeaderText = "Score";
            this.UsScore.Name = "UsScore";
            this.UsScore.Width = 170;
            // 
            // ChangeAccSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCnageSettings);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeAccSettingForm";
            this.Text = "SingIn Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_user)).EndInit();
            this.panelCnageSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelYourRezalt.ResumeLayout(false);
            this.panelYourRezalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btnChangAccSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox image_user;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Panel panelCnageSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox imageUser;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMoiblePhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonShowTableLeader;
        private System.Windows.Forms.Button buttonShowYourRezalts;
        private System.Windows.Forms.Panel panelYourRezalt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsScore;
    }
}