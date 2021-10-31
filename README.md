# Entrada e saída (I/O) com streams

## Objetivos ao completar os estudos

- Abra e crie arquivos com C#
- Compreenda o que é encoding, UTF8, Unicode, ASCII e outros
- Use buffers para lidar com fluxo de dados
- Crie arquivos binários
- Conheça a classe File

## Ementas:

### Lendo arquivos de texto
- Entendendo fluxo de dados
- Criando um FileStream
- Enumeradores
- Usando encoding
- Lendo documento
- Mãos na massa
- O que aprendi?
  - Como lidar com arquivos grandes e maiores que a RAM do computador;
  - O que são Streams;
  - Como usar o método `Read` e buffers;
  - Endereço de arquivo relativo;
  - Unicode e encoding UTF;


### FileStream e leitor StreamReader
- Método Close e using
- Trabalhando com buffers
- Usando o StreamReader
- Quando usar partial?
- Mãos na massa
- Erro ao ler arquivo
- O que aprendi?
  - O modificador `partial`;
  - O método `Close` de um stream;
  - Como usar o `StreamReader`;
  - Os métodos `Read`, `ReadLine` e `ReadToEnd`;
  - A propriedade `EndOfStream`.

### Fazendo Parse e StreamWriter
- Convertendo o texto para contacorrente
- Lendo arquivo CSV
- Criando arquivos CSV
- Usando StreamWriter e CreateNew
- Copiando arquivos
- Mãos na massa
- O que aprendi?
  - Os métodos `int.Parse` e `double.Parse`;
  - O formato de arquivo `.csv`;
  - Como escrever diretamente no `stream`;
  - Diferença entre `FileMode.Create` e `FileMode.CreateNew`;
  - Como usar o `StreamWriter`

### Flush e arquivos binários
- Método Flush
- Escrita binaria
- BinaryWriter vs StreamWriter
- Mãos na massa
- O que aprendi?
  - O método `Flush`;
  - `BinaryReader` e `BinaryWriter`.

### Streams da Console
- Usando o stream de entrada da Console
- Auxiliares na classe File
- Classe File
- Conclusão
- Projeto final do curso
- Mãos na massa
- O que aprendi?
  - Como a `Console` funciona com streams;
  - O método `Console.OpenStandardInput()`;
  - Métodos auxiliares na classe `File`;