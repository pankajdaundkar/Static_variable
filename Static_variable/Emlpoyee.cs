using Static_variable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Static_variable
{
    public class Emlpoyee
    {
        protected string name;
        protected int id;
        protected double bs, hra, ta, da, pf, gs, total;
        private static int count;
        public Emlpoyee(string name, int bs)
        {
            count++;
            this.name = name;
            this.bs = bs;
            this.id = count;
        }
        public static int Getcount()
        {
            return count;
        }
        public virtual void CalculateSalary()

        {
            hra = bs * 0.40;

            ta = bs * 0.20;

            da = bs * 0.15;

            pf = bs * 0.12;

            total = (bs + hra + ta + da);

            gs = (total) - pf;

        }
        public override string ToString()
        {
            return $"Name is {name},\nId is {count},\nTotal salary is {total},\nGross salary is {gs}";
        }
    }
    public class Sales_maneger : Emlpoyee
    {
        private double cumm;
        public Sales_maneger(double cumm, int bs, string name) : base(name, bs)
        {
            this.cumm = cumm;
        }
        public override void CalculateSalary()

        { hra = bs * 0.40;

            ta = bs * 0.20;

            da = bs * 0.15;

            pf = bs * 0.12;

            total = (bs + hra + ta + da + cumm);

            gs = (total) - pf;
        }

      public override string ToString()
        {
            return$"name is {name} \n id is {id}\ntotal salary is {total}\n gross salary is {gs}";
        }
    }
}    public class CEO : Emlpoyee
{
    double bonus;
    public CEO(double bonus, int bs, string name):base(name, bs)
    {
        this.bonus = bonus;
    }
    public override void CalculateSalary()
    {

        hra = bs * 0.40;

        ta = bs * 0.20;

        da = bs * 0.15;

        pf = bs * 0.12;

        total = (bs + hra + ta + da + bonus);

        gs = (total) - pf;
    }
    public override string ToString()
    {
        return $"name is {name},\n id is {id},\ntotal salary is {total},\ngross salary is {gs}";
    }
}