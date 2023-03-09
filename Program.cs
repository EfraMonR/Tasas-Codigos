using System;

class Program
{
    static void Main(string[] args)
    {
        double tasaNominal, frecuencia, tasaEfectiva, tasaEfetivaPorcentaje;
        int n;

        Console.Write("Ingrese la tasa nominal en porcentaje: ");
        tasaNominal = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Ingrese la frecuencia de capitalización (por año): ");
        frecuencia = double.Parse(Console.ReadLine());

        n = (int)(frecuencia); // Obtener la cantidad de veces que se capitaliza en un año
        tasaEfectiva = Math.Pow(1 + (tasaNominal / n), n) - 1;

        tasaEfetivaPorcentaje = tasaEfectiva * 100;

        //Console.WriteLine("La tasa de interés anual efectiva es: {0:P2}", tasaEfectiva);
        Console.WriteLine("La tasa de interés anual efectiva en Porcentaje es: " + tasaEfetivaPorcentaje);
    }
}