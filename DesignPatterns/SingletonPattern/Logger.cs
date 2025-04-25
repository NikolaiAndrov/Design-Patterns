namespace SingletonPattern
{
    public sealed class Logger
    {
        private static Logger? instance;
        private static readonly object padlock = new();
        private List<string> logs = new();

        private Logger()
        {
            
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)      
                        {
                            instance = new Logger();
                        }
                    }
                }

                return instance;
            }
        }

        public void Log(string message)
        {
            this.logs.Add($"Date: {DateTime.Now} Message: {message}");
        }

        public string GetLogs()
        {
            return string.Join(Environment.NewLine, this.logs);
        }
    }
}
