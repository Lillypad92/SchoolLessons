using static System.Console;
namespace School.Lesson9
{
    public class Lesson9
    {
        internal class SchoolLesson9 { }

        public void RunLesson9()
        {
            AddStudent("Alice", 85);
            AddStudent("Bob", 90);
            AddStudent("Linda", 100);

            UpdatePoints("Bob", 12);

            RemoveStudent("Alice");

            DisplayStudent();
        }
        private static Dictionary<string, int> studentScores = new Dictionary<string, int>();

        private static void AddStudent(string name, int points)
        {
            studentScores[name] = points;
        }
        private static void UpdatePoints(string name, int newPoints)
        {
            if (studentScores.ContainsKey(name))
            {
                studentScores[name] = newPoints;
            }
            else
            {
                WriteLine($"Student med denna {name} finns inte i listan.");
            }
        }
        private static void RemoveStudent(string name)
        {
            if (studentScores.ContainsKey(name))
            {
                studentScores.Remove(name);
            }
            else
            {
                WriteLine($"Student {name} finns inte i listan.");
            }
        }

        private static void DisplayStudent()
        {
            WriteLine("Studenter och deras poäng: ");
            foreach (var student in studentScores)
            {
                WriteLine($"{student.Key} : {student}");
            }
        }


    }

}


