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
    public partial class UC_MGD : UserControl
    {
        public UC_MGD()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            MGDLogsBox.Text = String.Empty;
        }

        private void SelectFilesFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg3 = new OpenFileDialog();
            fdlg3.Multiselect = true;
            fdlg3.Title = "SE Master | Select a file/folder to convert";
            fdlg3.InitialDirectory = @"c:\";
            fdlg3.Filter = "txt file (*.txt)|*.txt|cfg file (*.cfg)|*.cfg";
            fdlg3.FilterIndex = 2;
            fdlg3.RestoreDirectory = true;
            string[] result = fdlg3.FileNames;
            foreach (string y in result)
                // do something here
            if (fdlg3.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
