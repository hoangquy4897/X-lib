using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xLib
{
    class PrefixNotation : Notation
    {
        public string Arrange(string op, string operand1, string operand2)
        {
            return op + " " + operand1 + " " + operand2;
        }
    }
}
