using System;

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
            obj.displayData();

            Console.WriteLine();
            //fields calling    
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);

            Console.WriteLine();
            //partial class instance  
            partialclassDemo objpatial = new partialclassDemo();  
            objpatial.method1();  
            objpatial.method2(); 
        }
        
    }
}
