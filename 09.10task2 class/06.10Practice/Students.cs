using System;
namespace _06._10Practice
{
	public class Students
	{
		public string Name;
		public byte Point1;
        public byte Point2;
        public byte Point3;
		public byte Score;


        public Students(string name, byte point1, byte point2, byte point3)
		{
			Name = name;
			Point1 = point1;
			Point2 = point2;
			Point3 = point3;
			Score = 0;

        }
    }

}

