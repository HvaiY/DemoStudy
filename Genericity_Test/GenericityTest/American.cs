using System;

namespace Genericity_Test.GenericityTest
{
    public class American : Person

    {
        public override void Eat(string name)
        {
            Console.WriteLine($"美国人{name}大口吃汉堡");
        }
    }
}