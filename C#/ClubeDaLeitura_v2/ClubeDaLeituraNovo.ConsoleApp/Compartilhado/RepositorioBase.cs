using System.Collections.Generic;

namespace ClubeDaLeituraNovo.ConsoleApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected readonly List<T> registros;

        protected int contadorNumero;

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual string Inserir(T entidade)
        {
            entidade.numero = ++contadorNumero;

            registros.Add(entidade);

            return "REGISTRO_VALIDO";
        }
    }
}
