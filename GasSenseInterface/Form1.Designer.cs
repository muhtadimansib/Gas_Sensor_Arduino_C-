
namespace GasSenseInterface
{
    partial class Form1
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
            this.labelGasPercentage = new System.Windows.Forms.Label();
            this.labelCircleValue = new System.Windows.Forms.Label();
            this.labelPercentCircle = new System.Windows.Forms.Label();
            this.labelSensorValue = new System.Windows.Forms.Label();
            this.Gas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLED = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGasPercentage
            // 
            this.labelGasPercentage.AutoSize = true;
            this.labelGasPercentage.BackColor = System.Drawing.Color.Transparent;
            this.labelGasPercentage.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGasPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelGasPercentage.Location = new System.Drawing.Point(631, 149);
            this.labelGasPercentage.Name = "labelGasPercentage";
            this.labelGasPercentage.Size = new System.Drawing.Size(90, 45);
            this.labelGasPercentage.TabIndex = 1;
            this.labelGasPercentage.Text = "12.00";
            this.labelGasPercentage.Click += new System.EventHandler(this.labelGasPercentage_Click);
            // 
            // labelCircleValue
            // 
            this.labelCircleValue.AutoSize = true;
            this.labelCircleValue.Font = new System.Drawing.Font("Segoe MDL2 Assets", 120F);
            this.labelCircleValue.ForeColor = System.Drawing.Color.Yellow;
            this.labelCircleValue.Location = new System.Drawing.Point(57, 89);
            this.labelCircleValue.Name = "labelCircleValue";
            this.labelCircleValue.Size = new System.Drawing.Size(227, 160);
            this.labelCircleValue.TabIndex = 2;
            this.labelCircleValue.Text = "";
            // 
            // labelPercentCircle
            // 
            this.labelPercentCircle.AutoSize = true;
            this.labelPercentCircle.Font = new System.Drawing.Font("Segoe MDL2 Assets", 120F);
            this.labelPercentCircle.ForeColor = System.Drawing.Color.Yellow;
            this.labelPercentCircle.Location = new System.Drawing.Point(568, 89);
            this.labelPercentCircle.Name = "labelPercentCircle";
            this.labelPercentCircle.Size = new System.Drawing.Size(227, 160);
            this.labelPercentCircle.TabIndex = 2;
            this.labelPercentCircle.Text = "";
            // 
            // labelSensorValue
            // 
            this.labelSensorValue.AutoSize = true;
            this.labelSensorValue.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensorValue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSensorValue.Location = new System.Drawing.Point(130, 149);
            this.labelSensorValue.Name = "labelSensorValue";
            this.labelSensorValue.Size = new System.Drawing.Size(66, 45);
            this.labelSensorValue.TabIndex = 1;
            this.labelSensorValue.Text = "123";
            // 
            // Gas
            // 
            this.Gas.AutoSize = true;
            this.Gas.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gas.Location = new System.Drawing.Point(574, 260);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(198, 37);
            this.Gas.TabIndex = 1;
            this.Gas.Text = "Gas Percentage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(87, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor Value";
            // 
            // labelLED
            // 
            this.labelLED.AutoSize = true;
            this.labelLED.Font = new System.Drawing.Font("Segoe MDL2 Assets", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLED.ForeColor = System.Drawing.Color.Lime;
            this.labelLED.Location = new System.Drawing.Point(346, 138);
            this.labelLED.Name = "labelLED";
            this.labelLED.Size = new System.Drawing.Size(136, 96);
            this.labelLED.TabIndex = 3;
            this.labelLED.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLED);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gas);
            this.Controls.Add(this.labelSensorValue);
            this.Controls.Add(this.labelGasPercentage);
            this.Controls.Add(this.labelPercentCircle);
            this.Controls.Add(this.labelCircleValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelGasPercentage;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelCircleValue;
        private System.Windows.Forms.Label labelPercentCircle;
        private System.Windows.Forms.Label labelSensorValue;
        private System.Windows.Forms.Label Gas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLED;
    }
}

