using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPattern;
using System.IO;
namespace CreationalPattern
{
    public class FileLogger : ILogger
    {
        private static FileLogger instance;
        private StreamWriter fs;
        private string fileName;
        public static FileLogger Instanse
        {
            get
            {
                if (instance == null)
                    instance = new FileLogger();
                return instance;
            }
        }
        public static FileLogger getInstance()
        {
            if (instance == null)
                instance = new FileLogger();
            return instance;
        }
        private FileLogger()
        {
            fileName = "log.log";
            //fs = new StreamWriter(fileName);
        }
        public void SetFileLogger(string fileName)
        {
            this.fileName = fileName;
        }
        public void Debug(string message)
        {
            Write("Debug", message);
        }

        public void Error(string message)
        {
            Write("Error", message);

        }

        public void Fail(string message)
        {
            Write("Fail", message);

        }

        public void Info(string message)
        {
            Write("Info", message);
        }

        public void Warning(string message)
        {
            Write("Warning", message);

        }
        private void Write(string lvl, string msg)
        {
            try
            {
                if (fileName != "" || fileName != null)
                {
                    using (fs = new StreamWriter(fileName, true))
                    {

                        fs.WriteLine("{0} {1}: {2} : {3}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), lvl, msg);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
