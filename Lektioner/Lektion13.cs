using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace School.Lesson13
{
    public class Lesson13
    {
        public void RunLesson13() 
        {
            string fileName = "mytest.txt";
            string[] ArrLines;
            int n, i;
            Console.WriteLine("\n\nCreate a file with text and array of strings  :\n");
            Console.WriteLine("------------------------------------------------");
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.WriteLine("Input number of lines to write in the field: ");
                n = int.Parse(Console.ReadLine());
                ArrLines = new string[n];
                Console.WriteLine($"Input {n} strings below: \n");
                for (i = 0; i < n; i++) 
                {
                    Console.WriteLine($" Input line {i+1}: ");
                    ArrLines[i] = Console.ReadLine();
                }
                File.WriteAllLines(fileName, ArrLines);
               

                //using (StreamWriter fileStr = File.CreateText(fileName))
                //{
                //    fileStr.WriteLine("Hello and welcome");
                //    fileStr.WriteLine("It is the first content");
                //    fileStr.WriteLine("of the text mytest.txt");
                //}

                // Utskrift
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    Console.Write("The content of the file is :\n");
                    Console.Write("----------------------------\n");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception MyExecp) 
            {
                Console.WriteLine(MyExecp.ToString);
            }
          

        }

     
    }
}
//public record Score(string Name, int Point, int Level)
//{
//    List<Score> MakeDefaultScores()
//    {
//        return new List<Score>()
//        {
//            new Score("R2-D2", 12420, 15),
//            new Score("C-3PO", 8543, 9),
//            new Score("GONK", -1, 1),

//        };
//    }
//    void SaveScores(List<Score> scores)
//    {
//        List<string> scoreStrings = new List<string>();
//        foreach (Score score in scores)
//        {
//            scoreStrings.Add($" {score.Name}, {score.Point}, {score.Level}");
//            File.WriteAllLines("Scores.csv", scoreStrings);
//        }
//        SaveScores(MakeDefaultScores());
//    }

//}

//Console.WriteLine("What do you want me to tell you next time?");
//string? message = Console.ReadLine();
//File.WriteAllText("C:/Users/linda/OneDrive/Skrivbord/File/", message);
//string previous = File.ReadAllText("Message.txt");
//Console.WriteLine("Last time, you said this: " + previous);

//List<Score> LoadHighScore()
//{
//    string[] scoreStrings = File.ReadAllLines("Scores.csv");
//    List<Score> score = new List<Score>();

//    foreach (string scores in scoreStrings) 
//    {
//        string[] tokens = scoreString.Split(",");
//        Score score = new Score(tokens[0]),
//            Convert.ToInt32(tokens[1]);
//            Convert.ToInt32(tokens[2]);

//        scores.Add(score);
//    }
//    return scores;
//}

//foreach (Score score in LoadHighScore()) 
//{
//    Console.WriteLine(score);
//}
