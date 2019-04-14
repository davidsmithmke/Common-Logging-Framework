using System;

namespace Washable.Logging.Common
{
    public interface ILogger
    {
        void Trace(string message, params string[] args);
        void Trace(Exception e);
        void Debug(string message, params string[] args);
        void Debug(Exception e);
        void Info(string message, params string[] args);
        void Info(Exception e);
        void Warn(string message, params string[] args);
        void Warn(Exception e);
        void Error(string message, params string[] args);
        void Error(Exception e);
        void Fatal(string message, params string[] args);
        void Fatal(Exception e);
    }
}
