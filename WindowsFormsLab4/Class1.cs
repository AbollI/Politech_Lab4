using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab4
{
    class Fraction
    {
        private int lerror;
        private int a;
        private int b;
        private double answ;

        public Fraction(int a, int b)
        {
            if (b != 0)
            {
                lerror = 0;
                this.a = a;
                this.b = b;
                this.answ = a / b;
            }
            else { lerror = 1; }
        }

        public int GetError()
        {
            return lerror;
        }

        public double GetAnsw()
        {
            return answ;
        }

        public Fraction Reverse()
        {
            Fraction reversed = new Fraction(this.b, this.a);

            return reversed;
        }

        public string toString()
        {
            string returner="";

            returner = this.a + "/" + this.b;

            return returner;
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {

            Fraction Summ =new Fraction(left.a*right.b+right.a*left.b,left.b*right.b);
            if (Summ.b == 0)
            { 
                Summ.lerror = 1; 
            }
            else
            {
                Summ.lerror = 0;
            }
                return Summ;
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {

            Fraction Summ = new Fraction(left.a * right.b - right.a * left.b, left.b * right.b);
            if (Summ.b == 0)
            {
                Summ.lerror = 1;
            }
            else
            {
                Summ.lerror = 0;
            }
            return Summ;
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            Fraction Summ = new Fraction(left.a * right.a, left.b * right.b);
            if (Summ.b == 0)
            {
                Summ.lerror = 1;
            }
            else
            {
                Summ.lerror = 0;
            }
            return Summ;
        }
    }
}
