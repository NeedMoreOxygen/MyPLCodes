using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    enum Vacancies { Manager = 1, Boss, Clerk, Salesman, Cleaner, Administrator }
    struct Employee
    {
        string name;
        Vacancies vacancy;
        double salary;
        static string lastManager = "No New Managers Yet!";

        public Employee(string name, Vacancies vacancy, double salary)
        {
            this.name = name;
            this.vacancy = vacancy;
            this.salary = salary;
            if(vacancy.ToString() == "Manager")
                lastManager = $"Name Of The Manager: {name}";
        }
        public void changeSalary()
        {
            if (this.salary < 1000)
                salary *= 1.3;
            else
                salary *= 1.15;
        }
        public string GetInfo()
        {
            return $"Name: {name}\nVacancy: {vacancy}\nSalary: {salary}\n";
        }
        public string GetManagerName()
        {
            return lastManager;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NEW EMPLOYEE REGISTRATED\n");
            Employee employee1 = new Employee("Egor", (Vacancies)1, 5000);
            Console.WriteLine("Employee gets a New-Year Present!");
            employee1.changeSalary();
            Console.WriteLine(employee1.GetInfo());

            Console.WriteLine("\nNEW EMPLOYEE REGISTRATED\n");
            Employee employee2 = new Employee("Richard", (Vacancies)3, 800);
            Console.WriteLine("Employee gets a New-Year Present!");
            employee1.changeSalary();
            Console.WriteLine(employee2.GetInfo());
            Console.WriteLine(employee2.GetManagerName());
            Console.ReadKey();
        }
    }
}
