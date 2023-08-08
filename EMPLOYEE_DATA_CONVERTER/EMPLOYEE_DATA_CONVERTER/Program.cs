using System;
namespace Power
{
    struct employee
    {
        public int Employee_ID;
        public string Employee_Name;
        public int Basic_Salary;
        public int Transport_Allowance;
        public int Gross_Salary;
        public int Tax;
        public int Net_Salary;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            employee[] Emp = new employee[20];
            Console.WriteLine("Enter the number of Employees data to be collected: ");
            int emp = int.Parse(Console.ReadLine());

            for (int i = 0; i < emp; i++)
            {
                Console.WriteLine("Enter Employee_ID: ");
                Emp[i].Employee_ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name: ");
                Emp[i].Employee_Name = Console.ReadLine();
                Console.WriteLine("Enter Basic_Salary: ");
                Emp[i].Basic_Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter transport allowance: ");
                Emp[i].Transport_Allowance = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < emp; i++)
            {
                Emp[i].Gross_Salary = Emp[i].Basic_Salary + Emp[i].Transport_Allowance;
                Emp[i].Tax = (30 / 100) * Emp[i].Gross_Salary;
                Emp[i].Net_Salary = Emp[i].Gross_Salary - Emp[i].Tax;
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", Emp[i].Employee_ID, Emp[i].Employee_Name, Emp[i].Basic_Salary, Emp[i].Transport_Allowance, Emp[i].Gross_Salary, Emp[i].Tax, Emp[i].Net_Salary = Emp[i].Gross_Salary - Emp[i].Tax);
            }
        }
    }
}