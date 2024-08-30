using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_labb1_esterzetterlund
{
    public class TransactionLog
    {
        private static TransactionLog _instance;
        private List<string> _logEntries = new List<string>();

        private TransactionLog() { }

        public static TransactionLog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransactionLog();
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            _logEntries.Add(message);
            Console.WriteLine("Log entry added: " + message);
        }

        public void DisplayLog()
        {
            Console.WriteLine("Transaction Log:");
            foreach (var entry in _logEntries)
            {
                Console.WriteLine(entry);
            }
        }
    }

}
