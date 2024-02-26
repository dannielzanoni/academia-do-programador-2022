#region Inicialização de váriaveis
string opcaoDoUsuario = "";
string[] nomesEquipamento = new String[5];
decimal[] precosEquipamento = new decimal[5];
int[] seriesEquipamento = new int[5];
DateTime[] datasEquipamento = new DateTime[5];
string[] nomesFabricanteEquipamento = new string[5];

string[] tituloChamados = new string[5];
string[] descricaoChamados = new string[5];
int[] serieChamadosVinculados = new int[5];
string[] nomeChamadosVinculados = new string[5];
DateTime[] datasChamados = new DateTime[5];

int contadorEquipamentos = 0;
int contadorChamados = 0;
#endregion

do
{

    opcaoDoUsuario = ObterOpcaoUsuario(opcaoDoUsuario);

    switch (opcaoDoUsuario)
    {
        case "1":
            RegistrarEquipamentos(nomesEquipamento, precosEquipamento, seriesEquipamento, datasEquipamento, nomesFabricanteEquipamento, contadorEquipamentos);
            contadorEquipamentos++;
            break;
        case "2":
            VizualizarEquipamentos(nomesEquipamento, precosEquipamento, seriesEquipamento, datasEquipamento, nomesFabricanteEquipamento, contadorEquipamentos);
            break;
        case "3":
            EditarEquipamentos(nomesEquipamento, precosEquipamento, seriesEquipamento, datasEquipamento, nomesFabricanteEquipamento, contadorEquipamentos);
            break;
        case "4":
            ExcluirEquipamentos(nomesEquipamento, precosEquipamento, seriesEquipamento, datasEquipamento, nomesFabricanteEquipamento, contadorEquipamentos, 
                nomeChamadosVinculados, serieChamadosVinculados);
            contadorEquipamentos--;
            break;
        case "5":
            RegistrarChamados(tituloChamados, descricaoChamados, serieChamadosVinculados, datasChamados, 
                contadorChamados, contadorEquipamentos, nomesEquipamento, seriesEquipamento, nomeChamadosVinculados);
            contadorChamados++;
            break;
        case "6":
            VizualizarChamados(nomesEquipamento, tituloChamados, descricaoChamados, serieChamadosVinculados, datasChamados,
                contadorChamados, contadorEquipamentos, nomeChamadosVinculados);
            break;
        case "7":
            EditarChamados(tituloChamados, descricaoChamados, serieChamadosVinculados, datasChamados,
                contadorChamados, contadorEquipamentos, nomesEquipamento, seriesEquipamento);
            break;
        case "8":
            ExcluirChamados(tituloChamados, descricaoChamados, serieChamadosVinculados, datasChamados, 
                contadorChamados, contadorEquipamentos, seriesEquipamento);
            contadorChamados--;
            break;
    } 

} while (opcaoDoUsuario != "x");


