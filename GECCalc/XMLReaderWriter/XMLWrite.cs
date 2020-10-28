using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using CalculationModul;

namespace XMLReaderWriter
{
    class XMLWrite
    {
        string PathToFile;
        public XMLWrite(string pathToFile, SystemData systemData, ColumnMaterial columnMaterial, GeoTextile geoTextile, List<SoilMaterial> soilLayer)
        {
            int i = 0;
            PathToFile = pathToFile;
            XmlTextWriter xw = new XmlTextWriter(pathToFile, new UnicodeEncoding());

            xw.WriteStartDocument();

            xw.WriteStartElement("projectFile");
            
            xw.WriteStartElement("SystemData");
            xw.WriteAttributeString("projectName", Convert.ToString(systemData.Project));
            xw.WriteAttributeString("columnGrid", Convert.ToString(systemData.ColumGrid));
            xw.WriteAttributeString("method", Convert.ToString(systemData.Method));
            xw.WriteAttributeString("areaRatio", Convert.ToString(systemData.AreaRatio));
            xw.WriteAttributeString("columnRadius", Convert.ToString(systemData.ColumnRadius));
            xw.WriteAttributeString("widening", Convert.ToString(systemData.Rgeo));
            xw.WriteAttributeString("elongationStiffness", Convert.ToString(systemData.J));
            xw.WriteAttributeString("load", Convert.ToString(systemData.TotalLoad));
            xw.WriteAttributeString("athmosphericPressure", Convert.ToString(systemData.Pref));
            xw.WriteAttributeString("ohde", Convert.ToString(systemData.M));
            xw.WriteAttributeString("poisson", Convert.ToString(systemData.Poisson));
            xw.WriteAttributeString("columnDistance", Convert.ToString(systemData.S));
            xw.WriteEndElement();

            xw.WriteStartElement("ColumnMaterial");
            xw.WriteAttributeString("effectivShearStrength", Convert.ToString(columnMaterial.Phis));
            xw.WriteAttributeString("specificWeight", Convert.ToString(columnMaterial.Gammas));
            xw.WriteEndElement();

            xw.WriteStartElement("Geotextile");
            xw.WriteAttributeString("shortStrength", Convert.ToString(geoTextile.Rbk0));
            xw.WriteAttributeString("a1", Convert.ToString(geoTextile.A1));
            xw.WriteAttributeString("a2", Convert.ToString(geoTextile.A2));
            xw.WriteAttributeString("a3", Convert.ToString(geoTextile.A3));
            xw.WriteAttributeString("a4", Convert.ToString(geoTextile.A4));
            xw.WriteAttributeString("a5", Convert.ToString(geoTextile.A5));
            xw.WriteAttributeString("safetyFactor", Convert.ToString(geoTextile.GammaM));
            xw.WriteEndElement();

            foreach(SoilMaterial layer in soilLayer)
            {
                xw.WriteStartElement("soilLayer_" + i);
                xw.WriteAttributeString("layerThickness", Convert.ToString(layer.LayerThickness));
                xw.WriteAttributeString("referenceModul", Convert.ToString(layer.ReferenceEModul));
                xw.WriteAttributeString("effectiveCohesion", Convert.ToString(layer.EffectiveCohesion));
                xw.WriteAttributeString("effectiveShearStrength", Convert.ToString(layer.EffectiveShearStrengthLayer));
                xw.WriteAttributeString("specificWeight", Convert.ToString(layer.SpecificWeightLayer));
                xw.WriteEndElement();
                i++;
            }

            xw.WriteStartElement("Time_stamp");
            xw.WriteAttributeString("Saved_file_on", Convert.ToString(DateTime.Now));
            xw.WriteEndElement();

            xw.WriteEndElement();

            

            xw.Close();


        }
    }
}
