using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMonitor.src.Writers
{
    public interface IWriter
    {
        public void WriteLine(string data);
    }
}
