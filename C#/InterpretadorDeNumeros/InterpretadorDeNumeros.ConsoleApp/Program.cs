List<string> numerosLinha1 = new List<string>();

#region numeros

string um = @"
    
   |
   |
";

string dois = @"
 __ 
 __|
|__ 
";

string tres = @"
 __ 
 __|
 __|
";

string quatro = @"
    
|__|
   |
";

string cinco = @"
 __ 
|__ 
 __|
";
string seis = @"
 __ 
|__ 
|__|
";
string sete = @"
 __ 
   |
   |
";
string oito = @"
 __ 
|__|
|__|
";
string nove = @"
 __ 
|__|
 __|
";
string zero = @"
 __ 
|  |
|__|
";
#endregion

string textoExemplo = @"
 __   __   __   __   __        __   __      
|__  |__     | |__| |__|    |  __|  __| |__|
 __| |__|    | |__|  __|    | |__   __|    |

 __        __   __        __   __   __   __ 
 __| |__|    | |__|    |  __| |__  |__  |__|
 __|    |    | |__|    | |__   __| |__|  __|
 
 __   __   __   __   __        __   __      
 __|  __| |__  |__  |__| |__|    | |__|    |
 __| |__   __| |__|  __|    |    | |__|    |

 __   __   __   __   __   __        __      
|  |  __| |__  |__     | |__|    | |__| |__|
|__| |__   __| |__|    | |__|    | |__|    |
";
Console.Write(textoExemplo+"\n");

int contLinha1 = 2;
int contLinha2 = 48;
int contLinha3 = 94;
string numeroPrograma = @"";

//leitura das duas primeiras linhas
for (int i = 1; i <= 37; i++)
{
    string lerNumero = textoExemplo.Substring(contLinha1, textoExemplo.Length - 557);
    numeroPrograma += "\r\n";
    numeroPrograma += lerNumero + "\r\n";
    lerNumero = textoExemplo.Substring(contLinha2, textoExemplo.Length - 557);
    numeroPrograma += lerNumero + "\r\n";
    lerNumero = textoExemplo.Substring(contLinha3, textoExemplo.Length - 557);
    numeroPrograma += lerNumero + "\r\n";

    contLinha1 = contLinha1 + 5;
    contLinha2 = contLinha2 + 5;
    contLinha3 = contLinha3 + 5;


    string[] retorno = CompararNumerosPrograma(textoExemplo, numeroPrograma, um, dois, tres, quatro, cinco, seis, sete, oito, nove, zero);

    lerNumero = @"";
    numeroPrograma = @"";
}

int contLinha5 = 283;
int contLinha6 = 329;
int contLinha7 = 375;

//leitura da segunda linha 
for (int i = 1; i <= 37; i++)
{
    string lerNumero = textoExemplo.Substring(contLinha5, textoExemplo.Length - 557);
    numeroPrograma += "\r\n";
    numeroPrograma += lerNumero + "\r\n";
    lerNumero = textoExemplo.Substring(contLinha6, textoExemplo.Length - 557);
    numeroPrograma += lerNumero + "\r\n";
    lerNumero = textoExemplo.Substring(contLinha7, textoExemplo.Length - 557);
    numeroPrograma += lerNumero + "\r\n";

    contLinha5 = contLinha5 + 5;
    contLinha6 = contLinha6 + 5;
    contLinha7 = contLinha7 + 5;

    string[] retorno = CompararNumerosPrograma(textoExemplo, numeroPrograma, um, dois, tres, quatro, cinco, seis, sete, oito, nove, zero);
    lerNumero = @"";
    numeroPrograma = @"";
}

static string[] CompararNumerosPrograma(string textoExemplo, string numeroPrograma, string um, string dois,
    string tres, string quatro, string cinco, string seis, string sete, string oito, string nove, string zero)
{
    List<string> NumerosParaConsole = new List<string>();
    
    if(numeroPrograma == um)
    {
        NumerosParaConsole.Add("1");
    }else if(numeroPrograma == dois)
    {
        NumerosParaConsole.Add("2");
    }
    else if(numeroPrograma == tres)
    {
        NumerosParaConsole.Add("3");
    }
    else if (numeroPrograma == quatro)
    {
        NumerosParaConsole.Add("4");
    }
    else if (numeroPrograma == cinco)
    {
        NumerosParaConsole.Add("5");
    }
    else if (numeroPrograma == seis)
    {
        NumerosParaConsole.Add("6");
    }
    else if (numeroPrograma == sete)
    {
        NumerosParaConsole.Add("7");
    }
    else if (numeroPrograma == oito)
    {
        NumerosParaConsole.Add("8");
    }
    else if (numeroPrograma == nove)
    {
        NumerosParaConsole.Add("9");
    }
    else if (numeroPrograma == zero)
    {
        NumerosParaConsole.Add("0");
    }

    String[] stringDeNumeros = NumerosParaConsole.ToArray();
    int contador = 0;
    foreach (string listaParaImprimir in NumerosParaConsole)
    {
        Console.Write(listaParaImprimir);
    }
    return stringDeNumeros;
}