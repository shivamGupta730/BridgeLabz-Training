import java.util.Scanner;

public class PerimeterOfRectangle {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        float length=sc.nextFloat();
        float width=sc.nextFloat();
        float perimeter=2*(length+width);
        System.out.println(perimeter);
        sc.close();
    }
}
