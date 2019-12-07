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
        private string formaPgto;
        private DateTime dataPgto;
        private DateTime dataVcto;

        //Propriedade com get e set

        public string FormaPgto
        {
            set { formaPgto = value; }
            get { return formaPgto; }

        }
        public DateTime DataPgto 
        {
            set { dataPgto = value; }
            get { return dataPgto; }
        }
        public DateTime DataVcto
        {
            set { dataVcto = value; }
            get { return dataVcto; }
        }
    }
}
