using ClosedXML.Excel;
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
            InitEvaluation();

            timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void Update()
        {

        }

        private void InitEvaluation()
        {
            evaluationBuffer.Clear();
            evaluationBuffer.Add(Evaluation.SATISFACTION, 0);
            evaluationBuffer.Add(Evaluation.GOOD, 0);
            evaluationBuffer.Add(Evaluation.GOODLUCK, 0);
        }

        public void AddEvaluation(Evaluation evaluation)
        {
            evaluationBuffer[evaluation] += 1;
        }

        private Dictionary<Evaluation, int> LoadEveryMealData()
        {
            var mealData = new Dictionary<Evaluation, int>();
            using(XLWorkbook workbook = new XLWorkbook(docName))
            {
                var worksheet = workbook.Worksheet("Sheet1");
            }
            return mealData;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Update();
            InitEvaluation();
        }
    }
}
