using Autofac;
using Washable.Logging.Common;
using Washable.Logging.NLogFramework;

namespace Washable.Logging.NLog.Ninject
{
    public class NLogModule
         : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NLogLoggerProvider>().As<ILoggerProvider>();
        }
    }
}
