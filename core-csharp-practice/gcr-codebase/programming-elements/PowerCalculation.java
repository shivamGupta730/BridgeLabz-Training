import java.util.Scanner;

public class PowerCalculation {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        float base=sc.nextFloat();
        float exponent=sc.nextFloat();
        System.out.println(Math.pow(base, exponent));
        sc.close();
    }
}
