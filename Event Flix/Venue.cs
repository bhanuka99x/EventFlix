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
    public partial class Venue : Form
    {
        public Venue()
        {
            InitializeComponent();
            ShowVenue();

        }

        //Connect database

        SqlConnection ConV = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bhanuka\Desktop\New folder (10)\2nd sem project\Event Flix\Event Flix\Event MS.mdf"";Integrated Security=True");
        
        
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


        private void ShowVenue()
        {
            ConV.Open();
            String query = " Select * from VenueTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, ConV);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VenueDGV.DataSource = ds.Tables[0];

            ConV.Close();
        }


        //adding data in database

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtvenuename.Text == " " || txtcontactnumber.Text == " " || txtaddress.Text == " " || txtcapacity.Text == " ")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConV.Open();
                    SqlCommand cmd = new SqlCommand("Insert into VenueTbl(VName,VNumber,VAddress,VCapacity)values(@VN,@VP,@VA,@VC) ", ConV);
                    cmd.Parameters.AddWithValue("@VN", txtvenuename.Text);
                    cmd.Parameters.AddWithValue("@VP", txtcontactnumber.Text);
                    cmd.Parameters.AddWithValue("@VA", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@VC", txtcapacity.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added","Venue" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ConV.Close();
                    ShowVenue();
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
            if (txtvenuename.Text == " " || txtcontactnumber.Text == " " || txtaddress.Text == " " || txtcapacity.Text == " ")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ConV.Open();
                    SqlCommand cmd = new SqlCommand("Update VenueTbl Set VName = @VN, VNumber = @VP, VAddress = @VA, VCapacity = @VC where VId = @VCKey", ConV);
                    cmd.Parameters.AddWithValue("@VN", txtvenuename.Text);
                    cmd.Parameters.AddWithValue("@VP", txtcontactnumber.Text);
                    cmd.Parameters.AddWithValue("@VA", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@VC", txtcapacity.Text);
                    cmd.Parameters.AddWithValue("@VCKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Venue Updated", "Venue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConV.Close();
                    ShowVenue();
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
                MessageBox.Show("Select the Venue");
            }
            else
            {
                try
                {
                    ConV.Open();
                    SqlCommand cmd = new SqlCommand("Delete from VenueTbl where VId = @VCKey ", ConV);
                    cmd.Parameters.AddWithValue("@VCKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted","Venue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ConV.Close();
                    ShowVenue();
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
            txtvenuename.Text = "";
            txtcontactnumber.Text = "";
            txtaddress.Text = "";
            txtcapacity.Text ="";
        }


        //show database data in texboxes

        private void VenueDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtvenuename.Text = VenueDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtcontactnumber.Text = VenueDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtaddress.Text = VenueDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtcapacity.Text = VenueDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (txtvenuename.Text == " ")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(VenueDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        //loading loginfrm
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Loginfrm lgout = new Loginfrm();
            lgout.Show();
            this.Hide();
        }

        //loading event

        private void btnEvents_Click(object sender, EventArgs e)
        {
            Event_list El = new Event_list();
            El.Show();
            this.Hide();    
        }


        //loading budgetfrm
        private void btnBudget_Click(object sender, EventArgs e)
        {
            Budget Bd = new Budget();
            Bd.Show();
            this.Hide();
        }


        //loading adminfrm

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            Admin Ad = new Admin();
            Ad.Show();
            this.Hide();
        }
    }
}
