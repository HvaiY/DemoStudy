namespace Genericity_Test.GenericityTest
{
    public class TestGenericity<T> where T : Person, new()
    {
        public TestGenericity(string name)
        {
            var t = new T
            {
                Name = name
            };
            t.Eat(name);
        }
    }
}