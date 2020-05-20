using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex11 {
        public static void MainEx11(string[] args) {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();
            var reversedName = "";

            for(var i = name.Length-1; i >= 0; i--) {
                reversedName += name[i];
            }

            Console.WriteLine("Your reversed name is: " + reversedName);
        }
    }
}
