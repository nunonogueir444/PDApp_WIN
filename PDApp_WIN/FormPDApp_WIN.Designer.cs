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
            this.button_Run = new System.Windows.Forms.Button();
            this.label_OutputArgs = new System.Windows.Forms.Label();
            this.label_Serial = new System.Windows.Forms.Label();
            this.label_Model = new System.Windows.Forms.Label();
            this.label_Telematics = new System.Windows.Forms.Label();
            this.label_BatteryType = new System.Windows.Forms.Label();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.comboBox_Telematics = new System.Windows.Forms.ComboBox();
            this.comboBox_BatteryType = new System.Windows.Forms.ComboBox();
            this.label_SysTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Serial
            // 
            this.textBox_Serial.Location = new System.Drawing.Point(21, 153);
            this.textBox_Serial.Name = "textBox_Serial";
            this.textBox_Serial.Size = new System.Drawing.Size(139, 26);
            this.textBox_Serial.TabIndex = 0;
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(296, 220);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(162, 115);
            this.button_Run.TabIndex = 4;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.Button_Run_Click);
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
            this.label_Serial.Location = new System.Drawing.Point(17, 127);
            this.label_Serial.Name = "label_Serial";
            this.label_Serial.Size = new System.Drawing.Size(53, 20);
            this.label_Serial.TabIndex = 6;
            this.label_Serial.Text = "Serial:";
            // 
            // label_Model
            // 
            this.label_Model.AutoSize = true;
            this.label_Model.Location = new System.Drawing.Point(188, 114);
            this.label_Model.Name = "label_Model";
            this.label_Model.Size = new System.Drawing.Size(56, 20);
            this.label_Model.TabIndex = 7;
            this.label_Model.Text = "Model:";
            // 
            // label_Telematics
            // 
            this.label_Telematics.AutoSize = true;
            this.label_Telematics.Location = new System.Drawing.Point(375, 114);
            this.label_Telematics.Name = "label_Telematics";
            this.label_Telematics.Size = new System.Drawing.Size(85, 20);
            this.label_Telematics.TabIndex = 8;
            this.label_Telematics.Text = "Telematics";
            // 
            // label_BatteryType
            // 
            this.label_BatteryType.AutoSize = true;
            this.label_BatteryType.Location = new System.Drawing.Point(586, 114);
            this.label_BatteryType.Name = "label_BatteryType";
            this.label_BatteryType.Size = new System.Drawing.Size(102, 20);
            this.label_BatteryType.TabIndex = 9;
            this.label_BatteryType.Text = "Battery Type:";
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(192, 150);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Model.TabIndex = 10;
            // 
            // comboBox_Telematics
            // 
            this.comboBox_Telematics.FormattingEnabled = true;
            this.comboBox_Telematics.Location = new System.Drawing.Point(379, 150);
            this.comboBox_Telematics.Name = "comboBox_Telematics";
            this.comboBox_Telematics.Size = new System.Drawing.Size(168, 28);
            this.comboBox_Telematics.TabIndex = 11;
            // 
            // comboBox_BatteryType
            // 
            this.comboBox_BatteryType.FormattingEnabled = true;
            this.comboBox_BatteryType.Location = new System.Drawing.Point(568, 153);
            this.comboBox_BatteryType.Name = "comboBox_BatteryType";
            this.comboBox_BatteryType.Size = new System.Drawing.Size(168, 28);
            this.comboBox_BatteryType.TabIndex = 12;
            // 
            // label_SysTime
            // 
            this.label_SysTime.AutoSize = true;
            this.label_SysTime.Location = new System.Drawing.Point(659, 35);
            this.label_SysTime.Name = "label_SysTime";
            this.label_SysTime.Size = new System.Drawing.Size(111, 20);
            this.label_SysTime.TabIndex = 13;
            this.label_SysTime.Text = "label_SysTime";
            // 
            // FormPDApp_WIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_SysTime);
            this.Controls.Add(this.comboBox_BatteryType);
            this.Controls.Add(this.comboBox_Telematics);
            this.Controls.Add(this.comboBox_Model);
            this.Controls.Add(this.label_BatteryType);
            this.Controls.Add(this.label_Telematics);
            this.Controls.Add(this.label_Model);
            this.Controls.Add(this.label_Serial);
            this.Controls.Add(this.label_OutputArgs);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.textBox_Serial);
            this.Name = "FormPDApp_WIN";
            this.Text = "PDApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Serial;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Label label_OutputArgs;
        private System.Windows.Forms.Label label_Serial;
        private System.Windows.Forms.Label label_Model;
        private System.Windows.Forms.Label label_Telematics;
        private System.Windows.Forms.Label label_BatteryType;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.ComboBox comboBox_Telematics;
        private System.Windows.Forms.ComboBox comboBox_BatteryType;
        private System.Windows.Forms.Label label_SysTime;
    }
}

