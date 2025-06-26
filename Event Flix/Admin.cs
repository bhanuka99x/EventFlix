using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Flix
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ShowAdmin();
        }

        //Connect database

        SqlConnection ConA = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\Desktop\2nd sem project\Event Flix\Event Flix\Event MS.mdf"";Integrated Security=True;Connect Timeout=30");


        private void ShowAdmin()
        {
            ConA.Open();
            String query = " Select * from Adtbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, ConA);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            adminDGV.DataSource = ds.Tables[0];

            ConA.Close();
        }


        //adding data in database

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text == " " || txtpass.Text == " " )
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConA.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Adtbl(sysadmin,syspassword)values(@SA,@SP) ", ConA);
                    cmd.Parameters.AddWithValue("@SA", txtadmin.Text);
                    cmd.Parameters.AddWithValue("@SP", txtpass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConA.Close();
                    ShowAdmin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }
        int Key = 0;


        //update data in database

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text == " " || txtpass.Text == " " )
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConA.Open();
                    SqlCommand cmd = new SqlCommand("Update Adtbl Set sysadmin = @SA, syspassword = @SP where AId = @SPKey", ConA);
                    cmd.Parameters.AddWithValue("@SA", txtadmin.Text);
                    cmd.Parameters.AddWithValue("@SP", txtpass.Text);
                    cmd.Parameters.AddWithValue("@SPKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Updated", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConA.Close();
                    ShowAdmin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }


        //delete data in database

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Admin");
            }
            else
            {
                try
                {
                    ConA.Open();
                    SqlCommand cmd = new SqlCommand("Delete from Adtbl where AId = @SPKey ", ConA);
                    cmd.Parameters.AddWithValue("@SPKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Deleted", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConA.Close();
                    ShowAdmin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        //reset all textboxes

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            txtadmin.Text = "";
            txtpass.Text = "";
        }


        //show database data in texboxes

        private void adminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtadmin.Text = adminDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtpass.Text = adminDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            if (txtadmin.Text == " ")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(adminDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //application minimized and maxmized


        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        //applicarion close

        private void CLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        //darg application

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        //loading event

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Event_list El = new Event_list();
            El.Show();
            this.Hide();
        }


        //loading venue

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Venue Vn = new Venue();
            Vn.Show();
            this.Hide();
        }


        //loading budget

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Budget Bd = new Budget();
            Bd.Show();
            this.Hide();
        }


        //loading loginfrm

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Loginfrm lgout = new Loginfrm();
            lgout.Show();
            this.Hide();
        }
    }
}
