using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriterFactory _factory = LogWriterFactory.Instance;

            var flw = (FileLogWriter)_factory.GetLogWriter<FileLogWriter>();
            var clw = (ConsoleLogWriter)_factory.GetLogWriter<ConsoleLogWriter>();
            var mlw = (MultipleLogWriter)_factory.GetLogWriter<MultipleLogWriter>(flw, clw);

            mlw.LogError("Ошибко");
            mlw.LogInfo("Инфо");
            mlw.LogWarning("Предупреждение");

        }
    }
}
