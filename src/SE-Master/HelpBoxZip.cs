using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Master
{
    public partial class HelpBoxZip : Form
    {
        public HelpBoxZip()
        {
            InitializeComponent();
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeForm(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(67)))));
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
        }
    }
}
