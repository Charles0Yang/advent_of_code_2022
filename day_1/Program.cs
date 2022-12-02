using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Part 1

        string[] lines = File.ReadAllLines("input.txt");  
        int max_calories = 0;
        int[] max_three = {0, 0, 0};
        int temp = 0;

        for (int i=0; i < lines.Length; i++){
            if (lines[i] != ""){
                temp += Int32.Parse(lines[i]);
            }
            else{
                if (temp > max_calories){
                    max_calories = temp;
                }
                if (temp > max_three.Min()){
                    max_three[Array.IndexOf(max_three, max_three.Min())] = temp;
                }
                temp = 0;
            }
        }
        Console.WriteLine(Math.Max(max_calories, temp));

        int three_max = 0;
        foreach(int e in max_three){
            three_max += e;
        }
        Console.WriteLine(three_max);
    }
}