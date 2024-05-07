namespace DependencyInjection
{
    internal class SetterInject
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private ILogger _logger;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        // Property
        public ILogger Logger
        {
            set { _logger = value; }
        }

        public void Executor()
        {
            _logger.Log("Executing here.. property setter based dependency injection");
        }
    }
}
