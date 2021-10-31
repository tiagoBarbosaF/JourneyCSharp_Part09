using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
  partial class Program
  {
    static void Main(string[] args)
    {
      File.WriteAllText(@"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\escrevendoComAClasseFile.txt",
        "Testando a escrita direta da Classe File!!!!!!");

      Console.WriteLine("Arquivo criado!");

      var bytesArquivo =
        File.ReadAllBytes(@"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\contas.txt");
      Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

      var linhas = File.ReadAllLines(@"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\contas.txt");
      Console.WriteLine(linhas.Length);
      // Console.WriteLine("Digite o seu nome:");
      // var nome = Console.ReadLine();
      //
      // Console.WriteLine(nome);

      // UsandoEntradasConsole();
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
      var encoding = Encoding.UTF8;
      var texto = encoding.GetString(buffer, 0, bytesLidos);
      Console.Write(texto);
    }
  }
}