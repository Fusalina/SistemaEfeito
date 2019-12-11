using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Acompanhamento
    {
        //Atributos de acompanhamento
        private DateTime dataAval;
        private double peso;
        private double altura;
        private double pressArt;
        private int batRepouso;
        private string nivelCond;

        //Propriedade com get e set
        public DateTime DataAval
        {
            set { dataAval = value; }
            get { return dataAval; }
        }
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
        public double PressArt
        {
            set { pressArt = value; }
            get { return pressArt; }
        }
        public int BatRepouso
        {
            set { batRepouso = value; }
            get { return batRepouso; }
        }
        public string NivelCond
        {
            set { nivelCond = value; }
            get { return nivelCond; }
        }
    }
}
