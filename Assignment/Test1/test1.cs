// using System;
// namespace TestInheritance
// {
//     class A
//     {
//         static A()
//         {
//             Console.WriteLine("A static Constructor");
//         }
//         public A()
//         {
//             Console.WriteLine("A parameter less Constructor");
//         }
//         virtual public void display()
//         {
//             Console.WriteLine("A display");
//         }
//     }
//     class B:A
//     {
//         static B()
//         {
//             Console.WriteLine("B static Constructor");
//         }
//         public B()
//         {
//             Console.WriteLine("B parameter less Constructor");
//         }
//         new void display()
//         {
//             Console.WriteLine("B display");
//         }
//     }
//     abstract class C:B
//     {
//         static C()
//         {
//             Console.WriteLine("C static Constructor");
//         }
//         public C()
//         {
//             Console.WriteLine("C parameter less Constructor");
//         }
//         public void display()
//         {
//             Console.WriteLine("C display");
//         }
//     }
//     class D:C
//     {
//         static D()
//         {
//             Console.WriteLine("D static Constructor");
//         }
//         public D()
//         {
//             Console.WriteLine("D parameter less Constructor");
//         }
//         public void display()
//         {
//             Console.WriteLine("D display");
//         }
//     }
    
//     class Program
//     {
//         public static void Main( )
//         {
//             B objc=new D();
//             objc.display();
            
//             Console.ReadLine();
//         }
//         delegate void Printer(string s);

    
//         static void Main1()
//         {
//             // Instantiate the delegate type using an anonymous method.
//             Printer p = delegate(string j)
//             {
//                 System.Console.WriteLine(j);
//             };

//             // Results from the anonymous delegate call.
//             p("The delegate using the anonymous method is called.");

//             // The delegate instantiation using a named method "DoWork".
//             p = DoWork;

//             // Results from the old style delegate call.
//             p("The delegate using the named method is called.");
//         }

//         // The method associated with the named delegate.
//         static void DoWork(string k)
//         {
//             System.Console.WriteLine(k);
//         }
    
//     }
// }
