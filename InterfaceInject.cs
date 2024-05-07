using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface ILoggerSetter
    {
        void SetLogger(ILogger logger);
    }

    internal class InterfaceInject : ILoggerSetter
    {
        private ILogger? _logger;

        public void SetLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Executor()
        {
            _logger.Log("Executing here.. interface based dependency injection");
        }
    }   
}
