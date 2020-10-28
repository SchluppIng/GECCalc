using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using SplashScreen;
using CalculationModul;
using System.Reflection;
using XMLReaderWriter;
using System.IO;
using System.Globalization;
using Output;

//Set Version of G.E.C. Calc
[assembly: AssemblyVersion("1.0.1.1")]

namespace GECCalc
{
    public partial class MainForm : Form
    {
        SystemData sysData = new SystemData();
        GeoTextile geoTex = new GeoTextile();
        ColumnMaterial columnMaterial = new ColumnMaterial();
        SoilMaterial soilLayer;
        List<SoilMaterial> soilList = new List<SoilMaterial>();
        string filePath, previousPath, lastFullNameandFolder;


        public MainForm()
        {
            //StartSplashscreen with waiting of x Seconds
            createSplashScreenThread(2.5);
            InitializeComponent();

            //Change decimal , to . if necessary
            setDecimal();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "G.E.C. Calc Version " + typeof(MainForm).Assembly.GetName().Version;
            //Set Chars of Text to indices
            charOffsets();
        }

        //Start SplashScreen
        #region Start SplashScreen
        private void startSplashScreen()
        {
            //Show SplashScreenForm
            Application.Run(new SplashScreenForm());
        }

        private void createSplashScreenThread(double seconds)
        {
            //Create Thread and Start SplashScreen in new Stread
            int milliseconds = Convert.ToInt32(seconds * 1000);
            Thread threadSplashScreen = new Thread(new ThreadStart(startSplashScreen));
            threadSplashScreen.Start();
            Thread.Sleep(milliseconds);
            threadSplashScreen.Abort();
        }

        #endregion

        //Close Software
        #region close
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        //Set picture for Column Grid
        #region ColumnGridPicture
        private void comboBoxColumnGrid_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxColumnGrid.Text == "Quadratic")
            {
                pictureBoxColumnGrid.Image = Properties.Resources.Quadratic;

                lblGridSelected.Text = "Quadratic grid selected";
                ;
            }
            else
            {
                pictureBoxColumnGrid.Image = Properties.Resources.Rectangle;
                lblGridSelected.Text = "Rectangle grid selected";
            }

