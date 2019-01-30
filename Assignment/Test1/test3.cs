// namespace DefineIMyInterface
// {
//     using System;

//     public class IMyInterface
//     {
//         public int a;
//         // Any class that implements IMyInterface must define a method
//         // that matches the following signature.
//         void MethodB()
//         {
//             Console.WriteLine("interface Method B");
//         }
//     }
// }


// // Define extension methods for IMyInterface.
// namespace Extensions
// {
//     using System;
//     using DefineIMyInterface;
//     using ExtensionMethodsDemo1;

//     // The following extension methods can be accessed by instances of any 
//     // class that implements IMyInterface.
//     public static class Extension
//     {
//         public static void MethodA(this IMyInterface myInterface, int i)
//         {
//             myInterface.a=1;
//             Console.WriteLine
//                 ("Extension.MethodA(this IMyInterface myInterface, int i)");
//         }
//     }
// }


// // Define three classes that implement IMyInterface, and then use them to test
// // the extension methods.
// namespace ExtensionMethodsDemo1
// {
//     using System;
//     using Extensions;
//     using DefineIMyInterface;

//     public class A : IMyInterface
//     {
//         public int b;
//         public int a;
//         public void MethodB() { Console.WriteLine("A.MethodB()"); }
//         public void display(){Console.WriteLine(a);}
//     }

//     class ExtMethodDemo
//     {
//         static void Main(string[] args)
//         {
//             // Declare an instance of class A, class B, and class C.
//             A a = new A();
           
//             // For a, b, and c, call the following methods:
//             //      -- MethodA with an int argument
//             //      -- MethodA with a string argument
//             //      -- MethodB with no argument.

//             // A contains no MethodA, so each call to MethodA resolves to 
//             // the extension method that has a matching signature.
//             a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
           
//             // A has a method that matches the signature of the following call
//             // to MethodB.
//             a.MethodB();            // A.MethodB()

//             // B has methods that match the signatures of the following
//             // method calls.
            
//         }
//     }
// }