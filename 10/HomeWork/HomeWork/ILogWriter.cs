﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
