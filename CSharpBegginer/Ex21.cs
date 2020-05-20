using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpBegginer {
    class Ex21 {
        public static void Main(string[] args) {
            var path = @"C:\Users\ze_le\Documents\helloWorld.txt";
            var lines = File.ReadAllLines(path);
            var largestWord = "";

            foreach (var line in lines) {
                var words = line.Split(' ');
                foreach (var word in words) {
                    if (word.Length > largestWord.Length)
                        largestWord = word;
                }
            }

            Console.WriteLine("Maior palavra = " + largestWord);

        }
    }
}
