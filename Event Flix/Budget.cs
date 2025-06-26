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
using System.Collections;
using System.Web.WebSockets;
using System.Runtime.CompilerServices;
namespace Event_Flix
{
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
            Showbudget();
        }


        //Connect database

        SqlConnection ConB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bhanuka\Desktop\New folder (10)\2nd sem project\Event Flix\Event Flix\Event MS.mdf"";Integrated Security=True");



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


        //loading adminfrm

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            Ad.Show();
            this.Hide();
        }


        //loading loginfrm

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Loginfrm lgout = new Loginfrm();
            lgout.Show();
            this.Hide();

        }

        private void Showbudget()
        {
            ConB.Open();
            String querry = "Select * from bTbl";
            SqlDataAdapter sda = new SqlDataAdapter(querry, ConB);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            budgetDGV.DataSource = ds.Tables[0];
            ConB.Close();
        }


        //adding data in database

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtcus.Text == "" || txtcate.Text == "" || txtbud.Text == " ")
            {
                MessageBox.Show("Missing Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    ConB.Open();
                    SqlCommand cmd = new SqlCommand("Insert into bTbl(Bcusname,Bcategory,Bbudget)values(@Bc,@Ba,@Bb)", ConB);
                    cmd.Parameters.AddWithValue("@Bc", txtcus.Text);
                    cmd.Parameters.AddWithValue("@Ba", txtcate.Text);
                    cmd.Parameters.AddWithValue("@Bb", txtbud.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("successfully","Budget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConB.Close();
                    Showbudget();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        //update data in database

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (txtcus.Text == "" || txtcate.Text == "" || txtbud.Text == " ")
            {
                MessageBox.Show("Missing Information","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    ConB.Open();
                    SqlCommand cmd = new SqlCommand("Update bTbl Set Bcusname = @Bc,Bcategory = @Ba,Bbudget = @Bb where Bid = @BbKey", ConB);
                    cmd.Parameters.AddWithValue("@Bc", txtcus.Text);
                    cmd.Parameters.AddWithValue("@Ba", txtcate.Text);
                    cmd.Parameters.AddWithValue("@Bb", txtbud.Text);
                    cmd.Parameters.AddWithValue("@BbKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Budget Update","Budget", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConB.Close();
                    Showbudget();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;


        //delete data in database

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Event");
            }
            else
            {
                try
                {
                    ConB.Open();
                    SqlCommand cmd = new SqlCommand("Delete from bTbl where Bid = @BbKey", ConB);
                    cmd.Parameters.AddWithValue("@BbKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Succesfully", "budget", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConB.Close();
                    Showbudget();
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
            txtcus.Text = "";
            txtcate.Text = "";
            txtbud.Text = "";
        }


        //show database data in texboxes

        private void budgetDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcus.Text = budgetDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtcate.Text = budgetDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtbud.Text = budgetDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (txtcus.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(budgetDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //applicarion close

        private void CLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //application minimized and maxmized


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


        //darg application

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
