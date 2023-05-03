using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Digite o preço da gasolina:");
            double precoGasolina = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do álcool:");
            double precoAlcool = double.Parse(Console.ReadLine());

            double resultado = precoAlcool / precoGasolina;

            if (resultado < 0.7)
            {
                Console.WriteLine("Vale mais a pena, abastecer com álcool!");
            }
            else if (resultado > 0.7)
            {
                Console.WriteLine("Vale mais a pena, abastecer com gasolina!");
            }
            else
            {
                Console.WriteLine("Tanto faz abastecer com álcool ou gasolina");
            }

            Console.WriteLine("Deseja efetuar um novo cálculo? (S/N)");
        } while (Console.ReadLine().ToUpper() == "S");
    }
}
