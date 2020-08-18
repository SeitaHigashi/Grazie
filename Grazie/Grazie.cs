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

            label1.Text = $"{Logger.Evaluations[Evaluation.SATISFACTION]} 人";
            label2.Text = $"{Logger.Evaluations[Evaluation.GOOD]} 人";
            label3.Text = $"{Logger.Evaluations[Evaluation.GOODLUCK]} 人";

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
            label1.Text = $"{Logger.Evaluations[Evaluation.SATISFACTION]} 人";
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOOD);
            label2.Text = $"{Logger.Evaluations[Evaluation.GOOD]} 人";
        }

        private void goodluckButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOODLUCK);
            label3.Text = $"{Logger.Evaluations[Evaluation.GOODLUCK]} 人";
        }

        private void Grazie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Update();
        }
    }
}
