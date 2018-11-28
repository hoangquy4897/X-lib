using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class ConstExp : Expression
    {
        private double value;

        public ConstExp(double value)
        {
            this.value = value;
        }

        public Expression Derive()
        {
            return new ConstExp(0);
        }

        public double Evaluate(double x)
        {
            return value;
        }

        public string toString(Notation ntn)
        {
            return value.ToString();
        }
    }
}
