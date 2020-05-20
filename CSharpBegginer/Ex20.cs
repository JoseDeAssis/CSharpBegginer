using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpBegginer {
    class Ex20 {
        public static void MainEx20(string[] args) {
            var path = @"C:\Users\ze_le\Documents\helloWorld.txt";
            var file = File.ReadAllLines(path);
            var qtdWords = 0;

            foreach(var word in file) {
                var words = word.Split(' ');
                qtdWords += words.Length;
            }

            Console.WriteLine("Quantidade de palavras = " + qtdWords);

        }
    }
}
