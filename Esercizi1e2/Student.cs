using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi1e2
{
    public class Student
    {
        //elenco dei campi
        //full name, course, subject, university, e-mail and phone number
        string name;
        string surname;
        string course;
        string subject;
        string university;
        string? e_mail;
        string? phoneNumber;

        public Student(string name, string surname, string course,
            string subject, string university, string? e_mail, string? phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.e_mail = e_mail;
            this.phoneNumber = phoneNumber;
        }
        public Student(string name, string surname, 
            string course, string subject, string university, string? e_mail):
            this(name, surname, course, subject, university,e_mail,null)
        {
            //altro codice se necessario
        }
        public Student(string name, string surname,
            string course, string subject, string university):
            this(name, surname, course, subject, university, null) 
        { }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Subject { get => subject; set => subject = value; }
        public string University { get => university; set => university = value; }
        public string? E_mail { get => e_mail; set => e_mail = value; }
        public string? PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Course { get => course; set => course = value; }

        public string? FullName { 
            get => surname+" "+name; 
            set {
                //dato il valore del FullName assegnare name e surname
                //cerco la posizione dello spazio
                //? applicato a una variabile significa che se la
                if(value != null)
                {
                    int? posSpazio = value?.IndexOf(' '); //5
                    if (posSpazio != null && posSpazio != -1)
                    {
                        //ora posso impostare nome e cogne
                        surname = value.Substring(0, (int)posSpazio);
                        name = value.Substring((int)posSpazio+1);
                    }
                }
                
            } }
    }
}
