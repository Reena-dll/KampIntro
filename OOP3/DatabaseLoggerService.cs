using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    partial class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}