using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTint
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa Código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa Nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa Telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa Endereço

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Dados Atualizados com Sucesso!");
            this.Close();
        }//Fim do botão atualizar

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox2.Text = "Informe o Código";
                textBox3.Text = "Informe o Código";
                textBox4.Text = "Informe o Código";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);//Coletando o código

                textBox2.Text = atu.RetornarNome(codigo);//Preenchendo o campo nome
                textBox3.Text = atu.RetornarTelefone(codigo);//Preenchendo o campo telefone
                textBox4.Text = atu.RetornarEndereco(codigo);//Preenchendo o campo endereço

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
        }//Fim do botão buscar
    }//Fim da classe
}//Fim do projeto
