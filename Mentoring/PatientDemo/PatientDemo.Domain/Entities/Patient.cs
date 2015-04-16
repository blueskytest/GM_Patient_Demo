namespace PatientDemo.Domain.Entities
{
    public class Patient
    {
        public string Surname { get; set; }
        public string Forename { get; set; }
		public string Sex { get; set; }
		public string Height { get; set; }
		public string Weight { get; set; }
		public string BMI { get; set; }
    }
}
