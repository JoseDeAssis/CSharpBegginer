using System;

namespace HelloWorld {
    class Ex1 {

        static void MainEx1(string[] args) {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10) {
                Console.WriteLine("Valid");
            } else {
                Console.WriteLine("Invalid");
            }
        }
    }
}
