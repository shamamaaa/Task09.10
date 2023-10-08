using System;
using System.Xml.Linq;

namespace _09._10task.Models
{
	public class Student
	{
		public string Name;
		public string Surname;
		public string Group;
		public byte Point;
		public bool IsGraduated;


		public Student(string name, string surname, string group, byte point)
		{
			if (point<0 || point>100)
			{
				Console.WriteLine("Point duzgun daxil edilmeyib, 0-100 araliqinda olmalidir.");
				return;
			}

			Name = name;
			Surname = surname;
			Group = group;
			Point = point;

			if (point>=65)
			{
				IsGraduated = true;
			}
			else
			{
				IsGraduated = false;
			}
		}

		public void GetInfo()
        {
			Console.WriteLine($"{Name} {Surname} {Group} {Point} {IsGraduated}");
		}

		public void CheckGraduation()
		{
			if (IsGraduated)
			{
				Console.WriteLine("Telebe mezun oldu.");
				return;
			}
			else
			{
				Console.WriteLine("Telebe mezun ola bilmir.");
			}
		}

		public void GetDiplomDegree()
		{
			if (Point<65)
			{
				Console.WriteLine("Diplom ala bilmir.");
			}
			else if (Point>=65 && Point<=80)
			{
				Console.WriteLine("Adi diplom.");
			}
			else if (Point >= 80 && Point <= 90)
			{
				Console.WriteLine("Seref diplomu.");
			}
			else
			{
				Console.WriteLine("Yuksek seref diplomu.");
			}
		}

    }
}

