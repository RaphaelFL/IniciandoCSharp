using System;

class Program
{
    static void Main(String[] arg)
    {
        char letra = 'a';
        Console.WriteLine(letra);
        letra = (char)65;
        Console.WriteLine(letra);
        letra = (char)(64 + 1);
        Console.WriteLine(letra);

        String cursos = @"Cursos disponiveis:
        -Go
        -c#
        -Python
        -Java";
        Console.WriteLine(cursos);
        Console.WriteLine("Cursos de " + 2022);


        Console.WriteLine("Tecle para fechar!");
        Console.ReadLine();
    }
}