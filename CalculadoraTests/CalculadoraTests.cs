using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void SomaTeste(int v1, int v2, int resultado)
    {

        int resultadoCalc = _calc.Soma(v1, v2);

        Assert.Equal(resultado, resultadoCalc);
    }


    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(9, 5, 4)]
    public void SubtrairTeste(int v1, int v2, int resultado)
    {

        int resultadoCalc = _calc.Subtrair(v1, v2);

        Assert.Equal(resultado, resultadoCalc);
    }


    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void MultiplicarTeste(int v1, int v2, int resultado)
    {

        int resultadoCalc = _calc.Multiplicar(v1, v2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(3, 3, 1)]
    public void DividirTeste(int v1, int v2, int resultado)
    {

        int resultadoCalc = _calc.Dividir(v1, v2);

        Assert.Equal(resultado, resultadoCalc);
    }


    [Fact]
    public void DividirPor0Teste()
    {

        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void HistoricoTeste()
    {
        _calc.Soma(1,2);
        _calc.Soma(2,2);
        _calc.Soma(17,3);
        _calc.Soma(7,5);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}