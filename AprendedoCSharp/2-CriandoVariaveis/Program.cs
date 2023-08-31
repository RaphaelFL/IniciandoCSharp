using System;

class Program
{
    static void Main(String[] arg)
    {
        int idade;
        idade = 27;
        Console.WriteLine(idade);
        idade = 27 - 5 + 3;
        Console.WriteLine(idade);
        idade = 5 * 2 - 6;
        Console.WriteLine(idade);
        idade = (idade + 4) * 8;
        Console.WriteLine(idade);

        double media;
        media = 5 + 8;
        media  = media / 7;

        Console.WriteLine(media);
        int mediaReal= (int)media;
        Console.WriteLine(mediaReal);
        float altura = 1.68f;

        Console.WriteLine("Tecle para fechar!");
        Console.ReadLine();

    }
}