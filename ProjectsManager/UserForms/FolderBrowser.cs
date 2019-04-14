using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProjectsManager
{
    public partial class FolderBrowser : Form
    {
        public FolderBrowser()
        {
            InitializeComponent();
        }

        public string FolderName = "";

        private void FolderBrowser_Load(object sender, EventArgs e)
        {
            label2.Text = Settings1.Default.PhotosPath;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Columns.Add("FileName", "FileName");

            try
            {
                string[] dirs = Directory.GetDirectories(Settings1.Default.PhotosPath);
                
                foreach (string item in dirs)
                {
                    FileInfo FI = new FileInfo(item);
                    dataGridView1.Rows.Add(FI.Name);
                }
            }
            catch (Exception exp)
            { }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FolderName = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderName = Convert.ToString(dataGridView1.SelectedCells[0].Value);
            Close();
        }
    }
}
