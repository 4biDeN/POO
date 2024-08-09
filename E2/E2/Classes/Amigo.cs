using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Amigo : Pessoa
    {
        public DateTime DataAniversario { get; set; }

        public Amigo(string nome, string telefone, DateTime dataAniversario)
            : base(nome, telefone)
        {
            DataAniversario = dataAniversario;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Amigo: {Nome}, Telefone: {Telefone}, Aniversário: {DataAniversario.ToShortDateString()}");
        }
    }
}