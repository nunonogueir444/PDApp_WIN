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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

        //#############################################################################################

            comboBox1.Items.AddRange(new object[] {
                "aaaaaaaaaa",
                "bbbbbbbbbb",
                "cccccccccc",
                "dddddddddd",
                "eeeeeeeeee",
                "ffffffffff",
                "gggggggggg"
            });

            comboBox2.Items.AddRange(new object[] {
                "Yes",
                "No"
            });

            comboBox3.Items.AddRange(new object[] {
                "0 - C",
                "1 - CS",
                "2 - M",
                "3 - A",
            });

        //#############################################################################################

        }

        //#############################################################################################

        private void button1_Click(object sender, EventArgs e)
        {
            string arg1 = textBox1.Text;
            string arg2 = comboBox1.Text;
            string arg3 = comboBox2.Text;
            string arg4 = comboBox3.Text;

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "G:\\GitHub_nunonogueir444\\PDApp_TERM\\PDApp_TERM\\bin\\Debug\\PDApp_TERM.exe",
                Arguments = $"\"{arg1}\" \"{arg2}\" \"{arg3}\" \"{arg4}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                using (System.IO.StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    label1.Text = result;
                }
            }
        }

    //#############################################################################################

    }
}
