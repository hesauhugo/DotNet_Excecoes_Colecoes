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

    