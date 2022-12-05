using System;

class Program 
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("input.txt");  

        // Part 1

        int total = 0;
        int total_two = 0;

        foreach(string line in lines){
            String[] delimiters = {"-", ","};
            String[] arr = line.Split(delimiters, StringSplitOptions.None);
            int[] a = Array.ConvertAll(arr, s => int.Parse(s));
            total += ((a[0] <= a[2] && a[1] >= a[3]) || (a[0] >= a[2] && a[1] <= a[3])) ? 1 : 0;
            total_two += ((a[0] <= a[2] && a[1] >= a[2]) || (a[2] <= a[0] && a[3] >= a[0])) ? 1 : 0;
        }
        Console.WriteLine(total);
        Console.WriteLine(total_two);

    }
}
