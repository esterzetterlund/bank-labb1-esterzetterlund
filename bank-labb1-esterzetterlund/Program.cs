using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{


    class Program
    {
        static void Main(string[] args)
        {
            // Exempel på användning av Factory Method
            AccountFactory factory = new SavingsAccountFactory();
            Account account = factory.CreateAccount();
            account.DisplayAccountType();

            // Exempel på användning av Singleton
            TransactionLog log = TransactionLog.Instance;
            log.Log("Created a new savings account.");

            // Exempel på användning av Observer
            BankAccount bankAccount = new BankAccount();
            AccountHolder holder = new AccountHolder("Alice");
            bankAccount.Attach(holder);
            bankAccount.Deposit(100);

            Console.ReadLine();
        }
    }
}