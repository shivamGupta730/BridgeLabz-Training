using System;
class BmiCalculator
{
    static void Main()
    {
        double wt=double.Parse(Console.ReadLine());
        double ht=double.Parse(Console.ReadLine());
        ht=ht/100;
        double bmi=wt/(ht*ht);
        Console.WriteLine(bmi);
        if(bmi<=18.4)
            Console.WriteLine("Underweight");
        else if(bmi<=24.9)
            Console.WriteLine("Normal");
        else if(bmi<=39.9)
            Console.WriteLine("Overweight");
        else
            Console.WriteLine("Obese");
    }
}
