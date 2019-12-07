using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Endereco
    {
        //Atributos de endereço
        private string rua;
        private int numCasa;
        private string bairro;
        private string cidade;
        private string estado;

        //Propriedade com gets e sets dos atributos
        public string Rua
        {
            set { rua = value; }
            get { return rua; }
        }
        public int NumCasa
        {
            set { numCasa = value; }
            get { return numCasa; }
        }
        public string Bairro
        {
            set { bairro = value; }
            get { return bairro; }
        }
        public string Cidade
        {
            set { cidade = value; }
            get { return cidade; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
    
    }
}
