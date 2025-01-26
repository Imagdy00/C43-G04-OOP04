namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project - 3D Point Class

            //            using System;

            //class Point3D : IComparable<Point3D>, ICloneable
            //        {
            //            public int X { get; set; }
            //            public int Y { get; set; }
            //            public int Z { get; set; }


            //            public Point3D(int x, int y, int z)
            //            {
            //                X = x;
            //                Y = y;
            //                Z = z;
            //            }


            //            public Point3D(int x, int y) : this(x, y, 0) { }
            //            public Point3D(int x) : this(x, 0, 0) { }
            //            public Point3D() : this(0, 0, 0) { }


            //            public override string ToString()
            //            {
            //                return $"Point Coordinates: ({X}, {Y}, {Z})";
            //            }


            //            public int CompareTo(Point3D other)
            //            {
            //                if (X != other.X) return X.CompareTo(other.X);
            //                if (Y != other.Y) return Y.CompareTo(other.Y);
            //                return Z.CompareTo(other.Z);
            //            }


            //            public object Clone()
            //            {
            //                return new Point3D(X, Y, Z);
            //            }


            //            public override bool Equals(object obj)
            //            {
            //                if (obj is Point3D other)
            //                {
            //                    return X == other.X && Y == other.Y && Z == other.Z;
            //                }
            //                return false;
            //            }


            //            public override int GetHashCode()
            //            {
            //                return HashCode.Combine(X, Y, Z);
            //            }


            //            public static bool operator ==(Point3D p1, Point3D p2)
            //            {
            //                return p1.Equals(p2);
            //            }


            //            public static bool operator !=(Point3D p1, Point3D p2)
            //            {
            //                return !p1.Equals(p2);
            //            }
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {

            //                Console.WriteLine("Enter coordinates for P1 (X Y Z):");
            //                int x1 = int.Parse(Console.ReadLine());
            //                int y1 = int.Parse(Console.ReadLine());
            //                int z1 = int.Parse(Console.ReadLine());
            //                Point3D P1 = new Point3D(x1, y1, z1);


            //                Console.WriteLine("Enter coordinates for P2 (X Y Z):");
            //                int x2 = int.Parse(Console.ReadLine());
            //                int y2 = int.Parse(Console.ReadLine());
            //                int z2 = int.Parse(Console.ReadLine());
            //                Point3D P2 = new Point3D(x2, y2, z2);


            //                if (P1 == P2)
            //                {
            //                    Console.WriteLine("P1 and P2 are equal.");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("P1 and P2 are not equal.");
            //                }


            //                Point3D[] points = { P1, P2, new Point3D(5, 5, 5) };
            //                Array.Sort(points);

            //                Console.WriteLine("Sorted Points:");
            //                foreach (var p in points)
            //                {
            //                    Console.WriteLine(p);
            //                }


            //                Point3D P3 = (Point3D)P1.Clone();
            //                Console.WriteLine("Cloned Point: " + P3);
            //            }
            //        }

            #endregion


            #region Second Project - Maths Class

            //            using System;

            //class Maths
            //        {

            //            public static int Add(int a, int b) => a + b;
            //            public static int Subtract(int a, int b) => a - b;
            //            public static int Multiply(int a, int b) => a * b;
            //            public static double Divide(int a, int b) => (double)a / b;
            //        }

            //        class Program
            //        {
            //            static void Main()
            //            {
            //                Console.WriteLine("Add: " + Maths.Add(10, 5));
            //                Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
            //                Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
            //                Console.WriteLine("Divide: " + Maths.Divide(10, 5));
            //            }
            //        }

            #endregion



            #region Third Project - Duration Class

//            using System;

//class Duration
//        {
//            public int Hours { get; set; }
//            public int Minutes { get; set; }
//            public int Seconds { get; set; }

            
//            public Duration(int hours, int minutes, int seconds)
//            {
//                Hours = hours;
//                Minutes = minutes;
//                Seconds = seconds;
//                Normalize();
//            }

        
//            public Duration(int totalSeconds)
//            {
//                Hours = totalSeconds / 3600;
//                Minutes = (totalSeconds % 3600) / 60;
//                Seconds = totalSeconds % 60;
//            }

            
//            private void Normalize()
//            {
//                Minutes += Seconds / 60;
//                Seconds %= 60;
//                Hours += Minutes / 60;
//                Minutes %= 60;
//            }

            
//            public override string ToString()
//            {
//                if (Hours > 0)
//                    return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
//                else if (Minutes > 0)
//                    return $"Minutes: {Minutes}, Seconds: {Seconds}";
//                else
//                    return $"Seconds: {Seconds}";
//            }

            
//            public override bool Equals(object obj)
//            {
//                if (obj is Duration other)
//                {
//                    return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
//                }
//                return false;
//            }

           
//            public override int GetHashCode()
//            {
//                return HashCode.Combine(Hours, Minutes, Seconds);
//            }

            
//            public static Duration operator +(Duration d1, Duration d2)
//            {
//                return new Duration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
//            }

//            public static Duration operator +(Duration d, int seconds)
//            {
//                return new Duration(d.Hours, d.Minutes, d.Seconds + seconds);
//            }

//            public static Duration operator +(int seconds, Duration d)
//            {
//                return d + seconds;
//            }

//            public static Duration operator ++(Duration d)
//            {
//                return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
//            }

//            public static Duration operator --(Duration d)
//            {
//                return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
//            }

//            public static Duration operator -(Duration d1, Duration d2)
//            {
//                return new Duration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
//            }

//            public static bool operator >(Duration d1, Duration d2)
//            {
//                return d1.Hours > d2.Hours || (d1.Hours == d2.Hours && d1.Minutes > d2.Minutes) || (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds > d2.Seconds);
//            }

//            public static bool operator <(Duration d1, Duration d2)
//            {
//                return d1.Hours < d2.Hours || (d1.Hours == d2.Hours && d1.Minutes < d2.Minutes) || (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes && d1.Seconds < d2.Seconds);
//            }

//            public static bool operator <=(Duration d1, Duration d2)
//            {
//                return d1 < d2 || d1 == d2;
//            }

//            public static bool operator >=(Duration d1, Duration d2)
//            {
//                return d1 > d2 || d1 == d2;
//            }

//            public static implicit operator DateTime(Duration d)
//            {
//                return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
//            }
//        }

//        class Program
//        {
//            static void Main()
//            {
//                Duration D1 = new Duration(1, 10, 15);
//                Console.WriteLine(D1);

//                Duration D2 = new Duration(3600);
//                Console.WriteLine(D2);

//                Duration D3 = new Duration(7800);
//                Console.WriteLine(D3);

//                Duration D4 = new Duration(666);
//                Console.WriteLine(D4);

//                D3 = D1 + D2;
//                Console.WriteLine(D3);

//                D3 = D1 + 7800;
//                Console.WriteLine(D3);

//                D3 = 666 + D3;
//                Console.WriteLine(D3);

//                D3 = ++D1;
//                Console.WriteLine(D3);

//                D3 = --D2;
//                Console.WriteLine(D3);

//                D1 = D1 - D2;
//                Console.WriteLine(D1);

//                if (D1 > D2)
//                    Console.WriteLine("D1 is greater than D2");

//                if (D1 <= D2)
//                    Console.WriteLine("D1 is less than or equal to D2");

//                DateTime dateTime = (DateTime)D1;
//                Console.WriteLine("DateTime: " + dateTime);
//            }
//        }

        #endregion
    }
}
}
