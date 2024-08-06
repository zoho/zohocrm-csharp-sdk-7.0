using System.Diagnostics;

namespace Com.Zoho.Crm.API.Logger
{
    /// <summary>
    /// This class represents the Logger level and log file path.
    /// </summary>
    public class Logger
    {
        public class Builder
        {
            private Levels level;
            private string filePath;
            public Builder Level(Levels level)
            {
                this.level = level;
                return this;
            }

            public Builder FilePath(string filePath)
            {
                this.filePath = filePath;
                return this;
            }

            public Logger Build()
            {
                return new Logger(this.level, this.filePath);
            }
        }

        private int level;
        private string filePath;

        /// <summary>
        /// Creates an Logger class instance with the specified log level and file path.
        /// </summary>
        /// <param name="level">A enum containing the log level.</param>
        /// <param name="filePath">A String containing the log file path.</param>
        /// <returns></returns>
        private Logger(Levels level, string filePath)
        {
            this.level = (int)level;
            this.filePath = filePath;
        }

        /// <summary>
        /// This is a getter method to get logger level.
        /// </summary>
        /// <returns>A String representing the logger level.</returns>
        public int Level
        {
            get
            {
                return level;
            }
        }

        /// <summary>
        /// This is a getter method to get log file path.
        /// </summary>
        /// <returns>A String representing the Absolute file path, where messages need to be logged.</returns>
        public string FilePath
        {
            get
            {
                return filePath;
            }
        }

        /// <summary>
        /// This enum used to give logger levels.
        /// </summary>
        public enum Levels
        {
            ALL = TraceLevel.Verbose,
            INFO = TraceLevel.Info,
            WARNING = TraceLevel.Warning,
            ERROR = TraceLevel.Error,
            OFF = TraceLevel.Off
        }
    }
}