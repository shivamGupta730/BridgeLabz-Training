class Solution {
    public int removeDuplicates(int[] nums) {

        // Empty array ka case
        if (nums.length == 0) return 0;

        // i last unique element ka index track karega
        int i = 0;

        // j se array scan kar raha hoon
        for (int j = 1; j < nums.length; j++) {

            // Jab naya unique element mile
            if (nums[j] != nums[i]) {
                i++;              // index aage badhao
                nums[i] = nums[j]; // us unique ko place karo
            }
        }

        // unique elements ki count
        return i + 1;
    }
}
