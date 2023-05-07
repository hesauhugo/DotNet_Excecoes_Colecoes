using System ;

try
{

    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }

}catch (FileNotFoundException ex)
{

    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. {ex.Message}");

}catch (Exception ex)
{

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");

}finally{
    Console.WriteLine($"Chegou no Finally")
}