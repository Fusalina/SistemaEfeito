using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Plano
    {
        //Atributos de plano de pagamento
        private string tipoPlano;
        private DateTime dataInicio;
        private DateTime dataFinal;
        private DateTime dataPagIni;
        private double valorPlano;
        private int melhorDia;

        //Propriedades com gets e sets
        public string TipoPlano
        {
            set { tipoPlano = value; }
            get { return tipoPlano; }
        }
        public DateTime DataInicio
        {
            set { dataInicio = value; }
            get { return dataInicio; }
        }
        public DateTime DataFinal
        {
            set { dataFinal = value; }
            get { return dataFinal; }
        }
        public DateTime DataPagIni
        {
            set { dataPagIni = value; }
            get { return dataPagIni; }
        }
        public double ValorPlano 
        { 
            set { valorPlano = value; } 
            get { return valorPlano; } 
        }
        public int MelhorDia
        {
            set { melhorDia = value; }
            get { return melhorDia; }

        }
    }
}
