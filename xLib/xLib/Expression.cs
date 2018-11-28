using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    interface Expression
    {
        double Evaluate(double x);

        Expression Derive();

        string toString(Notation ntn);
    }
}
