namespace TesteDeUnidadeXUnit.API.RegraNegocio
{
    public class Calculadora
    {
        public double Somar(double x, double y)
        {
            return x + y;
        }
        public double Subtrair(double x, double y)
        {
            return x - y;
        }
        public double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public double Dividir(double x, double y)
        {
            if (y == 0) return 0;
            return x / y;
        }
    }
}
