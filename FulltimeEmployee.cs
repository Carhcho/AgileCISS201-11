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
    class FulltimeEmployee : Employee
    {
        //field
        private double salary;
        //properties
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        //constructor
        public FulltimeEmployee(string employeeId, string employeeName, double salary)
            : base(employeeId, employeeName)
        {
            this.salary = salary;
        }
        //method
        public override double GetWeeklyPaid()
        {
            double amount;
            amount = Salary / 52;
            return amount;
        }
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format(" Weekly paid: {0:C}", GetWeeklyPaid());
            return str;
        }
    }
}
