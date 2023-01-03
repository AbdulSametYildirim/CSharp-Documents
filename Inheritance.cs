using System;

namespace Inheritance{


	class Animal {
		public string name;
		public int age;
	}

	class Cat : Animal {

		public void Identity() {
			Console.WriteLine("Name+ " + name + " Age: " + age);

		}


	}

	class Program {
		static void Main(string[] args) {

			Kedi c = new Cat();
			c.name = "Pamuk";
			c.age = 3;
			c.Identity();


		}
	
	}

}