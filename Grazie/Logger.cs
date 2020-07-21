using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
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
            evaluationBuffer = LoadEveryMealData();
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
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(docName))
                {
                    var worksheet = workbook.Worksheet("Data");
                    var lastRow = worksheet.Column("A").LastCellUsed().WorksheetRow();
                    if (lastRow.Cell("B").Value.Equals(GetNowMeal().ToString()))
                    {
                    }
                }
            }
            catch(FileNotFoundException)
            {
                CreateDataFile();
            }
            return mealData;
        }

        private void CreateDataFile()
        {
            using(XLWorkbook workbook = new XLWorkbook())
            {
                workbook.AddWorksheet("Data");
                workbook.SaveAs(docName);
            }
        }

        private Meal GetNowMeal()
        {
            int hour = DateTime.Now.Hour;
            if(hour / 9 == 0)
            {
                return Meal.Morning;
            }
            else if(hour / 15 == 0)
            {
                return Meal.Lunch;
            }
            else
            {
                return Meal.Dinner;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Update();
        }
    }
}
