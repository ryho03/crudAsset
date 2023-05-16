using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudAsset
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetRegister_dbDataSet1.modelInventoryTable' table. You can move, or remove it, as needed.
            this.modelInventoryTableTableAdapter.Fill(this.assetRegister_dbDataSet1.modelInventoryTable);
            // TODO: This line of code loads data into the 'assetRegister_dbDataSet.userTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.assetRegister_dbDataSet.userTable);

        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addAsset_pnl.Visible = false;
        }

        private void addAsset_btn_Click_1(object sender, EventArgs e)
        {
            {
                AutoClosingMessageBox.Show("Loading...", "Loading", 1000);
                addAsset_pnl.Visible = true;
            }
        }

        private void exitApp_btn_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Uploading asset to database", "Uploading", 2000);
            
        }

        private void ane_btn_Click(object sender, EventArgs e)
        {

        }

        private void vaa_btn_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Loading...", "Loading", 1000);

        }
    }
}
