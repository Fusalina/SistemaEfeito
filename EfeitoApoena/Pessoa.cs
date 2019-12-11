using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Pessoa
    {
        //Atributos: Dados Pessoais
        private string nome;
        private double cPF;
        private char sexo;
        private string dataNasc;//como vamos usar a data?
        private char tpSang;
        private string eMail;
        private char fRH;

        //Propriedades com gets e sets: Dados Pessoais
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public double CPF
        {
            set { cPF = value; }
            get { return cPF; }
        }
        public char Sexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public string DataNasc
        {
            set { dataNasc = value; }
            get { return dataNasc; }
        }
        public char TpSang
        {
            set { tpSang = value; }
            get { return tpSang; }
        }
        public string EMail
        {
            set { eMail = value; }
            get { return eMail; }
        }
        public char FRH
        {
            set { fRH = value; }
            get { return fRH; }
        }
    }
}
