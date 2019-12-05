using System;
using System.Collections.Generic;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractLogWriter> list = new List<AbstractLogWriter>();
            list.Add(new ConsoleLogWriter());
            list.Add(new FileLogWriter("D:\\log.txt"));
            MultipleLogWriter mlw = new MultipleLogWriter(list);
            mlw.LogError("Ошибко");
            mlw.LogInfo("Инфо");
            mlw.LogWarning("Предупреждение");

            

           }
    }
}
