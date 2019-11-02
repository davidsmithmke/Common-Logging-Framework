using System;

namespace Washable.Logging.Common
{
    public interface ILoggerProvider
    {
        ILogger GetLogger(string name);
        ILogger GetLogger(Type targetType);
    }
}
