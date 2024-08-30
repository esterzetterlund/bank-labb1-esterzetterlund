using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{
    public class BankAccount
    {
        private List<IObserver> _observers = new List<IObserver>();
        private decimal _balance;

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Notify($"Deposited {amount}. New balance: {_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                Notify($"Withdrew {amount}. New balance: {_balance}");
            }
            else
            {
                Notify("Insufficient funds.");
            }
        }
    }

}
