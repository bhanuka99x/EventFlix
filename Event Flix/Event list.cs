using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;


namespace Event_Flix
{
    public partial class Event_list : Form
    {
        public Event_list()
        {
            InitializeComponent();
            ShowEvents();
            
        }

        //databasae connect

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\Desktop\2nd sem project\Event Flix\Event Flix\Event MS.mdf"";Integrated Security=True;Connect Timeout=30");

        

        private void ShowEvents()
        {
            Con.Open();
            String query = " Select * from EventlistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            eventDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
       

        // adding data

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (txtcustomerName.Text == " " || txtcustomerPhone.Text == " " || comboBox1.Text == " " || txtdate.Text == " ")
            {
                MessageBox.Show("Missing Information" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into EventlistTbl(CName,Cphone,Events,Date)values(@CN,@Cp,@E,@D) ", Con);
                    cmd.Parameters.AddWithValue("@CN", txtcustomerName.Text);
                    cmd.Parameters.AddWithValue("@Cp", txtcustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@E",  comboBox1.Text);
                    cmd.Parameters.AddWithValue("@D", txtdate.Text);
                    cmd.ExecuteNonQuery();          
                    MessageBox.Show("Successfully Added" , "Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    ShowEvents();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           
            
        }

        
        //reset textboxes

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            txtcustomerName.Text = "";
            txtcustomerPhone.Text = "";
            txtdate.Text = "";
            comboBox1.Text = "";
        }


        // update database

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (txtcustomerName.Text == " " || txtcustomerPhone.Text == " " || comboBox1.Text == " " || txtdate.Text == " ")
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventlistTbl Set CName = @CN,Cphone = @Cp,Events = @E,Date = @D where CId = @EKey" , Con);
                    cmd.Parameters.AddWithValue("@CN", txtcustomerName.Text);
                    cmd.Parameters.AddWithValue("@Cp", txtcustomerPhone.Text);
                    cmd.Parameters.AddWithValue("@E", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@D", txtdate.Text);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated" , "Event" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    ShowEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }


        //delete database data

        int Key = 0;
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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from EventlistTbl where CId = @EKey ", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted" ,"Event" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Con.Close();
                    ShowEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        

        // show the database text boxes

        private void eventDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcustomerName.Text = eventDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtcustomerPhone.Text = eventDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = eventDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtdate.Text = eventDGV.SelectedRows[0].Cells[4].Value.ToString();
            if(txtcustomerName.Text == " ")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(eventDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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


        // loading loginfrm

        private void btnlogout_Click(object sender, EventArgs e)
        {
           Loginfrm lgout = new Loginfrm();
            lgout.Show();
            this.Hide();
        }


        //loadingfrm

        private void btnVenue_Click(object sender, EventArgs e)
        {
            Venue Vn = new Venue();
            Vn.Show();
            this.Hide();
        }

        // application close 

        private void CLose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Exit?", "Confrim", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //minimize and maxmize application


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


        // application drag

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Event_list_Load(object sender, EventArgs e)
        {

        }
    }
}
