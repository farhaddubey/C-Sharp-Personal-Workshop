using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class pcm
    {
        //static void Main()
        //{
        //    Console.WriteLine("I'm pcm class");
        //    Geny gen = new Geny();
        //    //gen.geny();
        //}
    }
    public class Geny
    {
        public static void geny()
        {
            Console.WriteLine("I love you Geny");
        }
        static int average(int a , int b, int c)
        {
            return a + b + c;
        }
        static void Main()
        {

            Console.WriteLine("Hello three");
            Console.WriteLine(average(1, 2 ,4));
            Player tom = new Player();
            Console.WriteLine(tom.health);
        }
    }
    internal class Program
    {

        static void Greet()
        {
            Console.WriteLine("Helllo I'm Greeting Function");
        }
        //static void Main(string[] args)
        //{
        //    Greet();
        //    //Console.WriteLine("Hi, Mr. Farhad Dubey! What's up???");
        //    //int a = 34;
        //    ////float b = 2.4; By default in C# all decimals are dobule hence to use F for float

        //    //char e = 'r';
        //    //Console.WriteLine(e);
        //    //float b = 2.3F;
        //    //double c = 89;
        //    //Console.WriteLine(a);
        //    //Console.WriteLine(b);
        //    //Console.WriteLine(c);
        //    //double d = 90D;
        //    //Console.WriteLine(d);
        //    //bool isGreat = true;
        //    //Console.WriteLine(isGreat);

        //    //There are two types of Casting
        //    //    1.Implicit Casting
        //    //char to int to long to float to double 
        //    //Casting using this C sharp protocol is called Implicit Casting
        //    //char has the lowest power & double the highest so char can get promotion to it's seniors '
        //    //int z1 = z;  
        //    //implicity convert type 'double' to int. An explicit conversion exist
        //    //Console.WriteLine(z1);
        //    //    2.Explicit Casting
        //    //int x = (int)3.5;
        //    //float y = (float)44;
        //    //Console.WriteLine(y);
        //    //Console.WriteLine(x);
        //    ////Ctrl + K + c to Comment here 
        //    //float var = Convert.ToInt16(2.33);
        //    //Console.WriteLine(var);
        //    //Console.WriteLine("Enter your Name");
        //    //String name = Console.ReadLine();
        //    //Console.WriteLine("The name is : "+ name);
        //    //Console.WriteLine("How many choco do you want??");
        //    //String num = Console.ReadLine();
        //    //Console.WriteLine("You will get 4 more candies: "+ (Convert.ToInt16(num)+4));

        //    //Console.ReadLine();

        //    //Opearators in C Sharp C#
        //    //Arithmetic Operators 
        //    //Assignment Operaots
        //    //Logical Operators
        //    //Comparison Opeators
        //    //Console.WriteLine("The value of a+b is: " + (a + b));
        //    //Console.WriteLine("The valuee of a-b is: " + (a - b));
        //    //Console.WriteLine("The value of a*b is: " + (a * b));
        //    //Console.WriteLine("The value of a/ bis: " + (a / b));
        //    //int a1 = 4;
        //    //int b1 = a1;
        //    //Console.WriteLine(b1);
        //    //b1 -= 4;
        //    //Console.WriteLine("After Substracting: " + b1);
        //    //b1 += 10;
        //    //Console.WriteLine(b1);
        //    //b1 *= 2;
        //    //Console.WriteLine(b1);
        //    //b1 /= 4;
        //    //Console.WriteLine(b1);


        //    //Console.WriteLine(true && true);
        //    //Console.WriteLine(true || false);
        //    //Console.WriteLine(true && false);
        //    //Console.WriteLine(!false);
        //    //Console.WriteLine(325 < 400);
        //    //Console.WriteLine(400 == 400);
        //    //Console.WriteLine(400 >= 400);
        //    //Console.WriteLine(400 > 500);

        //    //char abc1= 'a';
        //    //Console.WriteLine(abc1);
        //    //int b5 = abc1;
        //    //Console.WriteLine(b5);
        //    //for (int i=0; i<26; i++)
        //    //{
        //    //    char final = (char)(i+b5);
        //    //    Console.WriteLine("The ASCII value of " + final + " is "+ (b5+i));
        //    //}














        //    //float var = Convert.ToInt16(3.55);
        //    //Console.WriteLine(var);
        //    //float var1 = Convert.ToInt32(4.00);
        //    //Console.WriteLine(var1);
        //    ////Convert.ToString, Convert.ToInt32
        //    ///


        //    //int i = 0;
        //    //while (i < 20)
        //    //{
        //    //    Console.WriteLine(i + " Hwllo there");
        //    //    i++;
        //    //}
        //    ///*            do while statement always runs for 1 time then it takes decison to stop or not*/
        //    //do
        //    //{
        //    //    Console.WriteLine("Do while runnig in false condition for time "+i);

        //    //}while(i > 20);

        //    //continue  immeditately again roolls the list for next iteration by skipping below codes
        //    for(int i=0; i<10; i++)
        //    {
        //        if(i==3 || i== 5 ||i== 9)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}
    }
}