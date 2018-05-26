using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DemoApp
{
    public static class TimerClass
    {
        public static DispatcherTimer timer = new DispatcherTimer();
        public static int counter { get; set; }
        public static void UpdateCount()
        {
            counter++;
        }
    }
}
