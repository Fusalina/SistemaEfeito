using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace EfeitoApoena
{
    class Endereco
    {
        //Atributos de endereço
        private int idEndereco;
        private string rua;
        private int numCasa;
        private string bairro;
        private string cidade;

        private string StringdeConexao;

        readonly Aluno AlunoClass = new Aluno();//Instanciação da classe pessoa

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int NumCasa { get => numCasa; set => numCasa = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        //Construtor: conecta com o banco de dados
        public Endereco()
        {
            //String de conexão com o BD
            StringdeConexao = @"Host = 127.0.0.1; Username = postgres; 
                Password = @#$BD1015a1@#$; Database = Efeito_Novo_SQL";
        }

        public void InsereDadosTabEndereco()
        {
            using (NpgsqlConnection conexaocombd = new NpgsqlConnection(StringdeConexao))
            {
                //Abre a conexão
                conexaocombd.Open();

                //Comando inserir
                using (NpgsqlCommand comando = new NpgsqlCommand())
                {
                    comando.Connection = conexaocombd;//atribui uma conexão ao comando

                    //comando que será executado
                    comando.CommandText = "INSERT INTO endereco(rua , numero , bairro , cidade , id_aluno) " +
                        "values(@rua , @numero , @bairro , @cidade , @id_aluno) ";

                    //seta os parametros que deverão ser passados para a consulta sql
                    comando.Parameters.AddWithValue("rua", Rua);
                    comando.Parameters.AddWithValue("numero", NumCasa);
                    comando.Parameters.AddWithValue("bairro", Bairro);
                    comando.Parameters.AddWithValue("cidade", Cidade);
                    comando.Parameters.AddWithValue("id_aluno", AlunoClass.IdAluno);

                    //Executa o comando
                    comando.ExecuteNonQuery();
                }
                using (NpgsqlCommand comando = new NpgsqlCommand("SELECT DISTINCT idendereco,id_aluno endereco WHERE id_aluno = @id_aluno ", conexaocombd)) //comando de seleção
                {
                    comando.Parameters.AddWithValue("id_aluno", AlunoClass.IdAluno);

                    using (NpgsqlDataReader reader = comando.ExecuteReader()) //executa o comando que retornará uma tabela
                    {
                        //comando.Parameters.AddWithValue("idcadastro", varteste);

                        reader.Read();

                        IdEndereco = reader.GetInt32(0);

                        reader.Close();
                    }
                }
                //Fecha a conexão
                conexaocombd.Close();
            }
        }

    }
}
