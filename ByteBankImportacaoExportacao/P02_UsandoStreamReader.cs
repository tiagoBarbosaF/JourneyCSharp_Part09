using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
  partial class Program
  {
    static void UsandoStreamReader()
    {
      var arquivo = @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\contas.txt";
      using (var fluxoDeArquivo = new FileStream(arquivo, FileMode.Open))
      using (var leitor = new StreamReader(fluxoDeArquivo))
      {
        while (!leitor.EndOfStream)
        {
          var linha = leitor.ReadLine();
          Console.WriteLine(linha);
        }
      }
    }
  }
}