using System.Diagnostics;

namespace PDApp_WIN
{
    public partial class FormPDApp_WIN : Form
    {
        //#############################################################################################

        readonly string appVersion = "v0.3 testing";

        public int MachineIndex = 0;

        private readonly ClassSysTime SysTime;
        private readonly ClassButtonRun ButtonRun;

        //#############################################################################################

        public FormPDApp_WIN()
        {
            InitializeComponent();

            //#############################################################################################

            SysTime = new ClassSysTime(Label_SysTime);
            SysTime.Start();

            //*********************************************************************

            ButtonRun = new ClassButtonRun(TextBox_MachineSerial, ComboBox_Antenna, ComboBox_BatteryType, Label_OutputArgs);

            //*********************************************************************

            ComboBox_MachineModel.Items.AddRange(new object[] {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f"
            });

            ComboBox_Antenna.Items.AddRange(new object[] {
                "Yes",
                "No"
            });

            ComboBox_BatteryType.Items.AddRange(new object[] {
                "CC",
                "CS",
                "Mid",
                "Acu",
            });

            //#############################################################################################

        }

        //############################################################################################

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PDApp " + appVersion + "\n\n@Nuno Nogueira", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Process.GetCurrentProcess().ProcessName);
            Environment.Exit(0);
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            ButtonRun.MachineIndex = MachineIndex;
            ButtonRun.FuncButtonRun();
        }

        private void ComboBox_MachineModel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboBox_MachineModel.Text == "a")
            {
                MachineIndex = 1000;
            }
            else if (ComboBox_MachineModel.Text == "b")
            {
                MachineIndex = 2000;
            }
            else if (ComboBox_MachineModel.Text == "c")
            {
                MachineIndex = 3000;
            }
            else if (ComboBox_MachineModel.Text == "d")
            {
                MachineIndex = 4000;
            }
            else if (ComboBox_MachineModel.Text == "e")
            {
                MachineIndex = 5000;
            }
            else if (ComboBox_MachineModel.Text == "f")
            {
                MachineIndex = 6000;
            }
        }

        //############################################################################################

    }
}
