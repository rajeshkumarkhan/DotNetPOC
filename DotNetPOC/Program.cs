using System;
using LibraryUtil;

namespace DotNetPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // object instantiation    
            Customer obj = new Customer();

            //Method calling  
            Console.WriteLine("1. Method calling");
            obj.displayData();

            //fields calling  
            Console.WriteLine("\nfields calling");
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);

            //partial class instance 
            Console.WriteLine("\n2. partial class instance");
            partialclassDemo objpatial = new partialclassDemo();  
            objpatial.method1();  
            objpatial.method2(); 

            //LibraryUtil --> class library reference added
            //library class instance  
            Console.WriteLine("\n3. class library instance");
            MathLib objMathLib = new MathLib();  
  
            //method populate  
            objMathLib.calculareSum(2, 5);  
            objMathLib.calculareSqrt(25); 
        }
        
    }
}
