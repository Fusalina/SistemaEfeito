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

    }
}
