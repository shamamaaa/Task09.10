namespace _09._10task;
internal class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("samama", "sabir",19);

        person1.GetInfo();
    }
}

class Person
{
    public string Name;
    public string Surname;
    public byte Age;

    public void GetInfo()
    {

        Console.WriteLine($"{Name} {Surname} {Age}");
    }

    public Person(string sname, string surname, byte age)
    {
        Name = sname;
        Surname = surname;
        Age = age;
    }
}
