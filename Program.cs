using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentQuestions
{
    
    class Program
    {
        

        static List<dynamic> GetQuestions()
        {
            return new List<dynamic>()
            {
                new { strand_id = 1,  standard_id = 1, question_id = 1},
                new { strand_id = 1,  standard_id = 1, question_id = 2},
                new { strand_id = 1,  standard_id = 2, question_id = 3},
                new { strand_id = 1,  standard_id = 2, question_id = 4},
                new { strand_id = 1,  standard_id = 3, question_id = 5},
                new { strand_id = 2,  standard_id = 4, question_id = 6},
                new { strand_id = 2,  standard_id = 4, question_id = 7},
                new { strand_id = 2,  standard_id = 4, question_id = 8},
                new { strand_id = 2,  standard_id = 5, question_id = 9},
                new { strand_id = 2,  standard_id = 5, question_id = 10}
            };
            
        }

        static void Main(string[] args)
        {
            var questions = GetQuestions();
            
            Console.ReadKey();
        }
    }
}
