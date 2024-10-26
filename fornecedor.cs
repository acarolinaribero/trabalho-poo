using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_poo
{
    internal class Fornecedor
    {
        public string Nome { get; set; }

        public int id { get; set; }

        public Fornecedor(string nome)
        {
            Nome = nome;
        }
    }
}
