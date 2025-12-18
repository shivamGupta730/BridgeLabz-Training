using System;
 class SimpleInterest {
     static void Main() {
        float principle=300.0f;
        float rate=2.0f;
        float time=10.0f;
        float output=(principle*rate*time)/100;
        Console.WriteLine(output);
    }
}
