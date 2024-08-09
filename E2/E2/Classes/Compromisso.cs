using E2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Compromisso : IContato, ILembrete
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DateTime DataLembrete { get; set; }
        public string Local { get; set; }

        public Compromisso(string nome, string telefone, DateTime dataCompromisso, DateTime dataLembrete, string local)
        {
            Nome = nome;
            Telefone = telefone;
            DataCompromisso = dataCompromisso;
            DataLembrete = dataLembrete;
            Local = local;
        }

        public void EnviarLembrete()
        {
            Console.WriteLine($"Lembrete enviado para o compromisso '{Nome}' marcado para {DataCompromisso.ToShortDateString()} no local '{Local}'");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Compromisso: {Nome}, Telefone: {Telefone}, Data: {DataCompromisso.ToShortDateString()}, Local: {Local}");
        }
    }
}