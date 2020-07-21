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
        private Dictionary<Evaluation, int> evaluation;
        private Timer timer;

        public Logger(string docName)
        {
            this.docName = docName;

            evaluation = new Dictionary<Evaluation, int>();
            evaluation = LoadEveryMealData();

            timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void Update()
        {

        }

        public void AddEvaluation(Evaluation evaluation)
        {
            this.evaluation[evaluation] += 1;
        }

        private Dictionary<Evaluation, int> InitEvaluation()
        {
            var data = new Dictionary<Evaluation, int>();
            data.Clear();
            data.Add(Evaluation.SATISFACTION, 0);
            data.Add(Evaluation.GOOD, 0);
            data.Add(Evaluation.GOODLUCK, 0);
            return data;
        }

        private Dictionary<Evaluation, int> LoadEveryMealData()
        {
            var evaluationData = InitEvaluation();
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(docName))
                {
                    var worksheet = workbook.Worksheet("Data");
                    var lastCell = worksheet.Column("A").LastCellUsed();
                    Console.WriteLine(lastCell.Value);
                    var row = lastCell.WorksheetRow();
                    if (((DateTime)lastCell.Value).DayOfYear == DateTime.Now.DayOfYear &&
                        row.Cell("B").Value.Equals(GetNowMeal().ToString()))
                    {
                        evaluationData[Evaluation.SATISFACTION] = (int)row.Cell("C").Value;
                        evaluationData[Evaluation.GOOD] = (int)row.Cell("C").Value;
                        evaluationData[Evaluation.GOODLUCK] = (int)row.Cell("C").Value;
                    }
                }
            }
            catch(FileNotFoundException)
            {
                CreateDataFile();
            }
            return evaluationData;
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
