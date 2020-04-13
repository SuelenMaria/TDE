using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text == "Suh") && (txtPass.Text == "123"));
            {
                Form2 frmp = new Form2();
                frmp.Show();
                this.Visible = false;
            }
            

        }

        
    }

        
}

