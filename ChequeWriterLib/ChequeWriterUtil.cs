using System.Collections.Generic;
using System.Text;

namespace ChequeWriterLib
{
    public class ChequeWriterUtil
    {
        /// <summary>
        /// Returns string representation of the input number suitable for writing monies into paper cheques.
        /// </summary>
        /// <param name="number">Any number below 2 billion, with or without decimal parts</param>
        /// <returns>string representation of the input number</returns>
        public static string GetString(decimal number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "negative number are not supported";

            if (number > 2000000000) //2 billion and up
                return "more than 2 billion are not supported";

            //convert to string and group by 3s
            var inputStr = number.ToString("###########0.00");
            var numParts = inputStr.Split(".");
            var res = new StringBuilder();

            var whole = numParts[0];
            var groups = GetGroups(whole);
            for (int i = 0; i < groups.Count; i++)
            {
                var txt = GetText(groups[i], i);
                if (res.Length > 0) txt = txt + ", ";

                res.Insert(0, txt);
            }
            if (int.Parse(whole) >= 2) res.Append(" DOLLARS");
            else if (int.Parse(whole) == 1) res.Append(" DOLLAR");
            else res.Append("");

            var deci = string.Empty;
            if (numParts.Length >= 2)
            {
                deci = numParts[1];

                if (int.Parse(deci) > 0)
                {
                    if (decimal.Parse(whole) > 0) res.Append(" AND "); //there's whole number value

                    groups = GetGroups(deci);
                    for (int i = 0; i < groups.Count; i++)
                    {
                        res.Append(GetText(groups[i], i));
                    }
                    if (int.Parse(deci) > 1) res.Append(" CENTS");
                    else if (int.Parse(deci) == 1) res.Append(" CENT");
                    else res.Append("");
                }
            }

            return res.ToString();
        }

        public static List<string> GetGroups(string number)
        {
            List<string> groups = new List<string>();
            int len = 3;
            for (int pos = number.Length - 3; pos >= -2; pos -= 3)
            {
                if (pos < 0)
                {
                    len = pos + 3;
                    pos = 0;
                }
                groups.Add(number.Substring(pos, len));
            }

            return groups;
        }

        static string GetText(string number, int group)
        {
            if (int.Parse(number) == 0)
                return string.Empty;

            string res = string.Empty; // hundreds
            string c = string.Empty; // tweens and below
            string suffix = GetGroupSuffix(group);
            string and = string.Empty;

            if (!string.IsNullOrEmpty(suffix)) suffix = " " + suffix;

            if (int.Parse(number) >= 100)
            {
                res = GetTweensAndOnes(int.Parse(number.Substring(0, 1))) + " hundred";
            }

            var s10 = int.Parse(number) % 100;
            if (s10 >= 20)
            {
                int bal = s10 % 10;
                var b = GetTweensAndOnes(s10 - bal); // 20 and up
                if (!string.IsNullOrEmpty(res) && !string.IsNullOrEmpty(b))
                    and = " and ";
                else and = string.Empty;
                res = string.Format("{0}{1}{2}", res.Trim(), and, b);

                if (bal > 0)
                {
                    c = GetTweensAndOnes(bal); //ones
                    res = string.Format("{0} {1}", res.Trim(), c);
                }
            }
            else
            {
                c = GetTweensAndOnes((s10)); // 19 and below
                if (!string.IsNullOrEmpty(res) && !string.IsNullOrEmpty(c))
                    and = " and ";
                else and = string.Empty;
                res = string.Format("{0}{1}{2}", res.Trim(), and, c);
            }

            return string.Format("{0}{1}", res.Trim(), suffix);
        }

        static string GetTweensAndOnes(int num)
        {
            switch (num)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "forty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
                default:
                    return "";
            }
        }

        static string GetGroupSuffix(int grp)
        {
            switch (grp)
            {
                case 3:
                    return "billion";
                case 2:
                    return "million";
                case 1:
                    return "thousand";
                default:
                    return "";
            }

        }
    }
}
