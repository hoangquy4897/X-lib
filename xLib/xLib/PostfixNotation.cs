using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class PostfixNotation : Notation
    {
        public string Arrange(string op, string operand1, string operand2)
        {
            return operand1 + " " + operand2 + " " + op;
        }
    }
}
