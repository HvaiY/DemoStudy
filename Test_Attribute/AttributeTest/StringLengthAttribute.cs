using System;

// 自定义特性 限制该特性只用于属性上  作用是限制长度
[AttributeUsage(AttributeTargets.Property)]
public class StringLengthAttribute : Attribute
{
    private readonly int _maxNumLength;

    public StringLengthAttribute(int maxNumLength)
    {
        _maxNumLength = maxNumLength;
    }

    public int MaxNumLength
    {
        get { return _maxNumLength; }
    }
}