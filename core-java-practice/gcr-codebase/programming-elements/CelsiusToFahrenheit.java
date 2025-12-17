import java.util.*;

public class CelsiusToFahrenheit {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        float celsius=sc.nextFloat();
        System.out.println((celsius*9/5)+32);
        sc.close();
    }
}
