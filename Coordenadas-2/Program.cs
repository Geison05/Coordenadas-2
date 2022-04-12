using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel
            int X, Y;

            //Entrada
            string[] valores = Console.ReadLine().Split(' ');
            X = int.Parse(valores[0]);
            Y = int.Parse(valores[1]);

            //Processamento
            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                    Console.WriteLine("Primeiro");

                else if (X < 0 && Y > 0)
                    Console.WriteLine("Segundo");

                else if (X < 0 && Y < 0)
                    Console.WriteLine("Terceiro");

                else
                    Console.WriteLine("Quarto");

                valores = Console.ReadLine().Split(' ');
                X = int.Parse(valores[0]);
                Y = int.Parse(valores[1]);

            }
        }
    }
}