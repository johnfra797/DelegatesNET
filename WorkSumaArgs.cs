using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class WorkSumaArgs : EventArgs
    {
        public int A { get; set; }
        public int B { get; set; }
        public WorkSumaArgs(int a, int b)
        {
            A = a;
            B = b;
        }
    }
}
