using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.Compartilhado
{
    public interface ITelaCadastravel
    {
        void Inserir();
        void Editar();
        void Excluir();
        bool VisualizarRegistros(string tipoVisualizacao);
    }
}
