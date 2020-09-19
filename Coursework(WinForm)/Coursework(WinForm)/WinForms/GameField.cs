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

namespace Coursework_WinForm_.WinForms
{
    public partial class GameField : Form
    {
        public int[,] map = new int[4, 4];
        public Label[,] labels = new Label[4, 4];
        public PictureBox[,] pics = new PictureBox[4, 4];
        public int score = 0;

        public string FontNameIngame { get; set; }
        public int FontSizeIngame { get; set; }
        public int BoxHeight_Y { get; set; }
        public int BoxWight_X { get; set; }
        public int StartUnderBoxPosition_Y { get; set; }
        public int StartUnderBoxPosition_X { get; set; }
        public int StartPositionX { get; set; }
        public int StartPositionY { get; set; }
        public int BoxDistance { get; set; }

        List<string> usermail = new List<string>();
        List<int> userscore = new List<int>();
        List<int> userid = new List<int>();

        public void FillUserForm(string name, Image image, List<string> user_mail, List<int> user_score, List<int> user_id)
        {
            label_name.Text = name;
            image_user.Image = image;

            usermail = user_mail;
            userscore = user_score;
            userid = user_id;
        }

        public GameField()
        {
            InitializeComponent();

            FontNameIngame = "Jokerman";
            FontSizeIngame = 18;
            BoxHeight_Y = 70;
            BoxWight_X = 70;
            StartUnderBoxPosition_X = 250 + 80;
            StartUnderBoxPosition_Y = 120 + 80;
            StartPositionX = 250;
            StartPositionY = 120;
            BoxDistance = 82;

            this.KeyDown += new KeyEventHandler(OnKeyboardPressed);
            map[0, 0] = 1;
            map[0, 1] = 1;

            CreateMap();
            CreatePics();
            GenerateNewPic();
            PlayAgin = false;
        }

