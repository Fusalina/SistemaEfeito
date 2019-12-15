using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Pagamento
    {
        //Atributos de pagamento
        private int idPagamento;
        private string formaPgto;
        private DateTime dataPgto;
        private DateTime dataVcto;

        public int IdPagamento { get => idPagamento; set => idPagamento = value; }
        public string FormaPgto { get => formaPgto; set => formaPgto = value; }
        public DateTime DataPgto { get => dataPgto; set => dataPgto = value; }
        public DateTime DataVcto { get => dataVcto; set => dataVcto = value; }

        //Propriedade com get e set


    }
}
