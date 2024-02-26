namespace GeradorDeTestes.Infra.Compartilhado.Serializadores
{
    public interface ISerializador
    {
        DataContext CarregarDadosDoArquivo();
        void GravarDadosEmArquivo(DataContext dados);
    }
}