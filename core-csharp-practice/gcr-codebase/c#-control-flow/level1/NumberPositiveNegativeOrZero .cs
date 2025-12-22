using System;
class NumberPositiveNegativeOrZero {
  static void Main() {
 Console.WriteLine("Enter the number ");
  int num=int.Parse(Console.ReadLine());
     if(num>0){
        Console.WriteLine("Positive");
     }
     else if(num==0){
         Console.WriteLine("Zero");
     }
     else{
         Console.WriteLine("Negative");
     }

  }
}