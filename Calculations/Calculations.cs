namespace Calculations
{
    internal class Calculations
    {
        public static double Somar(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }
        public static double Subtrair(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }
        public static double Multiplicar(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }
        public static double Dividir(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
        public static bool IsNumeroPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