static string ObterOpcaoUsuario(string OpcaoUsuario)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
    +-+-+-+-+-+-+ +-+-+ +-+-+-+-+-+-+-+-+
    |G|e|s|t|a|o| |d|e| |C|o|n|t|r|o|l|e|
    +-+-+-+-+-+-+ +-+-+ +-+-+-+-+-+-+-+-+
    ");
    Console.ResetColor();
    Console.WriteLine(" Digite uma das opções abaixo:");
    Console.WriteLine("\n=========_Equipamentos_===========\n");
    Console.WriteLine(" 1 - Registrar um equipamento");
    Console.WriteLine(" 2 - Vizualizar todos os equipamentos");
    Console.WriteLine(" 3 - Editar um equipamento");
    Console.WriteLine(" 4 - Excluir um equipamento");
    Console.WriteLine("\n=========_Chamados_===============\n");
    Console.WriteLine(" 5 - Registrar um chamado");
    Console.WriteLine(" 6 - Vizualizar todos os chamados");
    Console.WriteLine(" 7 - Editar um chamado");
    Console.WriteLine(" 8 - Excluir um chamado");
    Console.WriteLine("\n x - Para sair do programa.");
    Console.WriteLine();

    Console.Write(" Comando: ");
    string opcaoDoUsuario = Console.ReadLine();

    return opcaoDoUsuario;
}

 static int RegistrarEquipamentos(string[] nomesEquipamento, decimal[] precosEquipamento, 
    int[] seriesEquipamento, DateTime[] datasEquipamento, string[] nomesFabricanteEquipamento, int contadorEquipamentos)
{
    Console.Clear();
    Console.WriteLine("\n=========_Registrar Equipamentos_===========\n");

    Console.Write("Digite o nome do equipamento: ");
    string nomeEquipamento = Console.ReadLine();
    while (nomeEquipamento.Length < 6)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("O nome deve ter no mínimo 6 caracteres, digite o nome novamente: ");
        Console.ResetColor();
        nomeEquipamento = Console.ReadLine();
    }
    nomesEquipamento[contadorEquipamentos] = nomeEquipamento;

    Console.Write("Digite o preço do equipamento: ");
    decimal precoEquipamento = decimal.Parse(Console.ReadLine());
    precosEquipamento[contadorEquipamentos] = precoEquipamento;

    Console.Write("Digite o número da série: ");
    int serieEquipamento = int.Parse(Console.ReadLine());
    seriesEquipamento[contadorEquipamentos] = serieEquipamento;

    Console.Write("Digite a data de fabricação (dd/mm/yyyy): ");
    DateTime dataEquipamento = DateTime.Parse(Console.ReadLine());
    datasEquipamento[contadorEquipamentos] = dataEquipamento;

    Console.Write("Digite o nome da fabricante: ");
    string fabrincanteEquipamento = Console.ReadLine();
    nomesFabricanteEquipamento[contadorEquipamentos] = fabrincanteEquipamento;

    contadorEquipamentos++;

    Console.Clear();

    return contadorEquipamentos;
}

static void VizualizarEquipamentos(string[] nomesEquipamento, decimal[] precosEquipamento,
    int[] seriesEquipamento, DateTime[] datasEquipamento, string[] nomesFabricanteEquipamento, int contadorEquipamentos)
{
    Console.Clear();
    Console.WriteLine("\n=========_Vizualizar Equipamentos_===========\n");
    

    if (nomesEquipamento[0] == null)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Lista de equipamentos vazia! Por favor cadastre um equipamento para vizualizar.");
        Console.ResetColor();
    }
    else
    {
        for (int i = 0; i < contadorEquipamentos; i++)
        {
            Console.Write($"Equipamento {i+1}: {nomesEquipamento[i]}, Preço: {precosEquipamento[i]}, Série: {seriesEquipamento[i]}, " +
                $"Data de fabricação: {datasEquipamento[i]}, Fabricante: {nomesFabricanteEquipamento[i]}");
            Console.WriteLine();
        }
    }
    Console.ReadKey();
    Console.Clear();
}

static void EditarEquipamentos(string[] nomesEquipamento, decimal[] precosEquipamento,
    int[] seriesEquipamento, DateTime[] datasEquipamento, string[] nomesFabricanteEquipamento, int contadorEquipamentos)
{
    Console.Clear();
    Console.WriteLine("\n=========_Editar Equipamentos_===========\n");

    for (int i = 0; i < contadorEquipamentos; i++)
    {
        Console.Write($"Equipamento {i + 1}: {nomesEquipamento[i]}");
        Console.WriteLine();
    }
    Console.WriteLine("\nQual equipamento você deseja editar?");
    int equipamentoParaEditar = int.Parse(Console.ReadLine());

    Console.Write("Digite o nome do equipamento: ");
    string nomeEquipamento = Console.ReadLine();
    while (nomeEquipamento.Length < 6)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("O nome deve ter no mínimo 6 caracteres, digite o nome novamente: ");
        Console.ResetColor();
        nomeEquipamento = Console.ReadLine();
    }
    nomesEquipamento[equipamentoParaEditar - 1] = nomeEquipamento;

    Console.Write("Digite o preço do equipamento: ");
    decimal precoEquipamento = decimal.Parse(Console.ReadLine());
    precosEquipamento[equipamentoParaEditar - 1] = precoEquipamento;

    Console.Write("Digite o número da série: ");
    int serieEquipamento = int.Parse(Console.ReadLine());
    seriesEquipamento[equipamentoParaEditar - 1] = serieEquipamento;

    Console.Write("Digite a data de fabricação (dd/mm/yyyy): ");
    DateTime dataEquipamento = DateTime.Parse(Console.ReadLine());
    datasEquipamento[equipamentoParaEditar - 1] = dataEquipamento;

    Console.Write("Digite o nome da fabricante: ");
    string fabrincanteEquipamento = Console.ReadLine();
    nomesFabricanteEquipamento[equipamentoParaEditar - 1] = fabrincanteEquipamento;

}

