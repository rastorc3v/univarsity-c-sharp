using System;
                    
namespace Laba5
{
    public class Program
    {
        public void Main(string[] args)
        {
            B testClass = new B(5,3,3);
			
			for (int i = 0; i < testClass.arr.Length; i++) {
				// put array num [i, *here*]
				Console.WriteLine(testClass[i, 2]);
			}
			
			C<string> classC = new C<string>("1221");
			C<int> classC2 = new C<int>(1221);
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
		public float[] arr2 = new float[5];

        public B(float a, float b):base(a, b) {
		} public B(float a, float b, float d):this(a,b) {
			this.d = d;
            arr = new float[(int) a];
			for (int i = 0; i < arr.Length; i++) {
            	arr[i] = c2 * i;
				arr2[i] = c2 - i;
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
		
		public float this[int ind1, int arrNum] {
            get {
				if (arrNum == 1) {
					return arr[ind1]; 
				} else {
					return arr2[ind1];
				}
			}
            set {
				if (arrNum == 1) {
					this.arr[ind1] = value;
				} else {
					arr2[ind1] = value;
				}
			}
        }
    }
	
	public class C<T>{
		static T test;
		public C(T a) {
			test = a;
		}
		
	}
}