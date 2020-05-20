using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex9 {
        public static void MainEx9(string[] args) {
            Console.WriteLine("Please enter the numbers:");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Int32.Parse(numbers[0]);

            foreach(var number in numbers) {
                var num = Int32.Parse(number);

                if(max < num) {
                    max = num;
                }
            }

            Console.WriteLine("The maximum number is {0}", max);
        }
    }
}
