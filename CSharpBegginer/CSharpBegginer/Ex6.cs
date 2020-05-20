using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex6 {
        public static void MainEx6(string[] args) {
            var total = 0;

            while(true) {
                Console.WriteLine("Please enter a number or OK to exit:");
                var input = Console.ReadLine();

                if(input.ToLower().Equals("ok")) {
                    break;
                }
                else {
                    total += Int32.Parse(input);
                }
            }

            Console.WriteLine(total);
        }
    }
}
