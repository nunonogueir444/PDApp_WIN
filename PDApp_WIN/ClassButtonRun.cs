using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDApp_WIN
{
    class ClassButtonRun
    {
        private readonly TextBox textBox_Serial;
        private readonly ComboBox comboBox_Model;
        private readonly ComboBox comboBox_Telematics;
        private readonly ComboBox comboBox_BatteryType;
        private readonly Label label_OutputArgs;

        public ClassButtonRun(TextBox textBox_Serial, ComboBox comboBox_Model, ComboBox comboBox_Telematics, ComboBox comboBox_BatteryType, Label label_OutputArgs)
        {
            this.textBox_Serial = textBox_Serial;
            this.comboBox_Model = comboBox_Model;
            this.comboBox_Telematics = comboBox_Telematics;
            this.comboBox_BatteryType = comboBox_BatteryType;
            this.label_OutputArgs = label_OutputArgs;
        }

        public void FuncButtonRun()
        {
            string arg1 = textBox_Serial.Text;
            string arg2 = comboBox_Model.Text;
            string arg3 = comboBox_Telematics.Text;
            string arg4 = comboBox_BatteryType.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "G:\\GitHub_nunonogueir444\\PDApp_TERM\\PDApp_TERM\\bin\\Debug\\PDApp_TERM.exe",
                Arguments = $"\"{arg1}\" \"{arg2}\" \"{arg3}\" \"{arg4}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process? process = Process.Start(startInfo))
            {
                if (process != null)
                {
                    using (System.IO.StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        label_OutputArgs.Text = result;
                    }
                }
                else
                {
                    label_OutputArgs.Text = "Failed to start process.";
                }
            }
        }
    }
}
