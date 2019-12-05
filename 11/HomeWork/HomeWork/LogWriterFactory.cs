using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public sealed class LogWriterFactory
    {
        private static readonly LogWriterFactory instance = new LogWriterFactory();
       
        public static LogWriterFactory Instance { get { return instance; } }

        public AbstractLogWriter GetLogWriter<T>(params AbstractLogWriter[] writers) where T: AbstractLogWriter, new()
        {
            if (writers != null)
            {
                foreach (var writer in writers)
                {
                    MultipleLogWriter.LogWriters.Add(writer);
                } 
            }
            return new T();
        }
    }
}
