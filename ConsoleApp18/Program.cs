// See https://aka.ms/new-console-template for more information
using ConsoleApp18.Models;

Console.WriteLine("Hello, World!");
//Doctor doctor1 = new Doctor("Nihad", "Ibadzade", "Baki", new DateTime(2008, 2, 21));
//Doctor doctor2 = new Doctor("Kazim", "Ibadzadov", "samaxi", new DateTime(2001, 2, 21));
//Doctor doctor3 = new Doctor("kamil", "filankesov", "gence", new DateTime(1902, 2, 21));

//Doctor[] doctors = {doctor1, doctor2, doctor3};
//DateTime date1 = new DateTime(1993, 5, 25);
//DateTime date2 = new DateTime(2002, 12, 15);
//void GettingDoctors(DateTime m,DateTime n) {
//    foreach (Doctor doctor in doctors)
//    {
//        if(doctor.Birthday>m&&doctor.Birthday<n)
//        {
//            Console.WriteLine($"{doctor.Name} {doctor.SurName} {doctor.Address} {doctor.Birthday}");
//        }

//    }
//}

//GettingDoctors(date1, date2);
Doctor doctor = new();
doctor.info();
doctor.GettingDoctors();