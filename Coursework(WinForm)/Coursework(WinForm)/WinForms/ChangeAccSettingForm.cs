using Coursework_WinForm_.Classes;
using Coursework_WinForm_.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_WinForm_
{
    public partial class ChangeAccSettingForm : Form
    {
        private readonly ApplicationDbContext context;

        public string FirstName { get { return txtName.Text; } set { } }
        public string LastName { get { return txtLastName.Text; } set { } }
        public string MobilePhone { get { return txtMoiblePhone.Text; } set { } }
        public string Password { get { return txtPasswd.Text; } set { } }
        public string FileSelect { get; set; }

        List<string> user_mail = new List<string>();
        List<int> user_score = new List<int>();
        List<int> user_id = new List<int>();
        public ChangeAccSettingForm()
        {
            InitializeComponent();
            context = new ApplicationDbContext();
            panelYourRezalt.Visible = false;
            dataGridView1.Visible = false;

            foreach (var item2 in context.Users)
            {
                user_mail.Add(item2.Email);
            }

            foreach (var item in context.UserRezalts)
            {
                user_score.Add(item.UserScore);
                user_id.Add(item.UserID);
                dataGridView1.Rows.Add(new object[] { user_mail[item.UserID - 1], item.UserScore.ToString() });
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        public bool IsDel = false;
        private void BtnDelAcc_Click(object sender, EventArgs e)
        {
            IsDel = true;
            this.DialogResult = DialogResult.OK;
        }

        public void FillForm(DBUser user)
        {
            try
            {
                label_name.Text = user.FirstName;
                //var imageBytes = File.ReadAllBytes(Directory.GetCurrentDirectory() + @"\user_images\" + user.UserImage);
                using (MemoryStream stream = new MemoryStream(user.UserImage))
                {
                    image_user.Image = Image.FromStream(stream);
                }
                image_user.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! We not found picture!");
                image_user.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"\..\..\er_image.png");
            }

            txtName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtMoiblePhone.Text = user.MobilePhoneNumber;
        }

        private void BtnChangAccSet_Click(object sender, EventArgs e)
        {
            panelCnageSettings.Visible = true;
            panelYourRezalt.Visible = false;
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            string extension = Path.GetExtension(FileSelect);
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                using (var ms = new MemoryStream(byteArrayIn))
                {
                    var returnImage = Image.FromStream(ms);

                    return returnImage;
                }
            }
            catch (Exception)
            {
                return Image.FromFile(@"..\..\er_image.png");
            }
        }

        private void BtnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файли зображення|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            dialog.Title = "Choose photo.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FileSelect = dialog.FileName;
                imageUser.Image = Image.FromFile(this.FileSelect);

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Changes will be save!");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        DBUser login_user;

        public void FillLoginUser(DBUser us)
        {
            login_user = us;
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            bool playagain;
            GameField new_game;

            do
            {
                new_game = new GameField();

                playagain = false;
                try
                {
                    new_game.FillUserForm(login_user.Email, ByteArrayToImage(login_user.UserImage), user_mail, user_score, user_id);
                }
                catch (Exception) { };

                if (new_game.ShowDialog() == DialogResult.OK)
                {
                    playagain = new_game.PlayAgin;
                    if (new_game.score > 0)
                    {
                        UserRezalts newrezalt = new UserRezalts
                        {
                            UserScore = new_game.score,
                            UserID = login_user.Id,
                        };

                        context.UserRezalts.Add(newrezalt);
                        context.SaveChanges();
                    }
                }
                else
                {
                    try
                    {
                        if (new_game.score > 0)
                        {
                            UserRezalts newrezalt = new UserRezalts
                            {
                                UserScore = new_game.score,
                                UserID = login_user.Id,
                            };

                            context.UserRezalts.Add(newrezalt);
                            context.SaveChanges();
                        }
                    }
                    catch (Exception) { };
                }

            } while (playagain);
        }

        private void ButtonShowYourRezalts_Click(object sender, EventArgs e)
        {
            panelYourRezalt.Visible = true;
            dataGridView1.Visible = false;
            listView1.Columns.Clear();
            listView1.Clear();

            foreach (var item in context.UserRezalts)
            {
                if (item.UserID == login_user.Id)
                {
                    listView1.Items.Add(item.UserScore.ToString() + ", ");
                }
            }
            listView1.Sort();
        }

        private void ButtonShowTableLeader_Click(object sender, EventArgs e)
        {
            panelYourRezalt.Visible = true;
            //listView1.Columns.Clear();
            //listView1.Clear();
            //listView1.Columns.Add("Email");
            //listView1.Columns.Add("Score");
            //listView1.View = View.Details; // у вигляді таблиця
            dataGridView1.Visible = true;

            //int k = 0;

            foreach (var item2 in context.Users)
            {
                user_mail.Add(item2.Email);
            }

            foreach (var item in context.UserRezalts)
            {
                user_score.Add(item.UserScore);
                user_id.Add(item.UserID);
                dataGridView1.Rows.Add(new object[] { user_mail[item.UserID - 1], item.UserScore.ToString() });
            }

            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            //{
            //    listView1.Items.Add(user_mail[item.UserID - 1], item.UserScore.ToString());
            //    //listView1.Items.Add(item.UserScore.ToString());
            }

            //listView1.Sort();
            //foreach (var item in context.Users)
            //{
            //    listView1.Items.Add(item.Email);
            //    context.Users.F
            //}
        //}
    }
}
