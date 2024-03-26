using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoManagementSystem
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LogInPage Form5 = new LogInPage();
            Hide();
            Form5.Show();
        }

      
    }
}
