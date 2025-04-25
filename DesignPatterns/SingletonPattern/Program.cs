namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            Logger loggerNew = Logger.Instance;
            logger.Log("Testing");
            logger.Log("Log Event");
            loggerNew.Log("Third Event");

            Console.WriteLine(logger.GetLogs());
        }
    }
}
