using E2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Evento : IContato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataEvento { get; set; }
        public string Local { get; set; }

        public Evento(string nome, string telefone, DateTime dataEvento, string local)
        {
            Nome = nome;
            Telefone = telefone;
            DataEvento = dataEvento;
            Local = local;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Evento: {Nome}, Telefone: {Telefone}, Data: {DataEvento.ToShortDateString()}, Local: {Local}");
        }
    }
}