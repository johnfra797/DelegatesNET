using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Program
    {
        public delegate void Work();
        public static void Main(string[] args)
        {
            Work wrk = new Work(worker);
            wrk();
            Console.ReadKey();
        }
        private static void basic()
        {
            Basic basic = new Basic();
        }
        private static void worker()
        {
            WorkerRun wrkRun = new WorkerRun();
        }
    }
}
