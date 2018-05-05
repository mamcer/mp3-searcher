using System;

namespace CrossCutting.Core.Logging
{
    public interface ILogService
    {
        void Fatal(string message);

        void Error(string message);

        void Error(Exception ex);

        void Warn(string message);

        void Info(string message);

        void Debug(string message);
    }
}