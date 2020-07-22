﻿using ClosedXML.Excel;
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
                    var row = worksheet.LastRowUsed();
                    Console.WriteLine(row.ToString());
                    if(IsCurrentData(row))
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

        private Boolean IsCurrentData(IXLRow row)
        {
            Boolean day = (DateTime)row.Cell("A").Value == DateTime.Today;
            Boolean meal = row.Cell("B").Value.Equals(GetNowMeal().ToString());
            return day && meal;
        }

        private void CreateDataFile()
        {
            using(XLWorkbook workbook = new XLWorkbook())
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
