using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    // Abstract class
    public interface INotification
    {
        void Executor(string message);
    }
    // Low level class
    public class EmailNotification : INotification
    {
        public void Executor(string message)
        {
            Console.WriteLine($"Executing here.. IoC based Email notification: {message}");
        }
    }
    public class SmsNotification : INotification
    {
        public void Executor(string message)
        {
            Console.WriteLine($"Executing here.. IoC based SMS notification: {message}");
        }
    }
    // High level class
    internal class IoC_Notification
    {
        private INotification _notification;
        public IoC_Notification(INotification notification)
        {
            _notification = notification;
        }
        public void NotifyService(string message)
        {
            _notification.Executor(message);
        }
    }
}
