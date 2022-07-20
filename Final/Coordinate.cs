using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    [Serializable]
    public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(string _postalCode)
        {
            //We Need Post Company API Here
            //We get Exact Coordinate from their DataBase and set X & Y
            //But Now we dont have access so we only set two random numbers
            //long Seed = Convert.ToInt64(_postalCode);

            Random random = new Random();

            X = random.Next(90);
            if ((X % 2) == 0)
                X *= -1;

            Y = random.Next(180);
            if ((Y % 2) == 0)
                Y *= -1;
        }

        public static double Distance(Coordinate _firstCoordinate, Coordinate _secondCoordinate)
        {
            double XDistance = _firstCoordinate.X - _secondCoordinate.X;
            double YDistance = _firstCoordinate.Y - _secondCoordinate.Y;
            double Distance = Math.Sqrt(XDistance + YDistance);
            return Distance;
        }

        public static long Distance(string _firstPostalCode, string _secondPostalCode)
        {
            long FirstPostalCode = Convert.ToInt64(_firstPostalCode);
            long SecondPostalCode = Convert.ToInt64(_secondPostalCode);
            long Distance = FirstPostalCode - SecondPostalCode;
            if (Distance < 0)
            {
                Distance *= -1;
            }

            return Distance;
        }

        public static string CoordinateToString(Coordinate _coordinate)
        {
            return _coordinate.X.ToString() + "," + _coordinate.Y.ToString();
        }
    }
}
