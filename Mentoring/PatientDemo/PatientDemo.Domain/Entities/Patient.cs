using System;

namespace PatientDemo.Domain.Entities
{
	public class Patient
	{
		public string Surname { get; set; }
		public string Forename { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Gender gender { get; set; }

		public enum Gender
		{
			Male = 1,
			Female 
		};

		
		public float Height { get; set; }
		public float Weight { get; set; }
		private float CalculateBmi()
		{
			float BMI = Weight / (Height * Height);
			return BMI;
		}



		public override string ToString()
		{
			return string.Format("{0} {1} Gender :{2} BMI: {3}", Forename, Surname, gender, CalculateBmi());
		}
	
	
	
	}




}