using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class MinusExp : BinaryExp
    {
        public MinusExp(Expression e1, Expression e2) : base(e1,e2)
        {
            this.exp1 = e1;
            this.exp2 = e2;
        }

        public override Expression Derive()
        {
            return new MinusExp(exp1.Derive(), exp2.Derive());
        }

        public override double Evaluate(double x)
        {
            return DoEvaluate(exp1.Evaluate(x), exp2.Evaluate(x));
        }

        protected override double DoEvaluate(double val1, double val2)
        {
            return val1 - val2;
        }

        protected override string GetOperator()
        {
            return "-";
        }
    }
}
