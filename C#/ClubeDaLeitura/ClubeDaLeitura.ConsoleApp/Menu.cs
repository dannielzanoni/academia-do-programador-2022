using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.ConsoleApp
{
    internal class Menu
    {
        public string opcaoMenu;
        public Revista[] revistas;
        public Emprestimo[] emprestimos;
        public Amigo[] amigos;
        public Caixa[] caixas;

        int posicaoRevistas = 0;
        int posicaoEmprestimos = 0;
        int posicaoAmigos = 0;
        int posicaoCaixas = 0;
        public void apresentarMenu()
        {
            bool continuar = true;
            while(continuar == true)
            {
                Console.WriteLine("Clube da Leitura\n");
                Console.WriteLine("Digite umas da opções à baixo: ");
                Console.WriteLine(" 1 - Gerenciar Revistas");
                Console.WriteLine(" 2 - Gerenciar Empréstimos");
                Console.WriteLine(" 3 - Gerenciar Amigos");
                Console.WriteLine(" 4 - Gerenciar Caixas");
                Console.WriteLine(" 5 - Vizualizar Empréstimos");
                Console.WriteLine(" x - Sair do programa\n");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();
                Console.WriteLine();

                if (opcaoMenu == "x")
                    break;

                if ((opcaoMenu != "s") && (opcaoMenu != "1") && (opcaoMenu != "2") && (opcaoMenu != "3") && (opcaoMenu != "4") && (opcaoMenu != "5") && (opcaoMenu != "x"))
                {
                    opcaoMenuDiferente();
                    continue;
                }
                if(opcaoMenu == "1")
                {
                    opcaoMenuRevistas(opcaoMenu);
                    continue;
                }
                if(opcaoMenu == "2")
                {
                    opcaoMenuEmprestimo(opcaoMenu);
                    continue;
                }
                if(opcaoMenu == "3")
                {
                    opcaoMenuAmigo(opcaoMenu);
                    continue;
                }
                if(opcaoMenu == "4")
                {
                    opcaoMenuCaixa(opcaoMenu);
                    continue;
                }
                if(opcaoMenu == "5")
                {
                    opcaoMenuVizualizarEmprestimos(opcaoMenu);
                    continue;
                }
            }
        }

        #region revista
        public void opcaoMenuRevistas(string opcaoMenu)
        {
            bool continuar = true;
            while (continuar == true)
            {
                Console.Clear();
                Console.WriteLine("Clube da Leitura\n");
                Console.WriteLine(" 1 - Cadastrar Revista");
                Console.WriteLine(" 2 - Vizualizar Revista(s)");
                Console.WriteLine(" x - Voltar para o menu");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();
                if (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "x")
                {
                    opcaoMenuDiferente();
                }

                if (opcaoMenu == "x")
                {
                    Console.Clear();
                    break;
                }
                if (opcaoMenu == "1")
                {
                    Console.Write("\nDigite o tipo de coleção da revista: ");
                    string tipoColecao = Console.ReadLine();
                    Console.Write("Digite o número da edição: ");
                    int numeroEdicao = int.Parse(Console.ReadLine());
                    Console.Write("Digite a data da edição: ");
                    DateTime anoRevista = DateTime.Parse(Console.ReadLine());

                    if (caixas[0] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nÉ necessário cadastrar uma caixa para seguir!");
                        Console.ResetColor();
                        qualquerTeclaParaSair();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nLista de Caixas");
                        Console.WriteLine("\n{0,-20} | {1,-15} | {2,-15}", "Número da Caixa", "Etiqueta", "Cor");
                        for (int i = 0; i < caixas.Length; i++)
                        {
                            if (caixas[i] != null)
                            {
                                caixas[i].formataVizualizadorCaixa();
                            }
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("\nDigite o número da caixa correspondente: ");
                        int numeroCaixa = int.Parse(Console.ReadLine());
                        bool recebeBoolCaixaValida = false;
                        for (int i = numeroCaixa - 1; i < numeroCaixa; i++)
                        {
                            bool statusCaixaValida = true;

                            recebeBoolCaixaValida = verificaNumeroCaixa(numeroCaixa, statusCaixaValida);
                        }
                        if (recebeBoolCaixaValida == true)
                        {
                            addRevista(tipoColecao, numeroEdicao, anoRevista, numeroCaixa);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nNuméro de caixa inexistente! Por favor digite outro número!");
                            qualquerTeclaParaSair();
                        }
                        continue;
                    }
                    continue;
                }
                if (opcaoMenu == "2")
                {
                    vizualizarRevistas(true);
                    continue;
                }
            }
        }
        public void vizualizarRevistas(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                MostrarCabecalho("Gerenciamento de revistas", "Visualizando Revistas");

            if (checaArrayVazia(revistas) == true)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-20} | {1,-15} | {2,-15} | {3,-15}", "Tipo", "Número", "Ano", "Caixa");
                for (int i = 0; i < revistas.Length; i++)
                {
                    if (revistas[i] != null)
                    {
                        revistas[i].formatarVizualizacaoRevistas();
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                qualquerTeclaParaSair();
            }
        }
        public void addRevista(string tipoColecao, int numeroEdicao, DateTime anoRevista, int numeroCaixa)
        {
            Revista revista = new();
            revista.TipoColecao = tipoColecao;
            revista.NumeroEdicao = numeroEdicao;
            revista.AnoRevista = anoRevista;
            revista.numeroCaixa = numeroCaixa;

            for (int i = 0; i < revistas.Length; i++)
            {
                revistas[posicaoRevistas] = revista;
            }
            posicaoRevistas++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Revista adicionada com sucesso! ");
            qualquerTeclaParaSair();
        }
        #endregion

        #region emprestimo
        public void opcaoMenuEmprestimo(string opcaoMenu)
        {
            bool continuar = true;
            while(continuar == true)
            {
                Console.Clear();
                Console.WriteLine("Clube da Leitura - Gerenciamento de Empréstimos\n");
                Console.WriteLine(" 1 - Cadastrar empréstimo");
                Console.WriteLine(" 2 - Vizualizar empréstimo");
                Console.WriteLine(" x - Voltar para o menu");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();

                if (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "x")
                {
                    opcaoMenuDiferente();
                }
                if (opcaoMenu == "x")
                {
                    Console.Clear();
                    break;
                }
                if (opcaoMenu == "1")
                {
                    if (amigos[0] == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nÉ necessário cadastrar um amigo para seguir com a criação de um empréstimo!\n");
                        Console.ResetColor();
                        qualquerTeclaParaSair();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nLista de Amigos");
                        Console.WriteLine("\n{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4, -15}", "ID", "Nome", "Reponsável", "Telefone", "Endereço");
                        for (int i = 0; i < amigos.Length; i++)
                        {
                            if (amigos[i] != null)
                            {
                                amigos[i].formataVizualizadorAmigo();
                            }
                        }
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.Write("\nDigite o ID do amigo: ");
                        int idAmigo = int.Parse(Console.ReadLine());

                        bool recebeBoolIdAmigoValida = false;

                        for (int i = idAmigo -1; i < idAmigo; i++)
                        {
                            bool statusIdValido = true;

                            recebeBoolIdAmigoValida = verificaIdAmigoValido(idAmigo, statusIdValido);
                        }

                        if (recebeBoolIdAmigoValida == true)
                        {
                            bool idAmigoExistente = false;

                            for(int i = idAmigo -1; i < idAmigo; i++)
                            {
                                bool statusIdExistenteValido = true;

                                idAmigoExistente = verificaIdAmigoExistente(idAmigo, statusIdExistenteValido);
                            }
                            if(idAmigoExistente == true)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nEste ID já está cadastrado em um empréstimo!");
                                Console.ResetColor();
                                qualquerTeclaParaSair();
                            }
                            else
                            {
                                Console.Write("Digite o nome do amigo: ");
                                string amigoRevistaPega = Console.ReadLine();

                                if (revistas[0] == null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nÉ necessário cadastrar uma revista para seguir com a criação de um empréstimo!\n");
                                    Console.ResetColor();
                                    qualquerTeclaParaSair();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("\nLista de Revistas\n");
                                    Console.WriteLine("{0,-20} | {1,-15} | {2,-15} | {3,-15}", "Tipo", "Número Edição", "Ano", "Caixa");
                                    for (int i = 0; i < revistas.Length; i++)
                                    {
                                        if (revistas[i] != null)
                                        {
                                            revistas[i].formatarVizualizacaoRevistas();
                                        }
                                    }
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.Write("Digite o número da edição: ");
                                    int numeroRevistaEmprestimo = int.Parse(Console.ReadLine());

                                    bool recebeBoolNumeroRevistaValido = false;

                                    for (int i = numeroRevistaEmprestimo - 1; i < revistas.Length; i++)
                                    {
                                        bool statusNumeroRevistaValido = true;

                                        recebeBoolNumeroRevistaValido = verificaNumeroEdicaoRevista(numeroRevistaEmprestimo, statusNumeroRevistaValido);
                                    }

                                    Console.Write("Digite a data do empréstimo: ");
                                    DateTime dataEmprestimo = DateTime.Parse(Console.ReadLine());
                                    Console.Write("Digite a data de devolução: ");
                                    DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());
                                    addEmprestimo(idAmigo, amigoRevistaPega, numeroRevistaEmprestimo, dataEmprestimo, dataDevolucao);
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nID de Amigo inexistente! Por favor digite outro ID!");
                            qualquerTeclaParaSair();
                        }
                        continue;
                    }
                    continue;
                }
                if(opcaoMenu == "2")
                {
                    vizualizarEmprestimos(true);
                    continue;
                }
            }
        }
        public void addEmprestimo(int idAmigo, string amigoRevistaPega, int numeroRevistaEmprestimo, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            Emprestimo emprestimo = new();
            emprestimo.idAmigoEmprestimo = idAmigo;
            emprestimo.amigoRevistaPega = amigoRevistaPega;
            emprestimo.numeroRevistaEmprestimo = numeroRevistaEmprestimo;
            emprestimo.dataEmprestimo = dataEmprestimo;
            emprestimo.dataDevolucao = dataDevolucao;

            for(int i = 0; i < emprestimos.Length; i++)
            {
                emprestimos[posicaoEmprestimos] = emprestimo;
            }
            posicaoEmprestimos++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Empréstimo adicionado com sucesso!");
            Console.ResetColor();
            qualquerTeclaParaSair();
        }
        public void vizualizarEmprestimos(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                MostrarCabecalho("Gerenciamento de Empréstimos", "Visualizando Empréstimos");

            if (checaArrayVazia(emprestimos) == true)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-20} | {1,-15} | {2,-20} | {3,-20}", "Amigo", "Revista", "Data Empréstimo", "Data de Devolução");
                for (int i = 0; i < emprestimos.Length; i++)
                {
                    if (emprestimos[i] != null)
                    {
                        emprestimos[i].formatarVizualizarEmprestimo();
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                qualquerTeclaParaSair();
            }
        }
        #endregion

        #region amigo
        public void opcaoMenuAmigo(string opcaoMenu)
        {
            bool continuar = true;
            while(continuar == true)
            {
                Console.Clear();
                Console.WriteLine("Clube da Leitura - Gerencimento de Amigos\n");
                Console.WriteLine(" 1 - Cadastrar amigo");
                Console.WriteLine(" 2 - Vizualizar amigos");
                Console.WriteLine(" x - Voltar para o menu");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();
                if (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "x")
                {
                    opcaoMenuDiferente();
                    continue;
                }
                if (opcaoMenu == "x")
                {
                    Console.Clear();
                    break;
                }
                if(opcaoMenu == "1")
                {
                    Console.Write("Digite o ID do amigo: ");
                    int idAmigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do amigo: ");
                    string nomeAmigo = Console.ReadLine();
                    Console.Write("Digite o nome do responsável: ");
                    string nomeResponsavelAmigo = Console.ReadLine();
                    Console.Write("Digite o telefone: ");
                    string telefoneAmigo = Console.ReadLine();
                    Console.Write("Digite o endereço: ");
                    string enderecoAmigo = Console.ReadLine();
                    addAmigo(idAmigo, nomeAmigo, nomeResponsavelAmigo, telefoneAmigo, enderecoAmigo);
                    continue;
                }
                if(opcaoMenu == "2")
                {
                    vizualizarAmigos(true);
                    continue;
                }
            }
        }
        public void addAmigo(int idAmigo, string nomeAmigo, string nomeResponsavelAmigo, string telefoneAmigo, string enderecoAmigo)
        {
            Amigo amigo = new();
            amigo.idAmigo = idAmigo;
            amigo.nomeAmigo = nomeAmigo;
            amigo.nomeResponsavelAmigo = nomeResponsavelAmigo;
            amigo.telefoneAmigo = telefoneAmigo;
            amigo.enderecoAmigo = enderecoAmigo;
            amigo.amigoPossuiEmprestimo = false;

            for(int i = 0; i< amigos.Length; i++)
            {
                amigos[posicaoAmigos] = amigo;
            }
            posicaoAmigos++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Amigo adicionado com sucesso!");
            Console.ResetColor();
            qualquerTeclaParaSair();
        }
        public void vizualizarAmigos(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                MostrarCabecalho("Gerenciamento de Amigos", "Visualizando Amigos");

            if (checaArrayVazia(amigos) == true)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-10} | {1,-15} | {2,-15} | {3,-15} | {4, -15}","ID", "Nome", "Reponsável", "Telefone", "Endereço");
                for (int i = 0; i < amigos.Length; i++)
                {
                    if (amigos[i] != null)
                    {
                        amigos[i].formataVizualizadorAmigo();
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                qualquerTeclaParaSair();
            }
        }
        #endregion

        #region caixa
        public void opcaoMenuCaixa(string opcaoMenu)
        {
            bool continuar = true;
            while (continuar == true)
            {
                Console.Clear();
                Console.WriteLine("Clube da Leitura - Gerencimento de Caixas\n");
                Console.WriteLine("1 - Cadastrar Caixa");
                Console.WriteLine("2 - Vizualizar Caixas");
                Console.WriteLine("x - Voltar para o menu");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();
                if (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "x")
                {
                    opcaoMenuDiferente();
                    continue;
                }
                if (opcaoMenu == "x")
                {
                    Console.Clear();
                    break;
                }
                if (opcaoMenu == "1")
                {
                    Console.Write("Digite a cor da Caixa: ");
                    string corCaixa = Console.ReadLine();
                    Console.Write("Digite a etiqueta: ");
                    string etiquetaCaixa = Console.ReadLine();
                    Console.Write("Digite o número: ");
                    int numeroCaixa = int.Parse(Console.ReadLine());

                    addCaixa(corCaixa, etiquetaCaixa, numeroCaixa);
                    continue;
                }
                if (opcaoMenu == "2")
                {
                    vizualizarCaixas(true);
                    continue;
                }
            }
        }
        public void addCaixa(string corCaixa, string etiquetaCaixa, int numeroCaixa)
        {
            Caixa caixa = new();
            caixa.corCaixa = corCaixa;
            caixa.etiquetaCaixa = etiquetaCaixa;
            caixa.numeroCaixa = numeroCaixa;

            for(int i = 0; i < caixas.Length; i++)
            {
                caixas[posicaoCaixas] = caixa;
            }
            posicaoCaixas++;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Caixa adicionada com sucesso!");
            Console.ResetColor();
            qualquerTeclaParaSair();
        }
        public void vizualizarCaixas(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
                MostrarCabecalho("Gerenciamento de Caixas", "Visualizando Caixas");

            if (checaArrayVazia(caixas) == true)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-20} | {1,-15} | {2,-15}", "Número", "Etiqueta", "Cor");
                for (int i = 0; i < caixas.Length; i++)
                {
                    if (caixas[i] != null)
                    {
                        caixas[i].formataVizualizadorCaixa();
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                qualquerTeclaParaSair();
            }
        }
        #endregion

        #region vizualizar emprestimos
        public void opcaoMenuVizualizarEmprestimos(string opcaoMenu)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Clube da Leitura - Vizualização de Empréstimos");
                Console.WriteLine(" 1 - Vizualizar todos os empréstimos");
                Console.WriteLine(" 2 - Vizualizar empréstimos abertos");
                Console.WriteLine(" x - Voltar para o menu");
                Console.Write("Comando: ");
                opcaoMenu = Console.ReadLine();
                if (opcaoMenu != "1" && opcaoMenu != "2" && opcaoMenu != "x")
                {
                    opcaoMenuDiferente();
                    continue;
                }
                if(opcaoMenu == "x")
                {
                    Console.Clear();
                    break;
                }
                if(opcaoMenu == "1")
                {
                    vizualizarEmprestimos(true);
                    continue;
                }
                if(opcaoMenu == "2")
                {
                    vizualizarEmprestimosAbertos(true);
                    continue;
                }
            }
        }
        public void vizualizarEmprestimosAbertos(bool mostrarCabecalho)
        {
            if (mostrarCabecalho)
            {
                var dataAgora = DateTime.Now;
                MostrarCabecalho($"Empréstimos Abertos - {dataAgora.Day}/{dataAgora.Month}/{dataAgora.Year}", "Visualizando Empréstimos Abertos");
            }
            if (checaArrayVazia(emprestimos) == true)
            {
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("{0,-20} | {1,-15} | {2,-15} | {3,-15}", "Amigo", "Revista", "Data de Empréstimo", "Data de Devolução");
                for (int i = 0; i < emprestimos.Length; i++)
                {
                    if (emprestimos[i] != null)
                    {
                        emprestimos[i].formatarVizualizarEmprestimoAberto();
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                qualquerTeclaParaSair();
            }
        }
        #endregion

        #region metodos uteis
        public void MostrarCabecalho(string titulo, string subtitulo)
        {
            Console.Clear();
            Console.WriteLine(titulo);
            Console.WriteLine();
            Console.WriteLine(subtitulo);
            Console.WriteLine();
        }
        public bool checaArrayVazia(object[] array)
        {
            bool arrayVazia = false;
            if (array[0] == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Nenhum cadastro realizado! Por favor realize um cadastro...\n");
                Console.ResetColor();
                qualquerTeclaParaSair();
                arrayVazia = true;
            }
            else
            {
                arrayVazia = false;
            }
            return arrayVazia;
        }
        public void qualquerTeclaParaSair()
        {
            Console.Write("Digite qualquer tecla para voltar ao menu...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public void opcaoMenuDiferente()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nOpção inválida! Digite qualquer tecla para voltar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        #endregion

        #region metodos verificadores
        public bool verificaNumeroCaixa(int numeroCaixa, bool status)
        {
            bool statusCaixa = status;

            for (int i = 0; i < caixas.Length; i++)
            {
                status = caixas[i].verificaNumeroCaixaValido(numeroCaixa, statusCaixa);
                return status;
            }
            return status;
        }
        public bool verificaIdAmigoValido(int idAmigo, bool status)
        {
            bool statusIdAmigo = status;

            for (int i = 0; i < amigos.Length; i++)
            {
                status = amigos[i].verificaIdAmigo(idAmigo);
                return status;
            }
            return status;
        }
        public bool verificaNumeroEdicaoRevista(int numeroRevistaEmprestimo, bool status)
        {
            bool statusNumeroRevistaValido = status;

            for(int i = 0; i< revistas.Length; i++)
            {
                status = revistas[i].verificaNumeroRevistaValido(numeroRevistaEmprestimo, status);
                return status;
            }
            return status;
        }
        public bool verificaIdAmigoExistente(int idAmigo, bool status)
        {
            bool statusIdAmigoExistente = status;

            for(int i = 0; i < amigos.Length; i++)
            {
                status = amigos[i].verificaIdAmigoExistente(idAmigo, statusIdAmigoExistente);
                return status;
                //if (status)
                //{
                //    amigos[i].amigoPossuiEmprestimo = true;
                //}                
            }
            return status;
        }
        #endregion
        
    }
}
