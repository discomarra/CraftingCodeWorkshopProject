using System;

namespace BankKata.Tests
{
    public class Transation
    {
        private int amount;
        private DateTime dateTime;
        private TransactionType type;

        public Transation(int amount, DateTime dateTime, TransactionType type)
        {
            this.amount = amount;
            this.dateTime = dateTime;
            this.type = type;
        }
    }
}