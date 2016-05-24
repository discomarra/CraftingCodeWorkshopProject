using System;
using System.Collections.Generic;

namespace BankKata.Tests
{
    public interface ITransactionRepository
    {
        void Add(Transation transaction);

        List<Transation> GetTransactions();
    }
}