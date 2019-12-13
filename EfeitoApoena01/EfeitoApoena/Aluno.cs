using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;


namespace EfeitoApoena
{
    class Aluno
    {
        //Atributos: Dados Pessoais
        private int idAluno;
        private string nome;
        private double cpf;
        private char sexo;
        private DateTime dataNasc;
        private string tpSang;
        private string email;
        private double telefone;
        private double celular;
        private char fatorRH;
        private string StringdeConexao;

        //Construtor: conecta com o banco de dados
        public Aluno()
        {
            //String de conexão com o BD
            StringdeConexao1 = @"Host = 127.0.0.1; Username = postgres; 
                Password = @#$BD1015a1@#$; Database = Efeito_Novo_SQL";
        }

        public int IdAluno { get => idAluno; set => idAluno = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Cpf { get => cpf; set => cpf = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string TpSang { get => tpSang; set => tpSang = value; }
        public string Email { get => email; set => email = value; }
        public double Telefone { get => telefone; set => telefone = value; }
        public double Celular { get => celular; set => celular = value; }
        public char FatorRH { get => fatorRH; set => fatorRH = value; }
        public string StringdeConexao1 { get => StringdeConexao; set => StringdeConexao = value; }

        public void InsereDadosTabPessoa()
        {
            using (NpgsqlConnection conexaocombd = new NpgsqlConnection(StringdeConexao1))
            {
                //Abre a conexão
                conexaocombd.Open();

                //Comando inserir
                using (NpgsqlCommand comando = new NpgsqlCommand())
                {
                    comando.Connection = conexaocombd;//atribui uma conexão ao comando

                    //comando que será executado
                    comando.CommandText = "INSERT INTO aluno(nome , data_nasc , sexo , cpf , celular, " +
                        "telefone, email , tp_sang , fator_rh) " +
                        "values(@nome , @data_nasc , @sexo , @cpf , @celular, @telefone, @email, @tp_sang, @fator_rh)";

                    //seta os parametros que deverão ser passados para a consulta sql
                    comando.Parameters.AddWithValue("nome", Nome);
                    comando.Parameters.AddWithValue("data_nasc", DataNasc);
                    comando.Parameters.AddWithValue("sexo", Sexo);
                    comando.Parameters.AddWithValue("cpf", Cpf);
                    comando.Parameters.AddWithValue("celular", Celular);
                    comando.Parameters.AddWithValue("telefone", Telefone);
                    comando.Parameters.AddWithValue("email", Email);
                    comando.Parameters.AddWithValue("tp_sang", TpSang);
                    comando.Parameters.AddWithValue("fator_rh", FatorRH);

                    //Executa o comando
                    comando.ExecuteNonQuery();
                }
                using (NpgsqlCommand comando = new NpgsqlCommand("SELECT DISTINCT idaluno, cpf FROM aluno WHERE cpf = @cpf ", conexaocombd)) //comando de seleção
                {
                    comando.Parameters.AddWithValue("cpf", Cpf);

                    using (NpgsqlDataReader reader = comando.ExecuteReader()) //executa o comando que retornará uma tabela
                    {
                        //comando.Parameters.AddWithValue("idcadastro", varteste);

                        reader.Read();

                        IdAluno = reader.GetInt32(0);

                        reader.Close();
                    }
                }
                //Fecha a conexão
                conexaocombd.Close();
            }
        }
    }
}
