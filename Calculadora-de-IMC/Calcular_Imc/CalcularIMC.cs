using System;
using System.Collections.Generic;
using System.Text;

namespace Calcular_Imc
{
    class CalcularIMC
    {
        public double Imc(double v1, double v2)
        {
            double P = v1;
            double A = v2;
            return P / (A * A);
        }
    }
}
