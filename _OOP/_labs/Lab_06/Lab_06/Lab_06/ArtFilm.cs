using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
     class ArtFilm
    {
        public string nameOfFilm;
        public string producer;
        private int _yearOfPublish;
        public string []programGuide = {"19:30", "18:00", "14:30", "13:00", "19:00", "18:05", "11:30" };
        public string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public int yearOfPublish
        {
            set 
            {
                if (value <= 1895)
                    throw new YearException("Тогда еще не было фильмов! Первый фильм в истории вышел в 1895г. ", value);

                else
                {
                    _yearOfPublish = value;
                }
            }

            get 
            { 
                return _yearOfPublish; 
            }
        }

        public void ProgramGuide()
        {
            for(int i = 0; i < week.Length; i++)
            {
                Console.WriteLine("Время показа в (во) {0}: {1}", week[i], programGuide[i]);
            }
        }

        public void ProgramGuide(string? day)
        {
            Debug.Assert(day!= null); //используется только в режиме отладки, для поиска логических ошибок
            Trace.Assert(day != null); //режим release 

            int error = 0;
            for (int i = 0; i < week.Length; i++)
            {
                if (day == week[i])
                {
                    error = 1;
                }
            }

            if (error != 0)
            {
                for (int i = 0; i < week.Length; i++)
                {
                    if (day == week[i])
                    {
                        Console.WriteLine("Время показа в (во) {0}: {1}", week[i], programGuide[i]);
                    }
                }
            }

            else
                throw new WeekException("Вы ввели неверный день недели!", day);

        }

        public void ProgramGuide(int index)
        {
            if (index < 0 || index > 7)
            {
                throw new IndexOutOfRangeException("Вы вышли за диапазон значения массива!");
            }

            for (int i = 0; i < week.Length; i++)
            {
                if (i == index - 1)
                {
                    Console.WriteLine("Время показа в (во) {0}: {1}", week[i], programGuide[i]);
                }
            }
        }

        public ArtFilm(string nameOfFilm, string producer, int yearOfPublish)
        {
            this.nameOfFilm = nameOfFilm;
            this.producer = producer;
            this.yearOfPublish = yearOfPublish;
        }
    }
}
