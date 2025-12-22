using System;
class FriendsAgeProblem
{
    static void Main()
    {
        int aAge=int.Parse(Console.ReadLine());
        int bAge=int.Parse(Console.ReadLine());
        int cAge=int.Parse(Console.ReadLine());

        int aHt=int.Parse(Console.ReadLine());
        int bHt=int.Parse(Console.ReadLine());
        int cHt=int.Parse(Console.ReadLine());

        if(aAge<bAge && aAge<cAge)
            Console.WriteLine("Amar is youngest");
        else if(bAge<aAge && bAge<cAge)
            Console.WriteLine("Akbar is youngest");
        else
            Console.WriteLine("Anthony is youngest");

        if(aHt>bHt && aHt>cHt)
            Console.WriteLine("Amar is tallest");
        else if(bHt>aHt && bHt>cHt)
            Console.WriteLine("Akbar is tallest");
        else
            Console.WriteLine("Anthony is tallest");
    }
}
