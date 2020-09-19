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
using Coursework_WinForm_.Classes;
using Coursework_WinForm_.WinForms;
//using Coursework_WinForm_.model;

namespace Coursework_WinForm_
{
    public partial class StartForm : Form
    {
        private readonly ApplicationDbContext context;
        public StartForm()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            LoginForm dlg = new LoginForm();

            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            SingInForm dlg = new SingInForm();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var user = context.Users
                .Where(x => x.Deleted == false)
                .SingleOrDefault(u => u.Email == dlg.Email);
                //string extension = Path.GetExtension(dlg.UserIMage);
                //string nameFile = Path.GetRandomFileName() + extension;
                //var path = Path.Combine(Directory.GetCurrentDirectory(),
                //    "user_images", nameFile);

                if (dlg.Password == ".")
                {
                    MessageBox.Show("Inccorect 2 passwords");
                }
                else if (dlg.Email == "")
                {
                    MessageBox.Show("Email is empty");
                }
                else if (user != null)
                {
                    MessageBox.Show("Email is already regestred");
                }
                else
                {
                    try
                    {
                        //try
                        //{
                        //    var bmp = ImageHelper.ComprressImage(Image.FromFile(dlg.UserIMage), 120, 80);
                        //    bmp.Save(path, ImageFormat.Jpeg);
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show(ex.Message);
                        //}

                        ICryptoService cryptoService = new PBKDF2();

                        //New User
                        string password = dlg.Password;

                        //save this salt to the database
                        string salt = cryptoService.GenerateSalt();

                        //save this hash to the database
                        string hashedPassword = cryptoService.Compute(password);

                        DBUser dbUser = new DBUser
                        {
                            FirstName = dlg.FirstName,
                            LastName = dlg.LastName,
                            UserImage = dlg.ImageToByteArray(Image.FromFile(dlg.UserIMage)),
                            MobilePhoneNumber = dlg.MobilePhoneNumber,
                            DateRegistered = DateTime.Now,
                            LastLoginDate = DateTime.Now,
                            Deleted = false,
                            Email = dlg.Email,
                            //Password = dlg.Password,
                            Password = hashedPassword,
                            PasswordHash = salt,
                            //PasswordHash = dlg.Password.GetHashCode().ToString()

                        };

                        context.Users.Add(dbUser);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BtnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm adm = new AdminPanelForm();

            LoginForm lf = new LoginForm();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                if (adm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void HeadMenu_File_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HeadeMenu_Data_AdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanelForm apf = new AdminPanelForm();

            apf.ShowDialog();

        }

        private void HeaderMenu_Data_LogIn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();

            lf.ShowDialog();
        }

        private void HeaderMenu_Data_SingIn_Click(object sender, EventArgs e)
        {
            SingInForm sf = new SingInForm();

            sf.ShowDialog();
        }

        private void ButtonStartPlay_Click(object sender, EventArgs e)
        {
            bool playagain;
            GameField games;

            do
            {
                games = new GameField();
                playagain = false;


                if (games.ShowDialog() == DialogResult.OK)
                {
                    playagain = games.PlayAgin;
                    if (games.score > 0)
                    {
                        UserRezalts newrezalt = new UserRezalts
                        {
                            UserScore = games.score,
                            UserID = 2,
                        };

                        context.UserRezalts.Add(newrezalt);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if (games.score > 0)
                    {
                        UserRezalts newrezalt = new UserRezalts
                        {
                            UserScore = games.score,
                            UserID = 2,
                        };

                        context.UserRezalts.Add(newrezalt);
                        context.SaveChanges();
                    }
                }
            } while (playagain);
        }
    }
}
