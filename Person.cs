// File: ReferenceTypes/Person.cs
namespace BMIMonitor.ReferenceTypes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; private set; }

        public void CalculateBMI()
        {
            var measurement = new BMIMonitor.Measurement(Weight, Height);
            BMI = measurement.BMI;
        }
    }
}
