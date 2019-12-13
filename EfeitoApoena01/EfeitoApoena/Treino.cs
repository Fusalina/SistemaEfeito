using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Treino
    {
        //Atributos de treino
        private int idTreino;
        private string cat_Treino;
        private DateTime dataIni;
        private DateTime dataFim;

        //Propriedade com set e get
        public int IdTreino { get => idTreino; set => idTreino = value; }
        public string Cat_Treino { set { cat_Treino = value; } get { return cat_Treino; } }
        public DateTime DataIni { set { dataIni = value; } get { return dataIni; } }
        public DateTime DataFim { set { dataFim = value; } get { return dataFim; } }


    }
}
