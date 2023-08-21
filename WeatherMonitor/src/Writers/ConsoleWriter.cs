using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.src.Writers
{
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string data)
        {
            Console.WriteLine(data);
        }
    }
}
