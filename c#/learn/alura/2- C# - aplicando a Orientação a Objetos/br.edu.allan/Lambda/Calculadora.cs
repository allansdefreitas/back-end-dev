public class Calculadora
{


    public int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

    public int SomarComLabda(int a, int b) => a + b;
    public int SubtrairComLambda(int a, int b) => a - b;

    public int DividirComLambda(int a, int b) => a / b;

    public int MultiplicarComLambda(int a, int b) => a * b;

}