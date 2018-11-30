using Genericity_Test.GenericityTest;
using System;

namespace Genericity_Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("泛型测试");
            new TestGenericity<Chines>("大海");

            new TestGenericity<American>("Jack");
            Console.ReadKey();
        }
    }
}