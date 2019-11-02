using System;
using Washable.Logging.Common;

namespace Washable.Logging.NLogFramework
{
    public class NLogLoggerProvider
        : ILoggerProvider
    {
        public ILogger GetLogger(string name)
        {
            return new NLogLogger(name: name);
        }

        public ILogger GetLogger(Type targetType)
        {
            return GetLogger(name: targetType.FullName);
        }
    }
}
