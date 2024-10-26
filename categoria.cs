using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_poo
{
    internal class Categoria
    {
        public string Nome { get; set; }
        public int id { get; set; }

        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}
