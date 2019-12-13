using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Medidas
    {
        //Atributos de Medidas
        private int idMedidas;
        private double pescoco;
        private double peito;
        private double braco;
        private double antebraco;
        private double cintura;
        private double quadris;
        private double coxa;
        private double panturrilha;

        //Propriedade com set e get
        public int IdMedidas { get => idMedidas; set => idMedidas = value; }
        public double Pescoco { set { pescoco = value; } get { return pescoco; } }
        public double Peito { set { peito = value; } get { return peito; } }
        public double Braco { set { braco = value; } get { return braco; } }
        public double Antebraco { set { antebraco = value; } get { return antebraco; } }
        public double Cintura { set { cintura = value; } get { return cintura; } }
        public double Quadris { set { quadris = value; } get { return quadris; } }
        public double Coxa { set { coxa = value; } get { return coxa; } }
        public double Panturrilha { set { panturrilha = value; } get { return panturrilha; } }


    }
}
