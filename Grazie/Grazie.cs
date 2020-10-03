using System;
using System.Windows.Forms;

namespace Grazie
{
    public partial class Grazie : Form
    {
        private bool Fullscreen { get; set; }

        private Logger Logger { get; set; }

        private Timer Timer { get; set; }

        public Grazie()
        {
            InitializeComponent();

            Fullscreen = false;

            Logger = new Logger("log.xlsx");

            //Setting Timer
            Timer = new Timer
            {
                Interval = 20000,
                Enabled = true,
            };
            Timer.Tick += (s, e) => Update();

            KeyDown += Form_KeyDown;

            NumberOfSatisfaction.Text = IdeographicTallyMarks(Evaluation.SATISFACTION);
            NumberOfGood.Text = IdeographicTallyMarks(Evaluation.GOOD);
            NumberOfGoodluck.Text = IdeographicTallyMarks(Evaluation.GOODLUCK);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 122)
            {
                if (Fullscreen)
                {
                    WindowState = FormWindowState.Normal;
                    FormBorderStyle = FormBorderStyle.Sizable;
                    Fullscreen = false;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                    Fullscreen = true;
                }
            }
        }

        private void satisfactionButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.SATISFACTION);
            NumberOfSatisfaction.Text = IdeographicTallyMarks(Evaluation.SATISFACTION);
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOOD);
            NumberOfGood.Text = IdeographicTallyMarks(Evaluation.GOOD);
        }

        private void goodluckButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOODLUCK);
            NumberOfGoodluck.Text = IdeographicTallyMarks(Evaluation.GOODLUCK);
        }

        private void Grazie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Update();
        }

        private void Update()
        {
            Logger.Update();
            NumberOfSatisfaction.Text = IdeographicTallyMarks(Evaluation.SATISFACTION);
            NumberOfGood.Text = IdeographicTallyMarks(Evaluation.GOOD);
            NumberOfGoodluck.Text = IdeographicTallyMarks(Evaluation.GOODLUCK);
        }

        private string IdeographicTallyMarks(Evaluation evaluation)
             => new string('*', Logger.Evaluations[evaluation] / 5).Replace("*", "𝍶")
            + new string[] { string.Empty, "𝍲", "𝍳", "𝍴", "𝍵" }[Logger.Evaluations[evaluation] % 5];
    }
}
