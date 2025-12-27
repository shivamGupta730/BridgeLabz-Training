using System;

public class VowelsAndConsonants
{
    public static void Main(string[] args)
    {
      Console.WriteLine("enter the  string");
      String str=Console.ReadLine();
          int countVowel=0;
          int countConst=0;
      if(string.IsNullOrWhiteSpace(str)){
          Console.WriteLine("string is empty");
      }
      else{
                str=str.ToLower();
        char[] arr=str.ToCharArray();
        for(int i=0;i<arr.Length;i++){
            if(arr[i]=='a'||arr[i]=='e'||arr[i]=='i'||arr[i]=='o'||arr[i]=='u'){
                countVowel++;
            }
            else{
                countConst++;
            }
        }
      }
      Console.WriteLine("the count of consonants is : "+ countConst);
      Console.WriteLine("the count of vowel is : "+ countVowel);
    }
}