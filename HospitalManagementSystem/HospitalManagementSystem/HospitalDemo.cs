using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            Hospital hospital = new Hospital();

            // Додавання лікарів
            hospital.AddDoctor(new Doctor(1, "Jake", "Neurolog"));
            hospital.AddDoctor(new Doctor(2, "Emily", "Cardiologist"));
            hospital.AddDoctor(new Doctor(3, "John", "Surgeon"));

            // Реєстрація пацієнтів
            hospital.RegisterPatient(new Patient(1, "Alex", 25));
            hospital.RegisterPatient(new Patient(2, "Maria", 40));
            hospital.RegisterPatient(new Patient(3, "Tom", 30));
            hospital.RegisterPatient(new Patient(4, "Luna", 22));

            // Створення палат
            hospital.CreateRoom(new HospitalRoom(101, 2));
            hospital.CreateRoom(new HospitalRoom(102, 2));
            hospital.CreateRoom(new HospitalRoom(103, 1));

            // Госпіталізація
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 103);

            // Медичні записи
            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[0], hospital.Doctors[0], "Консультація невролога"));
            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[1], hospital.Doctors[1], "Перевірка серцевої діяльності"));
            hospital.AddMedicalRecord(new MedicalRecord(
                hospital.Patients[2], hospital.Doctors[2], "Післяопераційний огляд"));

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());

        }
    }
}