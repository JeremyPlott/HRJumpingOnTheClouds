using System;

namespace HRJumpingOnTheClouds {
    class Program {
        static void Main(string[] args) {

            // 7 is this actually input like it says?
            int[] c1 = { 0, 0, 1, 0, 0, 1, 0 }; // 4 jumps
            int[] c2 = { 0, 1, 0, 0, 1, 0, 0 }; // 4 jumps
            int[] c3 = { 0, 1, 0, 1, 0, 1, 0 }; // 3 jumps
            int[] c4 = { 0, 0, 0, 1, 0, 0 }; // 3 jumps
            int[] c5 = { 0, 0, 1, 0, 0, 1, 0 }; // 4 jumps

            // cloud += jumpdist | either 1 or 2, track to ensure it doesn't index OOR. if cloud + 2 > maxcloud, jumpdist = 1.

            int maxCloud = c5.Length;
            int cloudIdx = 0;
            int currentCloud = 1;
            int jumps = 0;

            Console.WriteLine("Jumps: 0, current cloud: 1");
            while (currentCloud <= maxCloud - 2) {

                if (c5[cloudIdx + 2] == 0) {
                    cloudIdx += 2;
                    currentCloud += 2;                      
                } else {
                    cloudIdx += 1;
                    currentCloud++;
                }
                jumps++;

                Console.WriteLine($"Jumps: {jumps}, current cloud: {currentCloud + 1}");
            }

            if (maxCloud - currentCloud != 0) {
                jumps++;
            }
            Console.WriteLine($"Jumps: {jumps}");

        }
    }
}
