using BankKata.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<Transation> transactions = new List<Transation>();

        public TransactionRepository()
        {
        }

        public void Add(Transation transaction)
        {
            transactions.Add(transaction);
        }

        public List<Transation> GetTransactions()
        {
            return transactions;
        }
    }
}
