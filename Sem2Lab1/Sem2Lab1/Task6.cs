using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1
{
    public delegate bool Validator(string input);
    public class Task6
    {
        public static Validator GetValidator (int minLength)
        {
            return input => input != null && input.Length >= minLength;
        }
    }
}
