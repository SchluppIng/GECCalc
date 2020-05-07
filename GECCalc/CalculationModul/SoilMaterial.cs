using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModul
{
    class SoilMaterial
    {
        double layerThickness;
        double referenceEModul;
        double effectiveCohesion;
        double effectiveShearStrengthLayer;
        double specificWeightLayer;
        public SoilMaterial()
        {

        }

        public SoilMaterial(double Layer_Thickness, double Reference_YoungsModul, double Effective_Cohesion, double Effective_ShearStrentghLayer, double Specific_WeightLayer)
        {
            LayerThickness = Layer_Thickness;
            ReferenceEModul = Reference_YoungsModul;
            EffectiveCohesion = Effective_Cohesion;
            EffectiveShearStrengthLayer = Effective_ShearStrentghLayer;
            SpecificWeightLayer = Specific_WeightLayer;
        }

        public double LayerThickness { get => layerThickness; set => layerThickness = value; }
        public double ReferenceEModul { get => referenceEModul; set => referenceEModul = value; }
        public double EffectiveCohesion { get => effectiveCohesion; set => effectiveCohesion = value; }
        public double EffectiveShearStrengthLayer { get => effectiveShearStrengthLayer; set => effectiveShearStrengthLayer = value; }
        public double SpecificWeightLayer { get => specificWeightLayer; set => specificWeightLayer = value; }
    }
}
