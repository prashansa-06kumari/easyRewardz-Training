using System;

namespace Assignment2
{
    class HospitalManagement
    {
        public static string HospitalName = "City Hospital";
        private static int totalPatients = 0;

        private string name;
        private int age;
        private string ailment;

        public readonly int PatientID;

        // Parameterized constructor
        public HospitalManagement(int patientID, string name, int age, string ailment)
        {
            PatientID = patientID;
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            totalPatients++;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Hospital   : {HospitalName}");
            Console.WriteLine($"Patient ID : {PatientID}");
            Console.WriteLine($"Name       : {name}");
            Console.WriteLine($"Age        : {age}");
            Console.WriteLine($"Ailment    : {ailment}");
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients : {totalPatients}");
        }
    }
}