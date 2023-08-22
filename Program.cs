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
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployees = new List<Employee>();
            FulltimeEmployee ft1 = new FulltimeEmployee("111", "Cesar", 100000.00);
            allEmployees.Add(ft1);
            FulltimeEmployee ft2 = new FulltimeEmployee("222", "Jack", 40000.00);
            allEmployees.Add(ft2);
            ParttimeEmployee pt1 = new ParttimeEmployee("333", "Emily", 20.12, 20);
            allEmployees.Add(pt1);
            ParttimeEmployee pt2 = new ParttimeEmployee("444", "Daron", 10.5, 25);
            allEmployees.Add(pt2);
            ParttimeEmployee pt3 = new ParttimeEmployee("555", "Supa", 30, 10);
            allEmployees.Add(pt3);
            foreach (Employee emp in allEmployees)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
        }
    }
}
