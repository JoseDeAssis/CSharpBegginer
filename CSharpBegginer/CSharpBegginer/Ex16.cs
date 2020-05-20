using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex16 {
        public static void MainEx16(string[] args) {
            Console.WriteLine("Please enter a few numbers separated by hyphen");
            var input = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(input)) {
                var numbers = input.Split('-');
                var duplicate = false;

                for(int i = 1; i < numbers.Length; i++) {
                    var number = Convert.ToInt32(numbers[i]);
                    var previousNumber = Convert.ToInt32(numbers[i - 1]);

                    if(number == previousNumber) {
                        duplicate = true;
                        break;
                    }
                }

                if(duplicate)
                    Console.WriteLine("Duplicate");
            }
        }
    }
}
