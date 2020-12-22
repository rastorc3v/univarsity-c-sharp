using System;
                    
namespace Laba3
{
    public class Program
    {
        public void Main(string[] args)
        {
            B testClass = new B(3,2,3);
            //testClass2 = new A(1,2);
			foreach (int i in testClass.arr) {
				Console.WriteLine(i);
			}
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
        public float[] arr;
        public B(float a, float b):base(a, b) {
		} public B(float a, float b, float d):this(a,b) {
			this.d = d;
            arr = new float[(int) a];
			for (int i = 0; i < arr.Length; i++) {
            	arr[i] = c2 * i;
            }	
        }
   
        public float c2 {
            get {
                for (int i = 0; i < 3; i++) {
                    this.d = this.d - c;
                }
                return this.d;
            }
        }
    }
}