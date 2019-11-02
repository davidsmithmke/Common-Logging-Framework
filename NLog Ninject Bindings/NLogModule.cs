using Ninject.Modules;
using Washable.Logging.Common;
using Washable.Logging.NLogFramework;

namespace Washable.Logging.NLog.Ninject
{
    public class NLogModule
        : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().ToMethod(context => new NLogLogger(name: context.Request.Target != null ? context.Request.Target.Member.DeclaringType.FullName : System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName));
            Bind<ILoggerProvider>().To<NLogLoggerProvider>().InSingletonScope();
        }
    }
}
