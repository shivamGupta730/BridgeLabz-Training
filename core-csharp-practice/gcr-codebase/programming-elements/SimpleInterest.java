import java.util.Scanner;

public class SimpleInterest {
    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        float principle=sc.nextFloat();
        float rate=sc.nextFloat();
        float time=sc.nextFloat();
        float output=(principle*rate*time)/100;
        System.out.println(output);
        sc.close();
    }
}
