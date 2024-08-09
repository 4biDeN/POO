using E2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Classes
{
    public class Agenda
    {
        private List<IContato> contatos;

        public Agenda()
        {
            contatos = new List<IContato>();
        }

        public void AdicionarContato(IContato contato)
        {
            contatos.Add(contato);
        }

        public void ExibirContatos()
        {
            foreach (var contato in contatos)
            {
                contato.ExibirDetalhes();
            }
        }

        public void EnviarLembretes()
        {
            foreach (var contato in contatos)
            {
                if (contato is ILembrete lembrete)
                {
                    lembrete.EnviarLembrete();
                }
            }
        }
    }
}