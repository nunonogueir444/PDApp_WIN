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

        readonly string appVersion = "v0.3 testing";

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
                "0 - CC",
                "1 - CS",
                "2 - Mid",
                "3 - Acu",
            });

        //#############################################################################################

        }

        //############################################################################################

        private void Button_Run_Click(object sender, EventArgs e)
        {
            ButtonRun.FuncButtonRun();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Process.GetCurrentProcess().ProcessName);
            Environment.Exit(0);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDApp " + appVersion + "\n\n@Nuno Nogueira", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button_Run_MouseEnter(object sender, EventArgs e)
        {
            Button_Run.BackColor = Color.FromArgb(38, 38, 38);
        }

        private void Button_Run_MouseLeave(object sender, EventArgs e)
        {
            Button_Run.BackColor = Color.FromArgb(64, 64, 64);
        }

        //#############################################################################################

    }
}
