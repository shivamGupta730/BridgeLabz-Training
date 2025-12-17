import java.util.*;
class Solution {
    public List<String> generateParenthesis(int n) {
        List<String> list=new ArrayList<>();
        print(n,"",0,0,list);
        return list;
    }
    public static void print(int n,String ans,int open,int close,List<String> list){
        if(open==n && close==n){
            list.add(ans);
            return;
        }
        if(open<n)
            print(n,ans+"(",open+1,close,list);
        if(close<open)
            print(n,ans+")",open,close+1,list);
    }
}