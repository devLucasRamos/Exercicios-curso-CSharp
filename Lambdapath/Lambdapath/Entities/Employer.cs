namespace Entities
{
    public class Employer
    {
        public string name { get; set; }
        public string email { get; set; }
        public double salary { get; set; }

        public Employer(string name, string email, double salary)
        {
            this.name = name;
            this.email = email;
            this.salary = salary;
        }
    }
}
