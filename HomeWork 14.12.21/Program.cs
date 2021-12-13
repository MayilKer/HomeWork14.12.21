using Library;
using System;

namespace HomeWork_14._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculate = new Calculator();
            Calculate.a = 8;
            Calculate.b = 10;
            Calculate.Multiply();
            Calculate.Plus();
            Calculate.Minus();
            Calculate.Divide();
        }
    }
}
