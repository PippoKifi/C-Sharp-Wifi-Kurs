using System;
using System.Data.SqlTypes;

namespace GrundlagenKlassen
{
    public class Employee
    {
        //Hier geht es immer nur um einen Mitarbeiter
        
        //ZUSTAND INFORMATIONEN
        public string Name;
        public Guid Id;
        public decimal Salary;
        public DateTime Birthday;
        public EmployeeState State;


        /*Standard Konstrucktor
        public Employee() //Konstrucktor (Methode innerhalb von einer klasse) Muss genau gleich heissen wie die klasse!
        {
            //Aufgabe: Objekt konsistenz herstellen (Standard werte)
            Name = "No Name";
            Id = Guid.NewGuid();
            Salary = 1.800m;
            Birthday = new DateTime(1998,11 ,1);
            State = EmployeeState.Probezeit;
        }
        */

        public Employee(string name, DateTime birthday, decimal salary) //Benutzerspezifische Parameter
        {
            Id = Guid.NewGuid();
            State = EmployeeState.Probezeit;

            Name = name;
            Birthday = birthday;
            Salary = salary;
        }


        //METHODEN
        public void DisplayInfos()
        {
            Console.WriteLine($"MA Id:      {Id}");
            Console.WriteLine($"Name:       {Name}");
            Console.WriteLine($"Birthday:   {Birthday.ToLongTimeString()}");
            Console.WriteLine($"State:      {State}");
        }


        public void UpdateSalary(double amountInProcent)
        {
            if (State != EmployeeState.Discontinued) //Status von MItarbeiter Prüfen
            {                            
            decimal alterGehalt = Salary;
            Salary += Salary * (decimal)(amountInProcent / 100);
            Console.WriteLine($"Gehalt von '{Name}' wurd von '{alterGehalt}' auf '{Salary}' erhöht (+{amountInProcent}%)");
            }
            else
            {
                Console.WriteLine($"Der Mitarbeiter '{Name}' kann keine gehaltserhögung bekommen! Grung: {State}");
            }
        }

    }
}