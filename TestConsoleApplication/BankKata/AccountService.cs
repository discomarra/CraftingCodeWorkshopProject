using BankKata.Tests;
using System;

namespace BankKata.Tests
{
    internal class AccountService : IAccountService
    {
        private ITransactionRepository transactionalRepository;
        private IDateProvider dateProvider;
        private IOutput output;

        public AccountService(IOutput output, ITransactionRepository account)
        {
            this.output = output;
            this.transactionalRepository = account;
        }

        public AccountService(IOutput output, ITransactionRepository account, IDateProvider dateProvider) : this(output, account)
        {
            this.dateProvider = dateProvider;
        }

        public void Deposit(int amount)
        {
            transactionalRepository.Add(new Transation(amount, dateProvider.GetNowDate(), TransactionType.IN));
        }

        public void PrintStatement()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int amount)
        {
            transactionalRepository.Add(new Transation(amount, dateProvider.GetNowDate(), TransactionType.OUT));
        }
    }
}