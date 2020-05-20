using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex2 {
        public static void MainEx2(string[] args) {
            int number1, number2;
            Console.WriteLine("Please enter the first number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= number2) {
                Console.WriteLine("The maximum number is {0}", number1);
            } else {
                Console.WriteLine("The maximum number is {0}", number2);
            } 
        }
    }
}
