using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Revista
{
    public string TipoColecao;
    public int NumeroEdicao;
    public DateTime AnoRevista;
    public int numeroCaixa;
    public void formatarVizualizacaoRevistas()
    {
        Console.WriteLine("{0,-20} | {1,-15} | {2,-15} | {3,-15}", 
            TipoColecao, NumeroEdicao, AnoRevista.Year, numeroCaixa);
    }
    public bool verificaNumeroRevistaValido(int numeroEdicaoRevista, bool status)
    {
        bool statusNumeroRevista;

        if (numeroEdicaoRevista == NumeroEdicao)
        {
            statusNumeroRevista = true;
            return statusNumeroRevista;
        }
        else
        {
            statusNumeroRevista = false;
        }
        return statusNumeroRevista;
    }

}

