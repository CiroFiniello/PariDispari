using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pari o Disparii");

        int numero = 0;

        Console.WriteLine("Inserisci un numero");
        numero = int.Parse(Console.ReadLine());
        if (numero <= 0)
        {
            Console.WriteLine("Il numero deve essere positivo");
            return;
        }
        if (numero % 2 == 0)
        {
            Console.WriteLine("il numero " + numero + " è pari");
        }
        else
        {
            Console.WriteLine("il numero " + numero + "è dispari");
        }
        Console.WriteLine("Premi un tasto per ");
    }
}