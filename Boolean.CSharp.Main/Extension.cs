﻿



using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Boolean.CSharp.Main
{
    public class Extension
    {        

        //Implement the following methods:

        //TODO: 1. add, which accepts two floats and returns a float (both floats added together)
        public float add(float a, float b)
        {
            return a + b;
        }

        //TODO: 2. add, which accepts two doubles and returns a double (both doubles added together)
        public double add(double a, double b)
        {
            return a + b;
        }

        //TODO: 3. subtract, which accepts two floats and returns a float (first float minus second float)
        public float subtract(float a, float b)
        {
            return a - b;  
        }

        //TODO: 4. subtract, which accepts a String and a char and returns a string with all instances of the provided char removed
        public string subtract(string str, char chr)
        {
            string newstr = str.Replace(chr.ToString(), null);
            return newstr;
        }

        //TODO: 5. multiply, which accepts two ints and returns an int (first int multiplied by second int)
        public int multiply(int a, int b)
        {
            return a * b;
        }

        //TODO: 6. multiply, which accepts a string and an int, and returns a string containing the provided string as many times as the provided int separated by a comma. E.g. multiply("Hello", 3) -> "Hello,Hello,Hello"
        public string multiply(string a, int b)
        {
            string newstr = a;
            for (int i = 0; i < b-1; i++)
            {
                newstr = newstr + "," + a;
            }
             
            return newstr;
        }

        //TODO: 7. multiply, which accepts an array of Strings that each contain a number, and an int. The method should return an array of ints that contain the value of multiplying each String number by the provided int E.g. multiply(["2", "7", "3"], 3) -> [6, 21, 9]
        public int[] multiply(string[] a, int b)
        {
            int[] lst = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                lst[i] = int.Parse(a[i]) * b; 
            }
            return lst;
        }
    }
}
