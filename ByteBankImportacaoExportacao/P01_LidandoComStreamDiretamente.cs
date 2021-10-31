using System.IO;

namespace ByteBankImportacaoExportacao
{
  partial class Program
  {
    static void LidandoComFileStream()
    {
      var arquivo = @"C:\Users\tiago.farias\dev\Alura\JourneyCSharpPart09\IOWithStreams\contas.txt";
      using (var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open))
      {
        var buffer = new byte[1024];

        var quantidadeBytesLidos = -1;

        while (quantidadeBytesLidos !=0)
        {
          quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
          EscreverBuffer(buffer,quantidadeBytesLidos);
        }
      }
    }
  }
}