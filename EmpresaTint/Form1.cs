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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }//Fim do form load

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//Fim do botão atualizar

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();
        }//Fim do Consultar

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();
        }//Fim do atualizar

        private void excluir_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }//Fim do excluir
    }//Fim da classe
}//Fim do projeto
