


#if false

// 特性适用于 
[AttributeUsage(AttributeTargets.All)]
public class TestAttribute : Attribute
{
}
[TestAttribute]//结构
public struct TestStruct { }

[TestAttribute]//枚举
public enum TestEnum { }

[TestAttribute]//类上
public class TestClass
{
    [TestAttribute]
    public TestClass() { }

    [TestAttribute]//字段
    private string _testField;

    [TestAttribute]//属性
    public string TestProperty { get; set; }

    [TestAttribute]//方法上
    [return: TestAttribute]//定义返回值的写法
    public string TestMethod([TestAttribute] string testParam)//参数上
    {
        throw new NotImplementedException();
    }
} /**/ 
	#endif