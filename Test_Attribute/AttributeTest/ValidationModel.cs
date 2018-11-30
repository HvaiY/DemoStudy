using System;
using System.Reflection;

namespace Test_Attribute.AttributeTest
{
    public class ValidationModel
    {
        public void Validate(object obj)
        {
            var t = obj.GetType();

            //由于我们只在Property设置了Attribute,所以先获取Property
            var properties = t.GetProperties();
            foreach (var property in properties)
            {
                //这里只做一个stringlength的验证，这里如果要做很多验证，需要好好设计一下,千万不要用if elseif去链接
                //会非常难于维护，类似这样的开源项目很多，有兴趣可以去看源码。

                // 下面参数 第二个 false  表示不用搜索 类的父类是否定义了 该特性
                if (!property.IsDefined(typeof(StringLengthAttribute), false)) continue;

                var attributes = property.GetCustomAttributes();
                foreach (var attribute in attributes)
                {
                    //这里的MaximumLength 最好用常量去做
                    var maxNumLength = (int)attribute.GetType().
                        GetProperty("MaxNumLength").
                        GetValue(attribute);

                    //获取属性的值
                    if (!(property.GetValue(obj) is string propertyValue))
                        throw new Exception("值不为null");//这里可以自定义，也可以用具体系统异常类

                    if (propertyValue.Length > maxNumLength)
                        throw new Exception($"属性{property.Name}的值{propertyValue}的长度超过了{maxNumLength}");
                }
            }
        }
    }
}