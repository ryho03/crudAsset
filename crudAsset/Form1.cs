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
    public partial class aar_Form : Form
    {
        public aar_Form()
        {
            InitializeComponent();
        }

        private void aar_Form_Load(object sender, EventArgs e)
        {

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


        private void aarExit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void vaa_btn_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Loading...", "Loading", 1000);
            this.Hide();
            vaa_Form myNewForm = new vaa_Form();
            myNewForm.Show();

        }

        private void aa_btn_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Loading...", "Loading", 1000);
            this.Hide();
            assignAsset_Form myNewForm = new assignAsset_Form();
            myNewForm.Show();
        }

        private void ra_btn_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Loading...", "Loading", 1000);
            this.Hide();
            retireAsset_Form myNewForm = new retireAsset_Form();
            myNewForm.Show();
        }

        private void ane_btn_Click(object sender, EventArgs e)
        {
            AutoClosingMessageBox.Show("Loading...", "Loading", 1000);
            this.Hide();
            addNewEquip_Form myNewForm = new addNewEquip_Form();
            myNewForm.Show();
        }
    }
}

    
   
