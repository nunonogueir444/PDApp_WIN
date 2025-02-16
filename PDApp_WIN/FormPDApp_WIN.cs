using System.Diagnostics;

namespace PDApp_WIN
{
    public partial class FormPDApp_WIN : Form
    {
        //#############################################################################################

        readonly string appVersion = "v0.3 testing";

        public int TruckIndex = 0;

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
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "h",
                "i",
                "j",
                "k",
                "l",
                "m",
                "n",
                "o",
                "p",
                "q"
            });

            comboBox_Telematics.Items.AddRange(new object[] {
                "Yes",
                "No"
            });

            comboBox_BatteryType.Items.AddRange(new object[] {
                "CC",
                "CS",
                "Mid",
                "Acu",
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
            ButtonRun.TruckIndex = TruckIndex;
            ButtonRun.FuncButtonRun();
        }

        private void comboBox_TruckModel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_TruckModel.Text == "a")
            {
                TruckIndex = 1000;
            }
            else if (comboBox_TruckModel.Text == "b")
            {
                TruckIndex = 2000;
            }
            else if (comboBox_TruckModel.Text == "c")
            {
                TruckIndex = 3000;
            }
            else if (comboBox_TruckModel.Text == "d")
            {
                TruckIndex = 4000;
            }
            else if (comboBox_TruckModel.Text == "e")
            {
                TruckIndex = 5000;
            }
            else if (comboBox_TruckModel.Text == "f")
            {
                TruckIndex = 6000;
            }
            else if (comboBox_TruckModel.Text == "g")
            {
                TruckIndex = 7000;
            }
            else if (comboBox_TruckModel.Text == "h")
            {
                TruckIndex = 8000;
            }
            else if (comboBox_TruckModel.Text == "i")
            {
                TruckIndex = 9000;
            }
            else if (comboBox_TruckModel.Text == "j")
            {
                TruckIndex = 10000;
            }
            else if (comboBox_TruckModel.Text == "k")
            {
                TruckIndex = 11000;
            }
            else if (comboBox_TruckModel.Text == "l")
            {
                TruckIndex = 12000;
            }
            else if (comboBox_TruckModel.Text == "m")
            {
                TruckIndex = 13000;
            }
            else if (comboBox_TruckModel.Text == "n")
            {
                TruckIndex = 14000;
            }
            else if (comboBox_TruckModel.Text == "o")
            {
                TruckIndex = 15000;
            }
            else if (comboBox_TruckModel.Text == "p")
            {
                TruckIndex = 16000;
            }
            else if (comboBox_TruckModel.Text == "q")
            {
                TruckIndex = 17000;
            }
        }


        //############################################################################################

    }
}
