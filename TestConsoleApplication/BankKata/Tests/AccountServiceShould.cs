using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankKata.Tests
{
    public class AccountServiceShould
    {
        private Mock<ITransactionRepository> transationRepository;
        private AccountService accountService;
        private Mock<IOutput> outputMock;
        private Mock<IDateProvider> dateProviderMock;
        private Mock<IStatementPrinter> statementPrinterMock;

        public AccountServiceShould()
        {
            transationRepository = new Mock<ITransactionRepository>();
            outputMock = new Mock<IOutput>();
            dateProviderMock = new Mock<IDateProvider>();

            accountService = new AccountService(outputMock.Object, transationRepository.Object, dateProviderMock.Object);
        }

        [Fact]
        public void Deposit1000ToAccount()
        {
            int amount = 1000;
            Transation transaction = new Transation(amount, DateTime.Parse("10/04/2014"), TransactionType.IN);

            transationRepository.Setup(x => x.Add(transaction));

            accountService.Deposit(amount);

            transationRepository.Verify(x => x.Add(transaction));
        }

        [Fact]
        public void Withdraw500From()
        {
            int amount = 500;

            Transation transaction = new Transation(amount, DateTime.Parse("11/04/2014"), TransactionType.OUT);

            transationRepository.Setup(x => x.Add(transaction));

            accountService.Withdraw(amount);

            transationRepository.Verify(x => x.Add(transaction));
        }

        [Fact]
        public void PrintBalance()
        {
            List<Transation> transactions = new List<Transation>
            {
                new Transation(1000, DateTime.Parse("11/04/2014"), TransactionType.IN),
                new Transation(500, DateTime.Parse("12/04/2014"), TransactionType.OUT),
                new Transation(1000, DateTime.Parse("13/04/2014"), TransactionType.IN),
            };

            accountService.PrintStatement();

            statementPrinterMock.Verify(x => x.Print(transactions));
        }
    }
}
