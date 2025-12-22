using System;
class CanVote {
  static void Main() {
Console.WriteLine("Enter the age");
  int age=Convert.ToInt32(Console.ReadLine());
     if (age >= 18)
        {
            Console.WriteLine("The person's age is " + age + " can vote" );
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " cannot  vote" );
        }

  }
}