using System;
using System.Text.RegularExpressions;

namespace wpfTimer
{
    public static class TimerHelper
    {
        public static int toIntegerFromStringValue(this String value)
        {
            if (!String.IsNullOrWhiteSpace(value) && !isNumberControl(value))
            {
                return Int32.Parse(value);
            }
            return 0;
        }

        public static bool isNumberControl(string text)
        {
            var regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            return regex.IsMatch(text);
        }
    }
}