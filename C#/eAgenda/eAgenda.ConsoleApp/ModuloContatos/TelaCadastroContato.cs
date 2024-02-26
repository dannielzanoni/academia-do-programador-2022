using System;
using System.Collections.Generic;
using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.ConsoleApp.ModuloContatos
{
    public class TelaCadastroContato : TelaBase, ITelaCadastrvel
    {
        private readonly IRepositorio<Contato> repositorioContato;
        private Notificador notificador;

        public TelaCadastroContato(
            IRepositorio<Contato> repositorioContato,
            Notificador notificador) : base("Cadastro de Contatos")
        {
            this.repositorioContato = repositorioContato;
            this.notificador = notificador;
        }
        public void InserirRegistro()
        {
            MostrarTitulo("Inserindo novo Contato");

            Contato novoContato = ObterContato();

            string statusValidacao = repositorioContato.Inserir(novoContato);

            if (statusValidacao == "REGISTRO_VALIDO")
                notificador.ApresentarMensagem("Contato inserido com sucesso", TipoMensagem.Sucesso);

            else
                notificador.ApresentarMensagem(statusValidacao, TipoMensagem.Erro);
        }

        public void EditarRegistro()
        {
            MostrarTitulo("Editando Contato");

            bool temContatosCadastrados = VisualizarRegistros("Pesquisando");

            if (temContatosCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhum Contato cadastrado para poder editar!", TipoMensagem.Atencao);
                return;
            }

            int numeroContato = ObterNumContato();
            Console.WriteLine();

            Contato contatoAtualizado = ObterContato();

            bool conseguiuEditar = repositorioContato.Editar(x => x.numero == numeroContato, contatoAtualizado);

            if (!conseguiuEditar)
                notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                notificador.ApresentarMensagem("Contato editado com sucesso!", TipoMensagem.Sucesso);

        }
        public void ExcluirRegistro()
        {
            MostrarTitulo("Excluindo Contato");

            bool temContatosCadastrados = VisualizarRegistros("Pesquisando");

            if (temContatosCadastrados == false)
            {
                notificador.ApresentarMensagem("Nenhum contato cadastrado para poder excluir", TipoMensagem.Atencao);
                return;
            }

            int numContato = ObterNumContato();
            Console.WriteLine();

            bool conseguiuExcluir = repositorioContato.Excluir(x => x.numero == numContato);

            if(!conseguiuExcluir)
                notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Atencao);
            else
                notificador.ApresentarMensagem("Contato excluído com sucesso", TipoMensagem.Sucesso);

        } 

        public bool VisualizarRegistros(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Contatos");

            List<Contato> Contatos = repositorioContato.SelecionarTodos();

            if (Contatos.Count == 0)
            {
                notificador.ApresentarMensagem("Não há nenhum Contato disponível.", TipoMensagem.Atencao);
            }

            foreach (Contato contato in Contatos)
                Console.WriteLine(contato.ToString());

            Console.ReadLine();

            return true;
        }

        #region Métodos privados

        public Contato ObterContato()
        {
            Console.Write("Digite o nome do Contato: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite a empresa: ");
            string empresa = Console.ReadLine();

            Console.Write("Digite o cargo: ");
            string cargo = Console.ReadLine();

            Contato novoContato = new Contato(nome, email, telefone, empresa, cargo);

            return novoContato;
        }

        private int ObterNumContato()
        {
            int numeroContato;
            bool numeroContatoEncontrado;

            do
            {
                Console.Write("Digite o número do Contato que deseja selecionar: ");
                numeroContato = Convert.ToInt32(Console.ReadLine());

                numeroContatoEncontrado = repositorioContato.ExisteRegistro(x => x.numero == numeroContato);

                if (numeroContatoEncontrado == false)
                    notificador.ApresentarMensagem("Número de Contato não encontrado, digite novamente!", TipoMensagem.Atencao);

            } while (numeroContatoEncontrado == false);

            return numeroContato;
        }
        #endregion
    }
}
