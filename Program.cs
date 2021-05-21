using System;

namespace calculadoraidade
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento = new DateTime(2001, 9, 23);
            DateTime agora = new DateTime(2021, 5, 21);
            TimeSpan vida = nascimento-agora;
            int vivi = vida.Days;
            Console.Write("Eu nasci no dia "+nascimento);
            Console.Write(" e já vivi "+vivi+" dias.");
            
        }
    }
}
