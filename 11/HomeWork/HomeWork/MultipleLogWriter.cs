using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
   class MultipleLogWriter : AbstractLogWriter
    {
        public static List<AbstractLogWriter> LogWriters { get; private set; }
        static MultipleLogWriter()
        {
            LogWriters = new List<AbstractLogWriter>();
        }
        public MultipleLogWriter() { }
           
        public override void WriteLog(string message)
        {
            LogWriters.ForEach(x => x.WriteLog(message));
        }

   }
}
