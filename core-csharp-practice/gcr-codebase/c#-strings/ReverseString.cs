using System;

public class ReverseString
{
    public static void Main(string[] args)
    {
      Console.WriteLine("enter the  string");
      String str=Console.ReadLine();
      if(string.IsNullOrWhiteSpace(str)){
          Console.WriteLine("string is empty");
      }
      else{
        char[] arr=str.ToCharArray();
        char[] newChar=new char[arr.Length];
        int j=0;
        for(int i=arr.Length-1;i>=0;i--){
            newChar[j]=arr[i];
            j++;
        }
        
      string resultString = string.Concat(newChar);
      Console.WriteLine(resultString);
      }
  
    }
}