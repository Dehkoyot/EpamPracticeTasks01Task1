using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLection11Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(1, 1, 1);
            Vector vector2 = new Vector(2, 2, 2);

            //Show Vectors
            vector1.Output();
            vector2.Output();
            
            //Substraction of Vectors
            Vector.ShowSubstraction(vector1,vector2);

            //Addition of Vectors
            Vector.ShowAddition(vector1, vector2);
            
            //If vectors are Equal
            vector1.IfEquals(vector2);

            //Length of vector
            vector1.ShowLength();

            //Vector pruduct of Vectors
            Vector.ShowMulti(vector1, vector2);

            //Scalar product of Vectors
            Vector.ShowScalarMulti(vector1, vector2);

            //Mix product of Vectors
            Vector vector3 = new Vector(3, 3, 3);
            Vector.ShowMixMulti(vector1, vector2, vector3);

            //Angle of Vectors
            Vector.ShowAngle(vector1,vector2);
         

            Console.ReadKey();
        }
    }
}
