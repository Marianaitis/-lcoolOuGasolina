using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Etanol ou Gasolina? ---");

        Console.Write("digite o preco do etanol: ");
        var e = Convert.ToDecimal(Console.ReadLine());

        Console.Write("digite o preco da gasolina: ");
        var g = Convert.ToDecimal(Console.ReadLine());

        string r;

        if (e / g >= 0.73m)
        {
            r = "gasolina";
        }
        else
        {
            r = "etanol";
        }

        decimal resultado = e / g * 100;

        Console.WriteLine("");
        Console.WriteLine("o etanol é " + resultado.ToString("N1") + "% do preco da gasolina");
        Console.WriteLine("abasteça com " + r.ToUpper());

        Console.ReadLine();
    }
}
