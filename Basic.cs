using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
  
    public class Basic
    {
        public delegate int WorkSuma(int a, int b);

        public Basic()
        {
            WorkSuma workSuma = new WorkSuma(Suma);
            WorkSuma workSuma2 = new WorkSuma(Suma2);
            WorkSuma workSuma3 = new WorkSuma(Suma3);
            workSuma += workSuma2 + workSuma3;
            Console.WriteLine(workSuma(1, 2));
        }
        private static int Suma(int a, int b)
        {
            Console.WriteLine("Suma");
            return a + b;
        }

        private static int Suma2(int a, int b)
        {
            Console.WriteLine("Suma2");
            return a + b + 1;
        }

        private static int Suma3(int a, int b)
        {
            Console.WriteLine("Suma3");
            return a + b + 2;
        }
    }
}
