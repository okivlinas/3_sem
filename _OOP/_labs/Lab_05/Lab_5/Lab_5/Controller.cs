using Lab_04;
using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    static public class Controller
    {
        static public void SearchByYear(ProgramGuide pg, string year)
        {
            var programs = pg.Programs;

            programs = programs.Where(
                el => (el is TV_program pr && pr._YearOfIssue == year)
            ).ToArray();

            if (programs.Length > 0)
            {
                foreach (var program in programs)
                {
                    program.ToString();
                    Console.WriteLine('\n');
                }
            }
            else
            {
                Console.WriteLine("Передачи с таким годом выпуска отсутствуют!");
            }
        }

        static public int DurationOfProgram(ProgramGuide pg)
        {
            var programs = pg.Programs;
            int sumDur = 0;

            foreach(var el in programs)
            {
                sumDur += Convert.ToInt32(el?._duraTION ?? "0");
            }

            return sumDur;
        }

        public static int CountOfAdvertising(ADVERTISING adver)
        {
            var _count = adver.count_2;
          
            return _count;
        }
    }
}
