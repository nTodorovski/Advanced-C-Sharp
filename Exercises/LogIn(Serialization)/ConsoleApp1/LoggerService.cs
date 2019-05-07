using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoggerService
    {
        public void Log(string username, string password, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"Time: {DateTime.Now.ToLocalTime()}");
                sw.WriteLine($"User: {username}");
                sw.WriteLine("-----------------------------------------------");
            }
        }
    }
}
