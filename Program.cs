using System;

public class CalculadoraFactorial
{
    // Método para calcular el factorial de un número de forma recursiva
    public int CalcularFactorialRecursivo(int n)
    {
        // Condición de Salida: Cuando n llega a 0, se retorna 1.
        if (n == 0)
        {
            return 1;
        }
        else
        {
            // Segmento Recursivo: Multiplica n por el resultado de la llamada recursiva con n-1.
            return n * CalcularFactorialRecursivo(n - 1);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        CalculadoraFactorial factorial = new CalculadoraFactorial();
        int n = 5; // Ejemplo: Calcular 5!
        int resultado = factorial.CalcularFactorialRecursivo(n);
        Console.WriteLine("El factorial es: " + resultado);
    }
}
