using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanzierung
            //Employee ma = new Employee(); //Runge klammern '()' Methode (Konstrucktor)
            //'ma' ist eine Instanz/Objekt

            Employee ma2 = new Employee("Anton", new DateTime(1985, 5, 20), 1.800m);

            //ma.Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(10000));
            //ma.Name = "Max Mustermann";
            //ma.Id = Guid.NewGuid();
            //ma.Salary = 1.800m;
            //ma.State = EmployeeState.Discontinued;

            ma2.DisplayInfos();
            ma2.UpdateSalary(30);

        }
    }
}