        private void CreateMap()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    pic.Location = new Point(StartPositionX + BoxDistance * j, StartPositionY + BoxDistance * i);
                    //pic.Location = new Point()
                    pic.Size = new Size(BoxWight_X, BoxHeight_Y);
                    pic.BackColor = Color.White;
                    this.Controls.Add(pic);
                }
            }
        }

        private void GenerateNewPic()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);
            while (pics[a, b] != null)
            {
                a = rnd.Next(0, 4);
                b = rnd.Next(0, 4);
            }
            map[a, b] = 1;
            pics[a, b] = new PictureBox();
            labels[a, b] = new Label();
            labels[a, b].Text = "2";
            labels[a, b].Size = new Size(BoxWight_X, BoxHeight_Y);
            labels[a, b].TextAlign = ContentAlignment.MiddleCenter;
            labels[a, b].Font = new Font(new FontFamily(FontNameIngame), FontSizeIngame);
            labels[a, b].ForeColor = Color.White;
            //labels[a, b].Font = new Font(new FontFamily("Microsoft Sans Serif"), 15);
            pics[a, b].Controls.Add(labels[a, b]);
            pics[a, b].Location = new Point(StartPositionX + b * BoxDistance, StartPositionY + BoxDistance * a); //(250 + 80 * j, 120 + 80 * i);
            //pics[a, b].Location = new Point(12 + b * 56, 73 + 56 * a);
            pics[a, b].Size = new Size(BoxWight_X, BoxHeight_Y);
            pics[a, b].BackColor = Color.Yellow;
            //pics[a, b].BackColor = Color.Yellow;
            this.Controls.Add(pics[a, b]);
            pics[a, b].BringToFront();
        }

        private void CreatePics()
        {
            pics[0, 0] = new PictureBox();
            labels[0, 0] = new Label();
            labels[0, 0].Text = "2";
            labels[0, 0].Size = new Size(BoxWight_X, BoxHeight_Y);
            labels[0, 0].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 0].Font = new Font(new FontFamily(FontNameIngame), FontSizeIngame);
            labels[0, 0].ForeColor = Color.White;
            pics[0, 0].Controls.Add(labels[0, 0]);
            pics[0, 0].Location = new Point(StartPositionX, StartPositionY);
            //pics[0, 0].Location = new Point(12, 73);
            pics[0, 0].Size = new Size(BoxWight_X, BoxHeight_Y);
            pics[0, 0].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 0]);
            pics[0, 0].BringToFront();

            pics[0, 1] = new PictureBox();
            labels[0, 1] = new Label();
            labels[0, 1].Text = "2";
            labels[0, 1].Size = new Size(BoxWight_X, BoxHeight_Y);
            labels[0, 1].TextAlign = ContentAlignment.MiddleCenter;
            labels[0, 1].Font = new Font(new FontFamily(FontNameIngame), FontSizeIngame);
            labels[0, 1].ForeColor = Color.White;
            pics[0, 1].Controls.Add(labels[0, 1]);
            pics[0, 1].Location = new Point(BoxDistance + StartPositionX, StartPositionY);
            pics[0, 1].Size = new Size(BoxWight_X, BoxHeight_Y);
            pics[0, 1].BackColor = Color.Yellow;
            this.Controls.Add(pics[0, 1]);
            pics[0, 1].BringToFront();
        }

        private void ChangeColor(int sum, int k, int j)
        {
            if (sum % 1024 == 0) pics[k, j].BackColor = Color.Pink;
            else if (sum % 512 == 0) pics[k, j].BackColor = Color.Red;
            else if (sum % 256 == 0) pics[k, j].BackColor = Color.DarkViolet;
            else if (sum % 128 == 0) pics[k, j].BackColor = Color.Blue;
            else if (sum % 64 == 0) pics[k, j].BackColor = Color.Brown;
            else if (sum % 32 == 0) pics[k, j].BackColor = Color.Coral;
            else if (sum % 16 == 0) pics[k, j].BackColor = Color.Cyan;
            else if (sum % 8 == 0) pics[k, j].BackColor = Color.Orange;
            else pics[k, j].BackColor = Color.GreenYellow;

            /* if (sum % 1024 == 0) pics[k, j].BackColor = Color.Pink;
            else if (sum % 512 == 0) pics[k, j].BackColor = Color.Red;
            else if (sum % 256 == 0) pics[k, j].BackColor = Color.DarkViolet;
            else if (sum % 128 == 0) pics[k, j].BackColor = Color.Blue;
            else if (sum % 64 == 0) pics[k, j].BackColor = Color.Brown;
            else if (sum % 32 == 0) pics[k, j].BackColor = Color.Coral;
            else if (sum % 16 == 0) pics[k, j].BackColor = Color.Cyan;
            else if (sum % 8 == 0) pics[k, j].BackColor = Color.Maroon;
            else pics[k, j].BackColor = Color.GreenYellow;*/
        }

        private void OnKeyboardPressed(object sender, KeyEventArgs e)
        {
            bool ifPicWasMoved = false;

            switch (e.KeyCode.ToString())
            {
                case "Right":
                case "D":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 2; l >= 0; l--)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l + 1; j < 4; j++)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j - 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j - 1];
                                        pics[k, j - 1] = null;
                                        labels[k, j] = labels[k, j - 1];
                                        labels[k, j - 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X + BoxDistance, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j - 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
                                            map[k, j - 1] = 0;
                                            this.Controls.Remove(pics[k, j - 1]);
                                            this.Controls.Remove(labels[k, j - 1]);
                                            pics[k, j - 1] = null;
                                            labels[k, j - 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Left":
                case "A":
                    for (int k = 0; k < 4; k++)
                    {
                        for (int l = 1; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = l - 1; j >= 0; j--)
                                {
                                    if (map[k, j] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[k, j + 1] = 0;
                                        map[k, j] = 1;
                                        pics[k, j] = pics[k, j + 1];
                                        pics[k, j + 1] = null;
                                        labels[k, j] = labels[k, j + 1];
                                        labels[k, j + 1] = null;
                                        pics[k, j].Location = new Point(pics[k, j].Location.X - BoxDistance, pics[k, j].Location.Y);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[k, j].Text);
                                        int b = int.Parse(labels[k, j + 1].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[k, j].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, k, j);
                                            label1.Text = "Score: " + score;
                                            map[k, j + 1] = 0;
                                            this.Controls.Remove(pics[k, j + 1]);
                                            this.Controls.Remove(labels[k, j + 1]);
                                            pics[k, j + 1] = null;
                                            labels[k, j + 1] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                case "S":
                    for (int k = 2; k >= 0; k--)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k + 1; j < 4; j++)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j - 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j - 1, l];
                                        pics[j - 1, l] = null;
                                        labels[j, l] = labels[j - 1, l];
                                        labels[j - 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y + BoxDistance);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j - 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
                                            map[j - 1, l] = 0;
                                            this.Controls.Remove(pics[j - 1, l]);
                                            this.Controls.Remove(labels[j - 1, l]);
                                            pics[j - 1, l] = null;
                                            labels[j - 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                case "W":
                    for (int k = 1; k < 4; k++)
                    {
                        for (int l = 0; l < 4; l++)
                        {
                            if (map[k, l] == 1)
                            {
                                for (int j = k - 1; j >= 0; j--)
                                {
                                    if (map[j, l] == 0)
                                    {
                                        ifPicWasMoved = true;
                                        map[j + 1, l] = 0;
                                        map[j, l] = 1;
                                        pics[j, l] = pics[j + 1, l];
                                        pics[j + 1, l] = null;
                                        labels[j, l] = labels[j + 1, l];
                                        labels[j + 1, l] = null;
                                        pics[j, l].Location = new Point(pics[j, l].Location.X, pics[j, l].Location.Y - BoxDistance);
                                    }
                                    else
                                    {
                                        int a = int.Parse(labels[j, l].Text);
                                        int b = int.Parse(labels[j + 1, l].Text);
                                        if (a == b)
                                        {
                                            ifPicWasMoved = true;
                                            labels[j, l].Text = (a + b).ToString();
                                            score += (a + b);
                                            ChangeColor(a + b, j, l);
                                            label1.Text = "Score: " + score;
                                            map[j + 1, l] = 0;
                                            this.Controls.Remove(pics[j + 1, l]);
                                            this.Controls.Remove(labels[j + 1, l]);
                                            pics[j + 1, l] = null;
                                            labels[j + 1, l] = null;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            if (ifPicWasMoved)
                GenerateNewPic();

            scores.Clear();
            label6.Text = "";
            scores.Height = panel3.Height - 30;
            scores.Width = panel3.Width - 30;
            scores.Location = panel3.Location;
            scores.BackColor = panel3.BackColor;
            scores.ForeColor = Color.White;
           
            scores.View = View.Details;
            //List<string> temp = new List<string>();
            var usercol = scores.Columns.Add("user");
            scores.Columns[0].Width = 50;
            // add one item to column A and B
            var scorecol = scores.Columns.Add("score");
            scores.Columns[1].Width = 50;

            try
            {
                //for (int i = 0; i < userscore.Count; i++)
                //{
                //    //    if(userscore[i] <= score)
                //    //    {
                //    //        scores.Items.Add("-> you <- " + score.ToString());
                //    //    }

                //    //ListViewItem listItem2 = new ListViewItem();
                //    w = userid[i];
                //    try
                //    {
                //        //listItem2.Text = "t";
                //        //listItem2.SubItems.Add(usermail[w]);
                //        //listItem2.SubItems.Add(userscore[i].ToString());
                //        //scores.Items.Add();


                //        //temp.Add(userscore[i].ToString() + " -> " + usermail[w]);
                //        //scores.Items.Add(usermail[w]);
                //        //subcol.SubItems.Add(userscore[i].ToString());
                //        scores.Items.Add(new ListViewItem(new[] { usermail[w], userscore[i].ToString() }));

                //        //scores.Items.Add(usermail[w] + " -> "+userscore[i].ToString());
                //        //scores.Items.Add(new ListViewItem[] { usermail[w], userscore[i].ToString() }.ToString());
                //    }
                //    catch (Exception)
                //    {

                //    }
                //}

                //scores.Sorting = SortOrder.Ascending;

                //temp.Sort();
                List<int> finfindex = new List<int>();
                finfindex = userscore;
                finfindex.Sort();
                int f_id = finfindex.FindIndex(x => x >= score);

                //scores.Items.Insert(f_id, new ListViewItem(new[] { "-> you <- ", score.ToString() }));

                //ListViewItem listItem3 = new ListViewItem();
                //listItem3.SubItems.Add("-> you <- ");
                //listItem3.SubItems.Add(score.ToString());
                //scores.Items.Insert(f_id, new ListViewItem(new[] { "-> you <- ", score.ToString() }));

                //subcol.SubItems.Insert(f_id,

                //for (int i = 0; i < temp.Count; i++)
                //{
                //    if (temp[i] < score.ToString())
                //    {
                //        scores.Items.Add(temp[i]);
                //    }
                //}
                //scores.Items.Insert(0, )
                int scorid = 0;
                int maxscore = 0;
                int minid = 0, maxid = 0;
                int minsc = 0, maxsc = 0;

                for (int i = 0; i < userscore.Count; i++)
                {
                    if (userscore[i] > maxscore)
                    {
                        maxscore = userscore[i];
                        scorid = i;
                    }
                }

                finfindex.Sort();

                for (int i = 0; i < finfindex.Count; i++)
                {
                    if (finfindex[i] < score)
                    {
                        minsc = finfindex[i];
                    }

                    if (finfindex[i] > score)
                    {
                        maxsc = finfindex[i];
                        break;
                    }
                }

                for (int i = 0; i < userscore.Count; i++)
                {
                    if (userscore[i] == minsc)
                    {
                        minid = i;
                    }

                    if (userscore[i] == maxsc)
                    {
                        maxid = i;
                    }
                }

                int usid = userid[scorid];
                scores.Items.Add(new ListViewItem(new[] { usermail[usid - 1], userscore[scorid].ToString() }));

                usid = userid[maxid];
                scores.Items.Add(new ListViewItem(new[] { usermail[usid - 1], userscore[maxid].ToString() }));

                scores.Items.Add(new ListViewItem(new[] { "-> you <- ", score.ToString() }));

                usid = userid[minid];
                scores.Items.Add(new ListViewItem(new[] { usermail[usid - 1], userscore[minid].ToString() }));

                //isonetime = false;
                //}
            }
            catch (Exception)
            {
                scores.Items.Add(new ListViewItem(new[] { "-> you <- ", score.ToString() }));
            }
            panel3.Controls.Add(scores);
            //scores.Sorting = SortOrder.Ascending;
            //if (isonetime)
            //{
            scores.BringToFront();
        }

        ListView scores = new ListView();

        private void LabelbuttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        Timer timer = new Timer();
        public bool IsBackgroundChange { get; set; }

        Image[] backgroundpicture;

        private void Labelbuttonchangebackground_Click(object sender, EventArgs e)
        {
            ChoosePhoto backpicture = new ChoosePhoto();

            if (backpicture.ShowDialog() == DialogResult.OK)
            {
                if (backpicture.IsSlideShow == false)
                {
                    timer.Stop();
                    IsBackgroundChange = false;
                    this.BackgroundImage = Image.FromFile(backpicture.ChoosenImage);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    IsBackgroundChange = true;
                    backgroundpicture = backpicture.slideshowpics;
                    timer.Interval = 5000;
                    timer.Tick += new EventHandler(timer_Tick);
                    this.BackgroundImage = backpicture.slideshowpics[0];
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    timer.Start();
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (IsBackgroundChange)
            {
                var colors = backgroundpicture;
                var index = DateTime.Now.Second % colors.Length;
                this.BackgroundImage = colors[index];
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public bool PlayAgin { get; set; }

        private void PicturebuttonReplay_Click(object sender, EventArgs e)
        {
            PlayAgin = true;
            this.DialogResult = DialogResult.OK;
        }

        SoundPlayer player1 = new SoundPlayer();
        private void LabelbuttonMusic_Click(object sender, EventArgs e)
        {
            ChooseMusic music = new ChooseMusic();

            if (music.ShowDialog() == DialogResult.OK)
            {
                player1.SoundLocation = music.ChoosenPlaylist;
                player1.Play();
            }
        }

        private void GameField_FormClosed(object sender, FormClosedEventArgs e)
        {
            player1.Stop();
        }
    }
}
