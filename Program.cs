using System;
using System.Collections.Generic;

namespace Filhantering {
    internal class progarm {
        public static void Main(string[] args) {
            string[] lines = File.ReadAllLines(path: "./talfil.txt");
            string[] intager;
            int newNum = 0;

            foreach (string line in lines) {
                intager = lines;
                int[] ints = Array.ConvertAll(array: lines, converter: s => int.Parse(s: s));

                foreach (int num in ints) {
                    newNum += ints[num];
                    Console.WriteLine(value: newNum);
                }
            }
        }
    }
}