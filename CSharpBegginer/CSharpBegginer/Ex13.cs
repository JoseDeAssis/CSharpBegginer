using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex13 {
        public static void MainEx13(string[] args) {
            var list = new List<int>();
            while(true) {
                Console.WriteLine("Please digit a number or 'Quit':" );
                var input = Console.ReadLine();

                if (input.ToLower().Equals("quit")) {
                    break;
                } 
                
                if(!list.Contains(Int32.Parse(input))) {
                    list.Add(Int32.Parse(input));
                }
            }

            foreach(var number in list) {
                Console.WriteLine(number);
            }
        }
    }
}
