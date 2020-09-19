using Coursework_WinForm_.Classes;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_WinForm_
{
    public partial class LoginForm : Form
    {
        private readonly ApplicationDbContext context;

        public LoginForm()
        {
            InitializeComponent();

            context = new ApplicationDbContext();

            this.txtBoxPassword.AutoSize = false;
            this.txtBoxUser.Size = new Size(this.txtBoxPassword.Size.Width, this.txtBoxPassword.Height);
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                string loginUser = txtBoxUser.Text;
                string passUser = txtBoxPassword.Text;

                var user = GetUserByEmail(loginUser);

                if (loginUser == "admin")
                {
                    if (passUser == "admin")
                    {
                        AdminPanelForm adp = new AdminPanelForm();
                        adp.ShowDialog();
                    }
                }
                else if (user != null || loginUser == "noconnection")
                {
                    if (loginUser == "noconnection")
                    {
                        ChangeAccSettingForm casf = new ChangeAccSettingForm();
                        
                        if (casf.ShowDialog() == DialogResult.OK)
                        {
                        }
                    }
                    else if (user.Deleted == false)
                    {
                        ICryptoService cryptoService = new PBKDF2();
                        string salt = user.PasswordHash;
                        string hashPassword2 = cryptoService.Compute(passUser, salt);
                        bool isPasswordValid = cryptoService.Compare(user.Password, hashPassword2);

                        if (isPasswordValid)
                        {
                            MessageBox.Show("You login success", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ChangeAccSettingForm casf = new ChangeAccSettingForm();
                            casf.FillForm(user);
                            casf.FillLoginUser(user);

                            if (casf.ShowDialog() == DialogResult.OK)
                            {
                                if (casf.IsDel)
                                {
                                    user.Deleted = true;
                                }

                                if (casf.FirstName != null && casf.FirstName != user.FirstName)
                                {
                                    user.FirstName = casf.FirstName;
                                }

                                if (casf.FileSelect != null && casf.FileSelect.ToString() != user.UserImage.ToString())
                                {
                                    //string extension = Path.GetExtension(casf.FileSelect);
                                    //string nameFile = Path.GetRandomFileName() + extension;
                                    //var path = Path.Combine(Directory.GetCurrentDirectory(),
                                    //    "user_images", Path.GetFileName(casf.FileSelect));

                                    //var bmp = ImageHelper.ComprressImage(Image.FromFile(casf.FileSelect), 120, 80);

                                    //try
                                    //{
                                    //  bmp.Save(path, ImageFormat.Jpeg);
                                    //}
                                    //catch (Exception ex)
                                    //{
                                    //  MessageBox.Show(ex.Message);
                                    //}

                                    user.UserImage = casf.ImageToByteArray(Image.FromFile(casf.FileSelect));
                                }

                                if (casf.LastName != null && casf.LastName != user.LastName)
                                {
                                    user.LastName = casf.LastName;
                                }

                                if (casf.MobilePhone != null && casf.MobilePhone != user.MobilePhoneNumber)
                                {
                                    user.MobilePhoneNumber = casf.MobilePhone;
                                }

                                if (casf.Password != "")
                                {
                                    ICryptoService new_cryptoService = new PBKDF2();

                                    //New User
                                    string new_password = casf.Password;

                                    //save this salt to the database
                                    string new_salt = cryptoService.GenerateSalt();

                                    //save this hash to the database
                                    string new_hashedPassword = cryptoService.Compute(new_password);

                                    user.Password = new_hashedPassword;
                                    user.PasswordHash = new_salt;
                                }

                                context.SaveChanges();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inccorect login or password!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This account not exist or be deleted!");
                    }
                }
                else
                {
                    MessageBox.Show("Inccorect login or password!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            this.Close();
        }

        public DBUser GetUserByEmail(string email)
        {
            var user = context.Users
                .Where(x => x.Deleted == false)
                .SingleOrDefault(u => u.Email == email);
            return user;

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.ForeColor = Color.Blue;
        }

        private void Btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.ForeColor = Color.White;
        }

        Point lastPoint;

        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
