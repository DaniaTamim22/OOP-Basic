namespace OOP_Basic
{
    internal class Program
    {
        static void Main(string[] args)
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

        }
    }
}
