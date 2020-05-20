using System;
using System.Collections.Generic;

namespace CSharpBegginer {
    class Ex10 {
        static void MainEx10(string[] args) {
            var nameList = new List<string>();
            while (true) {
                Console.WriteLine("Please enter a name: ");
                var name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) {
                    nameList.Add(name);
                    continue;
                }

                break;
            }

            if (nameList.Count == 1) {
                Console.WriteLine(nameList[0] + " likes your post.");
            } else if(nameList.Count == 2) {
                Console.WriteLine(nameList[0] + " and " + nameList[1] + " like your post");
            } else if(nameList.Count > 2) {
                Console.WriteLine(nameList[0] + ", " + nameList[1] + " and " + (nameList.Count - 2) + " others like your post");
            }
        }
    }
}
