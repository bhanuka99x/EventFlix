namespace Event_Flix
{
    partial class Venue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CLose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.minimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmins = new Guna.UI2.WinForms.Guna2Button();
            this.btnBudget = new Guna.UI2.WinForms.Guna2Button();
            this.btnVenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnEvents = new Guna.UI2.WinForms.Guna2Button();
            this.Resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.VenueDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtvenuename = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcontactnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VenueDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contact number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Venue Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.guna2PictureBox5);
            this.panel3.Controls.Add(this.CLose);
            this.panel3.Controls.Add(this.minimize);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 38);
            this.panel3.TabIndex = 31;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox5.Image = global::Event_Flix.Properties.Resources.e_white;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(14, 4);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(100, 32);
            this.guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox5.TabIndex = 23;
            this.guna2PictureBox5.TabStop = false;
            this.guna2PictureBox5.UseTransparentBackground = true;
            // 
            // CLose
            // 
            this.CLose.BackColor = System.Drawing.Color.Transparent;
            this.CLose.Image = global::Event_Flix.Properties.Resources.close_button_white1;
            this.CLose.ImageRotate = 0F;
            this.CLose.Location = new System.Drawing.Point(1068, 11);
            this.CLose.Name = "CLose";
            this.CLose.Size = new System.Drawing.Size(18, 18);
            this.CLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CLose.TabIndex = 6;
            this.CLose.TabStop = false;
            this.CLose.UseTransparentBackground = true;
            this.CLose.Click += new System.EventHandler(this.CLose_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Image = global::Event_Flix.Properties.Resources.minimize_sign_white;
            this.minimize.ImageRotate = 0F;
            this.minimize.Location = new System.Drawing.Point(1017, 11);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(18, 18);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 8;
            this.minimize.TabStop = false;
            this.minimize.UseTransparentBackground = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnAdmins);
            this.panel1.Controls.Add(this.btnBudget);
            this.panel1.Controls.Add(this.btnVenue);
            this.panel1.Controls.Add(this.btnEvents);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 709);
            this.panel1.TabIndex = 32;
            // 
            // btnlogout
            // 
            this.btnlogout.BorderThickness = 2;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.MistyRose;
            this.btnlogout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.Location = new System.Drawing.Point(11, 608);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(157, 36);
            this.btnlogout.TabIndex = 21;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BorderThickness = 2;
            this.btnAdmins.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmins.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmins.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmins.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmins.FillColor = System.Drawing.Color.MistyRose;
            this.btnAdmins.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdmins.ForeColor = System.Drawing.Color.Black;
            this.btnAdmins.Location = new System.Drawing.Point(16, 420);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(157, 47);
            this.btnAdmins.TabIndex = 21;
            this.btnAdmins.Text = "Admins";
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnBudget
            // 
            this.btnBudget.BorderThickness = 2;
            this.btnBudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBudget.FillColor = System.Drawing.Color.MistyRose;
            this.btnBudget.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnBudget.ForeColor = System.Drawing.Color.Black;
            this.btnBudget.Location = new System.Drawing.Point(16, 333);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(157, 47);
            this.btnBudget.TabIndex = 21;
            this.btnBudget.Text = "Budget";
            this.btnBudget.Click += new System.EventHandler(this.btnBudget_Click);
            // 
            // btnVenue
            // 
            this.btnVenue.BorderThickness = 2;
            this.btnVenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVenue.FillColor = System.Drawing.Color.MistyRose;
            this.btnVenue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnVenue.ForeColor = System.Drawing.Color.Black;
            this.btnVenue.Location = new System.Drawing.Point(16, 245);
            this.btnVenue.Name = "btnVenue";
            this.btnVenue.Size = new System.Drawing.Size(157, 47);
            this.btnVenue.TabIndex = 21;
            this.btnVenue.Text = "Venue";
            // 
            // btnEvents
            // 
            this.btnEvents.BorderThickness = 2;
            this.btnEvents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEvents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEvents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEvents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEvents.FillColor = System.Drawing.Color.MistyRose;
            this.btnEvents.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEvents.ForeColor = System.Drawing.Color.Black;
            this.btnEvents.Location = new System.Drawing.Point(16, 158);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(157, 47);
            this.btnEvents.TabIndex = 21;
            this.btnEvents.Text = "Events";
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BorderThickness = 2;
            this.Resetbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Resetbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Resetbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Resetbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Resetbtn.FillColor = System.Drawing.Color.Transparent;
            this.Resetbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Resetbtn.ForeColor = System.Drawing.Color.Black;
            this.Resetbtn.Location = new System.Drawing.Point(759, 638);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(108, 37);
            this.Resetbtn.TabIndex = 33;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BorderThickness = 2;
            this.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebtn.FillColor = System.Drawing.Color.Transparent;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn.Location = new System.Drawing.Point(631, 638);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(108, 37);
            this.Deletebtn.TabIndex = 34;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BorderThickness = 2;
            this.Updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatebtn.FillColor = System.Drawing.Color.Transparent;
            this.Updatebtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.Black;
            this.Updatebtn.Location = new System.Drawing.Point(501, 638);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(108, 37);
            this.Updatebtn.TabIndex = 35;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BorderThickness = 2;
            this.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbtn.FillColor = System.Drawing.Color.Transparent;
            this.Addbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Black;
            this.Addbtn.Location = new System.Drawing.Point(371, 637);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(108, 37);
            this.Addbtn.TabIndex = 36;
            this.Addbtn.Text = "Add";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // VenueDGV
            // 
            this.VenueDGV.AllowUserToAddRows = false;
            this.VenueDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.VenueDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VenueDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.VenueDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VenueDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.VenueDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VenueDGV.Location = new System.Drawing.Point(212, 188);
            this.VenueDGV.Name = "VenueDGV";
            this.VenueDGV.ReadOnly = true;
            this.VenueDGV.RowHeadersVisible = false;
            this.VenueDGV.RowTemplate.Height = 30;
            this.VenueDGV.Size = new System.Drawing.Size(831, 406);
            this.VenueDGV.TabIndex = 37;
            this.VenueDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.VenueDGV.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.VenueDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.VenueDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.VenueDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.VenueDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.VenueDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.VenueDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.VenueDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.VenueDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.VenueDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.VenueDGV.ThemeStyle.ReadOnly = true;
            this.VenueDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.VenueDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.VenueDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VenueDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.VenueDGV.ThemeStyle.RowsStyle.Height = 30;
            this.VenueDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.VenueDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.VenueDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VenueDGV_CellContentClick);
            // 
            // txtvenuename
            // 
            this.txtvenuename.Animated = true;
            this.txtvenuename.BorderColor = System.Drawing.Color.Black;
            this.txtvenuename.BorderThickness = 2;
            this.txtvenuename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvenuename.DefaultText = "";
            this.txtvenuename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtvenuename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtvenuename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvenuename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvenuename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvenuename.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtvenuename.ForeColor = System.Drawing.Color.Black;
            this.txtvenuename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvenuename.Location = new System.Drawing.Point(212, 115);
            this.txtvenuename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvenuename.Name = "txtvenuename";
            this.txtvenuename.PasswordChar = '\0';
            this.txtvenuename.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtvenuename.PlaceholderText = "Enter Name";
            this.txtvenuename.SelectedText = "";
            this.txtvenuename.Size = new System.Drawing.Size(200, 35);
            this.txtvenuename.TabIndex = 38;
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Animated = true;
            this.txtcontactnumber.BorderColor = System.Drawing.Color.Black;
            this.txtcontactnumber.BorderThickness = 2;
            this.txtcontactnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontactnumber.DefaultText = "";
            this.txtcontactnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcontactnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcontactnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontactnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontactnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontactnumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtcontactnumber.ForeColor = System.Drawing.Color.Black;
            this.txtcontactnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontactnumber.Location = new System.Drawing.Point(428, 115);
            this.txtcontactnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.PasswordChar = '\0';
            this.txtcontactnumber.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcontactnumber.PlaceholderText = "Enter Number";
            this.txtcontactnumber.SelectedText = "";
            this.txtcontactnumber.Size = new System.Drawing.Size(200, 35);
            this.txtcontactnumber.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(641, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Animated = true;
            this.txtaddress.BorderColor = System.Drawing.Color.Black;
            this.txtaddress.BorderThickness = 2;
            this.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtaddress.DefaultText = "";
            this.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtaddress.Location = new System.Drawing.Point(645, 114);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PasswordChar = '\0';
            this.txtaddress.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtaddress.PlaceholderText = "Enter Address";
            this.txtaddress.SelectedText = "";
            this.txtaddress.Size = new System.Drawing.Size(200, 35);
            this.txtaddress.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(857, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "Venue Capacity";
            // 
            // txtcapacity
            // 
            this.txtcapacity.Animated = true;
            this.txtcapacity.BorderColor = System.Drawing.Color.Black;
            this.txtcapacity.BorderThickness = 2;
            this.txtcapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcapacity.DefaultText = "";
            this.txtcapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcapacity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtcapacity.ForeColor = System.Drawing.Color.Black;
            this.txtcapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcapacity.Location = new System.Drawing.Point(861, 114);
            this.txtcapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.PasswordChar = '\0';
            this.txtcapacity.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtcapacity.PlaceholderText = "Enter capacity";
            this.txtcapacity.SelectedText = "";
            this.txtcapacity.Size = new System.Drawing.Size(200, 35);
            this.txtcapacity.TabIndex = 41;
            // 
            // Venue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcontactnumber);
            this.Controls.Add(this.txtvenuename);
            this.Controls.Add(this.VenueDGV);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VenueDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2PictureBox CLose;
        private Guna.UI2.WinForms.Guna2PictureBox minimize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnAdmins;
        private Guna.UI2.WinForms.Guna2Button btnBudget;
        private Guna.UI2.WinForms.Guna2Button btnVenue;
        private Guna.UI2.WinForms.Guna2Button btnEvents;
        private Guna.UI2.WinForms.Guna2Button Resetbtn;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2DataGridView VenueDGV;
        private Guna.UI2.WinForms.Guna2TextBox txtvenuename;
        private Guna.UI2.WinForms.Guna2TextBox txtcontactnumber;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtcapacity;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
    }
}