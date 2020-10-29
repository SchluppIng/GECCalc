using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CalculationModul;
using System.Xml;
using GECCalc;

namespace XMLReaderWriter
{
    class XMLRead
    {
        public SystemData sysData;// = new SystemData();
        public ColumnMaterial columnMaterial;// = new ColumnMaterial();
        public GeoTextile geo = new GeoTextile();
        public List<SoilMaterial> soilLayer;// = new List<SoilMaterial>();
        string path;
        MainForm mainfrm;
        //DataGridViewCellEventArgs eventArg;
        int i;

        public XMLRead(string pathToFile, MainForm mainForm)
        {
            //Set objects to read them into xml
            sysData = new SystemData();
            columnMaterial = new ColumnMaterial();
            geo = new GeoTextile();
            soilLayer = new List<SoilMaterial>();
            path = pathToFile;
            mainfrm = mainForm;
            readXML();
            setValuesToForm();
        }

        private void readXML()
        {
            XmlReader xr = new XmlTextReader(path);
            i = 0;

            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    if (xr.AttributeCount > 0)
                    {
                        if (xr.Name == "SystemData")
                        {
                            while (xr.MoveToNextAttribute())
                            {
                                switch (xr.Name)
                                {

                                    case "projectName":
                                        sysData.Project = xr.Value;
                                        break;
                                    case "columnGrid":
                                        sysData.ColumGrid = xr.Value;
                                        break;
                                    case "method":
                                        sysData.Method = xr.Value;
                                        break;
                                    case "areaRatio":
                                        sysData.AreaRatio = Convert.ToDouble(xr.Value);
                                        break;
                                    case "columnRadius":
                                        sysData.ColumnRadius = Convert.ToDouble(xr.Value);
                                        break;
                                    case "widening":
                                        sysData.Rgeo = Convert.ToDouble(xr.Value);
                                        break;
                                    case "elongationStiffness":
                                        sysData.J = Convert.ToDouble(xr.Value);
                                        break;
                                    case "load":
                                        sysData.TotalLoad = Convert.ToDouble(xr.Value);
                                        break;
                                    case "athmosphericPressure":
                                        sysData.Pref = Convert.ToDouble(xr.Value);
                                        break;
                                    case "ohde":
                                        sysData.M = Convert.ToDouble(xr.Value);
                                        break;
                                    case "poisson":
                                        sysData.Poisson = Convert.ToDouble(xr.Value);
                                        break;
                                    case "columnDistance":
                                        sysData.S = Convert.ToDouble(xr.Value);
                                        break;
                                }
                            }
                        }
                        if (xr.AttributeCount > 0)
                        {
                            if (xr.Name == "ColumnMaterial")
                            {
                                while (xr.MoveToNextAttribute())
                                {
                                    switch (xr.Name)
                                    {
                                        case "effectivShearStrength":
                                            columnMaterial.Phis = Convert.ToDouble(xr.Value);
                                            break;
                                        case "specificWeight":
                                            columnMaterial.Gammas = Convert.ToDouble(xr.Value);
                                            break;
                                    }
                                }
                            }
                        }
                        if (xr.AttributeCount > 0)
                        {
                            if (xr.Name == "Geotextile")
                            {
                                while (xr.MoveToNextAttribute())
                                {
                                    switch (xr.Name)
                                    {
                                        case "shortStrength":
                                            geo.Rbk0 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "a1":
                                            geo.A1 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "a2":
                                            geo.A2 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "a3":
                                            geo.A3 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "a4":
                                            geo.A4 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "a5":
                                            geo.A5 = Convert.ToDouble(xr.Value);
                                            break;
                                        case "safetyFactor":
                                            geo.GammaM = Convert.ToDouble(xr.Value);
                                            break;
                                    }
                                }
                            }
                        }

                        if (xr.AttributeCount > 0)
                        {
                            if (xr.Name == "soilLayer_" + i)
                            {
                                SoilMaterial soil = new SoilMaterial();
                                while (xr.MoveToNextAttribute())
                                {
                                    switch (xr.Name)
                                    {
                                        case "layerThickness":
                                            soil.LayerThickness = Convert.ToDouble(xr.Value);
                                            break;
                                        case "referenceModul":
                                            soil.ReferenceEModul = Convert.ToDouble(xr.Value);
                                            break;
                                        case "effectiveCohesion":
                                            soil.EffectiveCohesion = Convert.ToDouble(xr.Value);
                                            break;
                                        case "effectiveShearStrength":
                                            soil.EffectiveShearStrengthLayer = Convert.ToDouble(xr.Value);
                                            break;
                                        case "specificWeight":
                                            soil.SpecificWeightLayer = Convert.ToDouble(xr.Value);
                                            break;
                                    }

                                }
                                soilLayer.Add(soil);
                                i++;
                            }
                        }
                        if (xr.AttributeCount > 0)
                        {
                            if (xr.Name == "Time_stamp")
                            {
                                while (xr.MoveToNextAttribute())
                                {
                                    switch (xr.Name)
                                    {
                                        case "Saved_file_on":
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            xr.Close();
            
        }

        public void setValuesToForm()
        {
            foreach (TextBox t in mainfrm.Controls.OfType<TextBox>())
            {
                t.TextChanged -= mainfrm.textBox_changed;
            }

            mainfrm.txtConfigurationName.Text = sysData.Project;
            mainfrm.comboBoxColumnGrid.Text = sysData.ColumGrid;
            mainfrm.comboBoxMethod.Text = sysData.Method;
            mainfrm.txtAreaRatio.Text = Convert.ToString(sysData.AreaRatio);
            mainfrm.txtColumnRadius.Text = Convert.ToString(sysData.ColumnRadius);
            mainfrm.txtWideningActivation.Text = Convert.ToString(sysData.Rgeo);
            mainfrm.txtElongationStiffness.Text = Convert.ToString(sysData.J);
            mainfrm.txtLoad.Text = Convert.ToString(sysData.TotalLoad);
            mainfrm.txtAtmosphericPressure.Text = Convert.ToString(sysData.Pref);
            mainfrm.txtPowerOhde.Text = Convert.ToString(sysData.M);
            mainfrm.txtPoissonRatio.Text = Convert.ToString(sysData.Poisson);
            mainfrm.txtColumnDistance.Text = Convert.ToString(sysData.S);
            mainfrm.txtEffectivShearStrength.Text = Convert.ToString(columnMaterial.Phis);
            mainfrm.txtSpecificWeight.Text = Convert.ToString(columnMaterial.Gammas);
            mainfrm.txtRBk0.Text = Convert.ToString(geo.Rbk0);
            mainfrm.txtA1.Text = Convert.ToString(geo.A1);
            mainfrm.txtA2.Text = Convert.ToString(geo.A2);
            mainfrm.txtA3.Text = Convert.ToString(geo.A3);
            mainfrm.txtA4.Text = Convert.ToString(geo.A4);
            mainfrm.txtA5.Text = Convert.ToString(geo.A5);
            mainfrm.txtGammaM.Text = Convert.ToString(geo.GammaM);

            foreach (TextBox t in mainfrm.Controls.OfType<TextBox>())
            {
                t.TextChanged += mainfrm.textBox_changed;
            }

            if (mainfrm.dgvSoilProperties.Rows.Count > 0)
            {
                mainfrm.dgvSoilProperties.Rows.Clear();
            }            

            mainfrm.dgvSoilProperties.CellValueChanged -= mainfrm.set_SoilLayers;

            int rowIndex = 0;
            foreach (SoilMaterial layer in soilLayer)
            {
                mainfrm.dgvSoilProperties.Rows.Add();
                mainfrm.dgvSoilProperties.Rows[rowIndex].Cells["layer"].Value = layer.LayerThickness;
                mainfrm.dgvSoilProperties.Rows[rowIndex].Cells["refEModulLayer"].Value = layer.ReferenceEModul;
                mainfrm.dgvSoilProperties.Rows[rowIndex].Cells["effectiveCohesionLayer"].Value = layer.EffectiveCohesion;
                mainfrm.dgvSoilProperties.Rows[rowIndex].Cells["effectiveShearStrengthLayer"].Value = layer.EffectiveShearStrengthLayer;
                mainfrm.dgvSoilProperties.Rows[rowIndex].Cells["specificWeightLayer"].Value = layer.SpecificWeightLayer;
                //mainfrm.set_SoilLayers(mainfrm.dgvSoilProperties, new DataGridViewCellEventArgs(rowIndex - 1, i));
                rowIndex++;
            }
            mainfrm.dgvSoilProperties.CellValueChanged += mainfrm.set_SoilLayers;

        }
    }
}

        

    

