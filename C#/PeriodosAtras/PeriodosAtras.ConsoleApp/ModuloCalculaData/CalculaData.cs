using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp.ModuloCalculaData
{
    public class CalculaData
    {
        public TimeSpan CompararDatas(DateTime dataComparada, DateTime dataAgora)
        {
            return dataAgora - dataComparada;
        }

        public string FormatarData2(TimeSpan dataSubtraida)
        {
            string inputFormatado = "";

            string atras = " atrás";

            string[] numeros = new string[10];
            numeros[0] = "Um ";
            numeros[1] = "Dois ";
            numeros[2] = "Três ";
            numeros[3] = "Quatro ";
            numeros[4] = "Cinco ";
            numeros[5] = "Seis ";
            numeros[6] = "Sete ";
            numeros[7] = "Oito ";
            numeros[8] = "Nove ";
            numeros[9] = "Dez ";

            string uma = "Uma ";
            string dia = "dia";
            string dias = "dias";
            string semana = "semana";
            string semanas = "semanas";
            string mes = "mês";
            string meses = "mêses";
            string ano = "ano";
            string anos = "anos";

            if (dataSubtraida.Days == 1)
            {
                if(dataSubtraida.Days % 7 == 0)
                {
                    for (int i = 0; i <= dataSubtraida.Days; i++)
                    {
                        if (dataSubtraida.Days == i)
                        {
                            inputFormatado += uma + semana + atras;
                        }
                    }
                }
                else if(dataSubtraida.Days %7 != 0)
                {
                    for (int i = 0; i <= dataSubtraida.Days; i++)
                    {
                        if (dataSubtraida.Days == i)
                        {
                            inputFormatado += numeros[i - 1] + dia + atras;
                        }
                    }
                }
                
            }
            else if (dataSubtraida.Days > 1 && dataSubtraida.Days < 7)
            {
                for (int i = 0; i <= dataSubtraida.Days; i++)
                {
                    if (dataSubtraida.Days == i)
                    {
                         inputFormatado += numeros[i - 1] + dias + atras;
                    }
                }
            }
            //semana
            else if(dataSubtraida.Days == 7)
            {
                int contador = 0;

                for (int i = 0; i <= dataSubtraida.Days; i++)
                {
                    if(i == 7)
                    {
                        inputFormatado += numeros[i - 1] + semana + atras;
                    }
                }
            }
            //semanas
            else if(dataSubtraida.Days % 7 == 0)
            {
                for (int i = 0; i <= dataSubtraida.Days; i++)
                {
                    if (dataSubtraida.Days == i)
                    {
                        inputFormatado += numeros[i - 1] + mes + atras;
                    }
                }
            }
            //mes/meses
            else if (dataSubtraida.Days > 7)
            {   
                if(dataSubtraida.Days % 30 == 0)
                {
                    for (int i = 0; i <= dataSubtraida.Days; i++)
                    {
                        if (dataSubtraida.Days == i)
                        {
                            inputFormatado += numeros[i - 1] + mes + atras;
                        }
                    }
                }
                else if(dataSubtraida.Days % 31 == 1)
                {
                    for (int i = 0; i <= dataSubtraida.Days; i++)
                    {
                        if (dataSubtraida.Days == i)
                        {
                            inputFormatado += numeros[i - 1] + mes + atras;
                        }
                    }
                }
                //meses
                else if(dataSubtraida.Days > 31)
                {
                    if (dataSubtraida.Days % 30 == 0)
                    {
                        for (int i = 0; i <= dataSubtraida.Days; i++)
                        {
                            if (dataSubtraida.Days == i)
                            {
                                inputFormatado += numeros[i - 1] + meses + atras;
                            }
                        }
                    }
                    else if (dataSubtraida.Days % 31 == 1)
                    {
                        for (int i = 0; i <= dataSubtraida.Days; i++)
                        {
                            if (dataSubtraida.Days == i)
                            {
                                inputFormatado += numeros[i - 1] + meses + atras;
                            }
                        }
                    }
                }
            }
            return inputFormatado;
        }
    }
}
