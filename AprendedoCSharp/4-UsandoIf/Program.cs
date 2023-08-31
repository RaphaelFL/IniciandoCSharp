using System;

class Program
{
    static void Main(String[] arg)
    {
        int idadeJoão = 16;
        int quantidadePessoas = 2;
        bool acompanhado = quantidadePessoas > 1;

        if (idadeJoão >= 18 || acompanhado)
        {
            Console.WriteLine("Pode Entra!");
        }
        else
        {
            Console.WriteLine("Cai Fora!");
        }

        Console.WriteLine("Tecle para fechar!");
        Console.ReadLine();
    }
}
