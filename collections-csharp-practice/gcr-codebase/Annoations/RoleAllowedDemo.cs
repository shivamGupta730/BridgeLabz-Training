using System;

[AttributeUsage(AttributeTargets.Class)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

[RoleAllowed("ADMIN")]
class AdminPanel
{
    public void Access(string userRole)
    {
        if (userRole != "ADMIN")
            Console.WriteLine("Access Denied!");
        else
            Console.WriteLine("Access Granted!");
    }
}
