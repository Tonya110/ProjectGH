using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProgect
{
    class Processing
    {
        double rezult = 0;

        public int Summa(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Umnogit(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Delit(int number1, int number2)
        {
            if (number2 != 0)
           {
                rezult = number1 / number2;
           }
            return rezult;
        }
    }
}
