import java.util.Scanner;

public class AverageOfThreeNumbers {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        float num1=sc.nextFloat();
        float num2=sc.nextFloat();
        float num3=sc.nextFloat();
        System.out.println((num1+num2+num3)/3);
        sc.close();
    }
}
