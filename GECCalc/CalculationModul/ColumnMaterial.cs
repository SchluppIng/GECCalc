using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModul
{
    class ColumnMaterial
    {
        double phis;        //Effective shear strength in Degree
        double gammas;      //Specific weight in kN/m³

        //Constructor for column material
        public ColumnMaterial()
        {

        }
        public ColumnMaterial(double EffectivShearStrength, double SpecificWeight)
        {
            Phis = EffectivShearStrength;
            Gammas = SpecificWeight;
        }

        public double Phis { get => phis; set => phis = value; }
        public double Gammas { get => gammas; set => gammas = value; }
    }
}
