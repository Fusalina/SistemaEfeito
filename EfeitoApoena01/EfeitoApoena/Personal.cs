using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;


namespace EfeitoApoena
{
    class Personal
    {
        //Atributos: Dados Pessoais
        private int idPersonal;
        private string nome;
        private double cpf;
        private double cref;
        private char sexo;
        private DateTime dataNasc;
        private string email;
        private double telefone;
        private double celular;

        private string StringdeConexao;

        //Construtor: conecta com o banco de dados
        public Personal()
        {
            //String de conexão com o BD
            StringdeConexao1 = @"Host = 127.0.0.1; Username = postgres; 
                Password = @#$BD1015a1@#$; Database = Efeito_Novo_SQL";
        }

        public int IdPersonal { get => idPersonal; set => idPersonal = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Cpf { get => cpf; set => cpf = value; }
        public double Cref { get => cref; set => cref = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Email { get => email; set => email = value; }
        public double Telefone { get => telefone; set => telefone = value; }
        public double Celular { get => celular; set => celular = value; }
        public string StringdeConexao1 { get => StringdeConexao; set => StringdeConexao = value; }

    }
}
