using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class AccountHolder : IObserver
    {
        private string _name;

        public AccountHolder(string name)
        {
            _name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{_name} received notification: {message}");
        }
    }

}
