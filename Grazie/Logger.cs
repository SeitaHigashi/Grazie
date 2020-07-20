using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using ClosedXML.Excel;

namespace Grazie
{
    class Logger
    {
        private string docName;
        private Timer timer;

        public Logger(string docName)
        {
            this.docName = docName;

            timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void Update()
        {

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
        }
    }
}
