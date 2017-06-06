using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProgect
{
    class Processing
    {
        
        public static int Summa(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int Umnogit(int number1, int number2)
        {
            return number1 * number2;
        }

        public static double Delit(int number1, int number2)
        {
            double rezult = 0;

            if (number2 != 0)
           {
                rezult = number1 / number2;
           }
            return rezult;
        }
    }
}
