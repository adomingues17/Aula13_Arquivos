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
                        Console.WriteLine("Digite o nome do diretório, por favor.");
                        string arquivo = Console.ReadLine();
                        FileDataService.CriarArquivo(arquivo);                     
                        break;
                    case "2":
                        FileDataService.LerArquivo();                     
                        break;
                    case "3":
                        FileDataService.AcrescentarTexto();                        
                        break;
                    case "4":
                        FileDataService.ApagarArquivo();                        
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