static int ExcluirEquipamentos(string[] nomesEquipamento, decimal[] precosEquipamento,
    int[] seriesEquipamento, DateTime[] datasEquipamento, string[] nomesFabricanteEquipamento, int contadorEquipamentos, string[] nomeChamadosVinculados, int[] serieChamadosVinculados)
{
    Console.Clear();
    Console.WriteLine("\n=========_Excluir Equipamentos_===========\n");
    Console.WriteLine();

    for (int i = 0; i < contadorEquipamentos; i++)
    {
        Console.Write($"Equipamento {i + 1}: {nomesEquipamento[i]}");
        Console.WriteLine();
    }
    Console.WriteLine("\nQual equipamento você deseja excluir?");
    int equipamentoParaExcluir = int.Parse(Console.ReadLine());

    if (serieChamadosVinculados[equipamentoParaExcluir - 1] == seriesEquipamento[equipamentoParaExcluir - 1])
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Equipamento já vinculado á um chamado, por favor digite outro equipamento sem vinculação: ");
        Console.ResetColor();
    }
    else
    {
        for (int i = equipamentoParaExcluir - 1; i < contadorEquipamentos; i++)
            {
                nomesEquipamento[i] = nomesEquipamento[i + 1];
                precosEquipamento[i] = precosEquipamento[i + 1];
                seriesEquipamento[i] = seriesEquipamento[i + 1];
                datasEquipamento[i] = datasEquipamento[i + 1];
                nomesFabricanteEquipamento[i] = nomesFabricanteEquipamento[i + 1];
            }
        contadorEquipamentos--;
    }
    Console.ReadKey();
    Console.Clear();

    return contadorEquipamentos;
}

static int RegistrarChamados(string[] tituloChamados, string[] descricaoChamados, int[] serieChamadosVinculados, 
    DateTime[] datasChamados, int contadorChamados, int contadorEquipamentos, string[] nomesEquipamento, int[] seriesEquipamento, string[] nomeChamadosVinculados)
{
    Console.Clear();
    Console.WriteLine("\n=========_Registrar Chamado===========\n");
    
    Console.Write("Digite o título do chamado: ");
    string tituloChamado = Console.ReadLine();
    tituloChamados[contadorChamados] = tituloChamado;

    Console.Write("Digite a descrição do chamado: ");
    string descricaoChamado = Console.ReadLine();
    descricaoChamados[contadorChamados] = descricaoChamado;


    Console.WriteLine();
    Console.WriteLine("====_Lista de Equipamentos_====");
    for (int i = 0; i < contadorEquipamentos; i++)
    {
        Console.Write($"Equipamento {i + 1}: Nome: {nomesEquipamento[i]}, Série {seriesEquipamento[i]}");
        Console.WriteLine();
    }
    Console.Write("\nDigite a Série do equipamento que deseja vincular ao chamado: ");
    int serieEquipamentoVincular = int.Parse(Console.ReadLine());
    serieChamadosVinculados[contadorChamados] = serieEquipamentoVincular;
    nomeChamadosVinculados[contadorChamados] = nomesEquipamento[serieEquipamentoVincular];

    Console.Write("Digite a data de abertura (dd/mm/yyyy): ");
    DateTime dataChamado = DateTime.Parse(Console.ReadLine());
    datasChamados[contadorChamados] = dataChamado;

    contadorChamados++;

    Console.Clear();
    return contadorChamados;
}

static void VizualizarChamados(string[] nomesEquipamento, string[] tituloChamados, string[] descricaoChamados, int[] idEquipamentoChamados,
    DateTime[] datasChamados, int contadorChamados, int contadorEquipamentos, string[] nomeChamadosVinculados)
{
    Console.Clear();
    Console.WriteLine("\n=========_Vizualizar Chamados_===========\n");

    if (tituloChamados[0] == null)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Lista de chamados vazia! Por favor cadastre um chamado para vizualizar.");
        Console.ResetColor();
    }
    else
    {
        DateTime dataAgora = DateTime.Now;
        
            for (int i = 0; i < contadorChamados; i++)
        {
            Console.Write($"Título {i + 1}: {tituloChamados[i]}, Equipamento: {nomeChamadosVinculados[i]}, Descrição: {descricaoChamados[i]}, " +
                $"Data de abertura: {datasChamados[i]}, Dias abertos: {Convert.ToInt32(dataAgora.Subtract(datasChamados[i]).TotalDays)}");
            Console.WriteLine();
        }
    }
    Console.ReadKey();
    Console.Clear();

}

