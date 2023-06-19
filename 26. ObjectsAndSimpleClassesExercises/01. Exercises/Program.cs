using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Exercises
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            List<Exercise> colectionOfExercises = new List<Exercise>();
            while (input[0] != "go go go")
            {
                Exercise exercise = Exercise.ReadExercise(input);

                colectionOfExercises.Add(exercise);

                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in colectionOfExercises)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                int n = 0;
                foreach (var problem in item.Problems)
                {
                    n++;
                    Console.WriteLine($"{n}. {problem}");
                }

            }
        }
    }

    class Exercise
    {
        public Exercise(string v1, string v2, string v3, string[] v4)
        {
            Topic = v1;
            CourseName = v2;
            JudgeContestLink = v3;
            Problems = v4;
        }

        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public string[] Problems { get; set; }

        internal static Exercise ReadExercise(string[] input)
        {
            return new Exercise(input[0], input[1], input[2], input[3].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray());
        }
    }
}
