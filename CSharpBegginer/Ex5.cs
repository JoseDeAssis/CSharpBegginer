using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex5 {
        public static void MainEx5(string[] args) {
            var count = 0;
            for (var number = 1; number <= 100; number++) {
                if (number % 3 == 0) {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
