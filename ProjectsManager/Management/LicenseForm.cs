using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProjectsManager
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }
        
        StreamWriter Writer;
        StreamReader Reader;
        ActivationInfo ActivationInfoObject;
        

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            SuccessPictureBox.Visible = false;
            InfoLabel.Visible = false;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (File.Exists(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma"))
            {
                try
                {
                    Reader = new StreamReader(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                    ActivationInfoObject = ActivateProjectsManager.ReadActivation(Reader.ReadLine());
                    Reader.Close();

                    if (!ActivationInfoObject.CorruptActivation)
                    {
                        if (ActivationInfoObject.ActivationStatus == ActivationStatus.Activated)
                        {
                            ActivationStatusLabel.Text = "هذه النسخة مرخصة لصالح " + ActivationInfoObject.CompanyName;
                            ExportKeyLabel.Visible = false; 
                            ImportKeyLabel.Visible = false;
                            
                            ExportKeyButton.Visible = false;
                            ImportKeyButton.Visible = false;
                            
                            SuccessPictureBox.Visible = true;
                        }

                        else if (ActivationInfoObject.ActivationStatus == ActivationStatus.Trial)
                        { ActivationStatusLabel.Text += Convert.ToString(ActivationInfoObject.TrialDays); }
                    }
                }
                catch (Exception exp)
                { ActivationError(); }
            }
            else
            { ActivationError(); }
        }

        private void ActivationError()
        {
            ActivationStatusLabel.Text = "!مشكلة في تفعيل النسخة";
            ExportKeyButton.Visible = false;
            ImportKeyButton.Visible = false;
            ExportKeyLabel.Visible = false;
            ImportKeyLabel.Visible = false;
        }

        private void ExportKeyButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Writer = new StreamWriter(saveFileDialog1.FileName);
                Writer.WriteLine(ActivateProjectsManager.CreateRequestCode());
                Writer.Close();
            }
        }

        private void ImportKeyButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Reader = new StreamReader(openFileDialog1.FileName);
                ActivationInfoObject = ActivateProjectsManager.ReadActivation(Reader.ReadLine());
                Reader.Close();

                if (!ActivationInfoObject.CorruptActivation)
                {
                    if (ActivationInfoObject.ActivationStatus == ActivationStatus.Activated)
                    {
                        try
                        {
                            File.Delete(Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                            File.Move(openFileDialog1.FileName, Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\pma");
                            SuccessPictureBox.Visible = true;

                            MessageBox.Show("تم تفعيل النسخة ، شكرا لك" + "\n ستتم اعادة تشغيل البرنامج", "نجاح التفعيل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ProcessStartInfo Info = new ProcessStartInfo();
                            Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                            Info.WindowStyle = ProcessWindowStyle.Hidden;
                            Info.CreateNoWindow = true;
                            Info.FileName = "cmd.exe";
                            Process.Start(Info);
                            Application.Exit();
                        }
                        catch (Exception exp)
                        { InfoLabel.Text = "مشكلة في التفعيل"; }
                    }
                    else if (ActivationInfoObject.ActivationStatus != ActivationStatus.Activated)
                    { InfoLabel.Text = "الملف غير صالح ، يرجى التأكد من الملف"; }
                }
                else if (ActivationInfoObject.CorruptActivation)
                { InfoLabel.Text = "الملف غير صالح، يرجى التأكد"; }
            }
            InfoLabel.Visible = true;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
