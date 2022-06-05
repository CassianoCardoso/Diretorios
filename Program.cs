CriarDiretoriodGlobo();
CriarArquivo();

//MOVER UM ARQUIVO 
var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,
"globo",
 "América do Sul",
 "Brasil",
  "brasil.txt");

MoverArquivo(origem, destino);

static void MoverArquivo(string pathOrigem, string pathdestino)
{
  if (!File.Exists(pathOrigem))
  {
    System.Console.WriteLine("Arquivo de origem não existe");
    return;
  }
  if (File.Exists(pathdestino))
  {
    System.Console.WriteLine("Arquivo já existe na pasta de destino");
    return;
  }

  File.Move(pathOrigem, pathdestino);
}


//--------------------------------------------------------------------------------------------------------------------

//CRIAR UM ARQUIVO
static void CriarArquivo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

  if (!File.Exists(path))
  {
    using var sw = File.CreateText(path);

    sw.WriteLine("População: 213 MM");
    sw.WriteLine("IDH: 0,901");
    sw.WriteLine("Dados Atualizado em 20/05/2022");
  }

}
//--------------------------------------------------------------------------------------------
static void CriarDiretoriodGlobo()
{
  //CRIAR O DIRETÓRIO
  var path = Path.Combine(Environment.CurrentDirectory, "globo");

  if (!Directory.Exists(path))
  {
    var dirGlobo = Directory.CreateDirectory(path);

    var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
    var dirAmCentral = dirGlobo.CreateSubdirectory("América do Central");
    var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");


    dirAmNorte.CreateSubdirectory("USA");
    dirAmNorte.CreateSubdirectory("Mexico");
    dirAmNorte.CreateSubdirectory("Canada");

    dirAmCentral.CreateSubdirectory("Costa Rica");
    dirAmCentral.CreateSubdirectory("Panama");


    dirAmSul.CreateSubdirectory("Brasil");
    dirAmSul.CreateSubdirectory("Argentina");
    dirAmSul.CreateSubdirectory("paraguai");
  }

}

