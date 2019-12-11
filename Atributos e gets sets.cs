using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class TipoDado
    {
        //Atributos: Dados pessoais
        private string nome;
        private double cPF;
        private char sexo;
        private string dataNasc;//como vamos usar a data?
        private char tpSang;

        //Atributos: Dados de contato e endereço
        private string logradouro;
        private int numResidencia;
        private string nomeBairro;
        private string nomeCidade;
        private string eMail;
        private double numTelefone;

        //Atributos: Avaliação
        private double peso;
        private double altura;
        private double pressaoArterial;
        private int batRepouso;
        private string nivelCondic;

        //Atribrutos: Medidas
        private double pescoco;
        private double peito;
        private double braco;
        private double antebraco;
        private double cintura;
        private double quadris;
        private double coxa;
        private double panturrilha;

        //Atributos: Treino e exercicios
        //private string nome; (penso em usar o mesmo atributo de dados pessoais)
        //private double peso;(penso em usar o mesmo atributo de avaliação)
        private string catTreino;
        private int serie;
        private int repeticao;
        private string posicao;
        private string acaoPrincipal;
        private string observacoes;

        //Atributos: Plano e pagamento
        private string tpPlano;
        private double valPlano;
        private string formaPgto;

        //Atributos: Tempo
        //ainda não sei como vamos usar a data

        //Propriedades com gets e sets: Dados pessoais
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
        /*public string DataNasc
        {
            set { dataNasc = value; }
            get { return dataNasc; }
        } (Ainda não definido)*/
        public char TpSang
        {
            set { tpSang = value; }
            get { return tpSang; }
        }

        //Propriedade com gets e sets: Dados de contato e endereço
        public string Logradouro
        {
            set { logradouro = value; }
            get { return logradouro; }
        }
        public int NumResidencia
        {
            set { numResidencia = value; }
            get { return numResidencia; }
        }

        public string NomeBairro
        {
            set { nomeBairro = value; }
            get { return nomeBairro; }
        }
        public string NomeCidade
        {
            set { nomeCidade = value; }
            get { return nomeCidade; }
        }

        public string EMail
        {
            set { eMail = value; }
            get { return eMail; }
        }
        public double NumTelefone
        {
            set { numTelefone = value; }
            get { return numTelefone; }
        }

        //Priedade com gets e sets: Avaliação
        public double Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public double Altura
        {
            set { altura = value; }
            get { return altura; }
        }
        public double PressaoArterial
        {
            set { pressaoArterial = value; }
            get { return pressaoArterial; }
        }
        public int BatRepouso
        {
            set { batRepouso = value; }
            get { return batRepouso; }
        }
        public string NivelCondic
        {
            set { nivelCondic = value; }
            get { return nivelCondic; }
        }
       
        //Propriedade com gets e sets: Medidas
        public double Pescoco
        {
            set { pescoco = value; }
            get { return pescoco; }
        }
        public double Peito
        {
            set { peito = value; }
            get { return peito; }
        }
        public double Braco
        {
            set { braco = value; }
            get { return braco; }
        }
        public double Antebraco
        {
            set { antebraco = value; }
            get { return braco; }
        }
        public double Cintura
        {
            set { cintura = value; }
            get { return cintura; }
        }
        public double Quadris
        {
            set { quadris = value; }
            get { return quadris; }
        }
        public double Coxa
        {
            set { coxa = value; }
            get { return coxa; }
        }
        public double Panturrilha
        {
            set { panturrilha = value; }
            get { return panturrilha; }
        }

        //Propriedade com gets e sets: Treino e exercicios
        //private string nome; (penso em usar o mesmo atributo de dados pessoais)
        //private double peso;(penso em usar o mesmo atributo de avaliação)
        public string CatTreino
        {
            set { catTreino = value; }
            get { return catTreino; }
        }
        public int Serie
        {
            set { serie = value; }
            get { return serie; }
        }
        public int Repeticao
        {
            set { repeticao = value; }
            get { return repeticao; }
        }
        public string Posicao
        {
            set { posicao = value; }
            get { return posicao; }
        }
        public string AcaoPrincipal
        {
            set { acaoPrincipal = value; }
            get { return acaoPrincipal; }
        }
        public string Observacoes
        {
            set { observacoes = value; }
            get { return observacoes; }
        }
        //Propriedade com gets e sets: Plano e pagamento
        private string tpPlano;
        private double valPlano;
        private string formaPgto;

    }
}
