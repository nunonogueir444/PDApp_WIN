namespace PDApp_WIN
{
    partial class FormPDApp_WIN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            TextBox_MachineSerial = new TextBox();
            ComboBox_MachineModel = new ComboBox();
            ComboBox_Antenna = new ComboBox();
            ComboBox_BatteryType = new ComboBox();
            label_MachineSerial = new Label();
            label_MachineModel = new Label();
            label_Antenna = new Label();
            label_BatteryType = new Label();
            Label_SysTime = new Label();
            Label_OutputArgs = new Label();
            Button_Run = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartToolStripMenuItem, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(168, 34);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += RestartToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(168, 34);
            quitToolStripMenuItem.Text = "Exit";
            quitToolStripMenuItem.Click += QuitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(164, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // TextBox_MachineSerial
            // 
            TextBox_MachineSerial.Location = new Point(12, 120);
            TextBox_MachineSerial.Name = "TextBox_MachineSerial";
            TextBox_MachineSerial.Size = new Size(150, 31);
            TextBox_MachineSerial.TabIndex = 1;
            // 
            // ComboBox_MachineModel
            // 
            ComboBox_MachineModel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_MachineModel.FormattingEnabled = true;
            ComboBox_MachineModel.Location = new Point(216, 120);
            ComboBox_MachineModel.Name = "ComboBox_MachineModel";
            ComboBox_MachineModel.Size = new Size(182, 33);
            ComboBox_MachineModel.TabIndex = 2;
            ComboBox_MachineModel.SelectedValueChanged += ComboBox_MachineModel_SelectedValueChanged;
            // 
            // ComboBox_Antenna
            // 
            ComboBox_Antenna.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_Antenna.FormattingEnabled = true;
            ComboBox_Antenna.Location = new Point(434, 120);
            ComboBox_Antenna.Name = "ComboBox_Antenna";
            ComboBox_Antenna.Size = new Size(96, 33);
            ComboBox_Antenna.TabIndex = 3;
            // 
            // ComboBox_BatteryType
            // 
            ComboBox_BatteryType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_BatteryType.FormattingEnabled = true;
            ComboBox_BatteryType.Location = new Point(587, 120);
            ComboBox_BatteryType.Name = "ComboBox_BatteryType";
            ComboBox_BatteryType.Size = new Size(182, 33);
            ComboBox_BatteryType.TabIndex = 4;
            // 
            // label_MachineSerial
            // 
            label_MachineSerial.AutoSize = true;
            label_MachineSerial.Location = new Point(12, 92);
            label_MachineSerial.Name = "label_MachineSerial";
            label_MachineSerial.Size = new Size(129, 25);
            label_MachineSerial.TabIndex = 5;
            label_MachineSerial.Text = "Machine Serial:";
            // 
            // label_MachineModel
            // 
            label_MachineModel.AutoSize = true;
            label_MachineModel.Location = new Point(216, 92);
            label_MachineModel.Name = "label_MachineModel";
            label_MachineModel.Size = new Size(138, 25);
            label_MachineModel.TabIndex = 6;
            label_MachineModel.Text = "Machine Model:";
            // 
            // label_Antenna
            // 
            label_Antenna.AutoSize = true;
            label_Antenna.Location = new Point(434, 92);
            label_Antenna.Name = "label_Antenna";
            label_Antenna.Size = new Size(82, 25);
            label_Antenna.TabIndex = 7;
            label_Antenna.Text = "Antenna:";
            // 
            // label_BatteryType
            // 
            label_BatteryType.AutoSize = true;
            label_BatteryType.Location = new Point(587, 92);
            label_BatteryType.Name = "label_BatteryType";
            label_BatteryType.Size = new Size(113, 25);
            label_BatteryType.TabIndex = 8;
            label_BatteryType.Text = "Battery Type:";
            // 
            // Label_SysTime
            // 
            Label_SysTime.AutoSize = true;
            Label_SysTime.Location = new Point(721, 46);
            Label_SysTime.Name = "Label_SysTime";
            Label_SysTime.Size = new Size(124, 25);
            Label_SysTime.TabIndex = 9;
            Label_SysTime.Text = "Label_SysTime";
            // 
            // Label_OutputArgs
            // 
            Label_OutputArgs.AutoSize = true;
            Label_OutputArgs.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label_OutputArgs.Location = new Point(12, 175);
            Label_OutputArgs.Name = "Label_OutputArgs";
            Label_OutputArgs.Size = new Size(170, 22);
            Label_OutputArgs.TabIndex = 10;
            Label_OutputArgs.Text = "Label_OutputArgs";
            // 
            // Button_Run
            // 
            Button_Run.Location = new Point(565, 243);
            Button_Run.Name = "Button_Run";
            Button_Run.Size = new Size(150, 79);
            Button_Run.TabIndex = 11;
            Button_Run.Text = "Run";
            Button_Run.UseVisualStyleBackColor = true;
            Button_Run.Click += Button_Run_Click;
            // 
            // FormPDApp_WIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 628);
            Controls.Add(Button_Run);
            Controls.Add(Label_OutputArgs);
            Controls.Add(Label_SysTime);
            Controls.Add(label_BatteryType);
            Controls.Add(label_Antenna);
            Controls.Add(label_MachineModel);
            Controls.Add(label_MachineSerial);
            Controls.Add(ComboBox_BatteryType);
            Controls.Add(ComboBox_Antenna);
            Controls.Add(ComboBox_MachineModel);
            Controls.Add(TextBox_MachineSerial);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPDApp_WIN";
            Text = "PDApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox TextBox_MachineSerial;
        private ComboBox ComboBox_MachineModel;
        private ComboBox ComboBox_Antenna;
        private ComboBox ComboBox_BatteryType;
        private Label label_MachineSerial;
        private Label label_MachineModel;
        private Label label_Antenna;
        private Label label_BatteryType;
        private Label Label_SysTime;
        private Label Label_OutputArgs;
        private Button Button_Run;
    }
}
