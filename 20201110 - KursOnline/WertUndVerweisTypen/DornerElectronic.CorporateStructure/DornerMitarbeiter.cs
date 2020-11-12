using System;

namespace DornerElectronic.CorporateStructure
{
    public struct DornerMitarbeiter
    {
        //ZUSTAND INFORMATIONEN
        public string Name;
        public Guid Id;
        public decimal Salary;
        public DateTime Birthday;
        public EmployeeState State;
    }
}