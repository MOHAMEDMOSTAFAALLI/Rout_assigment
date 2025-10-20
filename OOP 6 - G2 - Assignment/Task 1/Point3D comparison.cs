using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Task 1: Point3D Comparison ===");

            int x1 = ReadInt("Enter X for first point: ");
            int y1 = ReadInt("Enter Y for first point: ");
            int z1 = ReadInt("Enter Z for first point: ");

            int x2 = ReadInt("Enter X for second point: ");
            int y2 = ReadInt("Enter Y for second point: ");
            int z2 = ReadInt("Enter Z for second point: ");

            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            if (p1 == p2)
                Console.WriteLine("Points are equal!");
            else
                Console.WriteLine("Points are not equal!");
        }

        static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
    }

    class Point3D : IEquatable<Point3D>
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Point3D(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public bool Equals(Point3D? other)
        {
            if (other is null) return false;
            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override bool Equals(object? obj) => Equals(obj as Point3D);

        public override int GetHashCode() => HashCode.Combine(X, Y, Z);

        public static bool operator ==(Point3D? a, Point3D? b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(Point3D? a, Point3D? b) => !(a == b);
    }
}
