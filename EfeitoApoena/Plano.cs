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
        private int plano;
        private string tipoPlano;
        private DateTime dataInicio;
        private DateTime dataFinal;
        private DateTime dataPagIni;
        private double valorPlano;

        //Propriedades com gets e sets
        public int Plan { get => plano; set => plano = value; }
        public string TipoPlano { get => tipoPlano; set => tipoPlano = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFinal { get => dataFinal; set => dataFinal = value; }
        public DateTime DataPagIni { get => dataPagIni; set => dataPagIni = value; }
        public double ValorPlano { get => valorPlano; set => valorPlano = value; }



    }
}
