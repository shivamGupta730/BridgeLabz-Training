using System.Collections.Generic;

class Customer
{
    private string name;
    private List<string> items;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<string> Items
    {
        get { return items; }
        set { items = value; }
    }
}
