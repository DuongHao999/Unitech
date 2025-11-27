namespace Thi_Dua.Controls
{
    partial class UserControlQLTK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel4 = new Panel();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dtgvAccount = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1630, 774);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSkyBlue;
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1622, 736);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Đổi mật khẩu";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(428, 113);
            panel4.Name = "panel4";
            panel4.Size = new Size(716, 482);
            panel4.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(252, 306);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(358, 31);
            textBox7.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(252, 229);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(358, 31);
            textBox6.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(87, 309);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 15;
            label8.Text = "Nhập lại mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(87, 232);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 15;
            label5.Text = "Mật khẩu mới:";
            // 
            // button2
            // 
            button2.Location = new Point(293, 373);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(252, 145);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(358, 31);
            textBox4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 145);
            label6.Name = "label6";
            label6.Size = new Size(117, 25);
            label6.TabIndex = 3;
            label6.Text = "Mật khẩu cũ:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(252, 58);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(358, 31);
            textBox5.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(87, 64);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 3;
            label7.Text = "Tên đăng nhập:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSkyBlue;
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1622, 736);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tài khoản";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(195, 80);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 20, 20);
            panel1.Size = new Size(1233, 576);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dtgvAccount);
            panel3.Location = new Point(505, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(707, 511);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(17, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 511);
            panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 33);
            comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 272);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 15;
            label4.Text = "Cán bộ:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(170, 322);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 29);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Đã hoạt động";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(342, 393);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 13;
            button5.Text = "Xóa";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(26, 393);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 12;
            button4.Text = "Tạo mới";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(184, 393);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 11;
            button3.Text = "Chỉnh sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 31);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 206);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(284, 31);
            textBox3.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 136);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên đăng nhập:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 31);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 74);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 3;
            label1.Text = "Mã tài khoản:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dtgvAccount
            // 
            dtgvAccount.BackgroundColor = SystemColors.HighlightText;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(17, 16);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.Size = new Size(669, 473);
            dtgvAccount.TabIndex = 0;
            // 
            // UserControlQLTK
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(tabControl1);
            Name = "UserControlQLTK";
            Size = new Size(1633, 777);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label4;
        private CheckBox checkBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox1;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private Label label8;
        private DataGridView dtgvAccount;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
