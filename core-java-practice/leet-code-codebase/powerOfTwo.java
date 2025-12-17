class Solution {

    // Checking if a number is power of two
    public boolean isPowerOfTwo(int n) {
        
        // 1 is a power of two (2^0), so return true
        if(n == 1) return true;

        // 0 can never be a power of two
        if(n == 0) return false;

        // If divisible by 2, keep dividing and check again, else it's not power of two
        return n % 2 == 0 ? isPowerOfTwo(n / 2) : false;
    }
}
