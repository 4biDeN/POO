using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Interface
{
    public interface ILembrete
    {
        DateTime DataLembrete { get; set; }
        void EnviarLembrete();
    }
}