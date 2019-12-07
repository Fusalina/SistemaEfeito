using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfeitoApoena
{
    class Aluno
    {
        //Atributo de aluno
        private int alunoCod;

        //Propriedade com get e set de aluno

        public int AlunoCod
        {
            set { alunoCod = value; }
            get { return alunoCod; }
        }
    }
}
