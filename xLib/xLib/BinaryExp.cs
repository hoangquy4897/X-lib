using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    abstract class BinaryExp : Expression
    {
        protected Expression exp1, exp2;

        public BinaryExp(Expression e1, Expression e2)
        {
            this.exp1 = e1;
            this.exp2 = e2;
        }

        public abstract Expression Derive();

        public abstract double Evaluate(double x);

        public string toString(Notation ntn)
        {
            string op = GetOperator();
            string operand1 = exp1.toString(ntn);
            string operand2 = exp2.toString(ntn);

            return ntn.Arrange(op, operand1, operand2);

        }

        protected abstract double DoEvaluate(double val1, double val2);

        protected abstract string GetOperator();
    }
}
