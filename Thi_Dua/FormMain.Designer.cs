
namespace Thi_Dua
{
    partial class FormMain
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
            panel1 = new Panel();
            btnQLCB = new Button();
            btnQLTD = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnQLCB);
            panel1.Controls.Add(btnQLTD);
            panel1.Location = new Point(1, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 777);
            panel1.TabIndex = 0;
            // 
            // btnQLCB
            // 
            btnQLCB.Location = new Point(3, 24);
            btnQLCB.Name = "btnQLCB";
            btnQLCB.Size = new Size(274, 34);
            btnQLCB.TabIndex = 0;
            btnQLCB.Text = "Quản lý cán bộ";
            btnQLCB.UseVisualStyleBackColor = true;
            btnQLCB.Click += btnQLNS_Click;
            // 
            // btnQLTD
            // 
            btnQLTD.Location = new Point(3, 64);
            btnQLTD.Name = "btnQLTD";
            btnQLTD.Size = new Size(274, 34);
            btnQLTD.TabIndex = 0;
            btnQLTD.Text = "Quản lý tài khoản";
            btnQLTD.UseVisualStyleBackColor = true;
            btnQLTD.Click += btnQLTD_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AntiqueWhite;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1919, 58);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imge_user_login_form;
            pictureBox1.Location = new Point(1712, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1743, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.LightSkyBlue;
            panelMain.Location = new Point(287, 64);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1633, 777);
            panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 844);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMain;
        private Button btnQLTD;
        private Button btnQLCB;
        private PictureBox pictureBox1;
        private Label label1;
        //private Label label1;
    }
}