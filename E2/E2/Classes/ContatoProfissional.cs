using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class ContatoProfissional : Pessoa
    {
        public string Empresa { get; set; }

        public ContatoProfissional(string nome, string telefone, string empresa)
            : base(nome, telefone)
        {
            Empresa = empresa;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Profissional: {Nome}, Telefone: {Telefone}, Empresa: {Empresa}");
        }
    }
}