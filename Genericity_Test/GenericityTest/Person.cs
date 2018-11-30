using System;

namespace Genericity_Test.GenericityTest
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void Eat(string name)
        {
            Console.WriteLine("不紧不慢的吃");
        }

        public void Sleep()
        {
            Console.WriteLine("倒头就睡");
        }
    }
}