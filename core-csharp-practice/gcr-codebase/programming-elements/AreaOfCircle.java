import java.util.*;

public class AreaOfCircle {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        float radius =sc.nextFloat();
        System.out.println(Math.PI*radius*radius);
        sc.close();
    }
}
