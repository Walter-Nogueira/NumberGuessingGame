using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Joguinho de adivinhar o numero");
            Console.WriteLine(" -------------------------------");

            Random randomNumber = new Random();

            int winNumber = randomNumber.Next(0, 100);

            bool win = false;

            while(win == false)
            {
                Console.Write("\n Adivinhe um numero entre 0 e 100: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < winNumber)
                {
                    Console.WriteLine(" Muito baixo. Chute mais alto...");
                }
                else if (number > winNumber)
                {
                    Console.WriteLine(" Muito alto. Chute mais baixo...");
                }
                else if (number == winNumber)
                {
                    Console.WriteLine("\n Voce acertou!!!");
                    win = true;
                }
            }
            Console.WriteLine("\n Obrigado por jogar.");
            Console.WriteLine(" Precione qualquer tecla para encerrar");
            Console.ReadKey(true);
        }
    }
}
