using System.Diagnostics;

namespace PDApp_WIN
{
    public partial class FormPDApp_WIN : Form
    {
        //#############################################################################################

        readonly string appVersion = "v0.3 testing";

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

            ButtonRun = new ClassButtonRun(textBox_TruckSerial, comboBox_TruckModel, comboBox_Telematics, comboBox_BatteryType, label_OutputArgs);

            //*********************************************************************

            comboBox_TruckModel.Items.AddRange(new object[] {
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDApp " + appVersion + "\n\n@Nuno Nogueira", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Process.GetCurrentProcess().ProcessName);
            Environment.Exit(0);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            ButtonRun.FuncButtonRun();
        }


        //############################################################################################

    }
}
