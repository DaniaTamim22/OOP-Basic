
namespace OOP_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstPart();

        }

        private static void FirstPart()
        {
            Person p = new Person();
            p.Name = "Dania";

            Employee e = new Employee();
            e.Name = "Kalle";
            e.salary = 20000;

            Admin a = new Admin();
            a.Name = "Nisse";
            a.salary = 30000;
            a.department = "IT";

            Employee admin = new Admin();
            Person admin2 = new Admin();
            Admin admin3 = new Admin();


            Do(admin);
            Do(admin2);
            Do(admin3);
        }

        private static void Do(Person person)
        {
            Console.WriteLine(person);
        }
    }
}
