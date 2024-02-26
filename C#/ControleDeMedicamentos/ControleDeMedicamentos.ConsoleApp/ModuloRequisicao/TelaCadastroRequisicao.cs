using System;
using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using ControleDeMedicamentos.ConsoleApp.ModuloMedicamento;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRequisicao
{
    public class TelaCadastroRequisicao : TelaBase
    {
        private readonly RepositorioRequisicao _repositorioRequisicao;
        private readonly Notificador _notificador;

        public TelaCadastroRequisicao(RepositorioRequisicao repositorioRequisicao, Notificador notificador):base("Cadastro de Requisição") 
        {
            _repositorioRequisicao = repositorioRequisicao;
            _notificador = notificador;
        }
        public void Inserir()
        {
            MostrarTitulo("Cadastro de Requisicão");
            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Visualizar");
        }
        public void Editar()
        {

        }
        public void Excluir()
        {

        }
        public bool VisualizarRegistros(string tipoVisualizado)
        {
            return true;
        }
        
    }
}
