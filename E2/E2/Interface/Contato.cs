using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Interface
{
    public interface IContato
    {
        string Nome { get; set; }
        string Telefone { get; set; }
        void ExibirDetalhes();
    }
}