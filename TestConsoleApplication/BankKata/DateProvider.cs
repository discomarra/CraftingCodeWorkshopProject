using BankKata.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class DateProvider : IDateProvider
    {
        public DateTime GetNowDate()
        {
            return DateTime.Now;
        }
    }
}
