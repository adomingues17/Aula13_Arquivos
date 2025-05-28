using Aula13Arquivos.Services;

namespace Aula13Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }
        
        public static void RunApplication()
        {
            while (true)
            {
                DisplayMenu();
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o nome do diretório a ser criado, por favor.");
                        var pastaCriar = Console.ReadLine();
                        FileDataService.CriarArquivo(pastaCriar);                     
                        break;
                    case "2":
                        Console.WriteLine("Digite o nome do arquivo a ser aberto.");
                        var arquivoLer = Console.ReadLine();
                        FileDataService.LerArquivo(arquivoLer);                     
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome do arquivo a ser alterado.");
                        var arquivoAlterar = Console.ReadLine();                       
                        Console.WriteLine("Digite o conteúdo a ser inserido no arquivo.");
                        var conteudo = Console.ReadLine();
                        FileDataService.AcrescentarTexto(arquivoAlterar, conteudo);                      
                        break;
                    case "4":
                        Console.WriteLine("Digite o nome do diretório a ser deletado por favor.");                        
                        var pastaDeletar = Console.ReadLine();
                        FileDataService.ApagarArquivo(pastaDeletar);
                        break;
                    case "5":
                        return;                       
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }        
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Criar Arquivo.");
            Console.WriteLine("2 - Ler Arquivo");
            Console.WriteLine("3 - Acrescentar Texto.");
            Console.WriteLine("4 - Apagar Arquivo.");
            Console.WriteLine("5 - Sair");
        }
    }
}
