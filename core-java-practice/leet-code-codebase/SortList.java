import java.util.*;

public class SortList {
      int val;
      SortList next;
   SortList() {}
     SortList(int val) { this.val = val; }
     SortList(int val, SortList next) { this.val = val; this.next = next; }
  }
 
class Solution {
    public SortList sortList(SortList head) {
        List<Integer> arrayList = new ArrayList<>();
        SortList current = head;

        // Convert linked list to ArrayList
        while (current != null) {
            arrayList.add(current.val);
            current = current.next;
        }

        // Sort the ArrayList
        Collections.sort(arrayList);

        // Reconstruct the sorted linked list
        current = head;
        for (int val : arrayList) {
            current.val = val;
            current = current.next;
        }

        return head;
    }
}