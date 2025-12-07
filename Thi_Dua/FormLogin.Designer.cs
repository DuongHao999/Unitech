namespace Thi_Dua
{
    partial class FormLogin
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            lbExit = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_login;
            pictureBox1.Location = new Point(118, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(76, 106);
            label1.Name = "label1";
            label1.Size = new Size(160, 54);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // panel1
            // 
            panel1.Location = new Point(44, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassWord);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(5, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 137);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(47, 87);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(239, 31);
            txtPassWord.TabIndex = 4;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(47, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 31);
            txtUserName.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(16, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 1);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Image = Properties.Resources.lock_logig_form;
            pictureBox3.Location = new Point(16, 87);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(16, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 1);
            panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.imge_user_login_form;
            pictureBox2.Location = new Point(16, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Microsoft JhengHei", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(44, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // lbExit
            // 
            lbExit.AutoSize = true;
            lbExit.Cursor = Cursors.Hand;
            lbExit.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExit.ForeColor = Color.DodgerBlue;
            lbExit.Location = new Point(137, 384);
            lbExit.Name = "lbExit";
            lbExit.Size = new Size(49, 23);
            lbExit.TabIndex = 5;
            lbExit.Text = "EXIT";
            lbExit.Click += label2_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(323, 430);
            Controls.Add(lbExit);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label lbExit;
    }
}
