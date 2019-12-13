using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Exercicios
    {
        //Atributos
        private int idExerc;
        private string nome;
        private double peso;
        private int serie;
        private int repeticao;
        private string posicao;
        private string acaoPrincipal;
        private string observacoes;

        //Propriedades

        public int IdExerc { get => idExerc; set => idExerc = value; }
        public string Nome { set { nome = value; } get { return nome; } }
        public double Peso { set { peso = value; } get { return peso; } }
        public int Serie { set { serie = value; } get { return serie; } }
        public int Repeticao { set { repeticao = value; } get { return repeticao; } }
        public string Posicao { set { posicao = value; } get { return posicao; } }
        public string AcaoPrincipal { set { acaoPrincipal = value; } get { return acaoPrincipal; } }
        public string Observacoes { set { observacoes = value; } get { return observacoes; } }

    }
}
