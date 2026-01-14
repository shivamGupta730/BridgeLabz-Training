// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
// Note that you must do this in-place without making a copy of the array.

public class Solution {
    public void MoveZeroes(int[]arr) {
        int position=0;
        for(int i=0;i<arr.Length;i++){
               if(arr[i]!=0){
                arr[position]=arr[i];
                position++;
               }
        }
        for(int i=position;i<arr.Length;i++){
            arr[i]=0;
        }
    }
}
