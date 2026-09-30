
using System;

class Program
{
    static void Main()
    {
    
        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();

    
        if (int.TryParse(entrada, out int numero))
        {
            Console.WriteLine($"Número convertido com sucesso: {numero}");
        }
        else
        {
            Console.WriteLine("Erro: O valor digitado não é um número inteiro válido.");
        }
    }
}
