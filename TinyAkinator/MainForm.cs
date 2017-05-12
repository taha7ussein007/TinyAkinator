using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace TinyAkinator
{
    public partial class MainForm : Form
    {
        private GameEngine GE;
        private bool AnswerBottonClicked = false;
        private MYCIN_TERM_FACTOR AnswerBottonClicked_Value;
        private bool BackClicked = false;
        public MainForm()
        {
            InitializeComponent();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            await new DBAppendModel().Append();
            Screen(1);
        }

        #region Global
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void maxi_restore_Click(object sender, EventArgs e)
        {
            //TODO: Handle All Controls -> Change To Relative Size!
            //if (WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //    maxi_restore.BackgroundImage = new Bitmap(@"Design/restore.png");
            //}
            //else
            //{
            //    WindowState = FormWindowState.Normal;
            //    CenterToScreen();
            //    maxi_restore.BackgroundImage = new Bitmap(@"Design/maximize.png");
            //}
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                WindowState = FormWindowState.Minimized;
        }
        private async void Screen(short n)
        {

            Invoke(new Action(() =>
            {
                panel1.Hide(); panel2.Hide(); panel3.Hide(); panel4.Hide(); textBox_why.Hide();
                BackgroundImage = new Bitmap(@"Design/bg/" + n.ToString() + ".png");
            }));

            switch (n)
            {
                case 1:
                    Invoke(new Action(() =>
                    {
                        panel1.Show();
                    }));
                    return;
                case 2:
                    Invoke(new Action(() =>
                    {
                        panel2.Show();
                    }));
                    await Task.Run(() =>
                    {
                        GE = GameEngine.Instance;
                        //StartGame
                        GE.StartNewGame(Ask);
                        short result = 0;
                        do
                        {
                            try
                            {
                                result = GE.Next(Ask);
                            }
                            catch
                            {
                                GE.Back();
                            }
                        }
                        while (result == 0);
                        //EndGame

                        //Note: Game can be forced to return answer (TrackFirstCharacterChange.Peek())
                        //every certain numer of questions! علشان اليوزر ميزهقش :D

                        Screen(3);
                        Invoke(new Action(() =>
                        {
                            if (result == 1)
                            {
                                try
                                {
                                    result_img.BackgroundImage = new Bitmap(GE.TrackFirstCharacterChange.Peek().img_path);
                                }
                                catch
                                {
                                    result_img.BackgroundImage = new Bitmap(@"Design/characters/unknown.jpg");
                                }
                                result_string.Text = GE.TrackFirstCharacterChange.Peek().name + "\n CF: " + GE.TrackFirstCharacterChange.Peek().Score.ToString();
                                result_string.Text += "\n\n" + GE.TrackFirstCharacterChange.Peek().description;
                            }
                            else
                            {
                                result_img.BackgroundImage = new Bitmap(@"Design/characters/unknown.jpg");
                                result_string.Text = "شخص غير موجود فى الوجود";
                            }
                        }));
                    });
                    return;
                case 3:
                    Invoke(new Action(() =>
                    {
                        panel3.Show();
                    }));
                    return;
                case 4:
                    Invoke(new Action(() =>
                    {
                        panel4.Show();
                    }));
                    return;
            }
        }
        #endregion

        #region Screen1 [Intro]
        private async void play_Click(object sender, EventArgs e)
        {
            if (textBox_age.Text.Length > 0)
            {
                short age; short.TryParse(textBox_age.Text, out age);
                if (age >= 1)
                {
                    Screen(2);
                    return;
                }
            }
            //Invalid Age!
            var ocl = textBox_age.BackColor;
            textBox_age.BackColor = Color.Red;
            await Task.Delay(200); // Wait without blocking
            textBox_age.BackColor = ocl;
        }
        #endregion

        #region Screen2 [Game]
        private void label_Yes_Click(object sender, EventArgs e)
        {
            AnswerBottonClicked_Value = MYCIN_TERM_FACTOR.DEFINITELY_YES;
            AnswerBottonClicked = true;
        }
        private void label_No_Click(object sender, EventArgs e)
        {
            AnswerBottonClicked_Value = MYCIN_TERM_FACTOR.DEFINITELY_NOT;
            AnswerBottonClicked = true;
        }
        private void label_Unknown_Click(object sender, EventArgs e)
        {
            AnswerBottonClicked_Value = MYCIN_TERM_FACTOR.UNKNOWN;
            AnswerBottonClicked = true;
        }
        private void label_ProbablyYes_Click(object sender, EventArgs e)
        {
            AnswerBottonClicked_Value = MYCIN_TERM_FACTOR.PROBABLY_YES;
            AnswerBottonClicked = true;
        }
        private void label_ProbablyNot_Click(object sender, EventArgs e)
        {
            AnswerBottonClicked_Value = MYCIN_TERM_FACTOR.PROBABLY_NOT;
            AnswerBottonClicked = true;
        }
        private void pictureBox_Back_Click(object sender, EventArgs e)
        {
            BackClicked = true;
        }
        private async void pictureBox_why_Click(object sender, EventArgs e)
        {
            await Task.Run(() => 
            {
                Invoke(new Action(() =>
                {
                    textBox_why.Clear();
                    if (textBox_why.Visible)
                        textBox_why.Hide();
                    else
                    {
                        textBox_why.Show();
                        textBox_why.AppendLine("...تتبع عكسى من السؤال الحالى وحتى نقطة البداية");
                        textBox_why.AppendLine("يجب ان تكون العلامة الكلية للشخصية المقترحة");
                        textBox_why.AppendLine(".أكبر من أو مساوية للقيمة 0.8 حتى تحتسب كهدف");

                        for (int i = 0; i < GE.TrackAnsweredQuestions.Count; i++)
                        {
                            textBox_why.AppendLine(":السؤال");
                            textBox_why.AppendLine(GE.TrackAnsweredQuestions.ElementAt(i).value);
                            textBox_why.AppendLine(":الاجابة");
                            textBox_why.AppendLine(GetEqArAns(GE.TrackAnsweredQuestions.ElementAt(i).Answer));
                            textBox_why.AppendLine(":درجة الـتأكد من الاجابة");
                            textBox_why.AppendLine(Math.Abs(((double)GE.TrackAnsweredQuestions.ElementAt(i).Answer)).ToString() + "%");
                            textBox_why.AppendLine(":الشخصية المقترحة");
                            textBox_why.AppendLine(GE.TrackFirstCharacterChange.ElementAt(i).name);
                            textBox_why.AppendLine(":العلامة الكلية للشخصية");
                            textBox_why.AppendLine(GE.TrackFirstCharacterChange.ElementAt(i).Score.ToString());
                            textBox_why.AppendLine("--------------------------------------");
                        }
                    }
                }));
            });
        }
        #endregion

        #region Screen3 [Results]
        private void label_PlayAgain_Click(object sender, EventArgs e)
        {
            Screen(2);
        }
        private void label_How_Click(object sender, EventArgs e)
        {
            Screen(4);
            textBox_How.Clear();
            textBox_How.AppendLine("...تتبع من نقطة البداية وحتى نهاية اللعبة");
            textBox_How.AppendLine("يجب ان تكون العلامة الكلية للشخصية المقترحة");
            textBox_How.AppendLine(".أكبر من أو مساوية للقيمة 0.8 حتى تحتسب كهدف");

            for (int i = GE.TrackAnsweredQuestions.Count - 1; i >= 0; i--)
            {
                textBox_How.AppendLine(":السؤال");
                textBox_How.AppendLine(GE.TrackAnsweredQuestions.ElementAt(i).value);
                textBox_How.AppendLine(":الاجابة");
                textBox_How.AppendLine(GetEqArAns(GE.TrackAnsweredQuestions.ElementAt(i).Answer));
                textBox_How.AppendLine(":درجة الـتأكد من الاجابة");
                textBox_How.AppendLine(Math.Abs(((double)GE.TrackAnsweredQuestions.ElementAt(i).Answer)).ToString() + "%");
                textBox_How.AppendLine(":الشخصية المقترحة");
                textBox_How.AppendLine(GE.TrackFirstCharacterChange.ElementAt(i).name);
                textBox_How.AppendLine(":العلامة الكلية للشخصية");
                textBox_How.AppendLine(GE.TrackFirstCharacterChange.ElementAt(i).Score.ToString());
                textBox_How.AppendLine("--------------------------------------");
            }
        }
        private string GetEqArAns(MYCIN_TERM_FACTOR ans)
        {
            switch (ans)
            {
                case MYCIN_TERM_FACTOR.DEFINITELY_YES:
                    return "نعم";
                case MYCIN_TERM_FACTOR.DEFINITELY_NOT:
                    return "لا";
                case MYCIN_TERM_FACTOR.PROBABLY_YES:
                    return "من الممكن";
                case MYCIN_TERM_FACTOR.PROBABLY_NOT:
                    return "الظاهر لا";
                default:
                    return "لا أعلم";
            }
        }
        #endregion

        #region Screen4 [How]
        private void playAgain_pictureBox_Click(object sender, EventArgs e)
        {
            Screen(2);
        }
        #endregion

        public MYCIN_TERM_FACTOR Ask(string q)
        {
            Invoke(new Action(() =>
            {
                label_Question.Text = q;
                label_Q_Num.Text = (GE.TrackAnsweredQuestions.Count + 1).ToString();
                if (GE.TrackAnsweredQuestions.Count + 1 == 1)
                {
                    Invoke(new Action(() =>
                    {
                        pictureBox_Back.Hide();
                        pictureBox_why.Hide();
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        pictureBox_Back.Show();
                        pictureBox_why.Show();
                    }));
                }
            }));
            while (!AnswerBottonClicked)
            {
                if (BackClicked)
                {
                    BackClicked = false;
                    Invoke(new Action(() =>
                    {
                        pictureBox_why.Hide();
                    }));
                    throw new Exception("Back Requested");
                }
                Task.Delay(22); // Wait without blocking
            }
            AnswerBottonClicked = false;
            Invoke(new Action(() => 
            {
                pictureBox_why.Hide();
            }));
            return AnswerBottonClicked_Value;
        }
    }
}
