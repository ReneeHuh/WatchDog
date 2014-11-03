using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriceEngineWatchDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            UpdateLabels();
            Core.Log(DateTime.Now + " - Started WatchDog");
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Core.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Core.Stop();
        }
        private void btRestart_Click(object sender, EventArgs e)
        {
            Core.Restart();
        }

        private void btOpenLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("WatchDog.Txt");
            }
            catch
            { 
            
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabels();
            //start
            if (Core.HasMultipleProcesses == true)
            {
                Core.Stop();
            }
            if (Core.IsRunning == true)
            {
                if (Core.IsResponding == false)
                {
                    Core.Restart();
                }
            }
            else
            {
                Core.Start();
            }

        }
        private void UpdateLabels()
        {
            if (Core.IsRunning == true && Core.IsResponding == true) { lblPriceEngineRunning.Text = "Price Engine Is Running"; }
            else if (Core.IsRunning == true && Core.IsResponding == false) { lblPriceEngineRunning.Text = "Price Engine Is Not Responding"; }
            else if (Core.IsRunning == false) { lblPriceEngineRunning.Text = "Price Engine Is Not Running"; }
            else { lblPriceEngineRunning.Text = "Price Engine Is ?????"; }
        }

        private void cbEnabled_CheckedChanged(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Enabled = cbEnabled.Checked;
            Properties.Settings.Default.Save();
        }

        
    }
}
