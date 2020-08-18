using System;
using System.Windows.Forms;

namespace Grazie
{
    public partial class Grazie : Form
    {
        private bool Fullscreen { get; set; }

        private Logger Logger { get; set; }

        public Grazie()
        {
            InitializeComponent();

            Fullscreen = false;

            Logger = new Logger("log.xlsx");

            KeyDown += Form_KeyDown;

            NumberOfSatisfaction.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.SATISFACTION])}";
            NumberOfGood.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.GOOD])}";
            NumberOfGoodluck.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.GOODLUCK])}";
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
            NumberOfSatisfaction.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.SATISFACTION])}";
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOOD);
            NumberOfGood.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.GOOD])}";
        }

        private void goodluckButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOODLUCK);
            NumberOfGoodluck.Text = $"{IdeographicTallyMarks(Logger.Evaluations[Evaluation.GOODLUCK])}";
        }

        private void Grazie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Update();
        }
        public string IdeographicTallyMarks(int x) =>
            new string('*', x / 5).Replace("*", "𝍶")
            + new string[] { string.Empty, "𝍲", "𝍳", "𝍴", "𝍵" }[x % 5];
    }
}
