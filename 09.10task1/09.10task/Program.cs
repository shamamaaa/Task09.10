using _09._10task.Models;

namespace _09._10task;
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Shamama", "Guliyeva", "AB104", 31);
        student1.GetInfo();
        student1.CheckGraduation();
        student1.GetDiplomDegree();
    }
}


