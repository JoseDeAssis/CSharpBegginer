using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBegginer {
    class Ex17 {
        public static void MainEx17(string[] args) {
            Console.WriteLine("Please enter a time value in the 24-hour time format(e.g. 19:00)");
            var input = Console.ReadLine();
            var time = input.Split(':');
            bool valid = false;

            if (time.Length == 2) {
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);
                valid = hour >= 0 && hour <= 24 && minute >= 0 && minute <= 59;
            }
            
                if(valid) {
                    Console.WriteLine("OK");
                } else {
                    Console.WriteLine("Invalid Time");
                }
        }
    }
}
