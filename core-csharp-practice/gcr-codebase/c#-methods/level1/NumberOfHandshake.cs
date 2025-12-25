using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level1
{
    internal class NumberOfHandshake
    {
        public int Handshake(int n) {
            int shake = (n * (n - 1)) / 2;
            return shake;
        }
    }
    internal class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("enter the number of students");
            int n=int.Parse(Console.ReadLine());
            NumberOfHandshake num=new NumberOfHandshake();
            int result=num.Handshake(n);
            Console.WriteLine(result);
        }
    }
}
