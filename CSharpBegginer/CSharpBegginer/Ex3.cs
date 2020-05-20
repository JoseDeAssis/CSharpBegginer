using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
    class Ex3 {
        public static void MainEx3(string[] args) {
            int width, height;
            Console.WriteLine("Please enter the width");
            width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height");
            height = Convert.ToInt32(Console.ReadLine());

            if (height > width) {
                Console.WriteLine("The image is portrait");
            } else {
                Console.WriteLine("The image is landscape");
            }
        }
    }
}
