using System;
                    
namespace Laba2
{
    public class Program
    {
        public void Main(string[] args)
        {
            B testClass = new B(1,2,3);
            A testClass2 = new A(1,2);
            Console.WriteLine(testClass2.c);
            Console.WriteLine(testClass.c2);
        }
    }
    public class A
    {
        private float a;
        private float b;
        
        public A (float a, float b) {
            this.a = a;
            this.b = b;
        }
    
        public float c
        {
            get { return a + b; }
            set { a = b - value; }  
        }
    }
    
    public class B : A {
        float d;
        public B(float a, float b):base(a, b) {
        } public B(float a, float b, float d):this(a,b) {
            this.d = d;
        }
        
        public float c2 {
            get {
                for (int i = 0; i < 3; i++) {
                    d = d - c;
                }
                return d;
            }
        }
    }
}