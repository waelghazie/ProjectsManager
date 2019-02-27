using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProjectsManager
{
    [DebuggerStepThrough]
    public partial class SplashScreen : Form
    {
        

        public SplashScreen()
        {
            InitializeComponent();
        }
        int counter = 0;
        public bool EnableEventHandler = false;
        int progress = 0;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
            this.TransparencyKey = Color.AntiqueWhite;
            
            label1.BackColor = Color.AntiqueWhite;

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly(); //using System.Diagnostics;
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            label2.Text += fvi.FileVersion;

        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            if(timer1.Enabled)
                timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter==2)
            {
                timer2.Enabled = true;
                timer1.Stop();
                timer2.Start();
                label1.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.08;
            label1.Text = "Loading " + progress++ + " %";

            if (this.Opacity == 0)
                this.Close();
        }

        private void SplashScreen_Click(object sender, EventArgs e)
        {
            if (EnableEventHandler)
                this.Close();
        }
    }
}
