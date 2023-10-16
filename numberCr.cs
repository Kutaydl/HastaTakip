using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
    class numberCr
    {
        private readonly Random _random = new Random();
      
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public int heightNumber(int age)
        {
            int height = 0;
            if (age > 5)
            {
                height = RandomNumber(110, 220);
            }
            else
            {
                height = RandomNumber(20, 110);
            }

            return height;
        }

        public int weightNumber(int age)
        {
            int weight = 0;
            if (age > 5)
            {
                weight = RandomNumber(20, 110);
            }
            else
            {
                weight = RandomNumber(10, 20);
            }

            return weight;
        }

        public string dateGen(int year)
        {
            int month = RandomNumber(1, 13);
            int day = 0;
            int value = year % 4;
            if (month == 2)
            {
                if (value == 0)
                {
                    day = RandomNumber(1, 30);
                }
                else
                {
                    day = RandomNumber(1, 29);
                }
            }
            else if (month == 1 || month == 3 ||month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                day = RandomNumber(1, 32);
            }
            else
            {
                day = RandomNumber(1, 31);
            }
            
            return month+"/"+day+"/"+year;
        }
        
    }
}
