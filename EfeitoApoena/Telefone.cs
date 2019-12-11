using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Telefone
    {
        private string tipo;
        private double numTel;

        public string Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public double NumTel
        {
            set { numTel = value; }
            get { return numTel; }
        }
    }
}
