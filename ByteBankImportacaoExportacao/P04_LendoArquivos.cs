using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
  partial class Program
  {
    static void LeituraBinaria()
    {
      var caminhoArquivo = @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\testeBinario.txt";

      using (var fs = new FileStream(caminhoArquivo, FileMode.Open))
      using (var leitor = new BinaryReader(fs))
      {
        var agencia = leitor.ReadInt32();
        var numero = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();

        Console.WriteLine($"Titular: {titular} - Conta corrente: Ag.{agencia}, Número: {numero}, Saldo: {saldo}");
      }
    }

    static void UsandoEntradasConsole()
    {
      using (var fluxoDeEntrada = Console.OpenStandardInput())
      using (var fs =
        new FileStream(@"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\entradaConsole.txt",
          FileMode.Create))
      {
        var buffer = new byte[1024];
        while (true)
        {
          var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
          
          fs.Write(buffer,0,bytesLidos);
          fs.Flush();
          Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
        }
      }
    }
  }
}