using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula13Arquivos.Services
{
    public class FileDataService()
    {
        public static void CriarArquivo(string nomeDiretorio) {            
            string path = @"D:\impacta\4cSharp\arquivos\";
            string pathComplete = Path.Combine(path, nomeDiretorio);
            Directory.CreateDirectory(pathComplete);
            Console.WriteLine("Diretório criado.");
            Console.ReadKey();
        }

        public static void LerArquivo(string lerArquivo) {
            string path = @"D:\impacta\4cSharp\arquivos\";
            string pathComplete = Path.Combine(path, lerArquivo);
            string texto = File.ReadAllText(pathComplete);
            Console.WriteLine(texto);
            Console.ReadKey();
        }

        public static void AcrescentarTexto(string acrescentarTexto, string conteudo) {
            string path = @"D:\impacta\4cSharp\arquivos\";
            /*string texto = "\n\n Lorem ipsum dolor sit amet, consectetur adipiscing elit, \n" +
                "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. \n" +
                "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip \n" +
                "ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit \n" +
                "esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, \n" +
                "sunt in culpa qui officia deserunt mollit anim id est laborum. \n";*/            
            //string texto = conteudo;//$"\n\n {conteudo} \n";
            string pathComplete = Path.Combine(path, acrescentarTexto);
            File.AppendAllText(pathComplete, conteudo);            
            Console.ReadKey();
        }

        public static void ApagarArquivo(string arquivo) {
            string path = @"D:\impacta\4cSharp\arquivos\";
            string pathComplete = Path.Combine (path, arquivo);
            Directory.Delete(pathComplete);
            Console.WriteLine("Diretório deletado.");
            Console.ReadKey();
        }
    }
}
