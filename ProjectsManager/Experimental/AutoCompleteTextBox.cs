using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectsManager
{
    public partial class AutoCompleteTextBox : UserControl
    {
        public AutoCompleteTextBox()
        {
            InitializeComponent();
        }

        public string text
        {
            set { textBox1.Text = this.text; }
            get { return textBox1.Text; }
        }
        
        [Description("Check if Text is Valid or not")]
        public bool ValidUserInput
        { get { return true; } }

        public BindingList<string> ListOfItems;
        //public event EventHandler TextBoxChanged;
        bool UserChoose = false;
        bool DrawListBoxToDown = true;

        private void AutoCompleteTextBox_Load(object sender, EventArgs e)
        {
            ListOfItems = new BindingList<string>();
            listBox1.DataSource = ListOfItems;
            //textBox1.TextChanged += this.HandleTextChanged;
            this.Size = new Size(150, 20);
            //pictureBox1.Visible = false;
        }

        /*private void HandleTextChanged(object sender, EventArgs e)
        {
            if (!UserChoose)
                this.OnTextChanged(EventArgs.Empty);
        }

        protected virtual void OnTextChanged(EventArgs e)
        {
            EventHandler handler = this.TextBoxChanged;
            if (handler != null)
            {
                ListOfItems.Clear();
                handler(this, e);
            }
        }*/
        private void textBox1_Enter(object sender, EventArgs e)
        {
            ShowListBox();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            HideListBox();
            ValidateTextBox();
        }
        private void ValidateTextBox()
        {
           /* if (!ListOfItems.Contains(textBox1.Text) && textBox1.Text != "")
                //pictureBox1.Visible = true;
            else
                //pictureBox1.Visible = false;*/
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            UserChoose = false;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    UserChoose = true;
                    textBox1.Text = Convert.ToString(listBox1.SelectedItem);
                    HideListBox();
                    ValidateTextBox();
                    break;
                case Keys.Up:
                    if (listBox1.SelectedIndex > 0)
                        listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
                    break;
                case Keys.Down:
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                        listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
                    break;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex = listBox1.Items.IndexOf(textBox1.Text); 
        }
        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserChoose = true;
                textBox1.Text = Convert.ToString(listBox1.SelectedItem);
                HideListBox();
                ValidateTextBox();
            }
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            UserChoose = true;
            textBox1.Text = Convert.ToString(listBox1.SelectedItem);
            ValidateTextBox();
        }

        private void HideListBox()
        {
            timer1.Enabled = true;
            DrawListBoxToDown = false;
        }
        private void ShowListBox()
        {
            timer1.Enabled = true;
            DrawListBoxToDown = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DrawListBoxToDown && this.Height <= 150)
            {
                this.Height += 5;
                if (this.Height == 150)
                    timer1.Enabled = false;
            }
            else if (!DrawListBoxToDown && this.Height >= 25)
            {
                this.Height -= 5;
                if (this.Height == 25)
                    timer1.Enabled = false;
            }

        }



    }
}
