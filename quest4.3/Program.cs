using System;
using System.Collections.Generic;
using System.Linq;

public class Patient
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Doctor { get; set; }

    public Patient(string name, string department, string doctor)
    {
        Name = name;
        Department = department;
        Doctor = doctor;
    }
}

public class Hospital
{
    private Dictionary<string, List<Patient>> departments = new Dictionary<string, List<Patient>>();
    private Dictionary<string, List<Patient>> doctors = new Dictionary<string, List<Patient>>();

    public void AddPatient(string department, string doctor, string patientName)
    {
        var patient = new Patient(patientName, department, doctor);

        if (!departments.ContainsKey(department))
        {
            departments[department] = new List<Patient>();
        }
        departments[department].Add(patient);

        if (!doctors.ContainsKey(doctor))
        {
            doctors[doctor] = new List<Patient>();
        }
        doctors[doctor].Add(patient);
    }

    public void PrintDepartmentPatients(string department)
    {
        if (departments.ContainsKey(department))
        {
            foreach (var patient in departments[department])
            {
                Console.WriteLine(patient.Name);
            }
        }
    }

    public void PrintRoomPatients(string department, int roomNumber)
    {
        if (departments.ContainsKey(department))
        {
            var patientsInRoom = departments[department]
                .Skip((roomNumber - 1) * 3)
                .Take(3)
                .OrderBy(p => p.Name)
                .ToList();

            foreach (var patient in patientsInRoom)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }

    public void PrintDoctorPatients(string doctor)
    {
        if (doctors.ContainsKey(doctor))
        {
            var patients = doctors[doctor].OrderBy(p => p.Name).ToList();
            foreach (var patient in patients)
            {
                Console.WriteLine(patient.Name);
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        var hospital = new Hospital();

        string input;
        while ((input = Console.ReadLine()) != "Output")
        {
            var parts = input.Split();
            string department = parts[0];
            string doctor = parts[1];
            string patientName = parts[2];

            hospital.AddPatient(department, doctor, patientName);
        }

        while ((input = Console.ReadLine()) != "End")
        {
            var parts = input.Split();
            if (parts.Length == 1)
            {
                hospital.PrintDepartmentPatients(parts[0]);
            }
            else if (parts.Length == 2)
            {
                int roomNumber = int.Parse(parts[1]);
                hospital.PrintRoomPatients(parts[0], roomNumber);
            }
            else if (parts.Length == 1)
            {
                hospital.PrintDoctorPatients(parts[0]);
            }
        }
    }
}
