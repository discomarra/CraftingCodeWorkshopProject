using BankKata.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class StatementPrinter : IStatementPrinter
    {
        private IOutput output;

        public StatementPrinter(IOutput output)
        {
            this.output = output;
        }

        public void Print(List<Transation> transactions)
        {
            throw new NotImplementedException();
        }
    }
}
