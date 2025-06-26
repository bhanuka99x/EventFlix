using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Event_Flix
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }


        //database connect

        SqlConnection Con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bhanuka\Desktop\New folder (10)\2nd sem project\Event Flix\Event Flix\Event MS.mdf"";Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }


        // login code

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            String sysadmin, syspassword;
            sysadmin = usertxt.Text;
            syspassword = passtxt.Text;

            try
            {
                String querry = " SELECT * FROM AdTbl WHERE sysadmin  = '" + usertxt.Text + "' AND syspassword = '" + passtxt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, Con2);
                DataTable dtable = new DataTable(); 
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0 )
                {
                    sysadmin = usertxt.Text;
                    syspassword = passtxt.Text;

                    MessageBox.Show("Login Successfull", "Login" , MessageBoxButtons.OK ,MessageBoxIcon.Information);
                

                    Event_list eventlist = new Event_list();
                    eventlist.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" Invalid Login Details", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usertxt.Clear();
                    passtxt.Clear();
                    usertxt.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Invalid Information","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                Con2.Close();
            } 
        }


        // application close
        private void CLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // minimize and maximize


        private void minimize_Click(object sender, EventArgs e)
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


        //password hide and unhide

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (passtxt.PasswordChar == '*') 
            {
                guna2Button1.BringToFront();
                passtxt.PasswordChar = '\0';
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (passtxt.PasswordChar == '\0') 
            {
                guna2Button2.BringToFront();
                passtxt.PasswordChar = '*';
            }
        }
    }
}
