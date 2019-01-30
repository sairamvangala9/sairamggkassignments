// using System;

// namespace Teststructs
// { 
//     struct pointstruct
//     {
//         public int a;
//         public static int b;
//     }
//     class sc1
//     {
//         public static int sc1a=1;
//         static sc1()
//         {
//             Console.WriteLine("sc1 static constructor");
//         }
//     }
//     class sc2:sc1
//     {
//         static sc2()
//         {
//             //sc1a=2;
//             Console.WriteLine("sc2 static constructor");
//         }
//     }
//     class pointclass
//     {
//         public int a;
//         public static int b;

//     }
//     enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };    
//     class Program
//     {  
        
//         static void Main()
//         {
//             sc2 obj1=new sc2();
//             //Console.WriteLine(sc1.sc1a);
//             // Colors c1;
//             // pointstruct obj;
//             // obj.a=1;
//             // pointstruct.b=2;
//             // pointclass obj2=new pointclass();
//             // Console.WriteLine(obj2.a+" "+pointclass.b+" "+obj.a+" "+pointstruct.b);
//             // Console.ReadKey();
//         }
//     }
// }

// using System;

// namespace Test1
// {
//     class Program
//     {
//         static void Main()
//         {
//             int[] a1 = new int[4];
//             int a = 54;
//             int b = 6;             
//             E e1 = new E();
//             E e2 = new E();
//             e1.i = 10;
//             e2.i = 20;
//             A obj = new A();
//             obj.display();
//             Console.WriteLine(a + " " + b + " " + e1.i + " " + e2.i);
//             obj.M(a, out b, e1, out e2);
//             //Console.WriteLine(a + " " + b + " " + e1.i + " " + e2.i);
//             Console.ReadLine();
//         }
//    }
//     public class E
//     {
//         public int i;
//     }
//     public class A
//     {
//         public void display()
//         {
//             //Console.WriteLine("display function from program class");
//         }
//         public void M(int a, out int b, E obj1, out E obj2)
//         {
//             E obj = new E();
//             obj.i = 55;
//             obj1 = new E();
//             a = 1;
//             b = 2;
//             obj1.i = 3;
//             // obj2.i = 4;
//             //obj2 = obj;
//             obj2=null;
//             //Console.WriteLine(a + " " + b + " " + obj1.i + " " + obj2.i);
//         }
//     }
// }
