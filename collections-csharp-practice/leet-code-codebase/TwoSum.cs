public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int>map=new Dictionary<int,int>();
          int[]arr=new int[2];
        for(int i=0;i<nums.Length;i++){
            int need=target-nums[i];
           if(map.ContainsKey(need)){
    return new int[]{ map[need], i };
}

              if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],i);
              }
        }
        return arr;
    }
}