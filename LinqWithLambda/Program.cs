﻿using LinqWithLambda.Tests;
using System;

namespace LinqWithLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest test = new TestLast();

            test.Test();

            Console.ReadLine();
        }
    }
}
