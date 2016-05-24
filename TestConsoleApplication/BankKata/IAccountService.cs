using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankKata
{
    public interface IAccountService
    {
        void Deposit(int amount);

        void Withdraw(int amount);

        void PrintStatement();
    }
}
