
namespace CalculationModul
{
    class GeoTextile
    {
        double rbk0;        //Short-term strength
        double a1;          //Reduction of creep strain
        double a2;          //Reduction for damage at column
        double a3;          //Reduction for production
        double a4;          //Reduction for enviroment influence
        double a5;          //Reduction for dynamic influence
        double gammaM;      //Safety factor for material

        public GeoTextile()
        {

        }
        public GeoTextile(double ShortTermStrength, double ReductionCreepStrain, double ColumnDamage, double ReductionProduction,
            double EnviromentInfluence, double DynamicInfluence, double MaterialSafetyFactor)
        {
            Rbk0 = ShortTermStrength;
            A1 = ReductionCreepStrain;
            A2 = ColumnDamage;
            A3 = ReductionProduction;
            A4 = EnviromentInfluence;
            A5 = DynamicInfluence;
            GammaM = MaterialSafetyFactor;
        }

        public double Rbk0 { get => rbk0; set => rbk0 = value; }
        public double A1 { get => a1; set => a1 = value; }
        public double A2 { get => a2; set => a2 = value; }
        public double A3 { get => a3; set => a3 = value; }
        public double A4 { get => a4; set => a4 = value; }
        public double A5 { get => a5; set => a5 = value; }
        public double GammaM { get => gammaM; set => gammaM = value; }
    }
}
