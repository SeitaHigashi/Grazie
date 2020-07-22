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
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOOD);
        }

        private void goodluckButton_Click(object sender, EventArgs e)
        {
            Logger.AddEvaluation(Evaluation.GOODLUCK);
        }

        private void Grazie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Update();
        }
    }
}
