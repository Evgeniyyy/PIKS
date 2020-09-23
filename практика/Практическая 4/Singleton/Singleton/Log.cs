using System;
using System.IO;

namespace Singleton
{
    class Log
    {
        Log() { }
        static Lazy<Log> myLog = new Lazy<Log>(() => new Log());

        public static Log MyLog
        {
            get
            {
                return myLog.Value;
            }
        }

        public void LogExecution(string mes)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Loger(mes, w);
                w.Close();
            }
        }

        public static void Loger(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("Action: {0}", logMessage);
            w.WriteLine("------------------------");
        }

        
    }
}
