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

        private static string? filePath;

        public int MachineIndex { get; set; }

        public void FuncButtonRun()
        {
            string arg1 = TextBox_MachineSerial.Text;
            string arg2 = MachineIndex.ToString();
            string arg3 = ComboBox_Antenna.Text;
            string arg4 = ComboBox_BatteryType.Text;

            string specifiedPath = "G:\\GitHub_nunonogueir444\\PDApp_TERM\\PDApp_TERM\\bin\\Debug\\net8.0\\PDApp_TERM.exe";
            string additionalPath = "C:\\aaa\\bbb\\ccc\\ddd\\PDApp_TERM.exe";
            string rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PDApp_TERM.exe");

            if (string.IsNullOrEmpty(filePath))
            {
                if (File.Exists(specifiedPath))
                {
                    filePath = specifiedPath;
                }
                else if (File.Exists(additionalPath))
                {
                    filePath = additionalPath;
                }
                else if (File.Exists(rootPath))
                {
                    filePath = rootPath;
                }
                else
                {
                    while (true)
                    {
                        using OpenFileDialog openFileDialog = new OpenFileDialog
                        {
                            InitialDirectory = AppDomain.CurrentDomain.BaseDirectory,
                            Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*",
                            FilterIndex = 1,
                            RestoreDirectory = true,
                            Title = "Select PDApp_TERM.exe"
                        };

                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (Path.GetFileName(openFileDialog.FileName) == "PDApp_TERM.exe")
                            {
                                filePath = openFileDialog.FileName;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Please select a file named PDApp_TERM.exe.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            Label_OutputArgs.Text = "File selection was canceled.";
                            return;
                        }
                    }
                }
            }

            ProcessStartInfo startInfo = new()
            {
                FileName = filePath,
                Arguments = $"\"{arg1}\" \"{arg2}\" \"{arg3}\" \"{arg4}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process? process = Process.Start(startInfo);
            if (process != null)
            {
                using StreamReader reader = process.StandardOutput;
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
