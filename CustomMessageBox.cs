using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        // Constants and WinAPI function declarations for form dragging.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Allows the form to be moved by clicking and dragging on a specific area.
        private void moveableBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        // Minimizes the form when the minimize button is clicked.
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Closes the form when the close button is clicked.
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sets the dialog result to OK when the OK button is clicked.
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // Closes the form when the close button is clicked.
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Minimizes the form when the minimize button is clicked.
        private void MinimizeButton_Click_1(object sender, EventArgs e)
        {
            WindowState |= FormWindowState.Minimized;
        }
    }
}
