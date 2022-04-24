using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_OOP2
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya log yaz");
        }
    }
}
