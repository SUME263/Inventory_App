namespace Appliance_Rental_System__Assignment_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoginBtn = new Button();
            Exitbtn = new Button();
            SignUpLink = new LinkLabel();
            UserTxt = new TextBox();
            PassTxt = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveBorder;
            LoginBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(463, 265);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(119, 32);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Red;
            Exitbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbtn.ForeColor = SystemColors.ButtonHighlight;
            Exitbtn.Location = new Point(703, 376);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(101, 29);
            Exitbtn.TabIndex = 1;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // SignUpLink
            // 
            SignUpLink.AutoSize = true;
            SignUpLink.Location = new Point(386, 376);
            SignUpLink.Name = "SignUpLink";
            SignUpLink.Size = new Size(251, 20);
            SignUpLink.TabIndex = 2;
            SignUpLink.TabStop = true;
            SignUpLink.Text = "New here? click to create an account";
            SignUpLink.LinkClicked += SignUpLink_LinkClicked;
            // 
            // UserTxt
            // 
            UserTxt.AccessibleName = "UserTxt";
            UserTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserTxt.ForeColor = SystemColors.ControlText;
            UserTxt.Location = new Point(463, 107);
            UserTxt.Name = "UserTxt";
            UserTxt.Size = new Size(362, 31);
            UserTxt.TabIndex = 3;
            // 
            // PassTxt
            // 
            PassTxt.AccessibleName = "PassTxt";
            PassTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassTxt.ForeColor = SystemColors.ControlText;
            PassTxt.Location = new Point(463, 204);
            PassTxt.Name = "PassTxt";
            PassTxt.PasswordChar = '*';
            PassTxt.Size = new Size(362, 31);
            PassTxt.TabIndex = 4;
            PassTxt.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(395, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(395, 204);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(395, 27);
            label1.Name = "label1";
            label1.Size = new Size(178, 46);
            label1.TabIndex = 7;
            label1.Text = "Welcome!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(368, 378);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 462);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PassTxt);
            Controls.Add(UserTxt);
            Controls.Add(SignUpLink);
            Controls.Add(Exitbtn);
            Controls.Add(LoginBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginBtn;
        private Button Exitbtn;
        private LinkLabel SignUpLink;
        private TextBox UserTxt;
        private TextBox PassTxt;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
    }
}