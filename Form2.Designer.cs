namespace Appliance_Rental_System__Assignment_
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            UserTxt = new TextBox();
            PassTxt = new TextBox();
            SignupBtn = new Button();
            chkAdmin = new CheckBox();
            chkCustomer = new CheckBox();
            label1 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserTxt
            // 
            UserTxt.AccessibleName = "UserTxt";
            UserTxt.Location = new Point(136, 81);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(258, 27);
            UserTxt.TabIndex = 0;
            // 
            // PassTxt
            // 
            PassTxt.AccessibleName = "PassTxt";
            PassTxt.Location = new Point(136, 148);
            PassTxt.Name = "PassTxt";
            PassTxt.Size = new Size(258, 27);
            PassTxt.TabIndex = 1;
            // 
            // SignupBtn
            // 
            SignupBtn.AccessibleDescription = "SignupBtn";
            SignupBtn.AccessibleName = "SignupBtn";
            SignupBtn.BackColor = SystemColors.ActiveCaption;
            SignupBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            SignupBtn.ForeColor = SystemColors.ButtonHighlight;
            SignupBtn.Location = new Point(136, 269);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.Size = new Size(103, 36);
            SignupBtn.TabIndex = 2;
            SignupBtn.Text = "Sign up";
            SignupBtn.UseVisualStyleBackColor = false;
            SignupBtn.Click += SignupBtn_Click;
            // 
            // chkAdmin
            // 
            chkAdmin.AutoSize = true;
            chkAdmin.Location = new Point(136, 218);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(122, 24);
            chkAdmin.TabIndex = 3;
            chkAdmin.Text = "Administrator";
            chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkCustomer
            // 
            chkCustomer.AutoSize = true;
            chkCustomer.Location = new Point(298, 218);
            chkCustomer.Name = "chkCustomer";
            chkCustomer.Size = new Size(94, 24);
            chkCustomer.TabIndex = 4;
            chkCustomer.Text = "Customer";
            chkCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 219);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 5;
            label1.Text = "Sign up as:";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(630, 363);
            button2.Name = "button2";
            button2.Size = new Size(105, 38);
            button2.TabIndex = 6;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(32, 371);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(360, 23);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? click here to login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 83);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 8;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 150);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(475, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 240);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(229, 190);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(473, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(519, 58);
            label5.Name = "label5";
            label5.Size = new Size(85, 23);
            label5.TabIndex = 12;
            label5.Text = "About Us:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 421);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(chkCustomer);
            Controls.Add(chkAdmin);
            Controls.Add(SignupBtn);
            Controls.Add(PassTxt);
            Controls.Add(UserTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserTxt;
        private TextBox PassTxt;
        private Button SignupBtn;
        private CheckBox chkAdmin;
        private CheckBox chkCustomer;
        private Label label1;
        private Button button2;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}