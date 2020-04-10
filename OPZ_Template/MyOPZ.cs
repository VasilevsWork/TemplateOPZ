using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPZ_Template
{
    class MyOPZ
    {
        string del = ".";

        public MyOPZ()
        {
        }

        public String Translate(String expression, char delimeter = ' ')
        {
            Stack<string> operators = new Stack<string>();

            String result = "";

            String number = "";
            foreach (char symbol in expression)
            {

            }

            return result;
        }

        public double Calculate(String opzString)
        {
            return 0;
        }

        bool isOperator(string symbol)
        {
            switch (symbol)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                    return true;
            }

            return false;
        }

        int Priority(string opeartion)
        {
            switch (opeartion)
            {
                case "(":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
            }

            return -1;
        }

        bool isDigit(char symbol)
        {
            return Char.IsDigit(symbol);
        }
    }
}
