using System;

class Program 
{
    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("input.txt");  

        // Part 1

        int total = 0;

        foreach(string line in lines){
            int str_len = line.Length;
            int c_len = line.Length / 2;

            string first_c = line.Substring(0, c_len);
            string second_c = line.Substring(c_len);

            HashSet<char> h = new HashSet<char>();
            foreach(char c in first_c){
                h.Add(c);
            }

            foreach(char c in second_c){
                if (h.Contains(c)){
                    total += Char.IsUpper(c) ? -38 + c : -96 + c;
                    break;
                }
            }
        }
        Console.WriteLine(total);

        // Part 2

        int total_two = 0;
        HashSet<char>[] hs = {new HashSet<char>(), new HashSet<char>(), new HashSet<char>()};
        int counter = 0;

        foreach(string line in lines){

            char[] sack = line.ToCharArray();
            HashSet<char> h = new HashSet<char>(sack);
            hs[counter] = h;

            if (counter == 2){
                HashSet<char> ans = hs[0];
                ans.IntersectWith(hs[1]);
                ans.IntersectWith(hs[2]);
                foreach(char c in ans){
                    total_two += Char.IsUpper(c) ? -38 + c : -96 + c;
                }
                counter = 0;
            }else{
                counter++;
            }
            
        }
        Console.WriteLine(total_two);
    }
}
