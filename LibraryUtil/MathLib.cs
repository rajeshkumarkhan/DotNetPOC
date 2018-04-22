using System;

namespace LibraryUtil
{
    public class MathLib  
    {  
        public MathLib() { }  
  
        public void calculareSum(int x, int y)  
        {  
            int z = x + y;  
            Console.WriteLine(z);    
        }  
  
        public void calculareSqrt(double x)  
        {  
            double z = Math.Sqrt(x);    
            Console.WriteLine(z);  
        }  
    } 
}
