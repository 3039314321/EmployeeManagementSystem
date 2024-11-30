using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class change : Login
    {
        public change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginName = this.textBox1.Text;
            string oldPassword = this.textBox2.Text;
            string newPassword = this.textBox3.Text;
            ChangePassword(loginName, oldPassword, newPassword);
        }
    }
}
