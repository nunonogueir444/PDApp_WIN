using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_WIN
{
    class ClassButtonRun(TextBox TextBox_MachineSerial, ComboBox ComboBox_Antenna, ComboBox ComboBox_BatteryType, Label Label_OutputArgs)
    {
        private readonly TextBox TextBox_MachineSerial = TextBox_MachineSerial;
        private readonly ComboBox ComboBox_Antenna = ComboBox_Antenna;
        private readonly ComboBox ComboBox_BatteryType = ComboBox_BatteryType;
        private readonly Label Label_OutputArgs = Label_OutputArgs;

        public int MachineIndex { get; set; }

        public void FuncButtonRun()
        {
            string arg1 = TextBox_MachineSerial.Text;
            string arg2 = MachineIndex.ToString();
            string arg3 = ComboBox_Antenna.Text;
            string arg4 = ComboBox_BatteryType.Text;

            ProcessStartInfo startInfo = new()
            {
                FileName = "G:\\GitHub_nunonogueir444\\PDApp_TERM\\PDApp_TERM\\bin\\Debug\\net8.0\\PDApp_TERM.exe",
                Arguments = $"\"{arg1}\" \"{arg2}\" \"{arg3}\" \"{arg4}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process? process = Process.Start(startInfo);
            if (process != null)
            {
                using System.IO.StreamReader reader = process.StandardOutput;
                string result = reader.ReadToEnd();
                Label_OutputArgs.Text = result;
            }
            else
            {
                Label_OutputArgs.Text = "Failed to start process.";
            }
        }
    }
}
