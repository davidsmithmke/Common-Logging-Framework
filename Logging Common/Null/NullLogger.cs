using System;

namespace Washable.Logging.Common.Null
{
    /// <summary>
    /// Discards all logged items without recording.
    /// </summary>
    public class NullLogger
        : ILogger
    {
        public void Debug(string message, params string[] args)
        {
            // Do nothing
        }

        public void Debug(Exception e)
        {
            // Do nothing
        }

        public void Error(string message, params string[] args)
        {
            // Do nothing
        }

        public void Error(Exception e)
        {
            // Do nothing
        }

        public void Fatal(string message, params string[] args)
        {
            // Do nothing
        }

        public void Fatal(Exception e)
        {
            // Do nothing
        }

        public void Info(string message, params string[] args)
        {
            // Do nothing
        }

        public void Info(Exception e)
        {
            // Do nothing
        }

        public void Trace(string message, params string[] args)
        {
            // Do nothing
        }

        public void Trace(Exception e)
        {
            // Do nothing
        }

        public void Warn(string message, params string[] args)
        {
            // Do nothing
        }

        public void Warn(Exception e)
        {
            // Do nothing
        }
    }
}
