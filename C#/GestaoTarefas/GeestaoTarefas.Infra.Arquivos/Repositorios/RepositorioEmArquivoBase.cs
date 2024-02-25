﻿using GestaoTarefas.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.Infra.Arquivos
{
    public abstract class RepositorioEmArquivoBase<T> where T : EntidadeBase<T>
    {
        protected DataContext dataContext;

        protected int contador = 0;

        public RepositorioEmArquivoBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public abstract List<T> ObterRegistros();

        public virtual void Inserir(T novoRegistro)
        {
            novoRegistro.Numero = ++contador;

            var registros = ObterRegistros();

            registros.Add(novoRegistro);
        }

        public virtual void Editar(T registro)
        {
            var registros = ObterRegistros();

            foreach (var item in registros)
            {
                if (item.Numero == registro.Numero)
                {
                    item.Atualizar(registro);
                    break;
                }
            }
        }

        public void Excluir(T registro)
        {
            var registros = ObterRegistros();

            registros.Remove(registro);
        }

        public List<T> SelecionarTodos()
        {
            return ObterRegistros().ToList();
        }


    }
}
