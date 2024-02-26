using GeradorDeTestes.Infra.Compartilhado.Serializadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra
{
    [Serializable]
    public class DataContext
    {
        private readonly ISerializador serializador;
    }
}
