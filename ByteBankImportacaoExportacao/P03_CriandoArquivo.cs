using System;
using System.IO;
using System.Text;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
  partial class Program
  {
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
      var campos = linha.Split(',');

      var agencia = campos[0];
      var numero = campos[1];
      var saldo = campos[2].Replace('.', ',');
      var nomeTitular = campos[3];

      var agenciaComoInt = int.Parse(agencia);
      var numeroComoInt = int.Parse(numero);
      var saldoComoDouble = double.Parse(saldo);

      var titular = new Cliente();
      titular.Nome = nomeTitular;

      var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
      resultado.Depositar(saldoComoDouble);
      resultado.Titular = titular;

      return resultado;
    }

    static void CriarArquivo()
    {
      var caminhoNovoArquivo =
        @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\contasExportadas.csv";

      using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
      using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
      {
        escritor.Write("987,987654,45687.90,Tiago Barbosa Farias");
      }
    }
    
    static void TestaEscrita()
    {
      var caminhoArquivo = @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\teste.txt";
      
      using(var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
      using (var escritor = new StreamWriter(fluxoDeArquivo))
      {
        for (int i = 0; i < 10000; i++)
        {
          escritor.WriteLine($"Linha {i}");
          escritor.Flush();
          Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma!");
          Console.ReadLine();
        }
      }
    }

    static void TestaEscritaBinaria()
    {
      var caminhoArquivo = @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\testeBinario.txt";
      
      using(var fs = new FileStream(caminhoArquivo, FileMode.Create))
      using (var escritor = new BinaryWriter(fs))
      {
        escritor.Write(987);
        escritor.Write(987654);
        escritor.Write(4250.05);
        escritor.Write("Tiago Barbosa");
      }
    }
  }
}