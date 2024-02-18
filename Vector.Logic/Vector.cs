using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Logic
{
    public class Vector
    {
        //Propiedades
        public double[] nVec { get; set; }

        //Constructor
        public Vector(double[] nVect)
        {
            nVec = nVect;
        }

        //Metodo Suma
        public Vector Suma(Vector v)
        {
            double[] res = new double[nVec.Length];
            for(int i = 0; i<nVec.Length; i++)
            {
                res[i] = nVec[i] + v.nVec[i];
            }
            return new Vector (res);
        }

        public Vector Resta(Vector v)
        {
            double[] res = new double[nVec.Length];
            for (int i = 0; i < nVec.Length; i++)
            {
                res[i] = nVec[i] - v.nVec[i];
            }
            return new Vector(res);
        }

        public Vector Mult(Vector v)
        {
            double[] res = new double[nVec.Length];
            for (int i = 0; i < nVec.Length; i++)
            {
                res[i] = nVec[i] * v.nVec[i];
            }
            return new Vector(res);
        }
    }
}
