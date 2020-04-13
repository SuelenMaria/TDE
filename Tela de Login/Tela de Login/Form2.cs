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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String sobrenome = txtEnd.Text;
            String numero = txtNum.Text;
            String telefone = mskTel.Text;
            String servico = cmbServ.Text;
            String horario = dtpHora.Text;

            MessageBox.Show("Salvo com Sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtNum.Text = "";
            mskTel.Text = "";
            cmbServ.Text = "";
            dtpHora.Text = "";
        }
    }
}
