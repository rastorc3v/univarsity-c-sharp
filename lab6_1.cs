using System;
using System.Collections.Generic;
                    
namespace Laba6_1
{
    public class Program
    {
        public void Main(string[] args)
        {
			People p1 = new People("Вторгуев", 2001, "Студент");
			People p2 = new People("Аторгуев", 2005, "Студент");
			People p3 = new People("Нторгуев", 2004, "Студент");
			People[] test = {p1, p2, p3};
			Array.Sort(test);		
			foreach (People dates in test) {
				Console.WriteLine(dates.birthYear);
			}
			Array.Sort(test, new PeopleComparer());
			foreach (People dates in test) {
				Console.WriteLine(dates.surname);
			}
        }
    }
	
	class People : IComparable
	{
		public string surname;
		public int birthYear;
		public string status;
		
		public int CompareTo(object o) {
			People p = o as People;
			if (p != null) {
				return this.birthYear.CompareTo(p.birthYear);
			} else {
				throw new Exception("Невозможно сравнить два объекта");
			}
		}

		public People () {}
		
		public People (string sn, int bY, string s){
			this.surname = sn;
			this.birthYear = bY;
			this.status = s;
		}
		
		public void getInfo () {
			Console.WriteLine("Фамилия: " + this.surname);
			Console.WriteLine("Возраст: " + this.Info());
			Console.WriteLine("Статус: " + this.status);
		}
		
		public virtual int Info(){
			return 2020 - this.birthYear;
		}
	}
	
	class Student : People {
		public int mathMark;
		public int physMark;
		public int hisMark;
		
		public Student (int mM, int pM, int hM) {
			this.mathMark = mM;
			this.physMark = pM;
			this.hisMark = hM;
		}
		
		public int avgMark () {
			return (this.mathMark + this.physMark + this.hisMark)/3;
		}
		
		public override int Info() {
			return Math.Max(Math.Max(this.mathMark, this.physMark), this.hisMark);
		}
	}
	
	class PeopleComparer : IComparer <People>
	{
		public int Compare(People p1, People p2){
			return String.Compare(p1.surname, p2.surname);
		}
	}
}