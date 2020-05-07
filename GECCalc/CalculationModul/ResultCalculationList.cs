using System;
using System.Collections.Generic;


namespace CalculationModul
{
    class ResultCalculationList
    {
        public List<ResultCalculation> ResultList;
        public double totSettlement;// { get => totSettlement; set => totSettlement = value; }
        public string resultValues;
        public double rbd;

        public ResultCalculationList()
        {
            ResultList = new List<ResultCalculation>();
            totSettlement = 0;
            rbd = 0;
        }

        public override string ToString()
        {
            int i = 1;
            foreach (ResultCalculation res in ResultList)
            {

                resultValues = "Soft layer " + i + "\nCoefficents for calculation\nK0,B " + Math.Round(res.K0b1, 3) + "\n" +
                    "K0,B*: " + Math.Round(res.K0bstar, 3) + "\n" +
                    "Ka,S: " + Math.Round(res.Kas, 3) + "\n" +
                    "Stress over soft layer σü,B: " + Math.Round(res.Sigmaueb, 3) + " kN/m²" + "\n" +
                    "Stress on column σü,S: " + Math.Round(res.Sigmaues, 3) + " kN/m²" + "\n" +
                    "Vertical stress from soil σv,B: " + Math.Round(res.Sigmavb, 3) + " kN/m²" + "\n" +
                    "p1: " + Math.Round(res.P1, 3) + " kN/m²" + "\n" +
                    "p2: " + Math.Round(res.P2, 3) + " kN/m²" + "\n" +
                    "p*: " + Math.Round(res.Pstar, 3) + " kN/m²" + "\n" + "\n" +
                    "Deformations/Settlements" + "\n" +
                    "ΔrS: " + Math.Round(res.Deltars, 3) + " m" + "\n" +
                    "Settlement of column ss: " + res.Ss + " cm" + "\n" +
                    "Settlement of soil sb: " + res.Sb + " cm" + "\n" +
                    "Load redistribution factor E: " + Math.Round(res.Swapping, 3) + "\n" + "\n" +
                    "Ringforce Fr: " + Math.Round(res.Ringforce, 2) + " kN/m" + "\n\n";

                    i++;
            }
            return resultValues;
        }
    }
}
