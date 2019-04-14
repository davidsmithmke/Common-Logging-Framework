using NLog;
using System;

namespace Washable.Logging.NLogFramework
{
    public class NLogLogger
    : Common.ILogger
    {
        public NLogLogger(string name)
        {
            Name = name;
            Logger = NLog.LogManager.GetLogger(name: Name);
        }

        private string Name { get; }
        private Logger Logger { get; }

        public void Debug(string message, params string[] args)
        {
            Logger.Debug(message: message, args: args);
        }

        public void Debug(Exception e)
        {
            Logger.Debug(e, String.Empty);
        }

        public void Error(string message, params string[] args)
        {
            Logger.Error(message: message, args: args);
        }

        public void Error(Exception e)
        {
            Logger.Error(e, String.Empty);
        }

        public void Fatal(string message, params string[] args)
        {
            Logger.Fatal(message: message, args: args);
        }

        public void Fatal(Exception e)
        {
            Logger.Fatal(e, String.Empty);
        }

        public void Info(string message, params string[] args)
        {
            Logger.Info(message: message, args: args);
        }

        public void Info(Exception e)
        {
            Logger.Info(e, String.Empty);
        }

        public void Trace(string message, params string[] args)
        {
            Logger.Trace(message: message, args: args);
        }

        public void Trace(Exception e)
        {
            Logger.Trace(e, String.Empty);
        }

        public void Warn(string message, params string[] args)
        {
            Logger.Warn(message: message, args: args);
        }

        public void Warn(Exception e)
        {
            Logger.Warn(e, String.Empty);
        }
    }
}
