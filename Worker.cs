using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class WorkerRun
    {
        public WorkerRun()
        {
            Worker wrk = new Worker();
            wrk.WorkPerformed += Wrk_WorkPerformed;       
            wrk.WorkCompleted += Wrk_WorkCompleted;
            wrk.DoWork(10);
        }

        private void Wrk_WorkPerformed(object sender, WorkSumaArgs e)
        {
            Console.WriteLine($"Suma entre {e.A} {e.B}");
        }

        private void Wrk_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("It's done.");
        }
    }
    // public delegate int WorkSuma(object sender,WorkSumaArgs e);
    public class Worker
    {
        //public event WorkSuma WorkPerformed;
        public event EventHandler<WorkSumaArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int num)
        {
            for (int i = 1; i < 15; i++)
            {
                OnWorkPerformed(num, i);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int a, int b)
        {
            var del = WorkPerformed as EventHandler<WorkSumaArgs>;
            if (del != null)
            {
                del(this, new WorkSumaArgs(a, b));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var wrk = WorkCompleted as EventHandler;
            if (wrk != null)
            {
                wrk(this, EventArgs.Empty);
            }
        }
    }
}
