using System;
namespace DotNetPOC
{
    public class funOverload
    {
        public funOverload()
        {
        }

        public string name;  
  
        //overloaded functions  
        public void setName(string last)  
        {  
            name = last;  
        }  
  
        public void setName(string first, string last)  
        {  
            name = first + "" + last;  
        }  
  
        public void setName(string first, string middle, string last)  
        {  
            name = first + "" + middle + "" + last;  
        } 

        //method for displaying records  
        public void showData()
        {
            Console.WriteLine(name);
        }
    }
}
