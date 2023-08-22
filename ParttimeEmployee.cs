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
    class ParttimeEmployee : Employee
    {
        //fields
        private double hourlyWage;
        private double hoursWorked;
        //properties
        public double HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value; }
        }
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        //costructor
        public ParttimeEmployee(string employeeId, string employeeName, double hourlyWage, double hoursWorked)
            : base(employeeId, employeeName)
        {
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }
        //methods
        public override double GetWeeklyPaid()
        {
            double amount;
            amount = HourlyWage * HoursWorked;
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
