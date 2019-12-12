using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace EfeitoApoena
{
    public partial class Menu01 : Form
    {

        NpgsqlConnection conexao = new NpgsqlConnection(); // classe de acesso; precisa ser global
        string stringConexao; // criação da string para acessar; precisa ser global


        public Menu01()
        {
            InitializeComponent();
        }

        private void Menu01_Load(object sender, EventArgs e) { // carregamento da janela principal

            stringConexao = "Server = 127.0.0.1; Port = 4107; Database = postgres; User Id = postgres; Password = 123"; // 4 - preenchimento da string
            conexao.ConnectionString = stringConexao; // envio da string para a classe de acesso

        }
        
        private void btnClose_Click(object sender, EventArgs e) { // botão de fechar

            this.Close();
        }

        private void btnCadastro_Click(object sender, EventArgs e) { // botão para janela de cadastro

            Menu02_cadastro FormCadastro = new Menu02_cadastro();
            FormCadastro.ShowDialog();
        }
        
        private void btnAcompanhamento_Click(object sender, EventArgs e){ //botão para janela de acompanhamento

            Menu03_acompanhamento FormCadastro = new Menu03_acompanhamento();
            FormCadastro.ShowDialog();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e) { //botão para janela do financeiro

        }

        private void logoTeste_Click(object sender, EventArgs e) { //teste de conexão com o banco

            try { 
                conexao.Open();
            }
            catch {
                MessageBox.Show("Conexão falhou! Verifique usuário, senha e serviço SQL");
                conexao.Close();
            }
            if (conexao.State.ToString() == "Open") {
                MessageBox.Show("Conexão realizada com sucesso");
                conexao.Close();
            }

        }

    }
}
