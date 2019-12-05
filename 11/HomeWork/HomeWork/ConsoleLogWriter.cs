using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
