import java.util.Scanner;

public class VolumeOfCylinder {
    public static void main(String[] args) {
           Scanner sc=new Scanner(System.in);
        float radius =sc.nextFloat();
        float height=sc.nextFloat();
        System.out.println(Math.PI*radius*radius*height);
        sc.close();
    }
}
