using System;

namespace Genericity_Test.GenericityTest
{
    public class Chines : Person
    {
        public override void Eat(string name)
        {
            Console.WriteLine($"中国人{name}细嚼慢咽的吃");
        }
    }
}