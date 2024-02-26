using ControleDeMedicamentos.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;    

namespace ControleDeMedicamentos.ConsoleApp.ModuloMedicamento
{
    public class TelaCadastroMedicamento : TelaBase, ITelaCadastravel
    {
        private readonly RepositorioMedicamento _repositorioMedicamento;
        private readonly Notificador _notificador;

        public TelaCadastroMedicamento(RepositorioMedicamento repositorioMedicamento,
            Notificador notificador):base("Cadastro de Medicamentos")
        {
            _repositorioMedicamento = repositorioMedicamento;
            _notificador = notificador;
        }

        public override string MostrarOpcoes()
        {
            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");
            Console.WriteLine("Digite 5 para Visualizar Medicamentos em falta");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;   
        }

        public void Inserir()
        {
            MostrarTitulo("Cadastro de Medicamento");

            Medicamento medicamento = ObterMedicamento();

            _repositorioMedicamento.Inserir(medicamento);

            _notificador.ApresentarMensagem("Medicamento adicionado com sucesso!", TipoMensagem.Sucesso);

        }
        public void Editar()
        {
            MostrarTitulo("Editando Medicamento");

            bool temMedicamentosCadastrados = VisualizarRegistros("Pesquisando");

            if (temMedicamentosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum medicamento cadastrado para editar", TipoMensagem.Atencao);
            }

            int numeroMedicamento = ObterNumeroRegistro();

            Medicamento medicamentoAtualizado = ObterMedicamento();

            bool conseguiuEditar = _repositorioMedicamento.Editar(numeroMedicamento, medicamentoAtualizado);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Medicamento editado com sucesso!", TipoMensagem.Sucesso);

        }
        public void Excluir()
        {
            MostrarTitulo("Excluindo Medicamento");

            bool temMedicamentosCadastrados = VisualizarRegistros("Pesquisando");

            if(temMedicamentosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum medicamento cadastrado para excluir!", TipoMensagem.Atencao);
                return;
            }

            int numeroMedicamento = ObterNumeroRegistro();

            bool conseguiuEditar = _repositorioMedicamento.Excluir(numeroMedicamento);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível excluir o medicamento!", TipoMensagem.Atencao);
            else
                _notificador.ApresentarMensagem("Medicamento excluído com sucesso!", TipoMensagem.Sucesso);
        }
        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Medicamentos");

            List<Medicamento> medicamentos = _repositorioMedicamento.SelecionarTodos();

            if (medicamentos.Count == 0)
            {
                _notificador.ApresentarMensagem("Nenhum funcionário disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Medicamento medicamento in medicamentos)
                Console.WriteLine(medicamento.ToString());

            Console.ReadLine();

            return true;
        }

        public bool VisualizarMedicamentosEmFalta(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Medicamentos em falta");

            List<Medicamento> medicamentosEmFalta = _repositorioMedicamento.Filtrar(x => x.TemMedicamentoEmFalta());

            if (medicamentosEmFalta.Count == 0)
            {
                _notificador.ApresentarMensagem("Não há nenhum medicamento em falta!.", TipoMensagem.Sucesso);
                return false;
            }

            foreach (Medicamento amigo in medicamentosEmFalta)
                Console.WriteLine(amigo.ToString());

            Console.ReadLine();

            return true;
        }

        public Medicamento ObterMedicamento()
        {
            Console.WriteLine("Digite o nome do medicamento: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua descrição: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite a quantidade disponível: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            return new Medicamento(nome, descricao, quantidade);
        }

        public int ObterNumeroRegistro()
        {
            int numeroRegistro;
            bool numeroRegistroEncontrado;

            do
            {
                Console.Write("Digite o ID do medicamento para editar: ");
                numeroRegistro = Convert.ToInt32(Console.ReadLine());

                numeroRegistroEncontrado = _repositorioMedicamento.ExisteRegistro(numeroRegistro);

                if(numeroRegistroEncontrado == false)
                {
                    _notificador.ApresentarMensagem("ID do medicamento não foi encontrado, digite novamente", TipoMensagem.Atencao);
                }

            }while(numeroRegistroEncontrado == false);

            return numeroRegistro;
        }
    }
}
