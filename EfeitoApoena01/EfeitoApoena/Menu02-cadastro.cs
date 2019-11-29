using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Adição das bibliotecas de banco de dados
using Npgsql;
using NpgsqlTypes;

namespace EfeitoApoena
{
    public partial class Menu02_cadastro : Form
    {
        public Menu02_cadastro()
        {
            InitializeComponent();
        }

        private void txtbNome_TextChanged(object sender, EventArgs e)
        {
            /*(txtbNome.Enabled = false;
                if (txtbNome.Enabled == false)
                {
                this.txtbNome.BackColor = Color.LightGray;
                }else
                {
                this.txtbNome.BackColor = Color.DarkGray;
                }
            */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu02_cadastro_Load(object sender, EventArgs e)
        {
            string connString = @"Host=127.0.0.1;Username=postgres;Password=ifsp;Database=efeitosystem";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    string nome = ;
                    char sexo = ;
                    int cpf = ;
                    string email = ;
                    string tp_sang = ;
                    char fator_rh = ;
                    cmd.CommandText = "insert into PESSOA(NOME,DATA_NASC,SEXO,CPF,EMAIL,TP_SANG,FATOR_RH) values(@nome, @data_nasc, @sexo, @cpf, @email, @tp_sang, @fator_rh); ";
                }
            }
            
        }

        private void rbtnHomem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
