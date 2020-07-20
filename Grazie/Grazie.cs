using System;
using System.Windows.Forms;

namespace Grazie
{
    public partial class Grazie : Form
    {
        private Boolean fullscreen;

        public Grazie()
        {
            InitializeComponent();

            this.fullscreen = false;

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
    }
}
