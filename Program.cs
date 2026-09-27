using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os lados do triângulo desejado.");
        Console.WriteLine();

        // Lendo os lados com o "!" para evitar erro de valor nulo
        Console.Write("Lado 1..: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Lado 2..: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Lado 3..: ");
        double c = double.Parse(Console.ReadLine()!);

        // Calculo do semiperimetro
        double p = (a + b + c) / 2;

        // Calculo da area (Heron)
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine();
        Console.WriteLine("Semiperímetro..: " + p);
        Console.WriteLine("Área...........: " + area);
    }
}