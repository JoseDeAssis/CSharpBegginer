using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex4 {
        public static void MainEx4(string[] args) {
            int carSpeed, limitSpeed;
            Console.WriteLine("Please enter the limit speed:");
            limitSpeed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the car speed:");
            carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > limitSpeed) {
                if (carSpeed > limitSpeed + 12) {
                    Console.WriteLine("License suspended");
                }
                else {
                    Console.WriteLine("{0} demerit points", (carSpeed-limitSpeed));
                }
            } else {
                Console.WriteLine("Ok");
            }
        }
    }
}
