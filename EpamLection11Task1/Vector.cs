using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task1
{
    public class Vector
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Output()
        {
            Console.WriteLine($"Vector {this.x} {this.y} {this.z}");
        }


        public double Length()
        {
            return Math.Sqrt((int)(x * x) + (int)(y * y) + (int)(z * z));
        }

        public static Vector Multi(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.y * vector2.z - vector1.z * vector2.y, vector1.z * vector2.x - vector1.x * vector2.z, vector1.x * vector2.y - vector1.y * vector2.x);
        }


        public static int MixMulti(Vector vector1, Vector vector2, Vector vector3)
        {
            return (vector1.x * vector2.y * vector3.z) + (vector1.y * vector2.z * vector3.x) + (vector1.z * vector2.x * vector3.y) - (vector1.z * vector2.y * vector3.x) - (vector1.y * vector2.x * vector3.z) - (vector1.x * vector2.z * vector3.y);
        }



        public static int ScalarMulti(Vector vector1, Vector vector2)
        {
            return vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
        }


        public static double Angle(Vector vector1, Vector vector2)
        {
            return ScalarMulti(vector1, vector2) / (vector1.Length() * vector2.Length());
        }

        public static Vector operator +(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
        }


        public static Vector operator -(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.x - vector2.x, vector1.y - vector2.y, vector1.z - vector2.z);
        }


        public bool Equals(Vector vector1)
        {
            if (this.x == vector1.x && this.y == vector1.y && this.z == vector1.z) return true;
            else return false;
        }

        public void IfEquals(Vector vector1)
        {
            if (Equals(vector1)) Console.WriteLine("Vectors are equal");
            else Console.WriteLine("Vectors aren't equal");
        }

        public static void ShowAddition(Vector vector1, Vector vector2)
        {
            Console.Write("Addition of vectors is ");
            (vector1 + vector2).Output();
        }

        public static void ShowSubstraction(Vector vector1, Vector vector2)
        {
            Console.Write("Substraction of vectors is ");
            (vector1 - vector2).Output();
        }

        public void ShowLength()
        {
            Console.WriteLine("Vector length is {0}", Length());
        }

        public static void ShowMulti(Vector vector1, Vector vector2)
        {
            Console.Write("Result of vector product is ");
            (Multi(vector1, vector2)).Output();
        }

        public static void ShowMixMulti(Vector vector1, Vector vector2, Vector vector3)
        {
            Console.WriteLine("Mixed product of vectors is {0}", MixMulti(vector1, vector2, vector3));
        }

        public static void ShowScalarMulti(Vector vector1, Vector vector2)
        {
            Console.WriteLine("Scalar product of vectors is {0}", ScalarMulti(vector1, vector2));
        }

        public static void ShowAngle(Vector vector1,Vector vector2)
        {
            Console.WriteLine("Angle of vectors is {0}", Angle(vector1, vector2));
        }
    }
}
