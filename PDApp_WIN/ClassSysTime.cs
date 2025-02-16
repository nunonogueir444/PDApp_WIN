using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************************************
using Timer = System.Windows.Forms.Timer;
//*********************************************************************

namespace PDApp_WIN
{
    class ClassSysTime
    {
        private readonly Timer Label_SysTime;
        private readonly Label Label_OutputArgs;

        public ClassSysTime(Label Label_OutputArgs)
        {
            Label_OutputArgs.Text = DateTime.Now.ToString("HH:mm:ss");

            this.Label_OutputArgs = Label_OutputArgs;
            Label_SysTime = new Timer
            {
                Interval = 1000
            };
            Label_SysTime.Tick += Timer_Tick;
        }

        public void Start()
        {
            Label_SysTime.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Label_OutputArgs.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
