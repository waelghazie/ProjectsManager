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
    public partial class RTFeditorForm : Form
    {
        private int indent = 10;
        [Category("Settings")]
        [Description("Value indicating the number of characters used for indentation")]
        public int INDENT
        {
            get { return indent; }
            set { indent = value; }
        }

        public RTFeditorForm(string RTFtext , bool ReadOnly)        //Constructor
        {
            InitializeComponent();
            richTextBox1.Rtf = RTFtext;
            if (ReadOnly)
            {
                richTextBox1.ReadOnly = true;
                FormattingToolBox.Visible = false;
                MainToolBox.Visible = false;
                contextMenuStrip1.Enabled = false;
                this.Text = @"محرر النص [لتحرير تقرير الصيانة يجب ضغط زر تعديل قبل الدخول]";
            }
        }

        public string RichText
        {
            set { richTextBox1.Rtf = RichText; }
            get { return richTextBox1.Rtf; }
        }

        private void RTFeditorForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.InstalledFontCollection col = new System.Drawing.Text.InstalledFontCollection();
            this.cmbFontName.Items.Clear();
            foreach (FontFamily ff in col.Families)
            { this.cmbFontName.Items.Add(ff.Name); }
            col.Dispose();

            cmbFontName.SelectedItem = "Tahoma";
            cmbFontSize.SelectedItem = "9";
            tstxtZoomFactor.Text = Convert.ToString(richTextBox1.ZoomFactor * 100);

            richTextBox1.Focus();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(richTextBox1.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Bold;

                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            richTextBox1.Focus();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(richTextBox1.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Italic;

                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(richTextBox1.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Underline;

                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void btnStrikeThrough_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(richTextBox1.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout;

                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void tbrLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tbrCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tbrRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cmbFontSize_KeyDown(object sender, KeyEventArgs e)
        {
            //filter keyboard input
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.D1 || e.KeyCode == Keys.D2 ||
                e.KeyCode == Keys.D3 || e.KeyCode == Keys.D4 || e.KeyCode == Keys.D5 ||
                e.KeyCode == Keys.D6 || e.KeyCode == Keys.D7 || e.KeyCode == Keys.D8 ||
                e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.NumPad1 ||
                e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 ||
                e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 ||
                e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.Back ||
                e.KeyCode == Keys.Enter || e.KeyCode == Keys.Delete)
            {
                //allow key
            }
            else
            {
                e.SuppressKeyPress = true;
            }
        }

        private void cmbFontSize_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    richTextBox1.SelectionFont = new Font(cmbFontName.Text, Convert.ToSingle(cmbFontSize.Text));
                    richTextBox1.Focus();
                }
                catch (Exception)
                {
                }
            }
        }

        private void cmbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cmbFontName.Focused) return;
                richTextBox1.SelectionFont = new Font(cmbFontName.Text, Convert.ToInt32(cmbFontSize.Text));
            }
            catch (Exception)
            {
            }
        }

        private void cmbFontName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    richTextBox1.SelectionFont = new Font(cmbFontName.Text, Convert.ToInt32(cmbFontSize.Text));
                    richTextBox1.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //contextMenuStrip1 show
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnCut_Click(sender, e);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnCopy_Click(sender, e);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnPaste_Click(sender, e);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void tsbtnFontColor_Click(object sender, EventArgs e)
        {
            // font color
            try
            {
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = richTextBox1.SelectionColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SelectionColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void tsbtnZoomIn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 64.0f - 0.20f)
            {
                richTextBox1.ZoomFactor += 0.20f;
                tstxtZoomFactor.Text = String.Format("{0:F0}", richTextBox1.ZoomFactor * 100);
            }
        }

        private void tsbtnZoomOut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.16f + 0.20f)
            {
                richTextBox1.ZoomFactor -= 0.20f;
                tstxtZoomFactor.Text = String.Format("{0:F0}", richTextBox1.ZoomFactor * 100);
            }
        }

        private void tstxtZoomFactor_Leave(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor = Convert.ToSingle(tstxtZoomFactor.Text) / 100;
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Enter valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Zoom factor should be between 20% and 6400%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tstxtZoomFactor.Focus();
                tstxtZoomFactor.SelectAll();
            }
        }

        private void richTextBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);
        }

        private void RTFeditorForm_Shown(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

        private void tsbtnBullets_Click(object sender, EventArgs e)
        {
            // bullets, indentation
            try
            {
                string name = (sender as ToolStripButton).Name;
                if (name.IndexOf("Bullets") >= 0)
                    richTextBox1.SelectionBullet = tsbtnBullets.Checked;
                else if (name.IndexOf("Indent") >= 0)
                    richTextBox1.SelectionIndent += INDENT;
                else if (name.IndexOf("Outdent") >= 0)
                    richTextBox1.SelectionIndent -= INDENT;
            }
            catch (Exception ex)
            {
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                btnBold.Checked = richTextBox1.SelectionFont.Bold;
                btnItalic.Checked = richTextBox1.SelectionFont.Italic;
                btnUnderline.Checked = richTextBox1.SelectionFont.Underline;
                btnStrikeThrough.Checked = richTextBox1.SelectionFont.Strikeout;
                tsbtnBullets.Checked = richTextBox1.SelectionBullet;

                cmbFontName.SelectedItem = richTextBox1.SelectionFont.FontFamily.Name;
                cmbFontSize.SelectedItem = richTextBox1.SelectionFont.Size.ToString();

                switch (richTextBox1.SelectionAlignment)
                {
                    case HorizontalAlignment.Left:
                        tbrLeft.Checked = true;
                        tbrCenter.Checked = false;
                        tbrRight.Checked = false;
                        break;

                    case HorizontalAlignment.Center:
                        tbrLeft.Checked = false;
                        tbrCenter.Checked = true;
                        tbrRight.Checked = false;
                        break;

                    case HorizontalAlignment.Right:
                        tbrLeft.Checked = false;
                        tbrCenter.Checked = false;
                        tbrRight.Checked = true;
                        break;
                }
            }
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // font size
            try
            {
                if (!(richTextBox1.SelectionFont == null))
                {
                    Font currentFont = richTextBox1.SelectionFont;
                    float newSize = Convert.ToSingle(cmbFontSize.SelectedItem.ToString());
                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
                }
            }
            catch (Exception ex)
            { }
        }




    }
}
