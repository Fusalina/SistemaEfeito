using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Avaliacao
    {
        //Atributos de acompanhamento
        private DateTime dataAval;
        private double peso;
        private double altura;
        private double pressArt;
        private int batRepouso;
        private string nivelCond;

        public DateTime DataAval { get => dataAval; set => dataAval = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public double PressArt { get => pressArt; set => pressArt = value; }
        public int BatRepouso { get => batRepouso; set => batRepouso = value; }
        public string NivelCond { get => nivelCond; set => nivelCond = value; }
    }
}