static void EditarChamados(string[] tituloChamados, string[] descricaoChamados, int[] idEquipamentoChamados,
    DateTime[] datasChamados, int contadorChamados, int contadorEquipamentos, string[] nomesEquipamento, int[] seriesEquipamento)
{
    int serieEquipamentoParaChamado = 0;

    Console.Clear();
    Console.WriteLine("\n=========_Editar Chamado===========\n");


    if (tituloChamados[0] == null)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Lista de chamados vazia! Por favor cadastre um chamado para vizualizar.");
        Console.ResetColor();
    }
    else
    {
        for (int i = 0; i < contadorChamados; i++)
        {
            Console.Write($"Título {i + 1}: {tituloChamados[i]}, Descrição: {descricaoChamados[i]}, ID: {idEquipamentoChamados[i+1]}, " +
                $"Data de abertura: {datasChamados[i]}");
            Console.WriteLine();
        }

        Console.Write("\nQual chamado você deseja editar: ");
        int chamadoParaEditar = int.Parse(Console.ReadLine());

        Console.Write("Digite o título do chamado: ");
        string tituloChamado = Console.ReadLine();
        tituloChamados[chamadoParaEditar - 1] = tituloChamado;

        Console.Write("Digite a descrição do chamado: ");
        string descricaoChamado = Console.ReadLine();
        descricaoChamados[chamadoParaEditar - 1] = descricaoChamado;

        for (int i = 0; i < contadorEquipamentos; i++)
        {
            Console.Write($"Equipamento {i + 1}: {nomesEquipamento[i]}, Série {seriesEquipamento[i]}");
            Console.WriteLine();
        }

        Console.WriteLine();
        for (int i = 0; i < contadorEquipamentos; i++)
        {
            Console.Write($"Equipamento ID({i + 1}): Nome: {nomesEquipamento[i]}, Série {seriesEquipamento[i]}");
            Console.WriteLine();
        }
        Console.Write("\nDigite o novo número(ID) do equipamento que deseja vincular: ");
        int idEquipamento = int.Parse(Console.ReadLine());
        serieEquipamentoParaChamado = seriesEquipamento[idEquipamento - 1];
        if (seriesEquipamento[idEquipamento - 1].Equals(serieEquipamentoParaChamado))
        {

        }

        idEquipamentoChamados[contadorChamados - 1] = serieEquipamentoParaChamado;


        Console.Write("Digite a data de abertura (dd/mm/yyyy): ");
        DateTime dataChamado = DateTime.Parse(Console.ReadLine());
        datasChamados[chamadoParaEditar - 1] = dataChamado;
    }
    Console.ReadKey();
    Console.Clear();

}

static int ExcluirChamados(string[] tituloChamados, string[] descricaoChamados, int[] serieChamadosVinculados,
    DateTime[] datasChamados, int contadorChamados, int contadorEquipamentos, int[] seriesEquipamento)
{
    Console.Clear();
    Console.WriteLine("\n=========_Excluir Chamados_===========\n");
    Console.WriteLine();

    for (int i = 0; i < contadorChamados; i++)
    {
        Console.Write($"Chamado ID({i + 1}): Nome: {tituloChamados[i]}, Série: {serieChamadosVinculados[i]}");
        Console.WriteLine();
    }
    Console.WriteLine("\nDigite a série do chamado que deseja excluir: ");
    int serieParaExcluir = int.Parse(Console.ReadLine());

    if(serieChamadosVinculados[serieParaExcluir - 1] == seriesEquipamento[serieParaExcluir])
    {
        Console.WriteLine("Contem");
    }
    

    for (int i = serieParaExcluir - 1; i < contadorChamados; i++)
    {
        tituloChamados[i] = tituloChamados[i + 1];
        descricaoChamados[i] = descricaoChamados[i + 1];
        serieChamadosVinculados[i] = serieChamadosVinculados[i + 1];
        datasChamados[i] = datasChamados[i + 1];
    }

    contadorChamados--;
    Console.ReadKey();
    Console.Clear();

    return contadorChamados;
}