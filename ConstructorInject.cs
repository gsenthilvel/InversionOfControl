using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    internal class ConstructorInject
    {
        private ILogger _logger;

        // Constructor
        public ConstructorInject(ILogger logger)
        {
            _logger = logger;
        }

        public void Executor()
        {
            _logger.Log("Executing here.. constructor based dependency injection");
        }
    }
}
