using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Event_Flix
{
    public partial class Loding : Form
    {
        
        public Loding()
        {
            InitializeComponent();

        }

        private void Loding_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar1.Value < 100)
            {
                ProgressBar1.Value += 1; 
                lblprograss.Text = ProgressBar1.Value.ToString() + " %";

            }
            else
            {
                timer1.Stop();
                Loginfrm lgfrm = new Loginfrm();
                lgfrm.Show();
                this.Hide();
            
            }
        }


        //application close

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        // Minimize Window
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    }
}
