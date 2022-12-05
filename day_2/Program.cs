using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Part 1

        string[] lines = File.ReadAllLines("input.txt");  
        IDictionary<string, int> move_to_score = new Dictionary<string, int>();
        move_to_score.Add("X", 1);
        move_to_score.Add("Y", 2);
        move_to_score.Add("Z", 3);

        IDictionary<string, int> moves_to_winning = new Dictionary<string, int>();
        moves_to_winning.Add("A X", 3);
        moves_to_winning.Add("A Y", 6);
        moves_to_winning.Add("A Z", 0);

        moves_to_winning.Add("B X", 0);
        moves_to_winning.Add("B Y", 3);
        moves_to_winning.Add("B Z", 6);

        moves_to_winning.Add("C X", 6);
        moves_to_winning.Add("C Y", 0);
        moves_to_winning.Add("C Z", 3);

        int total = 0;


        for (int i=0; i < lines.Length; i++){
            String[] moves = lines[i].Split(' ');
            total += move_to_score[moves[1]] + moves_to_winning[lines[i]];
        }
        Console.WriteLine(total);

        // Part 2

        IDictionary<string, int> move_to_score_two = new Dictionary<string, int>();
        move_to_score_two.Add("X", 0);
        move_to_score_two.Add("Y", 3);
        move_to_score_two.Add("Z", 6);

        IDictionary<string, int> moves_to_move = new Dictionary<string, int>();
        moves_to_move.Add("A X", 3);
        moves_to_move.Add("A Y", 1);
        moves_to_move.Add("A Z", 2);

        moves_to_move.Add("B X", 1);
        moves_to_move.Add("B Y", 2);
        moves_to_move.Add("B Z", 3);

        moves_to_move.Add("C X", 2);
        moves_to_move.Add("C Y", 3);
        moves_to_move.Add("C Z", 1);

        int total_two = 0;

        for (int i=0; i < lines.Length; i++){
            String[] moves = lines[i].Split(' ');
            total_two += move_to_score_two[moves[1]] + moves_to_move[lines[i]];
        }
        Console.WriteLine(total_two);
        

    }
}