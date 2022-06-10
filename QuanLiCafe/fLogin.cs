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
            fTableManager fTableManager = new fTableManager();
            this.Hide();
            fTableManager.ShowDialog();
            this.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
