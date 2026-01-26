public class Solution {
    public int RemoveElement(int[] nums, int value) {
        int start=0;
        int end=nums.Length-1;
       while(start<=end){
        if(nums[start]==value){
            int temp=nums[start];
            nums[start]=nums[end];
            nums[end]=temp;
            end--;
        }
         else{
            start++;
         }
       }
       return end+1;
        }
    }
