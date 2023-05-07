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
    *