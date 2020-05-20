using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex8 {
        public static void MainEx8(string[] args) {
            var number = new Random();
            var randomNumber = number.Next(1, 10);
            var correctGuess = false;

            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Please enter a number:");
                int guess = Int32.Parse(Console.ReadLine());

                if (guess == randomNumber) {
                    correctGuess = true;
                    break;
                }
            }

            if (correctGuess) {
                Console.WriteLine("You won!");
            } else {
                Console.WriteLine("You lost!");
            }

            Console.WriteLine(randomNumber);

        }
    }
}
