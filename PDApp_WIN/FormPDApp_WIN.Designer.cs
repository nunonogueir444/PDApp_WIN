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
            textBox_TruckSerial = new TextBox();
            comboBox_TruckModel = new ComboBox();
            comboBox_Telematics = new ComboBox();
            comboBox_BatteryType = new ComboBox();
            label_TruckSerial = new Label();
            label_Model = new Label();
            label_Telematics = new Label();
            label_BatteryType = new Label();
            label_SysTime = new Label();
            label_OutputArgs = new Label();
            button_Run = new Button();
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
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(168, 34);
            quitToolStripMenuItem.Text = "Exit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
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
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // textBox_TruckSerial
            // 
            textBox_TruckSerial.Location = new Point(28, 152);
            textBox_TruckSerial.Name = "textBox_TruckSerial";
            textBox_TruckSerial.Size = new Size(150, 31);
            textBox_TruckSerial.TabIndex = 1;
            // 
            // comboBox_TruckModel
            // 
            comboBox_TruckModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TruckModel.FormattingEnabled = true;
            comboBox_TruckModel.Location = new Point(232, 152);
            comboBox_TruckModel.Name = "comboBox_TruckModel";
            comboBox_TruckModel.Size = new Size(182, 33);
            comboBox_TruckModel.TabIndex = 2;
            // 
            // comboBox_Telematics
            // 
            comboBox_Telematics.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Telematics.FormattingEnabled = true;
            comboBox_Telematics.Location = new Point(450, 152);
            comboBox_Telematics.Name = "comboBox_Telematics";
            comboBox_Telematics.Size = new Size(96, 33);
            comboBox_Telematics.TabIndex = 3;
            // 
            // comboBox_BatteryType
            // 
            comboBox_BatteryType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_BatteryType.FormattingEnabled = true;
            comboBox_BatteryType.Location = new Point(603, 152);
            comboBox_BatteryType.Name = "comboBox_BatteryType";
            comboBox_BatteryType.Size = new Size(182, 33);
            comboBox_BatteryType.TabIndex = 4;
            // 
            // label_TruckSerial
            // 
            label_TruckSerial.AutoSize = true;
            label_TruckSerial.Location = new Point(28, 124);
            label_TruckSerial.Name = "label_TruckSerial";
            label_TruckSerial.Size = new Size(103, 25);
            label_TruckSerial.TabIndex = 5;
            label_TruckSerial.Text = "Truck Serial:";
            // 
            // label_Model
            // 
            label_Model.AutoSize = true;
            label_Model.Location = new Point(232, 124);
            label_Model.Name = "label_Model";
            label_Model.Size = new Size(112, 25);
            label_Model.TabIndex = 6;
            label_Model.Text = "Truck Model:";
            // 
            // label_Telematics
            // 
            label_Telematics.AutoSize = true;
            label_Telematics.Location = new Point(450, 124);
            label_Telematics.Name = "label_Telematics";
            label_Telematics.Size = new Size(96, 25);
            label_Telematics.TabIndex = 7;
            label_Telematics.Text = "Telematics:";
            // 
            // label_BatteryType
            // 
            label_BatteryType.AutoSize = true;
            label_BatteryType.Location = new Point(603, 124);
            label_BatteryType.Name = "label_BatteryType";
            label_BatteryType.Size = new Size(113, 25);
            label_BatteryType.TabIndex = 8;
            label_BatteryType.Text = "Battery Type:";
            // 
            // label_SysTime
            // 
            label_SysTime.AutoSize = true;
            label_SysTime.Location = new Point(687, 48);
            label_SysTime.Name = "label_SysTime";
            label_SysTime.Size = new Size(120, 25);
            label_SysTime.TabIndex = 9;
            label_SysTime.Text = "label_SysTime";
            // 
            // label_OutputArgs
            // 
            label_OutputArgs.AutoSize = true;
            label_OutputArgs.Location = new Point(25, 483);
            label_OutputArgs.Name = "label_OutputArgs";
            label_OutputArgs.Size = new Size(150, 25);
            label_OutputArgs.TabIndex = 10;
            label_OutputArgs.Text = "label_OutputArgs";
            // 
            // button_Run
            // 
            button_Run.Location = new Point(331, 305);
            button_Run.Name = "button_Run";
            button_Run.Size = new Size(146, 80);
            button_Run.TabIndex = 11;
            button_Run.Text = "Run";
            button_Run.UseVisualStyleBackColor = true;
            button_Run.Click += button_Run_Click;
            // 
            // FormPDApp_WIN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 542);
            Controls.Add(button_Run);
            Controls.Add(label_OutputArgs);
            Controls.Add(label_SysTime);
            Controls.Add(label_BatteryType);
            Controls.Add(label_Telematics);
            Controls.Add(label_Model);
            Controls.Add(label_TruckSerial);
            Controls.Add(comboBox_BatteryType);
            Controls.Add(comboBox_Telematics);
            Controls.Add(comboBox_TruckModel);
            Controls.Add(textBox_TruckSerial);
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
        private TextBox textBox_TruckSerial;
        private ComboBox comboBox_TruckModel;
        private ComboBox comboBox_Telematics;
        private ComboBox comboBox_BatteryType;
        private Label label_TruckSerial;
        private Label label_Model;
        private Label label_Telematics;
        private Label label_BatteryType;
        private Label label_SysTime;
        private Label label_OutputArgs;
        private Button button_Run;
    }
}
