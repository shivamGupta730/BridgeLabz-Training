using System;
class IsFirstNumberIsSmall {
  static void Main() {
Console.WriteLine("Enter the  first number");
  int num1=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the  second number");
  int num2=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter the  Third  number");
  int num3=Convert.ToInt32(Console.ReadLine());
   if(num1<num2 && num1<num3){
      Console.WriteLine(" Is the first number the smallest? True");
  }
  else{
       Console.WriteLine(" Is the first number the smallest? False");
  }
  }
}