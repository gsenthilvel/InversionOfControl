using System;

namespace DependencyInjection
{

    class Program
    {
        static void ConstructInvoke()
        {
            ConstructorInject constructorInject = new ConstructorInject(new ConsoleLogger());
            constructorInject.Executor();
        }
        static void SetterInvoke()
        {
            SetterInject setterInject = new SetterInject();
            setterInject.Logger = new ConsoleLogger();
            setterInject.Executor();
        }
        static void InterfaceInvoke()
        {
            InterfaceInject interfaceInject = new InterfaceInject();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            interfaceInject.SetLogger(consoleLogger);
            interfaceInject.Executor();
        }
        static void NotificationInvoke()
        {
            IoC_Notification notification = new IoC_Notification(new EmailNotification());
            notification.NotifyService("Hello Email Notification!");
            notification = new IoC_Notification(new SmsNotification());
            notification.NotifyService("Hello SMS Notification!");
        }
        static void Main(string[] args)
        {
            // Three different ways to inject dependency
            ConstructInvoke();
            SetterInvoke();
            InterfaceInvoke();

            // IoC based dependency injection
            NotificationInvoke();
        }
    }
}   