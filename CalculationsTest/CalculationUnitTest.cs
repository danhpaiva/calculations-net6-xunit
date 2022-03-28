using Xunit;

namespace CalculationsTest
{
    public class CalculationUnitTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        [InlineData(int.MinValue, +1, int.MinValue +1)]
        public void Somar_DoisNumerosRelativos_RetornaNumeroRelativo(int num1, int num2, int valorEsperado)
        {
            //Act
            var resultado = Calc.Somar(num1, num2);
            //Assert
            Assert.Equal(valorEsperado, resultado);
        }
        [Fact]
        public void Subtrair_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = -0.2;
            // Act  
            var subtracao = Calc.Subtrair(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, subtracao, 1);
        }
        [Fact]
        public void Multiplicar_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 8.99;
            // Act  
            var mult = Calc.Multiplicar(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, mult, 2);
        }
        [Fact]
        public void Dividir_DoisDouble_RetornaDouble()
        {
            // Arrange  
            var num1 = 2.9;
            var num2 = 3.1;
            var valorEsperado = 0.94; //Rounded value  
            // Act  
            var div = Calc.Dividir(num1, num2);
            //Assert  
            Assert.Equal(valorEsperado, div, 2);
        }
    }
}
