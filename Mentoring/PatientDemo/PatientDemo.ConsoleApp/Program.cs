using PatientDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDemo.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Patient myPatient = new Patient();
			myPatient.Surname = "Smith";
			myPatient.Forename = "John";
			myPatient.Sex = "Male";


			Console.WriteLine("Name: " + myPatient.Forename + " " + myPatient.Surname);
			Console.WriteLine("Sex: " + myPatient.Sex);

			Console.Write("What is patient height (cm)? ");
			String heightAsString = Console.ReadLine();
			int Height = int.Parse(heightAsString);


			Console.Write("What is patient weight (kg)? ");
			String weightAsString = Console.ReadLine();
			int Weight = int.Parse(weightAsString);


			var BMI = Weight / (Height * Height);

			Console.Write("Patient BMI = " + BMI.ToString() + "%");


			Console.ReadKey();
		}
	}
}
