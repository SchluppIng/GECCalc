using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModul
{
    class ResultCalculation
    {
        SystemData Data;
        ColumnMaterial Material;
        GeoTextile Textile;
        SoilMaterial SoilLayer;
        double dgeo;
        double k0b1;
        double k0bstar;
        double kas;
        double swapping;
        double sigmaueb;
        double sigmaues;
        double sigmavb;
        double p1;
        double p2;
        double pstar;
        double Esb;
        double Estar;
        double deltars;
        double ss;
        double sb;
        double ringforce;
        double rbd;




        public ResultCalculation(SystemData sysData, ColumnMaterial colMaterial, GeoTextile geoTextile, SoilMaterial soilLayer)
        {
            Data = sysData;
            Material = colMaterial;
            Textile = geoTextile;
            SoilLayer = soilLayer;
            dgeo = 0;
            k0b1 = 0;
            k0bstar = 0;
            kas = 0;
            swapping = 0;
            sigmaueb = 0;
            sigmaues = 0;
            sigmavb = 0;
            p1 = 0;
            p2 = 0;
            pstar = 0;
            Esb = 0;
            Estar = 0;
            deltars = 0;
            Ss = 0;
            sb = 0;
            ringforce = 0;
            rbd = 0;
            

            calcResults();

        }

        public double Ss { get => ss; private set => ss = value; }
        public double Dgeo { get => dgeo; private set => dgeo = value; }
        public double K0b1 { get => k0b1; private set => k0b1 = value; }
        public double K0bstar { get => k0bstar; private set => k0bstar = value; }
        public double Kas { get => kas; private set => kas = value; }
        public double Swapping { get => swapping; private set => swapping = value; }
        public double Sigmaueb { get => sigmaueb; private set => sigmaueb = value; }
        public double Sigmaues { get => sigmaues; private set => sigmaues = value; }
        public double Sigmavb { get => sigmavb; private set => sigmavb = value; }
        public double P1 { get => p1; private set => p1 = value; }
        public double P2 { get => p2; private set => p2 = value; }
        public double Pstar { get => pstar; private set => pstar = value; }
        public double Esb1 { get => Esb; private set => Esb = value; }
        public double Estar1 { get => Estar; private set => Estar = value; }
        public double Deltars { get => deltars; private set => deltars = value; }
        public double Ss1 { get => ss; private set => ss = value; }
        public double Sb { get => sb; private set => sb = value; }
        public double Ringforce { get => ringforce; private set => ringforce = value; }
        public double Rbd { get => rbd; set => rbd = value; }

        public void calcResults()
        {

            rbd = Math.Round(Textile.Rbk0 / (Textile.A1 * Textile.A2 * Textile.A3 * Textile.A4 * Textile.A5 * Textile.GammaM), 2);

            double angleRad = Math.PI / 180;
            k0b1 = 1 - Math.Sin(SoilLayer.EffectiveShearStrengthLayer * angleRad);
            
            if(Data.Method == "Displacement")
            {
                k0bstar = 1.0;
            }
            else
            {
                k0bstar = k0b1;
            }

            kas = Math.Pow(Math.Tan((45 - Material.Phis / 2) * angleRad), 2);

            for(swapping = 0; swapping <= 1.0; swapping = swapping + 0.0001)
            {
                //swapping = swapping + 0.0001;
                sigmaueb = SoilLayer.SpecificWeightLayer * SoilLayer.LayerThickness * 0.5;
                sigmaues = Material.Gammas * SoilLayer.LayerThickness * 0.5;
                sigmavb = (Data.TotalLoad - (swapping * Data.TotalLoad)) / (1 - Data.AreaRatio);
                
                p1 = sigmaueb;
                p2 = p1 + sigmavb;
                pstar = sigmavb / Math.Log(p2 / p1);

                Esb = SoilLayer.ReferenceEModul * Math.Pow((pstar + SoilLayer.EffectiveCohesion * 1 / Math.Tan(SoilLayer.EffectiveShearStrengthLayer * angleRad)) / Data.Pref, Data.M);
                Estar = (1 / (1 - Data.Poisson) + 1 / (1 + Data.Poisson) * 1 / Data.AreaRatio) * ((1 + Data.Poisson) * (1 - 2 * Data.Poisson)) / (1 - Data.Poisson) * Esb;

                //Ob der Wert passt?
                deltars = (kas * (1 / Data.AreaRatio * Data.TotalLoad - (1 - Data.AreaRatio) / Data.AreaRatio * sigmavb + sigmaues) 
                    - k0b1 * sigmavb - k0bstar * sigmaueb + ((Data.Rgeo - Data.ColumnRadius) * Data.J) / Math.Pow(Data.Rgeo, 2)) / (Estar / ((1 / Data.AreaRatio - 1) * Data.ColumnRadius) 
                    + Data.J/ (Math.Pow(Data.Rgeo,2)));

                Ss = ((1 - Math.Pow(Data.ColumnRadius, 2) / Math.Pow((Data.ColumnRadius + deltars), 2)) * SoilLayer.LayerThickness) * 100;

                sb = (((sigmavb / Esb - 2 / Estar * Data.Poisson / (1 - Data.Poisson) * (kas * (1 / Data.AreaRatio * Data.TotalLoad - (1 - Data.AreaRatio) / Data.AreaRatio * sigmavb + sigmaues) 
                    - k0b1 * sigmavb - k0bstar * sigmaueb + (Data.Rgeo - Data.ColumnRadius) * Data.J / Math.Pow(Data.Rgeo, 2) 
                    - deltars * Data.J / Math.Pow(Data.Rgeo,  2)))) * SoilLayer.LayerThickness) * 100;
                
                Ss = Math.Round(Ss, 1);
                sb = Math.Round(sb, 1);

                ringforce = Data.J * (deltars - (Data.Rgeo - Data.ColumnRadius)) / Data.Rgeo;

                if (Ss == sb)
                    break;
            }
        }
    }
}
