using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorFR.Clases
{
    class ClsOperaciones
    {
        public double Suma(double N1, double N2)
        {
            double Su;
            Su = N1 + N2;
            return Su;
        }

        public double Resta(double N1, double N2)
        {
            double Re;
            Re = N1 - N2;
            return Re;
        }
        public double Multiplicacion(double N1, double N2)
        {
            double Mu;
            Mu = N1 * N2;
            return Mu;
        }
        public double Division(double N1, double N2)
        {
            double Di;
            Di = N1 / N2;
            return Di;
        }
    }
}
