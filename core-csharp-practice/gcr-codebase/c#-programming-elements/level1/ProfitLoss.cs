using System;
class ProfitLoss{
  static void Main() {
     float cp=129;
     float sp=191;
     float profit=sp-cp;
     float profitPercent=(profit/cp)*100;
    
    Console.WriteLine("The Cost Price is INR "+cp+" Selling Price is INR "+sp+
    "\nThe Profit is INR "+profit+" and the Profit Percentage is "+profitPercent);
  }
}