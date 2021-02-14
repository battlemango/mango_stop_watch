using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoStopWatch
{
    class StopWatchManager
    {
        private Stopwatch mStopWatch;

        public StopWatchManager()
        {
            mStopWatch = new Stopwatch();
        }

        public void start()
        {
            mStopWatch.Start();
        }

        public void stop()
        {
            mStopWatch.Stop();
            Console.WriteLine(mStopWatch.ElapsedMilliseconds);
        }

        public void reset()
        {
            mStopWatch.Reset();
        }

        public string getText()
        {

            //mStopWatch.ElapsedMilliseconds.
            return mStopWatch.ElapsedMilliseconds.ToString();
        }
    

    }
}
