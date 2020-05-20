using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex7 {
        public static void MainEx7(string[] args) {
            Console.WriteLine("Please enter a number:");
            var number = Int32.Parse(Console.ReadLine());
            var total = 1;
            for(var i = number; i > 0; i--) {
                total = total * i;
            }

            Console.WriteLine(total);
        }
    }
}
