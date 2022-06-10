using System;
using System.Collections.Generic;

namespace DelegatesExercise
{
    internal class Program
    {
        // ex 15
        static Func<float, float, float> Plus = (a,b) => a+b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Mult = (a, b) => a * b;
        static Func<float, float, float> Div = (a, b) => a / b;

        static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            { "+", Plus },
            { "-", Minus },
            { "*", Mult },
            { "/", Div }
        };
        static Func<float, float, float> OperationsGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }

        // ex 14
        public delegate float OperationDelegate(float x, float y);

        static void Main(string[] args)
        {
            // ex 15
            OperationsGet("+");

            // ex 14
            Console.WriteLine(ApplyOperation(5, 6, Add));
            Console.WriteLine(ApplyOperation(10, 5, Multiply));
        }
        // ex 14
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Subtract(float x, float y)
        {
            return x - y;
        }
        public static float Multiply(float x, float y)
        {
            return x * y;
        }
        public static float Divide(float x, float y)
        {
            return x / y;
        }
        static float ApplyOperation(float x, float y, OperationDelegate del) 
        {
            float result;
            result = del(x, y);
            return result;
        }
    }
}
