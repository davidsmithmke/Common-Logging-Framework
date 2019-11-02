> Simple, extensible logging framework.  Allows for easy injection of logging dependencies while avoid close coupling with logging frameworks.

# Common Logging Framework

A simple, yet extensible, framework for adding logging capabilities to an application.  The framework is designed to provide an abstraction layer, allowing injection of loggers into applications while avoid the coupling to specific logging frameworks.

Provides a standard NLog package, and associated Ninject bindings.  Additional frameworks can be easily integrated.  Also includes a null logger for testing purposes.

## Getting Started

## Prerequisites

The NLog adapter requires [NLog](https://nlog-project.org/) 4.6.2 or higher.  The Ninject bindings require [Ninject](http://www.ninject.org/)  3.3.4 or higher.  Both will be automatically installed when installing the corresponding common logging framework package.

### Installing

The logging framework can be installed via Nuget, and can be found in the [Nuget Gallery](https://www.nuget.org/packages/Washable.Logging.Common/).

```
PM> Install-Package Washable.Logging.Common
```

The NLog adapter for the logging framework can be installed via Nuget, and can be found in the [Nuget Gallery](https://www.nuget.org/packages/Washable.Logging.NLog.Ninject/).

```
PM> Install-Package Washable.Logging.Common.NLogFramework
```

The standard bindings for the NLog adapter can be installed via Nuget, and can be found in the [Nuget Gallery](https://www.nuget.org/packages/Washable.Logging.Common.NLogFramework/).

```
PM> Install-Package Washable.Logging.NLog.Ninject
```

### Usage

#### Using the NLog Adapter

To being, add the [NLog adapter package](#Installing) to the project.  Create an [NLog configuration file](https://github.com/nlog/nlog/wiki/Configuration-file) for the application.  Create an instance of the `NLogLoggerProvider` class, and call the `GetLogger` method to obtain an NLog logger, providing either the name of the logger, or the type associated with the logger (the full name of which will be used as the name of the logger).

```csharp
ILoggerProvider loggerProvider = new NLogLoggerProvider();

ILogger logger = loggerProvider.GetLogger(targetType: typeof(Program));

logger.Info("Logger has been created.");
```

#### Using the NLog Adapter with Ninject

If you are using Ninject for dependency injection, add the [Ninject bindings](#Installing) package.  Create a Ninject kernel, and load the standard bindings modules using [dynamic module loading](https://github.com/ninject/Ninject/wiki/Modules-and-the-Kernel#dynamic-module-loading).  The kernel will inject an NLog logger named based on the containing type for `ILogger` targets.

```csharp
IKernel kernel = new StandardKernel();

kernel.Load("*.dll");

ILogger logger = kernel.Get<ILogger>();

logger.Info("This is a test from Main.");
```

#### Using the Null Logger with Ninject

If you are using Ninject, and wish to utilize the null logger for testing, apply the `NullLogger` attribute to the target parameter.  All logger calls will be discarded.

```csharp
class NullLoggerUser
{
    public NullLoggerUser([NullLogger] ILogger nullLogger)
    {
        nullLogger.Info("This message will be discarded.");
    }
}
```

Alternatively, do not load the standard binding modules package, and create Ninject bindings as needed.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details


