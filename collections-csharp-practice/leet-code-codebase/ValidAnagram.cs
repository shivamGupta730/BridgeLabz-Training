public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        Dictionary<char,int> map = new Dictionary<char,int>();

        // Count characters of s
        for(int i = 0; i < s.Length; i++){
            char ch = s[i];
            if(map.ContainsKey(ch)){
                map[ch]++;
            }
            else{
                map[ch] = 1;
            }
        }

        // Reduce count using t
        for(int i = 0; i < t.Length; i++){
            char ch = t[i];

            if(!map.ContainsKey(ch)){
                return false;
            }

            map[ch]--;

            if(map[ch] < 0){
                return false;
            }
        }

        return true;
    }
}
