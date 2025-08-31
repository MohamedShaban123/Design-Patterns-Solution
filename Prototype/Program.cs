namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Shallow Copy
            //Console.WriteLine("create first object");
            //Person person1 = new Person() { Name = "Mohamed Shaban", address= new Address { Country="Egypt",City="Menofia"} };
            //Console.WriteLine("person 1 before shallow copy");
            //Console.WriteLine(person1);
            //Person person2 = person1.ShallowCopy();
            //Console.WriteLine("person 2 after shallow copy without any modification");
            //Console.WriteLine(person2);
            //person2.Name = "Aya Shaban";
            //person2.address.Country = "Jordon";
            //person2.address.City = "Elmousal";
            //Console.WriteLine("person2 After Shallow Copy");
            //Console.WriteLine(person2);
            //Console.WriteLine("person1 After Shallow Copy");
            //Console.WriteLine(person1);

            #endregion

            #region Deep Copy
            //Console.WriteLine("create first object");
            //Person person1 = new Person() { Name = "Mohamed Shaban", address = new Address { Country = "Egypt", City = "Menofia" } };
            //Console.WriteLine("person 1 before Deep copy");
            //Console.WriteLine(person1);
            //Person person2 = person1.DeepCopy();
            //Console.WriteLine("person 2 after Deep copy without any modification");
            //Console.WriteLine(person2);
            //person2.Name = "Aya Shaban";
            //person2.address.Country = "Jordon";
            //person2.address.City = "Elmousal";
            //Console.WriteLine("person2 After Deep Copy");
            //Console.WriteLine(person2);
            //Console.WriteLine("person1 After Deep Copy");
            //Console.WriteLine(person1);
            #endregion
        }
    }
}
