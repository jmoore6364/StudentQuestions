using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentQuestions
{
    
    class Program
    {
        static new Dictionary<int, Dictionary<int, int>> strands;

        class Question
        {
            public int strand_id { get; set; }
            public int standard_id { get; set; }
            public int question_id { get; set; }
        }

        static List<Question> GetQuestions()
        {
            var questions = new List<Question>()
            {
                new Question { strand_id = 1,  standard_id = 1, question_id = 1},
                new Question { strand_id = 1,  standard_id = 1, question_id = 2},
                new Question { strand_id = 1,  standard_id = 2, question_id = 3},
                new Question { strand_id = 1,  standard_id = 2, question_id = 4},
                new Question { strand_id = 1,  standard_id = 3, question_id = 5},
                new Question { strand_id = 2,  standard_id = 4, question_id = 6},
                new Question { strand_id = 2,  standard_id = 4, question_id = 7},
                new Question { strand_id = 2,  standard_id = 4, question_id = 8},
                new Question { strand_id = 2,  standard_id = 5, question_id = 9},
                new Question { strand_id = 2,  standard_id = 5, question_id = 10}
            };

            BuildInfo(questions);

            return questions;
            
        }

        static void BuildInfo(List<Question> questions)
        {
            strands = new Dictionary<int, Dictionary<int, int>>();
            foreach (var question in questions)
            {
                if (strands.Keys.Contains((int)question.strand_id))
                {
                    if (strands[question.strand_id].Keys.Contains((int)question.standard_id))
                        strands[question.strand_id][question.standard_id] = strands[question.strand_id][question.standard_id] + 1;
                    else
                    {

                        strands[question.strand_id].Add(question.standard_id, 1);
                    }
                }
                else
                {
                    strands.Add(question.strand_id, new Dictionary<int, int>());
                }
            }
        }

        //static List<dynamic> GetQuestions(int n)
        //{
        //    var questions = GetQuestions();
        //}

        static List<Question> GetStrands(int n, List<Question> questions)
        {
            var result = new List<Question>();
            var remainder = n % strands.Count;
            var dist = n / strands.Count;
            var c = 0;
            for (var i = 0; i < (n + 1); i++ )
            {
                for (var x = 0; x < (dist + 1); x++)
                {

                }
            }
                foreach (var question in questions)
                    Console.WriteLine(dist);
            return questions;
        }

        static void Main(string[] args)
        {
            var questions = GetQuestions();
            GetStrands(5, questions);
            Console.ReadKey();
        }
    }
}
