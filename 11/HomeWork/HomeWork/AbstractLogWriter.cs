using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork
{
    public enum MessageType { Info, Error, Warning }
    public abstract class AbstractLogWriter : ILogWriter
    {
        
        private const string _logMessage = "{0:yyyy-MM-ddThh:mm:ss:ffff}\t{1}\t{2}";
        public void LogError(string message)
        {
            WriteLog(CreateLogMessage(MessageType.Error, message)); 
        }
        public void LogInfo(string message)
        {
            WriteLog(CreateLogMessage(MessageType.Info, message));
        }
        public void LogWarning(string message)
        {
            WriteLog(CreateLogMessage(MessageType.Warning, message));
        }
        private string CreateLogMessage(MessageType type, string message)
        {
            return String.Format(_logMessage, DateTime.Now, type, message);
        }
        public abstract void WriteLog(string message);

    }
}
