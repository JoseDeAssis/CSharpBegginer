using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex18 {
        public static void MainEx18(string[] args) {
            Console.WriteLine("Please enter a few words separated by a space");
            var input = Console.ReadLine();

            if(!string.IsNullOrEmpty(input)) {
                var words = input.Split(' ');
                var pascalCase = new StringBuilder();

                foreach(var word in words) {
                    pascalCase.Append(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
                }

                Console.WriteLine("Words in PascalCase: " + pascalCase);
            }
        }
    }
}
