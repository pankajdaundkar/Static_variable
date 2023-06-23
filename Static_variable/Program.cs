using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_variable
{                                                   
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Emlpoyee emp1 = new Emlpoyee("Pankaj", 50000);
        //    emp1.CalculateSalary();
        //    Console.WriteLine(emp1.PrintSalary());

        //    Emlpoyee emp2 = new Emlpoyee("Pratik", 100000);
        //    emp2.CalculateSalary();
        //    Console.WriteLine(emp2.PrintSalary());

        //    Console.WriteLine(Emlpoyee.Getcount());

           Sales_maneger sales_Maneger = new Sales_maneger(3500,1,"pankaj");
            sales_Maneger.CalculateSalary();
            Console.WriteLine(sales_Maneger);

            Emlpoyee emlpoyee = new Emlpoyee("pratik", 50000);
            emlpoyee.CalculateSalary();
            Console.WriteLine(emlpoyee);

            CEO ceo = new CEO(5000, 30000, "Sagar");//object create and parameter add
            ceo.CalculateSalary();//call to void method.object
            Console.WriteLine(ceo);//print object
        }
    }
}
