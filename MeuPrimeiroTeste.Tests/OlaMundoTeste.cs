using MeuPrimeiroTeste.App;
using Xunit;

namespace MeuPrimeiroTeste.Tests;

/// <summary>
/// Testes unitários da classe OlaMundo.
/// </summary>
public class OlaMundoTeste
{
    [Fact]
    public void ObterMensagem_DeveRetornar_ExatamenteHelloWorld()
    {
        // Arrange: instancia a classe do projeto de produção
        var olaMundo = new OlaMundo();

        // Act: chama o método sob teste
        string resultado = olaMundo.ObterMensagem();

        // Assert: valida se o resultado é exatamente "Hello, World!"
        Assert.Equal("Hello, World!", resultado);
    }
}
