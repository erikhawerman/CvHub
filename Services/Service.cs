using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class ForSaftey
    {
        public static DateTime getDateTime(string stringDate)
        {
            int dayDate = Int32.Parse(stringDate.Substring(0, 2));
            int monthDate = Int32.Parse(stringDate.Substring(3, 2));
            int yearDate = Int32.Parse(stringDate.Substring(6, 4));
            return new DateTime(yearDate, monthDate, dayDate);
        }
    }
}
