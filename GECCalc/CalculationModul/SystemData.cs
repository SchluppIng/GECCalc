using System;

namespace CalculationModul
{
    class SystemData
    {
        //Variables
        int id = 0;                 //ID of Configuration
        string project;              //Configuration Name
        string columGrid;           //Grid of Columns, quadratic or triangle
        string method;              //Displacement method or Excavation method
        double areaRatio;           //Ratio of area
        double columnRadius;        //Radius of encased sand column in meter
        double columnDiamter;       //Diameter of encased sand column in meter
        double rgeo;                //Widening activation in meter
        double j;                   //Elongation stiffness in kN/m
        double load;                //Toal load on columns in kN/m²²
        double pref;                //Atmospheric pressure in kN/m²
        double m;                   //Power to Ohde
        double poisson;             //Poisson ratio
        double s;                   //Distance between columns in meter
        double diameterUnitCell;    //Diameter of the unit cell
        double areaUnitCell;        //Area of the unit cell
        double columnArea;          //Area of the column
        string sysDataString;


        //Constructor for Systemdata
        public SystemData() { }
        #region Systemdata
        public SystemData(string ProjectName, string ColumnGrid, string Method, double ColumnRadius, double WideningActivation, double ElongationStiffness, double TotalLoad, 
            double AtmosphreicPressure, double PowerToOhde, double PoissonRatio, double columnDistance)//, double ColumnDistance)
        {
            id = id++;
            Project = ProjectName;
            columGrid = ColumnGrid;
            method = Method;
            areaRatio = 0;
            columnRadius = ColumnRadius;
            columnDiamter = 2 * columnRadius;
            rgeo = WideningActivation;
            j = ElongationStiffness;
            load = TotalLoad;
            pref = AtmosphreicPressure;
            m = PowerToOhde;
            poisson = PoissonRatio;
            s = columnDistance;
            diameterUnitCell = 0;
            areaUnitCell = 0;
            columnArea = 0;
            calc_column_distance();
        }

        public double calc_column_distance()
        {
  
            double a;
            double b;
                if (ColumGrid == "Rectangle")
                {
                    a = Math.Pow(Math.PI, 2);
                    b = Math.Pow(12 / a, (0.25));
                    diameterUnitCell = b * s;
                }
                else
                {
                    a = Math.Pow(Math.PI, 2);
                    b = Math.Pow(16 / a, (0.25));
                    diameterUnitCell = b * s;
                }

                areaUnitCell = Math.Round(Math.PI * Math.Pow(diameterUnitCell, 2) / 4, 4);
                columnDiamter = Math.Round(ColumnRadius * 2, 2);
                columnArea = Math.Round(Math.PI * Math.Pow(ColumnRadius, 2), 4);
                areaRatio = Math.Round(columnArea / areaUnitCell, 3);

            return areaRatio;
        }

        public override string ToString()
        {
            return sysDataString = "Project name: " + Project + "\n\n" +
                "Total load: " + Math.Round(TotalLoad, 2) + " kN/m²" + "\n" +
                "Elongation  stiffness: " + J + " kN/m²" + "\n" +
                "Grid: " + columGrid + "\n" +
                "Method: " + method + "\n" +
                "Column diameter dr: " + Math.Round(columnDiamter, 3) + " m\n" +
                "Columm diameter with widening dego: " + Math.Round(rgeo, 3) + " m\n" +
                "Diameter unit cell de: " + Math.Round(diameterUnitCell, 3) + "m\n" +
                "Column area As: " + Math.Round(columnArea, 3) + " m²\n" +
                "Area unit cell Ae: " + Math.Round(areaUnitCell, 3) + " m²\n" +
                "Area ratio as=As/Ae: " + Math.Round(areaRatio, 3) + " [-]\n" +
                "Column distance s: " + Math.Round(s, 3) + " m\n\n";

            
        }

        public string Config { get => Project; set => Project = value; }
        public string ColumGrid { get => columGrid; set => columGrid = value; }
        public string Method { get => method; set => method = value; }
        public double AreaRatio { get => areaRatio; set => areaRatio = value; }
        public double ColumnRadius { get => columnRadius; set => columnRadius = value; }
        public double Rgeo { get => rgeo; set => rgeo = value; }
        public double J { get => j; set => j = value; }
        public double TotalLoad { get => load; set => load = value; }
        public double Pref { get => pref; set => pref = value; }
        public double M { get => m; set => m = value; }
        public double Poisson { get => poisson; set => poisson = value; }
        public double S { get => s; set => s = value; }
        public string Project { get => project; set => project = value; }
        #endregion
    }
}
