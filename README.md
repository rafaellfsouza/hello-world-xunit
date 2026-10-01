# hello-world-xunit

> **Aluno:** Rafael Luiz Ferreira de Souza
> **RA:** 32511503
> **Disciplina:** Garantia da Qualidade de Software — Gestão e Qualidade de Software
> **Professor:** Daniel Henrique Matos de Paiva
> **Atividade:** Lista de Exercícios — Primeira solução .NET com Testes Unitários (xUnit)

## 📋 Sobre o Projeto

Solução **.NET 10** criada via **CLI** (`dotnet new`) que demonstra os fundamentos de testes
unitários com **xUnit**. O projeto de aplicação (`MeuPrimeiroTeste.App`) contém a classe
`OlaMundo` com o método `ObterMensagem()`, que retorna a string `"Hello, World!"`. O projeto de
testes (`MeuPrimeiroTeste.Tests`) valida o retorno desse método com `Assert.Equal()`, seguindo o
padrão **AAA** (Arrange, Act, Assert).

**Dica pedagógica aplicada:** o método foi projetado para *retornar* dados (string) em vez de
apenas imprimir no terminal via `Console.WriteLine()`, permitindo o teste unitário de forma
isolada. O `Program.cs` apenas consome a classe e exibe o resultado.

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Uso |
|---|---|---|
| [.NET](https://dotnet.microsoft.com/) | 10.0 | Plataforma de desenvolvimento |
| [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/) | 14 | Linguagem de programação |
| [xUnit](https://xunit.net/) | 2.9.3 | Framework de testes unitários |
| [Microsoft.NET.Test.Sdk](https://www.nuget.org/packages/Microsoft.NET.Test.Sdk) | 17.14.1 | Executor de testes |

## 📁 Estrutura da Solução

```text
hello-world-xunit/
├── MeuPrimeiroTeste.sln                        # Solução (agrupa os dois projetos)
├── MeuPrimeiroTeste.App/                       # Projeto de aplicação (código de produção)
│   ├── MeuPrimeiroTeste.App.csproj
│   ├── OlaMundo.cs                             # Classe com o método ObterMensagem()
│   └── Program.cs                              # Ponto de entrada (exibe a mensagem)
└── MeuPrimeiroTeste.Tests/                     # Projeto de testes unitários (xUnit)
    ├── MeuPrimeiroTeste.Tests.csproj
    └── OlaMundoTeste.cs                        # Teste [Fact] com Assert.Equal()
```

## 🚀 Como Executar

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/10.0) instalado
  (verifique com `dotnet --version`).

### Rodar a aplicação

```bash
dotnet run --project MeuPrimeiroTeste.App
```

Saída esperada:

```text
Hello, World!
```

### Rodar os testes unitários

Na raiz da solução:

```bash
dotnet test
```

Resultado esperado (suíte verde ✅):

```text
Passed!  - Failed:     0, Passed:     1, Skipped:     0, Total:     1, Duration: 10 ms - MeuPrimeiroTeste.Tests.dll (net10.0)
```

## 🔧 Comandos Utilizados para Criar a Solução (via .NET CLI)

```bash
# 1. Cria a Solução
dotnet new sln -n MeuPrimeiroTeste

# 2. Cria o projeto da aplicação (Código de Produção)
dotnet new console -n MeuPrimeiroTeste.App -f net10.0

# 3. Cria o projeto de Testes Unitários com xUnit
dotnet new xunit -n MeuPrimeiroTeste.Tests -f net10.0

# 4. Adiciona ambos os projetos à Solução
dotnet sln add MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
dotnet sln add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj

# 5. Adiciona a referência do projeto Principal dentro do projeto de Testes
dotnet add MeuPrimeiroTeste.Tests/MeuPrimeiroTeste.Tests.csproj reference MeuPrimeiroTeste.App/MeuPrimeiroTeste.App.csproj
```

## 📜 Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
