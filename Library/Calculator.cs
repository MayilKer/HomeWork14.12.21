using System;

namespace Library
{
    public class Calculator
    {
        public double a;
        public double b;
        public double res;
        public void Plus()
        {
            res = a + b;
            Result();
        }
        public void Minus()
        {
             res = a - b;
            Result();
        }
        public void Multiply()
        {
            res = a * b;
            Result();
        }
        public void Divide()
        {
            res = a / b;
            Result();
        }
        public void Result()
        {
            Console.WriteLine(res);
        }
    }
}
