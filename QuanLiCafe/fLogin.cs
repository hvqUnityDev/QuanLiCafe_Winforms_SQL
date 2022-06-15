using QuanLiCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName, passWord))
            {
                fTableManager fTableManager = new fTableManager();
                this.Hide();
                fTableManager.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {
            
            return AccountDAO.Instance.Login(userName, passWord);
        }


        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
