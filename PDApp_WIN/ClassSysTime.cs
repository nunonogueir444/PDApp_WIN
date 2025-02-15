using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************************************************
using System.Windows.Forms;
//*********************************************************************

namespace PDApp_WIN
{
    class ClassSysTime
    {
        private readonly Timer timer;
        private readonly Label label;

        public ClassSysTime(Label label)
        {
            label.Text = DateTime.Now.ToString("HH:mm:ss");

            this.label = label;
            timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += Timer_Tick;
        }

        public void Start()
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
