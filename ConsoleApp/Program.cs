using CommonUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static AppLogger _appLogger = AppLogger.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            _appLogger.Info($"Timestamp: {DateTime.Now}");
        }
    }
}
