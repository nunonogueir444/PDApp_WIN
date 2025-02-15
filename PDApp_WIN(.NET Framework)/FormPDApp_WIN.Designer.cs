namespace PDApp_WIN
{
    partial class FormPDApp_WIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Serial = new System.Windows.Forms.TextBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.label_OutputArgs = new System.Windows.Forms.Label();
            this.label_Serial = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_Telematics = new System.Windows.Forms.Label();
            this.label_BatteryType = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_Telematics = new System.Windows.Forms.ComboBox();
            this.comboBox_BatteryType = new System.Windows.Forms.ComboBox();
            this.label_SysTime = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Serial
            // 
            this.textBox_Serial.Location = new System.Drawing.Point(16, 155);
            this.textBox_Serial.Name = "textBox_Serial";
            this.textBox_Serial.Size = new System.Drawing.Size(139, 26);
            this.textBox_Serial.TabIndex = 0;
            // 
            // Button_Run
            // 
            this.Button_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Run.Location = new System.Drawing.Point(295, 243);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(162, 115);
            this.Button_Run.TabIndex = 4;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = false;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            this.Button_Run.MouseEnter += new System.EventHandler(this.Button_Run_MouseEnter);
            this.Button_Run.MouseLeave += new System.EventHandler(this.Button_Run_MouseLeave);
            // 
            // label_OutputArgs
            // 
            this.label_OutputArgs.AutoSize = true;
            this.label_OutputArgs.Location = new System.Drawing.Point(12, 404);
            this.label_OutputArgs.Name = "label_OutputArgs";
            this.label_OutputArgs.Size = new System.Drawing.Size(95, 20);
            this.label_OutputArgs.TabIndex = 5;
            this.label_OutputArgs.Text = "Output Args";
            // 
            // label_Serial
            // 
            this.label_Serial.AutoSize = true;
            this.label_Serial.Location = new System.Drawing.Point(12, 132);
            this.label_Serial.Name = "label_Serial";
            this.label_Serial.Size = new System.Drawing.Size(53, 20);
            this.label_Serial.TabIndex = 6;
            this.label_Serial.Text = "Serial:";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Location = new System.Drawing.Point(188, 132);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(56, 20);
            this.label_Model.TabIndex = 7;
            this.label_Model.Text = "Model:";
            // 
            // label_Telematics
            // 
            this.label_Telematics.AutoSize = true;
            this.label_Telematics.Location = new System.Drawing.Point(417, 132);
            this.label_Telematics.Name = "label_Telematics";
            this.label_Telematics.Size = new System.Drawing.Size(85, 20);
            this.label_Telematics.TabIndex = 8;
            this.label_Telematics.Text = "Telematics";
            // 
            // label_BatteryType
            // 
            this.label_BatteryType.AutoSize = true;
            this.label_BatteryType.Location = new System.Drawing.Point(564, 132);
            this.label_BatteryType.Name = "label_BatteryType";
            this.label_BatteryType.Size = new System.Drawing.Size(102, 20);
            this.label_BatteryType.TabIndex = 9;
            this.label_BatteryType.Text = "Battery Type:";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(192, 155);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Model.TabIndex = 10;
            // 
            // comboBox_Telematics
            // 
            this.comboBox_Telematics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Telematics.FormattingEnabled = true;
            this.comboBox_Telematics.Location = new System.Drawing.Point(421, 155);
            this.comboBox_Telematics.Name = "comboBox_Telematics";
            this.comboBox_Telematics.Size = new System.Drawing.Size(81, 28);
            this.comboBox_Telematics.TabIndex = 11;
            // 
            // comboBox_BatteryType
            // 
            this.comboBox_BatteryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BatteryType.FormattingEnabled = true;
            this.comboBox_BatteryType.Location = new System.Drawing.Point(568, 155);
            this.comboBox_BatteryType.Name = "comboBox_BatteryType";
            this.comboBox_BatteryType.Size = new System.Drawing.Size(168, 28);
            this.comboBox_BatteryType.TabIndex = 12;
            // 
            // label_SysTime
            // 
            this.label_SysTime.AutoSize = true;
            this.label_SysTime.Location = new System.Drawing.Point(677, 53);
            this.label_SysTime.Name = "label_SysTime";
            this.label_SysTime.Size = new System.Drawing.Size(111, 20);
            this.label_SysTime.TabIndex = 13;
            this.label_SysTime.Text = "label_SysTime";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Silver;
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 33);
            this.MenuStrip1.TabIndex = 14;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartToolStripMenuItem,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // RestartToolStripMenuItem
            // 
            this.RestartToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.RestartToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
            this.RestartToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.RestartToolStripMenuItem.Text = "Restart";
            this.RestartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormPDApp_WIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_SysTime);
            this.Controls.Add(this.comboBox_BatteryType);
            this.Controls.Add(this.comboBox_Telematics);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label_BatteryType);
            this.Controls.Add(this.label_Telematics);
            this.Controls.Add(this.label_Model);
            this.Controls.Add(this.label_Serial);
            this.Controls.Add(this.label_OutputArgs);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.textBox_Serial);
            this.Controls.Add(this.MenuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "FormPDApp_WIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDApp";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Serial;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.Label label_OutputArgs;
        private System.Windows.Forms.Label label_Serial;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_Telematics;
        private System.Windows.Forms.Label label_BatteryType;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_Telematics;
        private System.Windows.Forms.ComboBox comboBox_BatteryType;
        private System.Windows.Forms.Label label_SysTime;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

