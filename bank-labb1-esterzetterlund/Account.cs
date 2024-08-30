using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{
    public abstract class Account
    {
        public abstract void DisplayAccountType();
    }

    public class SavingsAccount : Account
    {
        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }
    }

    public class CurrentAccount : Account
    {
        public override void DisplayAccountType()
        {
            Console.WriteLine("Current Account");
        }
    }

}
