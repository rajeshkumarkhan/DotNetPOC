using System;
namespace DotNetPOC
{
    public class people
    {
        //Member Variables  
        public string Name;

        //constuctor for initializing fields  
        public people(string fname, string lname)
        {
            Name = fname + " " + lname;
        }

        //method for displaying people records  
        public void AppendData()
        {
            Console.WriteLine(Name);
        }

        public people()
        {
            Console.WriteLine("Fields initialized");
            Name = "Rajesh Kumar Khan";
        }

        //destructor  
        ~people()
        {
            Console.WriteLine("Fields cleaned");
            Name = string.Empty;
        }
    }
}
