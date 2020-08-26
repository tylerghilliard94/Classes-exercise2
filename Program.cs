using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company NSS = new Company("NSS", DateTime.Now);

            Employee Brenda = new Employee()
            {
                firstName = "Brenda",
                lastName = "Long",
                Title = "Instructor",
                startDate = DateTime.Now

            };
            Employee Rose = new Employee()
            {
                firstName = "Rose",
                lastName = "Wisotzky",
                Title = "Teacher's Aid",
                startDate = DateTime.Now

            };
            Employee Sage = new Employee()
            {
                firstName = "Sage",
                lastName = "Klein",
                Title = "Teacher's Aid",
                startDate = DateTime.Now
            };

            NSS.Add(Brenda);
            NSS.Add(Rose);
            NSS.Add(Sage);

            NSS.writeEmployees();
        }
    }
}
