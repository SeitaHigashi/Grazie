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
            SaveEvaluation();
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
                    var row = worksheet.LastRowUsed();
                    if (IsCurrentData(row))
                    {
                        Console.WriteLine(row.Cell("C").Value);
                        evaluationData[Evaluation.SATISFACTION] = (int)(double)row.Cell("C").Value;
                        evaluationData[Evaluation.GOOD] = (int)(double)row.Cell("D").Value;
                        evaluationData[Evaluation.GOODLUCK] = (int)(double)row.Cell("E").Value;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                CreateDataFile();
            }
            return evaluationData;
        }

        private void SaveEvaluation()
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook(docName))
                {
                    var worksheet = workbook.Worksheet("Data");
                    var row = worksheet.LastRowUsed();
                    if (!IsCurrentData(row))
                    {
                        row = row.RowBelow();
                    }
                    row.Cell("A").Value = DateTime.Today;
                    row.Cell("B").Value = GetNowMeal().ToString();
                    row.Cell("C").Value = evaluation[Evaluation.SATISFACTION];
                    row.Cell("D").Value = evaluation[Evaluation.GOOD];
                    row.Cell("E").Value = evaluation[Evaluation.GOODLUCK];
                    workbook.Save();
                }
            }
            catch (FileNotFoundException)
            {
                CreateDataFile();
            }
        }

        private Boolean IsCurrentData(IXLRow row)
        {
            Boolean day = (DateTime)row.Cell("A").Value == DateTime.Today;
            Boolean meal = row.Cell("B").Value.Equals(GetNowMeal().ToString());
            return day && meal;
        }

        private void CreateDataFile()
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Data");
                worksheet.Cell("A1").Value = DateTime.Today;
                worksheet.Cell("B1").Value = GetNowMeal().ToString();
                workbook.SaveAs(docName);
            }
        }

        private Meal GetNowMeal()
        {
            switch (DateTime.Now.Hour)
            {
                case int hour when hour < 9:
                    return Meal.Breakfast;
                case int hour when hour < 15:
                    return Meal.Lunch;
                default:
                    return Meal.Dinner;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Update();
        }
    }
}
