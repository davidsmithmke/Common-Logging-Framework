using Ninject.Modules;
using Washable.Logging.Common;
using Washable.Logging.Common.Null;

namespace Washable.Logging.NLog.Ninject
{
    public class NullLoggerBindingModule
        : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<NullLogger>().WhenTargetHas<NullLoggerAttribute>();
        }
    }
}
