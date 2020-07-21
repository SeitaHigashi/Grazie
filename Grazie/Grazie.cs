using System;
using System.Windows.Forms;

namespace Grazie
{
    public partial class Grazie : Form
    {
        private Boolean fullscreen;

        private Logger logger;

        public Grazie()
        {
            InitializeComponent();

            this.fullscreen = false;

            logger = new Logger("log.xlsx");

            this.KeyDown += Form_KeyDown;
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 122)
            {
                if (fullscreen)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    fullscreen = false;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.WindowState = FormWindowState.Maximized;
                    fullscreen = true;
                }
            }
        }

        private void satisfactionButton_Click(object sender, EventArgs e)
        {
            logger.AddEvaluation(Evaluation.SATISFACTION);
        }

        private void goodButton_Click(object sender, EventArgs e)
        {
            logger.AddEvaluation(Evaluation.GOOD);
        }

        private void goodluckButton_Click(object sender, EventArgs e)
        {
            logger.AddEvaluation(Evaluation.GOODLUCK);
        }
    }
}
