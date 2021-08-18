using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Entities;

namespace Lambdapath
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employer> employers = new List<Employer>();

            Console.WriteLine("Enter salary: ");
            int allsalary = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employers.Add(new Employer(name, email, salary));
                }
            }
            var names = employers.Where(n => n.salary > allsalary).OrderBy(n => n.email).Select(n => n.email);
            foreach (string email in names)
            {
                Console.WriteLine(email);
            }

            var sum = employers.Where(mp => mp.name[0] == 'M').Sum(mp => mp.salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+sum,"F2",CultureInfo.InvariantCulture);

            

        }
    }
}
