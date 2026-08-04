using System;

namespace Assignment
{
    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        private string diagnosis;
        private string medicalHistory;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }

        public Patient(int patientId, string name, int age)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
        }

        public void SetDiagnosis(string diagnosis)
        {
            this.diagnosis = diagnosis;
        }

        public void SetMedicalHistory(string medicalHistory)
        {
            this.medicalHistory = medicalHistory;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID : {PatientId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Age        : {Age}");
        }
    }

    class InPatient : Patient, IMedicalRecord
    {
        private string record;

        public InPatient(int patientId, string name, int age)
            : base(patientId, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 5000;
        }

        public void AddRecord(string record)
        {
            this.record = record;
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Medical Record : {record}");
        }
    }

    class OutPatient : Patient, IMedicalRecord
    {
        private string record;

        public OutPatient(int patientId, string name, int age)
            : base(patientId, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 800;
        }

        public void AddRecord(string record)
        {
            this.record = record;
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Medical Record : {record}");
        }
    }
}