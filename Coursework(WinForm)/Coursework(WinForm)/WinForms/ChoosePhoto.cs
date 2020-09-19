using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_WinForm_.WinForms
{
    public partial class ChoosePhoto : Form
    {
        public string ChoosenImage { get; set; }

        public bool IsSlideShow { get; set; }

        public Image[] slideshowpics = { Image.FromFile("../../images/pic1.jpg"),
            Image.FromFile("../../images/pic2.jpg"), Image.FromFile("../../images/pic3.jpg"),
            Image.FromFile("../../images/pic4.jpg") };

        public ChoosePhoto()
        {
            InitializeComponent();
            IsSlideShow = false;
        }

        private void ButtonChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image file|*.jpg;*.jpeg;*.png;|All files (*.*)|*.*";
            dialog.Title = "Choose photo";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.ChoosenImage = dialog.FileName;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonChooseSlideshow_Click(object sender, EventArgs e)
        {
            IsSlideShow = true;
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview5_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic5.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview6_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic6.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview7_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic7.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview8_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic8.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview1_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic1.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview2_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic2.jpg";
            this.DialogResult = DialogResult.OK;
        }

        private void Pictureview3_Click(object sender, EventArgs e)
        {
            ChoosenImage = "../../images/pic3.jpg";
            this.DialogResult = DialogResult.OK;
        }
    }
}
