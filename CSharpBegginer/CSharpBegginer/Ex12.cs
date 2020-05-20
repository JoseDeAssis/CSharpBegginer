using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex12 {
        public static void MainEx12(string[] args) {
            var list = new List<int>();
            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Please enter a number: ");
                var number = Int32.Parse(Console.ReadLine());

                while(list.Contains(number)) {
                    Console.WriteLine("The number is already on the list. Please retry.");
                    number = Int32.Parse(Console.ReadLine());
                }
                list.Add(number);
            }

            list.Sort();

            foreach(var number in list) {
                Console.WriteLine(number);
            }

        }
    }
}
