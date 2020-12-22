using System;
                    
namespace Laba1
{
    public class Program
    {
        public void Main(string[] args)
        {
            A testClass = new A();
            
            Console.WriteLine(testClass.c);
        }
    }
    class A
    {
       private float a = 9;
       private float b = 10;
 
        public float c
        {
            get { return a + b; }
            set { a = b - value; }  
        }
    }
}