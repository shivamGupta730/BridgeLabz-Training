// Step 1: Remove leading and trailing spaces using Trim()
// Step 2: Split the string into words using space as delimiter
// Step 3: The last word is at index (array.Length - 1)
// Step 4: Return the length of the last word


public class Solution {
    public int LengthOfLastWord(string s) {
        s=s.Trim();
        string[] parts=s.Split(" ");
        int i=parts.Length-1;
           return parts[i].Length;

    }
}