using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex15 {
        public static void MainEx15(string[] args) {
            Console.WriteLine("Please enter a few numbers separated by hyphen");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            var sequence = true;

            for(int i = 1; i < numbers.Length; i++) {
                var number = Convert.ToInt32(numbers[i]);
                var previousNumber = Convert.ToInt32(numbers[i - 1]);

                if(number - 1 == previousNumber) {
                    continue;
                } else {
                    sequence = false;
                    break;
                }
            }

            if(sequence) {
                Console.WriteLine("Consecutive");
            } else {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
