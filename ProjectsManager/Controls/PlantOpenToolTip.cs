using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class ChoosePlantSelectedTab : Form, INotifyPropertyChanged
    {
        public ChoosePlantSelectedTab()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        int _SelectedTab;
        public int PlanID;

        public int SelectedTab
        {
            set { }
            get { return _SelectedTab; }
        }

        private void SendPropertyChanged(string Property)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(Property));
        }

        private void PlantOpenToolTip_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        public void ShowForm()
        {
            this.TopMost = true;
            this.Show();

            OpenOpacityTimer.Enabled = true;
        }

        private void ChoosePlantSelectedTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            
            CloseOpacityTimer.Enabled = true;
        }

        private void OpenOpacityTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1.0)
            {
                OpenOpacityTimer.Enabled = false;
                WaitTimer.Enabled = true;
                this.TopMost = false;
            }
        }
        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            WaitTimer.Enabled = false;
            Close();
        }

        private void CloseOpacityTimer_Tick(object sender, EventArgs e)
        {
            if (!OpenOpacityTimer.Enabled)
            {
                this.Opacity -= 0.1;
                if (this.Opacity == 0)
                {
                    CloseOpacityTimer.Enabled = false;
                    this.Hide();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SelectedTab = 1;
            SendPropertyChanged("SelectedTab");
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SelectedTab = 2;
            SendPropertyChanged("SelectedTab");
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SelectedTab = 3;
            SendPropertyChanged("SelectedTab");
            Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _SelectedTab = 4;
            SendPropertyChanged("SelectedTab");
            Close();
        }

        protected override bool ShowWithoutActivation
        { // start window without focus
            get
            { return true; }
        }

        private void PlantOpenToolTip_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1.0;
            WaitTimer.Enabled = false;
            
        }

        private void PlantOpenToolTip_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
            WaitTimer.Enabled = true;
            
        }

        private void ChoosePlantSelectedTab_Deactivate(object sender, EventArgs e)
        {
                Close();
        }

    }
}
