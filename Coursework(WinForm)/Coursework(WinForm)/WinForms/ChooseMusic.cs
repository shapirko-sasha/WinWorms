using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WMPLib;
//using WMPLib;

namespace Coursework_WinForm_.WinForms
{
    public partial class ChooseMusic : Form
    {
        SoundPlayer player1 = new SoundPlayer();
        // WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        public string ChoosenPlaylist { get; set; }

        public ChooseMusic()
        {
            InitializeComponent();
        }

        private void ButtonListen1_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2018-04-29_-_Too_Fly_David_Fesliyan (online-audio-converter.com).wav";
            player1.SoundLocation = ChoosenPlaylist;
            player1.Play();
        }

        private void ChooseMusic_FormClosed(object sender, FormClosedEventArgs e)
        {
            player1.Stop();
        }

        private void ButtonListen2_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2017-04-14_-_Happy_Dreams_-_David_Fesliyan.wav";
            player1.SoundLocation = ChoosenPlaylist;
            player1.Play();
        }

        private void ButtonListen3_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2019-06-17_-_Super_Spiffy_-_David_Fesliyan.wav";
            player1.SoundLocation = ChoosenPlaylist;
            player1.Play();
        }

        private void ButtonListen4_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2020-08-18_-_Smilin'_And_Vibin'_-_www.FesliyanStudios.com_David_Renda.wav";
            player1.SoundLocation = ChoosenPlaylist;
            player1.Play();
        }

        private void ButtonListen5_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/ChristmasBackgroundMusic2018-12-5_-_A_Happy_Christmas_-_David_Fesliyan.wav";
            player1.SoundLocation = ChoosenPlaylist;
            player1.Play();
        }

        private void ButtonChoose1_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2018-04-29_-_Too_Fly_David_Fesliyan (online-audio-converter.com).wav";
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonChoose2_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2017-04-14_-_Happy_Dreams_-_David_Fesliyan.wav";
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonChoose3_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2019-06-17_-_Super_Spiffy_-_David_Fesliyan.wav";
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonChoose4_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/2020-08-18_-_Smilin'_And_Vibin'_-_www.FesliyanStudios.com_David_Renda.wav";
            this.DialogResult = DialogResult.OK;
        }

        private void ButtonChoose5_Click(object sender, EventArgs e)
        {
            ChoosenPlaylist = "../../music/ChristmasBackgroundMusic2018-12-5_-_A_Happy_Christmas_-_David_Fesliyan.wav";
            this.DialogResult = DialogResult.OK;
        }
    }
}
