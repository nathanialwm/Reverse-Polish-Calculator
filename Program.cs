using System;
using System.Text.RegularExpressions;

namespace ReversePolishCalculator {
    class Program {

        enum Operators { ADD, SUBTRACT, MULTIPLY, DIVIDE, EXP};

        static Stack<Tokens> StoreTokens(string expression) {
            
            Stack<Tokens> stack = new Stack<Tokens>();

            foreach (char c in expression) {
                if (c.Equals('+')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.ADD, c, 0));
                } else if (c.Equals('-')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.SUBTRACT, c, 0));
                } else if (c.Equals('*')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.MULTIPLY, c, 5));
                } else if (c.Equals('/')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.DIVIDE, c, 5));
                } else if (c.Equals('^')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.EXP, c, 10));
                } else if (char.IsDigit(c)) {
                    stack.Push(new Tokens(Tokens.TokenTypes.NUMBER, c));
                } else if (c.Equals('(')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.LPAREN, c));
                } else if (c.Equals(')')) {
                    stack.Push(new Tokens(Tokens.TokenTypes.RPAREN, c));
                } else {
                    stack.Clear();
                    Console.WriteLine("Invalid expression");
                    return stack;
                }
            }
            return stack;
        }

        static void Calculate(Stack<Tokens> stack) {
            while 
        }

        static void Main(string[] args) {
            Console.WriteLine("Reverse Polish Calculator");
            Console.WriteLine("Enter a mathematical expression and it will be calculated");
            Console.WriteLine("using the Reverse Polish Notation method");

            string expression = Console.ReadLine();

            if (expression == "") {
                Console.WriteLine("No expression entered");
                return;
            } else {
                Calculate(StoreTokens(expression));
            }
        }
    }
}