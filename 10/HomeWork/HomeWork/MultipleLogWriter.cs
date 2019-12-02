using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
   class MultipleLogWriter : AbstractLogWriter
    {
        private List<AbstractLogWriter> _list;
        public MultipleLogWriter(List<AbstractLogWriter> list)
        {
            _list = list;
        }
        public override void WriteLog(string message)
        {
            _list.ForEach(x => x.WriteLog(message));
        }
    }
}
