using System;
using LibraryUtil;

namespace DotNetPOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //object instantiation    
            customer obj = new customer();

            //Method calling  
            Console.WriteLine("1. object instantiation");
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

            //constructor and destructor  
            Console.WriteLine("\n4. constructor and destructor");
            people objpeople1 = new people("Rajesh","Khan");
            objpeople1.AppendData();

            people objpeople2 = new people();
            objpeople2.AppendData();

            //function overloading
            Console.WriteLine("\n5. function overloading");
            funOverload objfunOverload = new funOverload();  
  
            objfunOverload.setName("Rajesh"); 
            objfunOverload.showData();
            objfunOverload.setName("Rajesh"," Khan "); 
            objfunOverload.showData();
            objfunOverload.setName("Rajesh"," Tarun"," Khan"); 
            objfunOverload.showData();
        }
        
    }
}
