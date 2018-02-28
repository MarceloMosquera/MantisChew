using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantisChew
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            var user  = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            user = user.IndexOf("\\") > 0 ? user.Substring(user.IndexOf("\\") + 1) : user;
            txtUser.Text = user;
        }

        public string User { get; set; }
        public string Pass { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            User = txtUser.Text;
            Pass = txtPass.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
