using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Inheritance
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int[] TestScores { get; set; }

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            TestScores = scores;
        }
        public string Calculate()
        {
            var averageScore = TestScores.Average();
            if (averageScore >= 90 && 100 >= averageScore) return "O";
            else if (averageScore >= 80 && 90 > averageScore) return "E";
            else if (averageScore >= 70 && 80 > averageScore) return "A";
            else if (averageScore >= 55 && 70 > averageScore) return "P";
            else if (averageScore >= 40 && 55 > averageScore) return "D";
            else return "T";
        }
    }

    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
    }
}
