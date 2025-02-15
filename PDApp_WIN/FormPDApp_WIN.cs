using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PDApp_WIN
{
    public partial class FormPDApp_WIN: Form
    {
        //#############################################################################################

        private readonly ClassSysTime SysTime;
        private readonly ClassButtonRun ButtonRun;

        //#############################################################################################
        public FormPDApp_WIN()
        {
            InitializeComponent();

            //#############################################################################################

            SysTime = new ClassSysTime(label_SysTime);
            SysTime.Start();

            //*********************************************************************

            ButtonRun = new ClassButtonRun(textBox_Serial, comboBox_Model, comboBox_Telematics, comboBox_BatteryType, label_OutputArgs);
            
            //*********************************************************************

            comboBox_Model.Items.AddRange(new object[] {
                "aaaaaaaaaa",
                "bbbbbbbbbb",
                "cccccccccc",
                "dddddddddd",
                "eeeeeeeeee",
                "ffffffffff",
                "gggggggggg"
            });

            comboBox_Telematics.Items.AddRange(new object[] {
                "Yes",
                "No"
            });

            comboBox_BatteryType.Items.AddRange(new object[] {
                "0 - C",
                "1 - CS",
                "2 - M",
                "3 - A",
            });

        //#############################################################################################

        }

        //############################################################################################

        private void Button_Run_Click(object sender, EventArgs e)
        {
            ButtonRun.FuncButtonRun();
        }

        //#############################################################################################

    }
}
