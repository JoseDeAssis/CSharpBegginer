using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex14 {
        public static void MainEx14(string[] args) {
            var numbers = new List<int>();
            while (true) {
                Console.WriteLine("Please enter at least 5 numbers separated by comma");
                var input = Console.ReadLine();
                var separatedNumbers = input.Split(",");
                if (separatedNumbers.Length >= 5) {
                    for (int i = 0; i < separatedNumbers.Length; i++) {
                        numbers.Add(Int32.Parse(separatedNumbers[i]));
                    }
                    break;
                }
            }

            numbers.Sort();

            Console.WriteLine(numbers[0] + ", " + numbers[1] + ", " + numbers[2]);
        }
    }
}
