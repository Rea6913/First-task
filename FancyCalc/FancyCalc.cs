using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
            //throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            //   throw new NotImplementedException();
            string anton = "";
            string chisla = "0123456789";
            char big_balls = ' ';
            int a=-1, b=0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (chisla.Contains(expression[i]) == true)
                    anton += expression[i];
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*')
                    big_balls = expression[i];
                else if (expression[i] == ' ' && anton !="")
                {
                    if (a != -1)
                        b = Convert.ToInt32(anton);
                    else
                        a = Convert.ToInt32(anton);
                    anton = "";
                }
            }
            switch (big_balls)
            {
                case '+':
                    {
                        return Add(a, b);
                        break;
                    }
                case '-':
                    {
                        return Subtract(a, b);
                        break;
                    }
                case '*':
                    {
                        return Multiply(a, b);
                        break;
                    } 
            }
            throw new NotImplementedException();
        }
    }
}