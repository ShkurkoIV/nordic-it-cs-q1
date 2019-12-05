using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork
{
    class FileLogWriter : AbstractLogWriter, IDisposable
    {
        private StreamWriter _writer;

        public FileLogWriter()
        {
            _writer = new StreamWriter(File.Open("test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
            _writer.BaseStream.Seek(0, SeekOrigin.End);
        }
       
        public void Dispose()
        {
            if (_writer != null)
            {
                _writer.Dispose();
            }
        }

        public override void WriteLog(string message)
        {
            _writer.WriteLine(message);
            _writer.Flush();
       }
    }
}
