namespace _07.Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class Timer
    {
        private int timeInterval;

        public delegate void TimerDlg();

        public TimerDlg SomeMethods { get; set; }

        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }

            private set
            {
                this.timeInterval = value;
            }
        }

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            for (int i = 0; i < 10; i++)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 100);
            }
        }
    }
}
