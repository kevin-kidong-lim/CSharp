using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchageIns
{
    class Util
    {
        public string changeMonthString(string month)
        {
            string monthNumber = "01";
            switch (month)
            {
                case "Jan":
                    {
                        monthNumber = "01"; break;
                    }
                case "Feb":
                    {
                        monthNumber = "02"; break;
                    }
                case "Mar":
                    {
                        monthNumber = "03"; break;
                    }
                case "Apr":
                    {
                        monthNumber = "04"; break;
                    }
                case "May":
                    {
                        monthNumber = "05"; break;
                    }
                case "Jun":
                    {
                        monthNumber = "06"; break;
                    }
                case "July":
                    {
                        monthNumber = "07"; break;
                    }
                case "Aug":
                    {
                        monthNumber = "08"; break;
                    }
                case "Sept":
                    {
                        monthNumber = "09"; break;
                    }
                case "Oct":
                    {
                        monthNumber = "10"; break;
                    }
                case "Nov":
                    {
                        monthNumber = "11"; break;
                    }
                case "Dec":
                    {
                        monthNumber = "12"; break;
                    }
                default:
                    {
                        monthNumber = month; break;
                    }

            }

            return monthNumber;

        }
    }
}
