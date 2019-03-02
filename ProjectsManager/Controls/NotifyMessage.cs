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
    public partial class NotifyMessage : Form
    {
        public enum NotifyMessageIcon { Saved, Recycle, Deleted, Restored, Info, Error }

        public NotifyMessage(string NotifyString, NotifyMessageIcon MessageIcon)
        {
            InitializeComponent();
            this.label1.Text = NotifyString;
            switch (MessageIcon)
            {
                case NotifyMessageIcon.Saved: pictureBox1.Image = Properties.Resources.success; break;
                case NotifyMessageIcon.Deleted: pictureBox1.Image = Properties.Resources.trash; break;
                case NotifyMessageIcon.Recycle: pictureBox1.Image = Properties.Resources.garbage_2_img; break;
                case NotifyMessageIcon.Restored: pictureBox1.Image = Properties.Resources.broken_link; break;
                case NotifyMessageIcon.Info: pictureBox1.Image = Properties.Resources.idea; break;
                case NotifyMessageIcon.Error: pictureBox1.Image = Properties.Resources.error; break;
            }
        }

        private int YLocation = 0;
        private int XLocation = 0;
        
        private void NotifyWindow_Load(object sender, EventArgs e)
        {
            XLocation = Screen.FromControl(this).Bounds.Width / 2 - this.Width / 2;
            SetDesktopLocation(XLocation , 0);
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            SetDesktopLocation(XLocation , YLocation);
            YLocation++;

            if (YLocation == 20)
            {
                ShowTimer.Enabled = false;
                WaitTimer.Enabled = true;
            }
        }

        private void NotifyWindow_Shown(object sender, EventArgs e)
        {
            if (label1.Text.Length > 20)
            {
                label1.Height *= 2;
                this.Height *= 2;
            }
            ShowTimer.Enabled = true;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            SetDesktopLocation(XLocation, YLocation);
            YLocation--;

            if (YLocation == 0)
            {
                ShowTimer.Enabled = false;
                Close();
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            WaitTimer.Enabled = false;
            CloseTimer.Enabled = true;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            CloseTimer.Enabled = true;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            CloseTimer.Enabled = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CloseTimer.Enabled = true;
        }
    }
}
