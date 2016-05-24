using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankKata.Tests
{
    public class PrintStatemenFeature
    {
        private Mock<IOutput> console = new Mock<IOutput>();
        private Mock<ITransactionRepository> transactionalRepository = new Mock<ITransactionRepository>();

        [Fact]
        public void print_statement_containing_transactions_in_reverse_chronological_order()
        {
            IAccountService accountService = new AccountService(console.Object, transactionalRepository.Object);
            accountService.Deposit(1000);
            accountService.Withdraw(100);
            accountService.Deposit(500);

            accountService.PrintStatement();

            console.Verify(x => x.PrintLine("DATE | AMOUNT | BALANCE"));
            console.Verify(x => x.PrintLine("10/04/2014 | 500.00 | 1400.00"));
            console.Verify(x => x.PrintLine("02/04/2014 | -100.00 | 900.00"));
            console.Verify(x => x.PrintLine("01/04/2014 | 1000.00 | 1000.00"));
        }
    }
}
