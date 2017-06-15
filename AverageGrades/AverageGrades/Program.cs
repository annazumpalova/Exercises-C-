using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Average_Grades
{
    class Program
    {
        static void Main()
        {

            var n = int.Parse(Console.ReadLine());
            Dictionary<string, double> gradesDict = new Dictionary<string, double>();
            List<string> input = new List<string>();
            var student = new AverageGrades.Student();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                student.Name = input[0];
                for (int j = 1; j < input.Count; j++)
                {
                    student.Grades.Add(double.Parse(input[j]));
                }

                gradesDict.Add(student.Name, student.averageGrades);

            }
            var result = gradesDict
            .Where(x => x.Value >= 5.50)
            .OrderBy(x => x.Key)
            .ThenByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);



            foreach (var item in result)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}