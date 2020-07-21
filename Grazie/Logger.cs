using System;
using System.Collections.Generic;
using System.Timers;

namespace Grazie
{
    class Logger
    {
        private string docName;
        private Dictionary<Evaluation, int> evaluationBuffer;
        private Timer timer;

        public Logger(string docName)
        {
            this.docName = docName;

            evaluationBuffer = new Dictionary<Evaluation, int>();
            InitEvaluationBuffer();

            timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void Update()
        {

        }

        private void InitEvaluationBuffer()
        {
            evaluationBuffer.Clear();
            evaluationBuffer.Add(Evaluation.SATISFACTION, 0);
            evaluationBuffer.Add(Evaluation.GOOD, 0);
            evaluationBuffer.Add(Evaluation.GOODLUCK, 0);
        }

        private void AddEvaluation(Evaluation evaluation)
        {
            evaluationBuffer[evaluation] += 1;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
        }
    }
}
