using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace EfeitoApoena {
    class Conexao {

        public NpgsqlConnection conexao = null;
        string stringConexao = "Server = 127.0.0.1; Port = 4107; Database = postgres; User Id = postgres; Password = 123"; 

        public void AbrirCon() {
            try {
                conexao = new NpgsqlConnection(stringConexao);
                conexao.Open();

            }
            catch (Exception ex) {

                throw ex;
            }
        }


        public void FecharCon() {
            try {
                conexao = new NpgsqlConnection(stringConexao);
                conexao.Close();

            }
            catch (Exception ex) {

                throw ex;
            }
        }
    }
}