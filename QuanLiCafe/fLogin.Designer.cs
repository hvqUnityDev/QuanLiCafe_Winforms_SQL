
namespace QuanLiCafe
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 147);
            this.panel1.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(285, 111);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "Thoát";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPassWord);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(57, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 30);
            this.panel3.TabIndex = 2;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(116, 3);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(187, 23);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.Text = "1";
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(173, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(57, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 30);
            this.panel2.TabIndex = 1;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(116, 3);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(187, 23);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.Text = "k9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 188);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOut;
    }
}

