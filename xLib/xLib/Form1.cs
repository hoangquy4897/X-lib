using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        List<Expression> GetListExpression(string exp)
        {
            //string[] listOpe = new string[] { "+", "-", "*", "/", "(", ")" };
            string listOpe = "+-/*()";
            List<Expression> listExp = new List<Expression>();
            List<Expression> subListExp = new List<Expression>();
            bool priortize = false;

            for(int i=0; i<exp.Length; i++)
            {
                if(exp[i] == '(')
                {
                    priortize = true;
                }
                else if(exp[i] == ')')
                {
                    priortize = false;
                }

                if (i == exp.Length - 1)
                {
                    if(exp[i] == 'x')
                    {
                        Expression monoExp = MonomialExp.CreateInstance(1, 1);
                    }
                    else
                    {
                        if (exp[i] != 'x' && !listOpe.Contains(exp[i]))
                        {
                            Expression constExp = new ConstExp(double.Parse(exp[i].ToString()));
                        }
                    }
                }
                else
                {
                    if (listOpe.Contains(exp[i]) && !listOpe.Contains(exp[i + 1]))
                    {
                        string temp = "";
                        for (int j = i + 1; j < exp.Length; j++)
                        {
                            if (listOpe.Contains(exp[j]))
                            {
                                temp = exp.Substring(i + 1, j - (i + 1));
                                i = j - 1;
                                break;
                            }
                        }
                        if (temp.Contains('x'))
                        {
                            double a = double.Parse(temp.Substring(0, temp.IndexOf('x')));
                            double n = 1;
                            if (temp.IndexOf('x') != temp.Length - 1)
                            {
                                n = double.Parse(temp.Substring(temp.IndexOf('x') + 1, temp.Length - (temp.IndexOf('x') + 1)));
                            }
                            Expression monoExp = MonomialExp.CreateInstance(a, n);

                            if(priortize == true)
                            {
                                listExp.Add(monoExp);
                            }
                            else
                            {
                                subListExp.Add(monoExp);
                            }
                        }
                        else
                        {
                            Expression constExp = new ConstExp(double.Parse(temp));
                            listExp.Add(constExp);

                            if (priortize == true)
                            {
                                listExp.Add(constExp);
                            }
                            else
                            {
                                subListExp.Add(constExp);
                            }
                        }
                    }
                }
            }

            for(int m=0; m<subListExp.Count; m++)
            {
                listExp.Add(subListExp[m]);
            }

            return listExp;
        }

        List<string> GetListOperator(string exp)
        {
            string listOpe2 = "+-/*";
            List<string> ope = new List<string>();
            List<string> subOpe = new List<string>();
            bool priortize = false;

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                {
                    priortize = true;
                }
                else if (exp[i] == ')')
                {
                    priortize = false;
                }

                if (priortize == true && listOpe2.Contains(exp[i]))
                {
                    ope.Add(exp[i].ToString());
                }
                else if (priortize == false)
                {
                    if (exp[i] == '*' || exp[i] == '/')
                    {
                        subOpe.Add(exp[i].ToString());
                    }
                    else if (exp[i] == '+' || exp[i] == '-')
                    {
                        subOpe.Add(exp[i].ToString());
                    }
                }
            }

            for (int k = 0; k < subOpe.Count; k++)
            {
                ope.Add(subOpe[k]);
            }

            return ope;
        }

        List<Expression> ShortenExpression(List<Expression> exps, string exp)
        {
            List<string> listOperator = GetListOperator(exp);
            List<Expression> listExp = exps;

            //for()
            while(listExp.Count > 2)
            {

            }

            return listExp;
        }
        

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            List<Expression> listExp = GetListExpression(ConstExpressionTextBox.Text);
            List<string> listOpe = GetListOperator(ConstExpressionTextBox.Text);

            for(int i=0; i<listExp.Count; i++)
            {
                Notation ntn = null;
                ListExpresstionTextBox.AppendText(listExp[i].toString(ntn) + "\n");
            }

            for(int j=0; j<listOpe.Count; j++)
            {
                ListExpresstionTextBox.AppendText(listOpe[j] + "\n");
            }
        }
        */

        Expression GetMonoExpression(string exp)
        {
            Expression ex;

            if (exp.Contains('x'))
            {
                double a = double.Parse(exp.Substring(0, exp.IndexOf('x')));
                double n = 1;
                if (exp.IndexOf('x') != exp.Length - 1)
                {
                    n = double.Parse(exp.Substring(exp.IndexOf('x') + 1, exp.Length - (exp.IndexOf('x') + 1)));
                }
                ex = MonomialExp.CreateInstance(a, n);
            }
            else
            {
                ex = new ConstExp(double.Parse(exp));
            }

            return ex;
        }

        private void DeriveButton_Click(object sender, EventArgs e)
        {
            ListExpresstionTextBox.Clear();

            Notation ntn = new InfixNotation();
            Expression constExp = new ConstExp(double.Parse(ConstExpressionTextBox.Text));
            Expression monoExp = GetMonoExpression(MonomialExpressionTextBox.Text);

            Expression binExp1 = GetMonoExpression(BinaryExpression1TextBox.Text);
            Expression binExp2 = GetMonoExpression(BinaryExpression2TextBox.Text);
            Expression binExp = null;

            constExp = constExp.Derive();
            monoExp = monoExp.Derive();

            ListExpresstionTextBox.AppendText(constExp.toString(ntn) + "\n");
            ListExpresstionTextBox.AppendText(monoExp.toString(ntn) + "\n");

            
            string ope = OperatorTextBox.Text;
            switch(ope)
            {
                case "+":
                    binExp = new AddExp(binExp1, binExp2).Derive();
                    break;
                case "-":
                    binExp = new MinusExp(binExp1, binExp2).Derive();
                    break;
                case "*":
                    binExp = new MulExp(binExp1, binExp2).Derive();
                    break;
                case "/":
                    binExp = new DivExp(binExp1, binExp2).Derive();
                    break;
            }
            ListExpresstionTextBox.AppendText(binExp.toString(ntn) + "\n");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListExpresstionTextBox.Clear();

            Notation ntn = new InfixNotation();
            double x = double.Parse(XValueTextBox.Text);
            Expression constExp = new ConstExp(double.Parse(ConstExpressionTextBox.Text));
            Expression monoExp = GetMonoExpression(MonomialExpressionTextBox.Text);

            Expression binExp1 = GetMonoExpression(BinaryExpression1TextBox.Text);
            Expression binExp2 = GetMonoExpression(BinaryExpression2TextBox.Text);
            Expression binExp = null;

            ListExpresstionTextBox.AppendText(constExp.Evaluate(x).ToString() + "\n");
            ListExpresstionTextBox.AppendText(monoExp.Evaluate(x).ToString() + "\n");

            string ope = OperatorTextBox.Text;
            switch (ope)
            {
                case "+":
                    binExp = new AddExp(binExp1, binExp2);
                    break;
                case "-":
                    binExp = new MinusExp(binExp1, binExp2);
                    break;
                case "*":
                    binExp = new MulExp(binExp1, binExp2);
                    break;
                case "/":
                    binExp = new DivExp(binExp1, binExp2);
                    break;
            }
            ListExpresstionTextBox.AppendText(binExp.Evaluate(x).ToString() + "\n");
        }

        void ShowExpression(Notation notation)
        {
            Notation ntn = notation;
            Expression constExp = new ConstExp(double.Parse(ConstExpressionTextBox.Text));
            Expression monoExp = GetMonoExpression(MonomialExpressionTextBox.Text);

            Expression binExp1 = GetMonoExpression(BinaryExpression1TextBox.Text);
            Expression binExp2 = GetMonoExpression(BinaryExpression2TextBox.Text);
            Expression binExp = null;

            ListExpresstionTextBox.AppendText(constExp.toString(ntn) + "\n");
            ListExpresstionTextBox.AppendText(monoExp.toString(ntn) + "\n");

            string ope = OperatorTextBox.Text;
            switch (ope)
            {
                case "+":
                    binExp = new AddExp(binExp1, binExp2);
                    break;
                case "-":
                    binExp = new MinusExp(binExp1, binExp2);
                    break;
                case "*":
                    binExp = new MulExp(binExp1, binExp2);
                    break;
                case "/":
                    binExp = new DivExp(binExp1, binExp2);
                    break;
            }
            ListExpresstionTextBox.AppendText(binExp.toString(ntn) + "\n");
        }

        private void InfixNotationButton_Click(object sender, EventArgs e)
        {
            ListExpresstionTextBox.Clear();
            Notation ntn = new InfixNotation();

            ShowExpression(ntn);
        }

        private void PostfixNotationButton_Click(object sender, EventArgs e)
        {
            ListExpresstionTextBox.Clear();
            Notation ntn = new PostfixNotation();

            ShowExpression(ntn);
        }

        private void PrefixNotationButton_Click(object sender, EventArgs e)
        {
            ListExpresstionTextBox.Clear();
            Notation ntn = new PrefixNotation();

            ShowExpression(ntn);
        }
    }
}
