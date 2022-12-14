using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Master.UserControls
{
    public partial class UC_RTE : UserControl
    {
        public UC_RTE()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg2 = new OpenFileDialog();
            fdlg2.Title = "SE Master | Select a cfg/testscript file";
            fdlg2.InitialDirectory = @"c:\";
            fdlg2.Filter = "txt file (*.txt)|*.txt|cfg file (*.cfg)|*.cfg";
            fdlg2.FilterIndex = 2;
            fdlg2.RestoreDirectory = true;
            if (fdlg2.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private async void changeText()
        {
            btnCVARs.Text = "Link Copied!";
            await Task.Delay(2000);
            btnCVARs.Text = "Download CVARs!";
        }

        private void DownloadCVARS_click(object sender, EventArgs e)
        {
            Clipboard.SetText("https://cdn.discordapp.com/attachments/909176335535054939/1051897912088596520/X360-Source-CVARs.zip");
            changeText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
    }
}