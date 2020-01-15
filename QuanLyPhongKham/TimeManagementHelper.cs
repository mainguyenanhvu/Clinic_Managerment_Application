using System;
using System.Collections.Generic;

namespace QuanLyPhongKham
{
    public class TimeManagementHelper
    {
        private string defaultValue = "";
        private string Status;
        public Dictionary<string, string> date = new Dictionary<string, string>
        {
            {"Day", "" },
            {"Month","" },
            {"Year","" }
        };

        private void normalizeFunctions()
        {
            normalizeDay();
            normalizeMonth();
            normalizeYear();
        }

        private void normalizeDay()
        {
            bool day_check = checkNumber(date["Day"]);

            if (day_check == false)// || date["Day"].Length != 2)
            {
                date["Day"] = defaultValue;
            }

        }

        
        private void normalizeMonth()
        {
            bool month_check = checkNumber(date["Month"]);

            if (month_check == false)// || date["Month"].Length != 2)
            {
                date["Month"] = defaultValue;
            }
        }

        private void normalizeYear()
        {
            bool year_check = checkNumber(date["Year"]);

            if (year_check == false)// || date["Year"].Length != 4)
            {
                date["Year"] = defaultValue;
            }

        }

        private bool checkNumber(string str)
        {
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        public TimeManagementHelper(string[] conditionstring)
        {
            date["Day"] = conditionstring[0];
            date["Month"] = conditionstring[1];
            date["Year"] = conditionstring[2];
            normalizeFunctions();
            updateStatus();
        }

        private void updateStatus()
        {
            Status = "None";
            foreach (string key in new string[] { "Year", "Month", "Day" })
                if (date[key] != defaultValue)
                {
                    Status = key;
                }
                else break;
        }

        public string getStatus()
        {
            return Status;
        }
    }
}