using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex19 {
        public static void MainEx19(string[] args) {
            Console.WriteLine("Please enter an English word");
            var input = Console.ReadLine();

            var numVowels = 0;
            foreach (var character in input) {
                if (character.Equals('a') 
                    || character.Equals('A')
                    || character.Equals('e') 
                    || character.Equals('E')
                    || character.Equals('i')
                    || character.Equals('I')
                    || character.Equals('o')
                    || character.Equals('O')
                    || character.Equals('u')
                    || character.Equals('U')) {
                    numVowels++;
                }
            }

            Console.WriteLine(numVowels + " vowels");
        }
    }
}
