using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class MonomialExp : Expression
    {
        private double a, n;

        public static Expression CreateInstance(double a, double n)
        {
            if (a == 0)
                return new ConstExp(0);
            if (n == 0)
                return new ConstExp(1);
            return new MonomialExp(a, n);
        }

        protected MonomialExp(double a, double n)
        {
            this.a = a;
            this.n = n;
        }

        public Expression Derive()
        {
            return new MonomialExp(a * n, n - 1);
        }

        public double Evaluate(double x)
        {
            double result = a;

            if (this.a == 0)
                return 0;

            for (int i = 0; i < this.n; i++)
            {
                result *= x;
            }

            return result;
        }

        public string toString(Notation ntn)
        {
            return a.ToString() + "x^" + n.ToString();
        }
    }
}
