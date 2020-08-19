using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace Grazie
{
    class Logger
    {
        private string DocName { get; set; }
        public Dictionary<Evaluation, int> Evaluations { get; private set; }
        private Timer Timer { get; set; }

        public Logger(string docName)
        {
            DocName = docName;

            Evaluations = new Dictionary<Evaluation, int>();
            Evaluations = LoadEveryMealData();

            Timer = new Timer
            {
                Interval = 10000,
                AutoReset = true,
                Enabled = true,
            };
            Timer.Elapsed += (s, e) => Update();
        }

        public void Update()
        {
            SaveEvaluation();
        }

        public void AddEvaluation(Evaluation evaluation) => Evaluations[evaluation]++;

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
                using (XLWorkbook workbook = new XLWorkbook(DocName))
                {
                    var worksheet = workbook.Worksheet("Data");
                    var row = worksheet.LastRowUsed();
                    if (IsCurrentData(row))
                    {
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
                using (XLWorkbook workbook = new XLWorkbook(DocName))
                {
                    var worksheet = workbook.Worksheet("Data");
                    var row = worksheet.LastRowUsed();
                    if (!IsCurrentData(row))
                    {
                        row = row.RowBelow();
                    }
                    row.Cell("A").Value = DateTime.Today;
                    row.Cell("B").Value = GetNowMeal().ToString();
                    row.Cell("C").Value = Evaluations[Evaluation.SATISFACTION];
                    row.Cell("D").Value = Evaluations[Evaluation.GOOD];
                    row.Cell("E").Value = Evaluations[Evaluation.GOODLUCK];
                    workbook.Save();
                }
            }
            catch (FileNotFoundException)
            {
                CreateDataFile();
            }
        }

        private bool IsCurrentData(IXLRow row)
        {
            bool day = (DateTime)row.Cell("A").Value == DateTime.Today;
            bool meal = row.Cell("B").Value.ToString() == GetNowMeal().ToString();
            return day && meal;
        }

        private void CreateDataFile()
        {
            using (XLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Data");
                worksheet.Cell("A1").Value = DateTime.Today;
                worksheet.Cell("B1").Value = GetNowMeal().ToString();
                workbook.SaveAs(DocName);
            }
        }

        private static Meal GetNowMeal()
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
    }
}
