namespace Edu.Allan.Calculadora.Modelos

{
    public class Calculadora
    {

        public static double Somar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public static double Subtrair(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public static double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public static double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }

        public static double RaizQuadrada(double valor)
        {
            return Math.Sqrt(valor);
        }

        public static double Potencia(double valorBase, double valorExpoente)
        {
            return Math.Pow(valorBase, valorExpoente);
        }
    }
}
