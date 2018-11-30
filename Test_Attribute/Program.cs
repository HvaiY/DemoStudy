using System;
using Test_Attribute.AttributeTest;

namespace Test_Attribute
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var people = new People()
            {
                Name = "张三张三张三张三张三张三张三张三张三张三",
                Description = "descriptions descriptions descriptions descriptions descriptions"
            };
            try
            {
                new ValidationModel().Validate(people);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}