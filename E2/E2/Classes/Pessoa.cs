using E2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public abstract class Pessoa : IContato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public abstract void ExibirDetalhes();

        protected Pessoa(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}