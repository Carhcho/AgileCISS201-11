using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//10/11/2020
namespace dropbox10
{
    abstract class Employee
    {
        //fields
        private string employeeId;
        private string employeeName;
        //properties
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        //constructor
        public Employee(string employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
        }
        public abstract double GetWeeklyPaid();
        public override string ToString()
        {
            string str;
            str = string.Format("Name: {0} ID: {1}", EmployeeName, EmployeeId);
            return str;
        }
    }
}
