## Repositório
* Criar git Ignore

```ps
    echo "" > .gitignore
```

* Incluindo pastas e arquivos no git ignore
* O sinal de  >> espeficica que o texto do echo será incluído na linha final do arquivo

```ps
    echo "*.obj" >> .gitignore
    echo "*.bin" >> .gitignore
```

## Try catch
* Tratando excessão genéricas.
* Podemos ter mais de um bloco catch
* Exceções específicas `FileNotFoundException` ou `DirectoryNotFoundeException`
* Finally

```csharp

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
        Console.WriteLine($"Chegou no Finally");
    }

```
## Throw

* Dispara ratreando em forma de cascata. (stack trace)
* Se tiver um bloco cath será usado a exceção.

```csharp
    new Excecoes().Metodo1();
```    

## Filas

* First In First Out

```csharp

    Queue<int> fila = new Queue<int>();

    //incluir elementos
    fila.Enqueue(2);
    fila.Enqueue(4);
    fila.Enqueue(6);
    fila.Enqueue(8);

    foreach (int item in fila)
    {
        Console.WriteLine(item);
    }

    //tirar elementos
    Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

    foreach (int item in fila)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Adicionando elemento : {10}");
    fila.Enqueue(10);

    foreach (int item in fila)
    {
        Console.WriteLine(item);
    }

```

## Pilhas

* Remove o ultimo que entrou
* Last In First Out

```csharp
    Stack<int> pilha = new Stack<int>();

    pilha.Push(4);
    pilha.Push(6);
    pilha.Push(8);
    pilha.Push(10);

    foreach (int item in pilha)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

    Console.WriteLine($"Adicionando o elemento do topo: {20}");

    pilha.Push(20);

    foreach (int item in pilha)
    {
        Console.WriteLine(item);
    }
```

## Dictionary

* Chave valor sem uma ordem específica

## Referências
 1. .[https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated]
 2. .[https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-numeric-format-strings]
 3. .[https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1]
 4. .[https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/tokens/interpolated]
 5. .[https://docs.microsoft.com/pt-br/dotnet/standard/base-types/custom-numeric-format-strings]
 6. .[https://docs.microsoft.com/pt-br/dotnet/api/system.datetime]
 7. .[https://riptutorial.com/csharp/example/19285/datetime-tryparseexact-string--string--iformatprovider--datetimestyles--datetime-]

