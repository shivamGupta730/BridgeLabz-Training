using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(5)]
    public string Username;

    public User(string name)
    {
        if (name.Length > 5)
            throw new ArgumentException("Username length exceeded");

        Username = name;
    }
}
