using Coursework_WinForm_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_WinForm_
{
    public partial class SingInForm : Form
    {
        public int Id { get; set; }
        public string FirstName { get { return txtName.Text; } }
        public string LastName { get { return txtLastName.Text; } }

        public string UserIMage { get; set; }
        public string MobilePhoneNumber { get { return txtMobile.Text; } }

        public DateTime DateRegistered { get; }
        public DateTime LastLoginDate { get; set; }
        public bool Deleted { get { return false; } }

        private string CodeVal;
        public string Email { get { return txtEmail.Text; } }

        public string Password
        {
            get
            {
                if (txtPsw.Text == txtPswRepeat.Text)
                {
                    return txtPsw.Text;
                }
                else if (CodeVal != null)
                {
                    var temp = CodeVal;
                    CodeVal = null;
                    return temp;
                }
                else
                {
                    return ".";
                }
            }
            set { }
        }
        public string PasswordHash { get; set; }

        public SingInForm()
        {
            InitializeComponent();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            string extension = Path.GetExtension(UserIMage);
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
            dialog.Filter = "FIle Photo|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            dialog.Title = "Choose photo";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UserIMage = dialog.FileName;
                pictureBoxSignIn.Image = Image.FromFile(this.UserIMage);
                pictureBoxSignIn.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }



        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPsw.BackColor = Color.Gray;//Text = "you choose other way";
            txtPswRepeat.BackColor = Color.Gray;//.Text = "you choose other way";

            //SMTPSender emailSender = new SMTPSender();
            //CodeVal = (new Random()).Next(1000, 9000).ToString();
            //emailSender.SendMessage(Email,
            //    "Incorporated | Реєстрація | Код",
            //    $"<b>{CodeVal}</b>");

            MailAddress fromMailAddress = new MailAddress("itstudentyre@gmail.com");
            MailAddress toMailAddress = new MailAddress(Email);

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))
            {
                using (SmtpClient smtpClient = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587))
                {
                    mailMessage.Subject = " Incorporated |Regestration | Code";
                    CodeVal = (new Random()).Next(1000, 9999).ToString();
                    mailMessage.Body = CodeVal;

                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Qw3eI98*63%");

                    smtpClient.Send(mailMessage);

                    MessageBox.Show("Code was sended. Please check your mail.");
                }
            }

            txtPsw.Text = CodeVal;
            txtPswRepeat.Text = CodeVal;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;

        private void PanelCnageSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PanelCnageSettings_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
