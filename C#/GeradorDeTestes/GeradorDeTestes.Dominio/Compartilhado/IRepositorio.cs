using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeradorDeTestes.Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase<T>
    {
        ValidationResult Inserir(T novoRegistro);

        ValidationResult Editar(T registro);

        ValidationResult Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorNumero(int numero);
    }
}