            show_Results();

        }
        #endregion

        //Set offsets for Chars in Richtextbox
        #region Set offsets for text
        public void charOffsets()
        {
            richTextBoxColumRadius.SelectionStart = 14;
            richTextBoxColumRadius.SelectionLength = "c".Length;
            richTextBoxColumRadius.SelectionCharOffset = -5;

            richTextBoxWideningActivation.SelectionStart = 21;
            richTextBoxWideningActivation.SelectionLength = "geo".Length;
            richTextBoxWideningActivation.SelectionCharOffset = -5;

            richTextBoxLoad.SelectionStart = 7;
            richTextBoxLoad.SelectionLength = "d".Length;
            richTextBoxLoad.SelectionCharOffset = -5;
            richTextBoxLoad.SelectionStart = 12;
            richTextBoxLoad.SelectionLength = "d".Length;
            richTextBoxLoad.SelectionCharOffset = -5;
            richTextBoxLoad.SelectionStart = 16;
            richTextBoxLoad.SelectionLength = "0".Length;
            richTextBoxLoad.SelectionCharOffset = -5;

            richTextBoxShearStrength.SelectionStart = 27;
            richTextBoxShearStrength.SelectionLength = "s".Length;
            richTextBoxShearStrength.SelectionCharOffset = -5;

            richTextBoxWeight.SelectionStart = 17;
            richTextBoxWeight.SelectionLength = "s".Length;
            richTextBoxWeight.SelectionCharOffset = -5;

            richTextBoxRBK0.SelectionStart = 38;
            richTextBoxRBK0.SelectionLength = "B,k0".Length;
            richTextBoxRBK0.SelectionCharOffset = -5;

            richTextBoxGammaM.SelectionStart = "Partial safety factor for material ".Length + 1;
            richTextBoxGammaM.SelectionLength = "M".Length;
            richTextBoxGammaM.SelectionCharOffset = -5;

        }
        #endregion

        //set values for column, geotextile and system and check if textbox is a value or empty
        #region check for textboxes
        public void textBox_changed(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                if (sender.GetType().Name == "TextBox")
                {
                    TextBox tb = (TextBox)sender;
                    if (tb.Text != "")
                        check = true;
                }
                else
                {
                    check = true;
                }

                if (check)
                {
                    foreach (TextBox t in this.Controls.OfType<TextBox>())
                    {
                        if (t.Text != null)
                        {

                            //System Data
                            sysData.Config = txtConfigurationName.Text;
                            sysData.ColumGrid = comboBoxColumnGrid.Text;
                            sysData.Method = comboBoxMethod.Text;
                            //sysData.e areaRatio = Convert.ToDouble(txtAreaRatio.Text);
                            sysData.ColumnRadius = Convert.ToDouble(txtColumnRadius.Text);
                            sysData.Rgeo = Convert.ToDouble(txtWideningActivation.Text);
                            sysData.J = Convert.ToDouble(txtElongationStiffness.Text);
                            sysData.TotalLoad = Convert.ToDouble(txtLoad.Text);
                            sysData.Pref = Convert.ToDouble(txtAtmosphericPressure.Text);
                            sysData.M = Convert.ToDouble(txtPowerOhde.Text);
                            sysData.Poisson = Convert.ToDouble(txtPoissonRatio.Text);
                            sysData.S = Convert.ToDouble(txtColumnDistance.Text);

                            //Geotextile material
                            geoTex.Rbk0 = Convert.ToDouble(txtRBk0.Text);
                            geoTex.A1 = Convert.ToDouble(txtA1.Text);
                            geoTex.A2 = Convert.ToDouble(txtA2.Text);
                            geoTex.A3 = Convert.ToDouble(txtA3.Text);
                            geoTex.A4 = Convert.ToDouble(txtA4.Text);
                            geoTex.A5 = Convert.ToDouble(txtA5.Text);
                            geoTex.GammaM = Convert.ToDouble(txtGammaM.Text);

                            //Column material
                            columnMaterial.Gammas = Convert.ToDouble(txtSpecificWeight.Text);
                            columnMaterial.Phis = Convert.ToDouble(txtEffectivShearStrength.Text);


                            sysData.S = Convert.ToDouble(txtColumnDistance.Text);
                            txtAreaRatio.Text = sysData.calc_column_distance().ToString("F3");
                        }
                    }

                }
            }

            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message, "Worng Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Worng Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            show_Results();
        }
        #endregion

        //set soil layers to object, put in a list, and if value changed, check wich index and change value
        #region set soil layers
        public void set_SoilLayers(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = 0;
                int cellIndex = 0;
                double LayerThickness = 0;
                double ReferenceEModul = 0;
                double EffectiveCohesion = 0;
                double EffectiveShearStrengthLayer = 0;
                double SpecificWeightLayer = 0;

                if (dgvSoilProperties.CurrentCell != null)
                {
                    rowIndex = dgvSoilProperties.CurrentCell.RowIndex;
                    cellIndex = dgvSoilProperties.CurrentCell.ColumnIndex;

                    LayerThickness = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["layer"].Value);
                    ReferenceEModul = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["refEModulLayer"].Value);
                    EffectiveCohesion = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveCohesionLayer"].Value);
                    EffectiveShearStrengthLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveShearStrengthLayer"].Value);
                    SpecificWeightLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["specificWeightLayer"].Value);

                    if (LayerThickness == 0 && ReferenceEModul == 0 && EffectiveCohesion == 0 && EffectiveShearStrengthLayer == 0 && SpecificWeightLayer == 0)
                    {
                        soilList.RemoveAt(rowIndex);
                        dgvSoilProperties.Rows.RemoveAt(rowIndex);
                    }

                    if (LayerThickness != 0 && ReferenceEModul != 0 && EffectiveCohesion != 0 && EffectiveShearStrengthLayer != 0 && SpecificWeightLayer != 0)
                    {
                        if (rowIndex > soilList.Count - 1)
                        {
                            LayerThickness = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["layer"].Value);
                            ReferenceEModul = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["refEModulLayer"].Value);
                            EffectiveCohesion = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveCohesionLayer"].Value);
                            EffectiveShearStrengthLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveShearStrengthLayer"].Value);
                            SpecificWeightLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["specificWeightLayer"].Value);
                            soilList.Add(soilLayer = new SoilMaterial(LayerThickness, ReferenceEModul, EffectiveCohesion, EffectiveShearStrengthLayer, SpecificWeightLayer));
                        }
                        else
                        {
                            soilList[rowIndex].LayerThickness = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["layer"].Value);
                            soilList[rowIndex].ReferenceEModul = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["refEModulLayer"].Value);
                            soilList[rowIndex].EffectiveCohesion = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveCohesionLayer"].Value);
                            soilList[rowIndex].EffectiveShearStrengthLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["effectiveShearStrengthLayer"].Value);
                            soilList[rowIndex].SpecificWeightLayer = Convert.ToDouble(dgvSoilProperties.Rows[rowIndex].Cells["specificWeightLayer"].Value);
                        }
                    }
                }
            }

            catch (FormatException FormEx)
            {
                MessageBox.Show(FormEx.Message, "Worng Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            show_Results();
        }
        #endregion

        //Key down Element to remove value from datagridview
        #region DGV KeyDOwn
        private void dgvSoilProperties_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete && dgvSoilProperties.CurrentCell.Selected) || (e.KeyCode == Keys.Back && dgvSoilProperties.CurrentCell.Selected))
            {
                dgvSoilProperties.CurrentCell.Value = null;
                e.Handled = true;
            }
        }
        #endregion

        //Show Results
        #region Show Results
        public void show_Results()
        {
            richTxtResults.Text = "";

            ResultCalculationList resList = new ResultCalculationList();

            if (resList.ResultList != null)
            {
                resList.ResultList.Clear();
            }

            richTxtResults.Text = sysData.ToString();

            double maxRingForce = 0;
            string assessment = "";
            foreach (SoilMaterial layer in soilList)
            {
                ResultCalculation res = new ResultCalculation(sysData, columnMaterial, geoTex, layer);
                resList.totSettlement += res.Ss;
                resList.rbd = res.Rbd;
                resList.ResultList.Add(res);
                richTxtResults.Text += resList.ToString();
                if(maxRingForce < res.Ringforce)
                {
                    maxRingForce = Math.Round(res.Ringforce,2);
                }
                if(maxRingForce <= res.Rbd)
                {
                    assessment = "Proof of geo textile fulfilled";
                }
                else
                {
                    assessment = "Proof of geo textile not fulfilled";
                }

            }


            richTxtResults.Text += "\nTotal settlement " + resList.totSettlement + " cm" 
                + "\nGeo textile resistance: " + resList.rbd + " kN/m"
                + "\nMax. ringforce: " + maxRingForce + " kN/m" + "\n" + assessment;

            formatRichTextBox();
        }
        #endregion

        //About form
        #region about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAbout about = new formAbout();
            about.ShowDialog();
        }
        #endregion

        //Format Richtext box
        #region format richtextboxrsults
        private void formatRichTextBox()
        {
            int i = 0;
            foreach (string line in richTxtResults.Lines)
            {
                if (line.StartsWith("Project"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
                if (line.StartsWith("Soft"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
                if (line.StartsWith("Total settlement"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
                if (line.StartsWith("Geo textile"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
                if (line.StartsWith("Max. ring"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                }
                if (line.StartsWith("Proof of geo textile fulfilled"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    richTxtResults.SelectionColor = Color.Green;
                }
                if (line.StartsWith("Proof of geo textile not fulfilled"))
                {
                    richTxtResults.SelectionStart = richTxtResults.Find(richTxtResults.Lines[i]);
                    richTxtResults.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    richTxtResults.SelectionColor = Color.Red;
                }

                i++;

            }
        }
        #endregion

        //Save file with save file dialog
        #region saveFileDialog
        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSaveAsFileDialog("xml");
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            ShowSaveAsFileDialog("xml");
        }

        private void ShowSaveAsFileDialog(string filter)
        {
            
            
            SaveFileDialog sfd = new SaveFileDialog();
            {
                sfd.RestoreDirectory = true;
                sfd.FilterIndex = 1;

                if (filter == "xml")
                {                 
                    //sfd.InitialDirectory = Directory.GetCurrentDirectory();                    
                    sfd.DefaultExt = ".xml";
                    sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    sfd.Title = "Save file as XML.";
                }
                else if(filter == "doc")
                {
                    sfd.DefaultExt = "*.doc";
                    sfd.Filter = "Doc files (*.doc)|*.doc|All files (*.*)|*.*";
                    sfd.Title = "Save file as Word.";
                }
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
                previousPath = Path.GetDirectoryName(sfd.FileName);
                lastFullNameandFolder = previousPath + "\\" + Path.GetFileName(sfd.FileName);

                if (filter == "xml")
                {
                    XMLWrite xwWrite = new XMLWrite(filePath, sysData, columnMaterial, geoTex, soilList);
                }
                else if(filter == "doc")
                {
                    WordExport doc = new WordExport(filePath, richTxtResults.Rtf);
                }

                MessageBox.Show("File saved as " + filePath, "File saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        //Save file without dialog
        #region savefile

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFile(lastFullNameandFolder);
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(lastFullNameandFolder);
        }
        private void saveFile(string lastFullPath)
        {
            string lastPath = lastFullPath;
            if (String.IsNullOrEmpty(lastPath))
            {
                ShowSaveAsFileDialog("xml");
            }
            else
            {
                try
                {
                    XMLWrite xwWrite = new XMLWrite(lastPath, sysData, columnMaterial, geoTex, soilList);
                    MessageBox.Show("File saved as " + filePath, "File saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could not save file. Try \"File save as\" " + ex.Message, "Error saved.",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        //Open file Dialog
        #region openfileDialog

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            ShowOpenFileDialog();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOpenFileDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingResults printRes = new PrintingResults();
        }

        private void buttonExportWord_Click(object sender, EventArgs e)
        {
            ShowSaveAsFileDialog("doc");
        }

        private void ShowOpenFileDialog()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            {
                ofd.FilterIndex = 2;
                ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                if (String.IsNullOrEmpty(previousPath))
                {
                    ofd.InitialDirectory = Path.GetFileName(Environment.CurrentDirectory);
                }
                else
                {
                    ofd.InitialDirectory = previousPath;
                }
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XMLRead xr = new XMLRead(ofd.FileName, this);
                        sysData = xr.sysData;
                        geoTex = xr.geo;
                        columnMaterial = xr.columnMaterial;
                        soilList = xr.soilLayer;
                        show_Results();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                }
            }
        }
        #endregion

        //set decimal . or , at start
        private void setDecimal()
        {
            //Keyboard language for decimal . or ,
            //Maybe a bad solution with 3 foreach loops, but it works
            //Check out for new/different solutions
            
            CultureInfo keyBoardLang = new CultureInfo(Convert.ToString(CultureInfo.CurrentCulture), true);

            string comma = ",";
            string point  = ".";

            if (keyBoardLang.NumberFormat.NumberDecimalSeparator != ",")
            {
                foreach(TextBox t in this.Controls.OfType<TextBox>())
                {
                    t.TextChanged -= this.textBox_changed;
                }

                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {
                    string text = t.Text;
                    text = text.Replace(comma, point);
                    t.Text = text;
                }

                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {
                    t.TextChanged += this.textBox_changed;
                }
            }
        }
    }   
}

