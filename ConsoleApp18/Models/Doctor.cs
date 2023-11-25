using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Models
{
    internal class Doctor
    {
        public string Name { get; set; }
        public  string SurName { get; set; }
        public string  Address { get; set; }
        public DateTime Birthday { get; set; }

        public Doctor(string name,string surname,string address,DateTime birthday) {
        Name = name;
            SurName = surname;
            Address = address;
            Birthday = birthday;
        
        }
        public Doctor() { }
        public Doctor[] info()
        {
            Doctor doctor1 = new Doctor("Nihad", "Ibadzade", "Baki", new DateTime(2008, 2, 21));
            Doctor doctor2 = new Doctor("Kazim", "Ibadzadov", "samaxi", new DateTime(2001, 2, 21));
            Doctor doctor3 = new Doctor("kamil", "filankesov", "gence", new DateTime(1902, 2, 21));

            Doctor[] doctors = { doctor1, doctor2, doctor3 };
            return doctors;
        }
        public void GettingDoctors()
        {
            Doctor[] doctorsInfo=info();
            DateTime date1 = new DateTime(1993, 5, 25);
            DateTime date2 = new DateTime(2002, 12, 15);
            foreach (Doctor doctor in doctorsInfo)
            {
                if (doctor.Birthday > date1 && doctor.Birthday < date2)
                {
                    Console.WriteLine($"{doctor.Name} {doctor.SurName} {doctor.Address} {doctor.Birthday}");
                }

            }
        }
    }

}
