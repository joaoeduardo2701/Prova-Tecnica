using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1, temp;

        while (a <= n)
        {
            if (a == n)
                return true;

            temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}