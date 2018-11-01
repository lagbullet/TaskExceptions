using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
            {
                {new Worker("Surnameone", "Firstnameone", "Patronymicone", "14.08.1992", 123.234 )},
                {new Worker("Surnametwo", "Firstnametwo", "Patronymictwo", "14.08.1993", 456.232 )},
                {new Worker("Surnamethree", "Firstnamethree", "Patronymicthree", "14.08.1994", 789.1452 )},
                {new Worker("Surnamefour", "Firstnamefour", "Patronymicfour", "14.08.1995", 582.2837 )}
            };
            Console.ReadKey();
            Worker worker = new Worker();
            worker.SetWorker();
            workers.Add(worker);
            foreach (var item in workers)
                item.GetInfo();
            Console.ReadKey();
        }
    }
}
