using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{
    public abstract class AccountFactory
    {
        public abstract Account CreateAccount();
    }

    public class SavingsAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new SavingsAccount();
        }
    }

    public class CurrentAccountFactory : AccountFactory
    {
        public override Account CreateAccount()
        {
            return new CurrentAccount();
        }
    }

}
