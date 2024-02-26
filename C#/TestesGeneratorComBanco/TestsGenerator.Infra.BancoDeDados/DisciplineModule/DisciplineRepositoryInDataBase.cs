using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.BancoDeDados.DisciplineModule
{
    public class DisciplineRepositoryInDataBase : IRepository<Discipline>
    {
        private const string enderecoBanco =
                "Data Source=(LocalDb)\\MSSqlLocalDB;" +
                "Initial Catalog=eAgendaDb;" +
                "Integrated Security=True;" +
                "Pooling=False";

        private const string sqlInserir = @"INSERT INTO [TBDISCIPLINA]
                            (
                                [NOME],
                            )
                            VALUES
                            (
                                @n,
                            );SELECT SCOPE_INDETITY();";

        private const string sqlExcluir =
            @"DELETE FROM [TBDISCIPLINA]
                WHERE
                    [NUMERO] = @NUMERO";

        private const string sqlSelecionarPorId =
            @"SELECT
                    [NUMERO],
                    [NOME]
                FROM
                    [TBDISCIPLINA]
                WHERE
                    [NUMERO] = @NUMERO";

        private const string sqlSelecionarTodos =
             @"SELECT
                    [NUMERO],
                    [NOME]
                FROM
                    [TBDISCIPLINA]";

        public List<Discipline> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            List<Discipline> disciplines = new List<Discipline>();

            while (leitorDisciplina.Read())
            {
                Discipline discipline = ConverterParaDisciplina(leitorDisciplina);

                disciplines.Add(discipline);
            }

            //fechar a conexao
            conexaoComBanco.Close();

            return disciplines;
        }

        private static Discipline ConverterParaDisciplina(SqlDataReader leitorDisciplina)
        {
            int numero = Convert.ToInt32(leitorDisciplina["NUMERO"]);
            string name = Convert.ToString(leitorDisciplina["NOME"]);

            var discipline = new Discipline
            {
                Id = numero,
                Name = name
            };
            return discipline;
        }

        public ValidationResult Delete(Discipline discipline)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            ConfigurarParametrosDisciplina(discipline, comandoExclusao);

            conexaoComBanco.Open();
            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));
                
                conexaoComBanco.Close();

            return resultadoValidacao; 
        }

        public Discipline GetByIndex(int index)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorId, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", index);

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();

            Discipline discipline = null;
            if (leitorDisciplina.Read())
            {
                discipline = ConverterParaDisciplina(leitorDisciplina);
            }

            return discipline;
        }

        public ValidationResult Insert(Discipline novaDisciplina)
        {
            var validador = new DisciplineValidator();

            var resultadoValidacao = validador.Validate(novaDisciplina);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosDisciplina(novaDisciplina, comandoInsercao);

            conexaoComBanco.Open();
            var id = comandoInsercao.ExecuteScalar();
           novaDisciplina.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        private static void ConfigurarParametrosDisciplina(Discipline novaDisciplina, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", novaDisciplina.Id);
            comando.Parameters.AddWithValue("NOME", novaDisciplina.Name);
        }
    }
}
