
namespace OOP_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // FirstPart();

            Vehicle v= new Vehicle("Volvo");
            Car c = new Car("Saab", "97");
            Saab s= new Saab();

            Console.WriteLine(v.Drive(50));
            Console.WriteLine(c.Drive(55));
            Console.WriteLine(s.Drive(50));
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
