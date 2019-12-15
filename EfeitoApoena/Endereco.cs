using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace EfeitoApoena
{
    class Endereco
    {
        //Atributos de endereço
        private int idEndereco;
        private string rua;
        private int numCasa;
        private string bairro;
        private string cidade;
        private int id_Aluno;
        private int id_Personal;

        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
        public string Rua { get => rua; set => rua = value; }
        public int NumCasa { get => numCasa; set => numCasa = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public int Id_Aluno { get => id_Aluno; set => id_Aluno = value; }
        public int Id_Personal { get => id_Personal; set => id_Personal = value; }


    }
}
