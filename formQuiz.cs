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
    public partial class formQuiz : Form
    {
        public formQuiz()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the form when the close button is clicked
            this.Close();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void moveableBar_MouseMove(object sender, MouseEventArgs e)
        {
            // Allow the form to be moved when the top bar is clicked and dragged
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            // Minimize the form when the minimize button is clicked
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form when the close button is clicked
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            // Show the custom message box with game rules when the rules button is clicked
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
        }

        private formGame game_ = null;
        private void btnBegin_Click(object sender, EventArgs e)
        {
            // Start the game when the begin button is clicked
            if (game_ != null && !game_.IsDisposed)
            {
                game_.WindowState = FormWindowState.Normal;
                game_.Focus();
            }
            else
            {
                game_ = new formGame();
                game_.Show();
            }
        }
    }
}
