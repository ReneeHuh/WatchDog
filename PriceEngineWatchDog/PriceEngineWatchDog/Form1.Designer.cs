namespace PriceEngineWatchDog
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
            this.components = new System.ComponentModel.Container();
            this.btOpenLogFile = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.lblPriceEngineRunning = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btOpenLogFile
            // 
            this.btOpenLogFile.Location = new System.Drawing.Point(149, 176);
            this.btOpenLogFile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btOpenLogFile.Name = "btOpenLogFile";
            this.btOpenLogFile.Size = new System.Drawing.Size(125, 54);
            this.btOpenLogFile.TabIndex = 0;
            this.btOpenLogFile.Text = "Open Log File";
            this.btOpenLogFile.UseVisualStyleBackColor = true;
            this.btOpenLogFile.Click += new System.EventHandler(this.btOpenLogFile_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 5000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(149, 114);
            this.btStop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(125, 54);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "Stop Price Engine";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(14, 114);
            this.btStart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(125, 54);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start Price Engine";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lblPriceEngineRunning
            // 
            this.lblPriceEngineRunning.AutoSize = true;
            this.lblPriceEngineRunning.Location = new System.Drawing.Point(49, 24);
            this.lblPriceEngineRunning.Name = "lblPriceEngineRunning";
            this.lblPriceEngineRunning.Size = new System.Drawing.Size(181, 18);
            this.lblPriceEngineRunning.TabIndex = 3;
            this.lblPriceEngineRunning.Text = "Price Engine Is ?????";
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(14, 176);
            this.btRestart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(125, 54);
            this.btRestart.TabIndex = 4;
            this.btRestart.Text = "ReStart Price Engine";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Checked = global::PriceEngineWatchDog.Properties.Settings.Default.Enabled;
            this.cbEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PriceEngineWatchDog.Properties.Settings.Default, "Enabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbEnabled.Location = new System.Drawing.Point(14, 63);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(172, 22);
            this.cbEnabled.TabIndex = 5;
            this.cbEnabled.Text = "Enable WatchDog";
            this.cbEnabled.UseVisualStyleBackColor = true;
            this.cbEnabled.CheckedChanged += new System.EventHandler(this.cbEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 246);
            this.Controls.Add(this.cbEnabled);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.lblPriceEngineRunning);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btOpenLogFile);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Price Engine WatchDog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpenLogFile;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lblPriceEngineRunning;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.CheckBox cbEnabled;
    }
}

