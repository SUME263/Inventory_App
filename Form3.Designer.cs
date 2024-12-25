namespace Appliance_Rental_System__Assignment_
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            LogoutBtn = new Button();
            dataGridView1 = new DataGridView();
            Addbtn = new Button();
            Deletebtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            adminTab = new TabPage();
            EditBtn = new Button();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            customerTab = new TabPage();
            RefreshBtn = new Button();
            pictureBox3 = new PictureBox();
            SearchBtn = new Button();
            Searchtxt = new TextBox();
            label7 = new Label();
            CartBtn = new Button();
            TotalCost = new Label();
            dataGridView2 = new DataGridView();
            applianceBindingSource = new BindingSource(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            adminTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            customerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applianceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.Red;
            LogoutBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutBtn.ForeColor = SystemColors.ButtonHighlight;
            LogoutBtn.Location = new Point(498, 530);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(143, 40);
            LogoutBtn.TabIndex = 7;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleDescription = "";
            dataGridView1.AccessibleName = "";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(848, 374);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(67, 395);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(178, 33);
            Addbtn.TabIndex = 14;
            Addbtn.Text = "Save Item";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Location = new Point(673, 395);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(178, 33);
            Deletebtn.TabIndex = 15;
            Deletebtn.Text = "Delete Item";
            Deletebtn.UseVisualStyleBackColor = true;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 50);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(173, 15);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 19;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(49, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Active user:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(adminTab);
            tabControl1.Controls.Add(customerTab);
            tabControl1.Location = new Point(5, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1080, 467);
            tabControl1.TabIndex = 18;
            // 
            // adminTab
            // 
            adminTab.AccessibleDescription = "AdminTab";
            adminTab.BackColor = Color.Gainsboro;
            adminTab.Controls.Add(EditBtn);
            adminTab.Controls.Add(label6);
            adminTab.Controls.Add(pictureBox2);
            adminTab.Controls.Add(label5);
            adminTab.Controls.Add(dataGridView1);
            adminTab.Controls.Add(Addbtn);
            adminTab.Controls.Add(Deletebtn);
            adminTab.Location = new Point(4, 29);
            adminTab.Name = "adminTab";
            adminTab.Padding = new Padding(3);
            adminTab.Size = new Size(1072, 434);
            adminTab.TabIndex = 0;
            adminTab.Text = "Admin";
            // 
            // EditBtn
            // 
            EditBtn.Location = new Point(373, 396);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(141, 29);
            EditBtn.TabIndex = 21;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // label6
            // 
            label6.Location = new Point(866, 69);
            label6.Name = "label6";
            label6.Size = new Size(200, 100);
            label6.TabIndex = 20;
            label6.Text = "To edit an item, click on  its row and then its cell and after changing the details click on the edit button\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(866, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(908, 15);
            label5.Name = "label5";
            label5.Size = new Size(158, 38);
            label5.TabIndex = 18;
            label5.Text = "Help";
            // 
            // customerTab
            // 
            customerTab.BackColor = Color.Gainsboro;
            customerTab.Controls.Add(label3);
            customerTab.Controls.Add(RefreshBtn);
            customerTab.Controls.Add(pictureBox3);
            customerTab.Controls.Add(SearchBtn);
            customerTab.Controls.Add(Searchtxt);
            customerTab.Controls.Add(label7);
            customerTab.Controls.Add(CartBtn);
            customerTab.Controls.Add(TotalCost);
            customerTab.Controls.Add(dataGridView2);
            customerTab.Location = new Point(4, 29);
            customerTab.Name = "customerTab";
            customerTab.Padding = new Padding(3);
            customerTab.Size = new Size(1072, 434);
            customerTab.TabIndex = 1;
            customerTab.Text = "Customer";
            // 
            // RefreshBtn
            // 
            RefreshBtn.Location = new Point(859, 111);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(195, 29);
            RefreshBtn.TabIndex = 30;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = true;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(859, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(859, 63);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(195, 29);
            SearchBtn.TabIndex = 28;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // Searchtxt
            // 
            Searchtxt.Location = new Point(859, 19);
            Searchtxt.Name = "Searchtxt";
            Searchtxt.Size = new Size(195, 27);
            Searchtxt.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(845, 329);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 25;
            label7.Text = "Total:";
            // 
            // CartBtn
            // 
            CartBtn.Location = new Point(912, 352);
            CartBtn.Name = "CartBtn";
            CartBtn.Size = new Size(142, 42);
            CartBtn.TabIndex = 22;
            CartBtn.Text = "Add to Cart";
            CartBtn.UseVisualStyleBackColor = true;
            CartBtn.Click += CartBtn_Click;
            // 
            // TotalCost
            // 
            TotalCost.Location = new Point(896, 329);
            TotalCost.Name = "TotalCost";
            TotalCost.Size = new Size(170, 24);
            TotalCost.TabIndex = 23;
            TotalCost.Text = "items to buy";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(836, 388);
            dataGridView2.TabIndex = 0;
            // 
            // applianceBindingSource
            // 
            applianceBindingSource.DataSource = typeof(Appliance);
            // 
            // label3
            // 
            label3.Location = new Point(859, 174);
            label3.Name = "label3";
            label3.Size = new Size(195, 107);
            label3.TabIndex = 31;
            label3.Text = "To rent an appliance, select the row and add to cart, Note: You can't rent the same appliance at the same time.\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1089, 574);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(LogoutBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            adminTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            customerTab.ResumeLayout(false);
            customerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)applianceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button LogoutBtn;
        private DataGridView dataGridView1;
        private Button Addbtn;
        private Button Deletebtn;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage adminTab;
        private TabPage customerTab;
        private DataGridView dataGridView2;
        private BindingSource applianceBindingSource;
        private Button CartBtn;
        private Label TotalCost;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button SearchBtn;
        private TextBox Searchtxt;
        private Button EditBtn;
        private PictureBox pictureBox3;
        private Button RefreshBtn;
        private Label label3;
    }
}