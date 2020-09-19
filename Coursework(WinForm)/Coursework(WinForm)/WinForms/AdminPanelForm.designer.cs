namespace Coursework_WinForm_
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSearchLastName = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsrMobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDateRegistreted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDateLastLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDeleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnSearchFirstName = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(124, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // btnSearchLastName
            // 
            this.btnSearchLastName.Location = new System.Drawing.Point(288, 38);
            this.btnSearchLastName.Name = "btnSearchLastName";
            this.btnSearchLastName.Size = new System.Drawing.Size(93, 23);
            this.btnSearchLastName.TabIndex = 2;
            this.btnSearchLastName.Text = "Search";
            this.btnSearchLastName.UseVisualStyleBackColor = true;
            this.btnSearchLastName.Click += new System.EventHandler(this.BtnSearchLastName_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.UserName,
            this.UserLastName,
            this.UsrMobilePhone,
            this.UserDateRegistreted,
            this.UserDateLastLogin,
            this.UserDeleted,
            this.UserEmail,
            this.UserImage});
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 86);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(776, 279);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.Width = 40;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            // 
            // UserLastName
            // 
            this.UserLastName.HeaderText = "LastName";
            this.UserLastName.Name = "UserLastName";
            // 
            // UsrMobilePhone
            // 
            this.UsrMobilePhone.HeaderText = "MobilePhone";
            this.UsrMobilePhone.Name = "UsrMobilePhone";
            // 
            // UserDateRegistreted
            // 
            this.UserDateRegistreted.HeaderText = "DateRegistreted";
            this.UserDateRegistreted.Name = "UserDateRegistreted";
            this.UserDateRegistreted.Width = 90;
            // 
            // UserDateLastLogin
            // 
            this.UserDateLastLogin.HeaderText = "DateLastLogin";
            this.UserDateLastLogin.Name = "UserDateLastLogin";
            this.UserDateLastLogin.Width = 80;
            // 
            // UserDeleted
            // 
            this.UserDeleted.HeaderText = "Deleted";
            this.UserDeleted.Name = "UserDeleted";
            this.UserDeleted.Width = 50;
            // 
            // UserEmail
            // 
            this.UserEmail.HeaderText = "Email";
            this.UserEmail.Name = "UserEmail";
            // 
            // UserImage
            // 
            this.UserImage.HeaderText = "Image";
            this.UserImage.Name = "UserImage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirsName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(511, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // btnSearchFirstName
            // 
            this.btnSearchFirstName.Location = new System.Drawing.Point(675, 40);
            this.btnSearchFirstName.Name = "btnSearchFirstName";
            this.btnSearchFirstName.Size = new System.Drawing.Size(100, 23);
            this.btnSearchFirstName.TabIndex = 4;
            this.btnSearchFirstName.Text = "Search";
            this.btnSearchFirstName.UseVisualStyleBackColor = true;
            this.btnSearchFirstName.Click += new System.EventHandler(this.BtnSearchFirstName_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(320, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearchFirstName);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.btnSearchLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSearchLastName;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnSearchFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsrMobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDateRegistreted;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDateLastLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDeleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewImageColumn UserImage;
        private System.Windows.Forms.Button btnDelete;
    }
}