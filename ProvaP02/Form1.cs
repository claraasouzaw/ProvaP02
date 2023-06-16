using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaP02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tx_matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_cadastro_Click(object sender, EventArgs e)
        {
            string matricula = tx_matricula.Text;
            string cpf = tx_cpf.Text;
            string nome = tx_nome.Text;
            string funcao = tx_funcao.Text;
            string salario = tx_salario.Text;

            Funcionario f = new Funcionario(matricula, cpf, nome, funcao, Convert.ToDouble(salario));
            lb_confirm.Text = $"seu salário é";
            lb_confirm2.Text = $"seu jrpf é";


        }

        private void tx_salario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
