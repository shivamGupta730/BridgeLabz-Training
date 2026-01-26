public class Solution {
    public void MoveZeroes(int[] nums) {

        int pointerB = 0; // next non-zero ki position

        // scanner loop
        for (int pointerA = 0; pointerA < nums.Length; pointerA++) {

            // jab non-zero mile
            if (nums[pointerA] != 0) {

                // non-zero ko left side me le aao
                int temp = nums[pointerA];
                nums[pointerA] = nums[pointerB];
                nums[pointerB] = temp;

                // next non-zero seat
                pointerB++;
            }
        }
    }
}
