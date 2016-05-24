using System.Collections.Generic;

namespace BankKata.Tests
{
    public interface IStatementPrinter
    {
        void Print(List<Transation> transactions);
    }
}