namespace GECCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInputDataText = new System.Windows.Forms.Label();
            this.comboBoxColumnGrid = new System.Windows.Forms.ComboBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.lblColumnGrid = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblSystemData = new System.Windows.Forms.Label();
            this.lblAreaRatio = new System.Windows.Forms.Label();
            this.txtAreaRatio = new System.Windows.Forms.TextBox();
            this.txtColumnRadius = new System.Windows.Forms.TextBox();
            this.lblConfigurationName = new System.Windows.Forms.Label();
            this.txtConfigurationName = new System.Windows.Forms.TextBox();
            this.lblGridSelected = new System.Windows.Forms.Label();
            this.txtWideningActivation = new System.Windows.Forms.TextBox();
            this.richTextBoxWideningActivation = new System.Windows.Forms.RichTextBox();
            this.lblElongationStiffness = new System.Windows.Forms.Label();
            this.txtElongationStiffness = new System.Windows.Forms.TextBox();
            this.lblAtmosphericPressure = new System.Windows.Forms.Label();
            this.txtAtmosphericPressure = new System.Windows.Forms.TextBox();
            this.lblPowerOhde = new System.Windows.Forms.Label();
            this.txtPowerOhde = new System.Windows.Forms.TextBox();
            this.richTextBoxLoad = new System.Windows.Forms.RichTextBox();
            this.txtLoad = new System.Windows.Forms.TextBox();
            this.richTextBoxColumRadius = new System.Windows.Forms.RichTextBox();
            this.txtPoissonRatio = new System.Windows.Forms.TextBox();
            this.lblPoissonRatio = new System.Windows.Forms.Label();
            this.lblColumnDistance = new System.Windows.Forms.Label();
            this.txtColumnDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpecificWeight = new System.Windows.Forms.TextBox();
            this.txtEffectivShearStrength = new System.Windows.Forms.TextBox();
            this.richTextBoxShearStrength = new System.Windows.Forms.RichTextBox();
            this.richTextBoxWeight = new System.Windows.Forms.RichTextBox();
            this.txtGammaM = new System.Windows.Forms.TextBox();
            this.txtA5 = new System.Windows.Forms.TextBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtRBk0 = new System.Windows.Forms.TextBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.lblgeotextile = new System.Windows.Forms.Label();
            this.richTextBoxRBK0 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxGammaM = new System.Windows.Forms.RichTextBox();
            this.dgvSoilProperties = new System.Windows.Forms.DataGridView();
            this.layer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refEModulLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveCohesionLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectiveShearStrengthLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificWeightLayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxColumnGrid = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTxtResults = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonExportWord = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoilProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumnGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1488, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "&Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileToolStripMenuItem.Text = "&Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileAsToolStripMenuItem.Text = "S&ave file as";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveFileAsToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblInputDataText
            // 
            this.lblInputDataText.AutoSize = true;
            this.lblInputDataText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputDataText.Location = new System.Drawing.Point(350, 25);
            this.lblInputDataText.Name = "lblInputDataText";
            this.lblInputDataText.Size = new System.Drawing.Size(268, 29);
            this.lblInputDataText.TabIndex = 1;
            this.lblInputDataText.Text = "G.E.C. Calc input data";
            // 
            // comboBoxColumnGrid
            // 
            this.comboBoxColumnGrid.FormattingEnabled = true;
            this.comboBoxColumnGrid.Items.AddRange(new object[] {
            "Rectangle",
            "Quadratic"});
            this.comboBoxColumnGrid.Location = new System.Drawing.Point(160, 139);
            this.comboBoxColumnGrid.Name = "comboBoxColumnGrid";
            this.comboBoxColumnGrid.Size = new System.Drawing.Size(110, 21);
            this.comboBoxColumnGrid.TabIndex = 2;
            this.comboBoxColumnGrid.Text = "Rectangle";
            this.comboBoxColumnGrid.SelectedValueChanged += new System.EventHandler(this.comboBoxColumnGrid_SelectedValueChanged);
            this.comboBoxColumnGrid.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Displacement",
            "Excavation"});
            this.comboBoxMethod.Location = new System.Drawing.Point(160, 171);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(110, 21);
            this.comboBoxMethod.TabIndex = 3;
            this.comboBoxMethod.Text = "Displacement";
            this.comboBoxMethod.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblColumnGrid
            // 
            this.lblColumnGrid.AutoSize = true;
            this.lblColumnGrid.Location = new System.Drawing.Point(92, 142);
            this.lblColumnGrid.Name = "lblColumnGrid";
            this.lblColumnGrid.Size = new System.Drawing.Size(62, 13);
            this.lblColumnGrid.TabIndex = 4;
            this.lblColumnGrid.Text = "Column grid";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(111, 174);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "Method";
            // 
            // lblSystemData
            // 
            this.lblSystemData.AutoSize = true;
            this.lblSystemData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemData.Location = new System.Drawing.Point(41, 66);
            this.lblSystemData.Name = "lblSystemData";
            this.lblSystemData.Size = new System.Drawing.Size(93, 19);
            this.lblSystemData.TabIndex = 6;
            this.lblSystemData.Text = "System data";
            // 
            // lblAreaRatio
            // 
            this.lblAreaRatio.AutoSize = true;
            this.lblAreaRatio.Location = new System.Drawing.Point(87, 202);
            this.lblAreaRatio.Name = "lblAreaRatio";
            this.lblAreaRatio.Size = new System.Drawing.Size(64, 13);
            this.lblAreaRatio.TabIndex = 8;
            this.lblAreaRatio.Text = "Area ratio [-]";
            // 
            // txtAreaRatio
            // 
            this.txtAreaRatio.Location = new System.Drawing.Point(160, 203);
            this.txtAreaRatio.Name = "txtAreaRatio";
            this.txtAreaRatio.ReadOnly = true;
            this.txtAreaRatio.Size = new System.Drawing.Size(110, 20);
            this.txtAreaRatio.TabIndex = 4;
            this.txtAreaRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtColumnRadius
            // 
            this.txtColumnRadius.Location = new System.Drawing.Point(160, 234);
            this.txtColumnRadius.Name = "txtColumnRadius";
            this.txtColumnRadius.Size = new System.Drawing.Size(110, 20);
            this.txtColumnRadius.TabIndex = 5;
            this.txtColumnRadius.Text = "0,4";
            this.txtColumnRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtColumnRadius.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblConfigurationName
            // 
            this.lblConfigurationName.AutoSize = true;
            this.lblConfigurationName.Location = new System.Drawing.Point(80, 95);
            this.lblConfigurationName.Name = "lblConfigurationName";
            this.lblConfigurationName.Size = new System.Drawing.Size(71, 13);
            this.lblConfigurationName.TabIndex = 12;
            this.lblConfigurationName.Text = "Project Name";
            // 
            // txtConfigurationName
            // 
            this.txtConfigurationName.Location = new System.Drawing.Point(160, 92);
            this.txtConfigurationName.Name = "txtConfigurationName";
            this.txtConfigurationName.Size = new System.Drawing.Size(376, 20);
            this.txtConfigurationName.TabIndex = 1;
            this.txtConfigurationName.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblGridSelected
            // 
            this.lblGridSelected.AutoSize = true;
            this.lblGridSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridSelected.Location = new System.Drawing.Point(329, 118);
            this.lblGridSelected.Name = "lblGridSelected";
            this.lblGridSelected.Size = new System.Drawing.Size(159, 15);
            this.lblGridSelected.TabIndex = 14;
            this.lblGridSelected.Text = "Rectangle grid selected";
            // 
            // txtWideningActivation
            // 
            this.txtWideningActivation.Location = new System.Drawing.Point(160, 265);
            this.txtWideningActivation.Name = "txtWideningActivation";
            this.txtWideningActivation.Size = new System.Drawing.Size(110, 20);
            this.txtWideningActivation.TabIndex = 6;
            this.txtWideningActivation.Text = "0,4025";
            this.txtWideningActivation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWideningActivation.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // richTextBoxWideningActivation
            // 
            this.richTextBoxWideningActivation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWideningActivation.Location = new System.Drawing.Point(14, 267);
            this.richTextBoxWideningActivation.Multiline = false;
            this.richTextBoxWideningActivation.Name = "richTextBoxWideningActivation";
            this.richTextBoxWideningActivation.ReadOnly = true;
            this.richTextBoxWideningActivation.Size = new System.Drawing.Size(145, 20);
            this.richTextBoxWideningActivation.TabIndex = 17;
            this.richTextBoxWideningActivation.TabStop = false;
            this.richTextBoxWideningActivation.Text = "Widening activation rgeo [m]";
            // 
            // lblElongationStiffness
            // 
            this.lblElongationStiffness.AutoSize = true;
            this.lblElongationStiffness.Location = new System.Drawing.Point(20, 300);
            this.lblElongationStiffness.Name = "lblElongationStiffness";
            this.lblElongationStiffness.Size = new System.Drawing.Size(134, 13);
            this.lblElongationStiffness.TabIndex = 18;
            this.lblElongationStiffness.Text = "Elongation stiffness [kN/m]";
            // 
            // txtElongationStiffness
            // 
            this.txtElongationStiffness.Location = new System.Drawing.Point(160, 296);
            this.txtElongationStiffness.Name = "txtElongationStiffness";
            this.txtElongationStiffness.Size = new System.Drawing.Size(110, 20);
            this.txtElongationStiffness.TabIndex = 7;
            this.txtElongationStiffness.Text = "3576";
            this.txtElongationStiffness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtElongationStiffness.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblAtmosphericPressure
            // 
            this.lblAtmosphericPressure.AutoSize = true;
            this.lblAtmosphericPressure.Location = new System.Drawing.Point(7, 363);
            this.lblAtmosphericPressure.Name = "lblAtmosphericPressure";
            this.lblAtmosphericPressure.Size = new System.Drawing.Size(147, 13);
            this.lblAtmosphericPressure.TabIndex = 20;
            this.lblAtmosphericPressure.Text = "Atmospheric pressure [kN/m²]";
            // 
            // txtAtmosphericPressure
            // 
            this.txtAtmosphericPressure.Location = new System.Drawing.Point(160, 358);
            this.txtAtmosphericPressure.Name = "txtAtmosphericPressure";
            this.txtAtmosphericPressure.Size = new System.Drawing.Size(110, 20);
            this.txtAtmosphericPressure.TabIndex = 9;
            this.txtAtmosphericPressure.Text = "100";
            this.txtAtmosphericPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAtmosphericPressure.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblPowerOhde
            // 
            this.lblPowerOhde.AutoSize = true;
            this.lblPowerOhde.Location = new System.Drawing.Point(53, 392);
            this.lblPowerOhde.Name = "lblPowerOhde";
            this.lblPowerOhde.Size = new System.Drawing.Size(101, 13);
            this.lblPowerOhde.TabIndex = 22;
            this.lblPowerOhde.Text = "Power to Ohde m [-]";
            // 
            // txtPowerOhde
            // 
            this.txtPowerOhde.Location = new System.Drawing.Point(160, 389);
            this.txtPowerOhde.Name = "txtPowerOhde";
            this.txtPowerOhde.Size = new System.Drawing.Size(110, 20);
            this.txtPowerOhde.TabIndex = 10;
            this.txtPowerOhde.Text = "1";
            this.txtPowerOhde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPowerOhde.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // richTextBoxLoad
            // 
            this.richTextBoxLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLoad.Location = new System.Drawing.Point(24, 330);
            this.richTextBoxLoad.Multiline = false;
            this.richTextBoxLoad.Name = "richTextBoxLoad";
            this.richTextBoxLoad.ReadOnly = true;
            this.richTextBoxLoad.Size = new System.Drawing.Size(145, 20);
            this.richTextBoxLoad.TabIndex = 24;
            this.richTextBoxLoad.TabStop = false;
            this.richTextBoxLoad.Text = "Load (gd + qd) σ0 [kN/m²]";
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(160, 327);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(110, 20);
            this.txtLoad.TabIndex = 8;
            this.txtLoad.Text = "100";
            this.txtLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoad.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // richTextBoxColumRadius
            // 
            this.richTextBoxColumRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxColumRadius.Location = new System.Drawing.Point(58, 235);
            this.richTextBoxColumRadius.Multiline = false;
            this.richTextBoxColumRadius.Name = "richTextBoxColumRadius";
            this.richTextBoxColumRadius.ReadOnly = true;
            this.richTextBoxColumRadius.Size = new System.Drawing.Size(98, 20);
            this.richTextBoxColumRadius.TabIndex = 26;
            this.richTextBoxColumRadius.TabStop = false;
            this.richTextBoxColumRadius.Text = "Colum radius rc [m]";
            // 
            // txtPoissonRatio
            // 
            this.txtPoissonRatio.Location = new System.Drawing.Point(160, 420);
            this.txtPoissonRatio.Name = "txtPoissonRatio";
            this.txtPoissonRatio.Size = new System.Drawing.Size(110, 20);
            this.txtPoissonRatio.TabIndex = 11;
            this.txtPoissonRatio.Text = "0,4";
            this.txtPoissonRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPoissonRatio.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // lblPoissonRatio
            // 
            this.lblPoissonRatio.AutoSize = true;
            this.lblPoissonRatio.Location = new System.Drawing.Point(75, 424);
            this.lblPoissonRatio.Name = "lblPoissonRatio";
            this.lblPoissonRatio.Size = new System.Drawing.Size(79, 13);
            this.lblPoissonRatio.TabIndex = 27;
            this.lblPoissonRatio.Text = "Poisson ratio [-]";
            // 
            // lblColumnDistance
            // 
            this.lblColumnDistance.AutoSize = true;
            this.lblColumnDistance.Location = new System.Drawing.Point(44, 453);
            this.lblColumnDistance.Name = "lblColumnDistance";
            this.lblColumnDistance.Size = new System.Drawing.Size(110, 13);
            this.lblColumnDistance.TabIndex = 29;
            this.lblColumnDistance.Text = "Column distance s [m]";
            // 
            // txtColumnDistance
            // 
            this.txtColumnDistance.Location = new System.Drawing.Point(160, 451);
            this.txtColumnDistance.Name = "txtColumnDistance";
            this.txtColumnDistance.Size = new System.Drawing.Size(110, 20);
            this.txtColumnDistance.TabIndex = 12;
            this.txtColumnDistance.Text = "1,703";
            this.txtColumnDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtColumnDistance.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Column material";
            // 
            // txtSpecificWeight
            // 
            this.txtSpecificWeight.Location = new System.Drawing.Point(160, 551);
            this.txtSpecificWeight.Name = "txtSpecificWeight";
            this.txtSpecificWeight.Size = new System.Drawing.Size(110, 20);
            this.txtSpecificWeight.TabIndex = 14;
            this.txtSpecificWeight.Text = "18";
            this.txtSpecificWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSpecificWeight.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtEffectivShearStrength
            // 
            this.txtEffectivShearStrength.Location = new System.Drawing.Point(160, 520);
            this.txtEffectivShearStrength.Name = "txtEffectivShearStrength";
            this.txtEffectivShearStrength.Size = new System.Drawing.Size(110, 20);
            this.txtEffectivShearStrength.TabIndex = 13;
            this.txtEffectivShearStrength.Text = "32";
            this.txtEffectivShearStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEffectivShearStrength.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // richTextBoxShearStrength
            // 
            this.richTextBoxShearStrength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxShearStrength.Location = new System.Drawing.Point(11, 520);
            this.richTextBoxShearStrength.Multiline = false;
            this.richTextBoxShearStrength.Name = "richTextBoxShearStrength";
            this.richTextBoxShearStrength.ReadOnly = true;
            this.richTextBoxShearStrength.Size = new System.Drawing.Size(145, 20);
            this.richTextBoxShearStrength.TabIndex = 33;
            this.richTextBoxShearStrength.TabStop = false;
            this.richTextBoxShearStrength.Text = "Effective shear strength ɸ\'s [°]";
            // 
            // richTextBoxWeight
            // 
            this.richTextBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWeight.Location = new System.Drawing.Point(27, 554);
            this.richTextBoxWeight.Multiline = false;
            this.richTextBoxWeight.Name = "richTextBoxWeight";
            this.richTextBoxWeight.ReadOnly = true;
            this.richTextBoxWeight.Size = new System.Drawing.Size(128, 20);
            this.richTextBoxWeight.TabIndex = 34;
            this.richTextBoxWeight.TabStop = false;
            this.richTextBoxWeight.Text = "Specific weight γs [kN/m³]";
            // 
            // txtGammaM
            // 
            this.txtGammaM.Location = new System.Drawing.Point(528, 564);
            this.txtGammaM.Name = "txtGammaM";
            this.txtGammaM.Size = new System.Drawing.Size(100, 20);
            this.txtGammaM.TabIndex = 21;
            this.txtGammaM.Text = "1,4";
            this.txtGammaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGammaM.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtA5
            // 
            this.txtA5.Location = new System.Drawing.Point(528, 533);
            this.txtA5.Name = "txtA5";
            this.txtA5.Size = new System.Drawing.Size(100, 20);
            this.txtA5.TabIndex = 20;
            this.txtA5.Text = "1,0";
            this.txtA5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA5.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(528, 506);
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(100, 20);
            this.txtA4.TabIndex = 19;
            this.txtA4.Text = "1,03";
            this.txtA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA4.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(528, 475);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 20);
            this.txtA3.TabIndex = 18;
            this.txtA3.Text = "1,0";
            this.txtA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA3.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(528, 444);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 17;
            this.txtA2.Text = "1,2";
            this.txtA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA2.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(528, 415);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 16;
            this.txtA1.Text = "1,52";
            this.txtA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA1.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // txtRBk0
            // 
            this.txtRBk0.Location = new System.Drawing.Point(528, 384);
            this.txtRBk0.Name = "txtRBk0";
            this.txtRBk0.Size = new System.Drawing.Size(100, 20);
            this.txtRBk0.TabIndex = 15;
            this.txtRBk0.Text = "200";
            this.txtRBk0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRBk0.TextChanged += new System.EventHandler(this.textBox_changed);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label30.Location = new System.Drawing.Point(342, 536);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(180, 13);
            this.Label30.TabIndex = 74;
            this.Label30.Text = "Reduction for dynamic influences A5";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label29.Location = new System.Drawing.Point(315, 509);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(207, 13);
            this.Label29.TabIndex = 73;
            this.Label29.Text = "Reduction for environmental influences A4";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label28.Location = new System.Drawing.Point(365, 478);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(157, 13);
            this.Label28.TabIndex = 72;
            this.Label28.Text = "Reduction for manufacturing A3";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label27.Location = new System.Drawing.Point(394, 447);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(128, 13);
            this.Label27.TabIndex = 71;
            this.Label27.Text = "Reduction for damage A2";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label26.Location = new System.Drawing.Point(392, 418);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(130, 13);
            this.Label26.TabIndex = 70;
            this.Label26.Text = "Reduction creep strain A1";
            // 
            // lblgeotextile
            // 
            this.lblgeotextile.AutoSize = true;
            this.lblgeotextile.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.lblgeotextile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblgeotextile.Location = new System.Drawing.Point(416, 363);
            this.lblgeotextile.Name = "lblgeotextile";
            this.lblgeotextile.Size = new System.Drawing.Size(81, 18);
            this.lblgeotextile.TabIndex = 68;
            this.lblgeotextile.Text = "Geo textile";
            // 
            // richTextBoxRBK0
            // 
            this.richTextBoxRBK0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxRBK0.Location = new System.Drawing.Point(288, 384);
            this.richTextBoxRBK0.Multiline = false;
            this.richTextBoxRBK0.Name = "richTextBoxRBK0";
            this.richTextBoxRBK0.ReadOnly = true;
            this.richTextBoxRBK0.Size = new System.Drawing.Size(234, 20);
            this.richTextBoxRBK0.TabIndex = 83;
            this.richTextBoxRBK0.TabStop = false;
            this.richTextBoxRBK0.Text = "Short term strength in ring direction RB,k0 [kN/m]";
            // 
            // richTextBoxGammaM
            // 
            this.richTextBoxGammaM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxGammaM.Location = new System.Drawing.Point(356, 567);
            this.richTextBoxGammaM.Multiline = false;
            this.richTextBoxGammaM.Name = "richTextBoxGammaM";
            this.richTextBoxGammaM.ReadOnly = true;
            this.richTextBoxGammaM.Size = new System.Drawing.Size(166, 20);
            this.richTextBoxGammaM.TabIndex = 84;
            this.richTextBoxGammaM.TabStop = false;
            this.richTextBoxGammaM.Text = "Partial safety factor for material γM";
            // 
            // dgvSoilProperties
            // 
            this.dgvSoilProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSoilProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoilProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layer,
            this.refEModulLayer,
            this.effectiveCohesionLayer,
            this.effectiveShearStrengthLayer,
            this.specificWeightLayer});
            this.dgvSoilProperties.Location = new System.Drawing.Point(10, 626);
            this.dgvSoilProperties.Name = "dgvSoilProperties";
            this.dgvSoilProperties.Size = new System.Drawing.Size(686, 315);
            this.dgvSoilProperties.TabIndex = 22;
            this.dgvSoilProperties.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.set_SoilLayers);
            this.dgvSoilProperties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSoilProperties_KeyDown);
            // 
            // layer
            // 
            this.layer.HeaderText = "Layer Thickness hi [m]";
            this.layer.Name = "layer";
            this.layer.Width = 120;
            // 
            // refEModulLayer
            // 
            this.refEModulLayer.HeaderText = "Reference rigid module ES,ref [kN/m²]";
            this.refEModulLayer.Name = "refEModulLayer";
            this.refEModulLayer.Width = 140;
            // 
            // effectiveCohesionLayer
            // 
            this.effectiveCohesionLayer.HeaderText = "Effective Cohesion c\'B [kN/m²]";
            this.effectiveCohesionLayer.Name = "effectiveCohesionLayer";
            this.effectiveCohesionLayer.Width = 130;
            // 
            // effectiveShearStrengthLayer
            // 
            this.effectiveShearStrengthLayer.HeaderText = "Effective shear strength Φ\'B [°]";
            this.effectiveShearStrengthLayer.Name = "effectiveShearStrengthLayer";
            this.effectiveShearStrengthLayer.Width = 130;
            // 
            // specificWeightLayer
            // 
            this.specificWeightLayer.HeaderText = "Specific Weight γB [kN/m³]";
            this.specificWeightLayer.Name = "specificWeightLayer";
            this.specificWeightLayer.Width = 120;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label22.Location = new System.Drawing.Point(773, 69);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(123, 18);
            this.Label22.TabIndex = 87;
            this.Label22.Text = "Structural system";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold);
            this.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label18.Location = new System.Drawing.Point(13, 605);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(302, 18);
            this.Label18.TabIndex = 88;
            this.Label18.Text = "Soil properties of the surrounding soft layer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GECCalc.Properties.Resources.System;
            this.pictureBox1.Location = new System.Drawing.Point(636, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 431);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxColumnGrid
            // 
            this.pictureBoxColumnGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColumnGrid.Image = global::GECCalc.Properties.Resources.Rectangle;
            this.pictureBoxColumnGrid.Location = new System.Drawing.Point(276, 139);
            this.pictureBoxColumnGrid.Name = "pictureBoxColumnGrid";
            this.pictureBoxColumnGrid.Size = new System.Drawing.Size(288, 221);
            this.pictureBoxColumnGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxColumnGrid.TabIndex = 7;
            this.pictureBoxColumnGrid.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(1309, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 92;
            this.label3.Text = "Developed by Simon Schonhöft M.Eng.";
            // 
            // richTxtResults
            // 
            this.richTxtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtResults.Location = new System.Drawing.Point(1084, 95);
            this.richTxtResults.Name = "richTxtResults";
            this.richTxtResults.ReadOnly = true;
            this.richTxtResults.Size = new System.Drawing.Size(392, 846);
            this.richTxtResults.TabIndex = 93;
            this.richTxtResults.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(1260, 68);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(57, 19);
            this.lblResults.TabIndex = 94;
            this.lblResults.Text = "Results";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(721, 918);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 95;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(721, 889);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 96;
            this.buttonSave.Text = "Save file";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(802, 889);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveAs.TabIndex = 97;
            this.buttonSaveAs.Text = "Save file as";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(883, 889);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 98;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonExportWord
            // 
            this.buttonExportWord.Location = new System.Drawing.Point(964, 889);
            this.buttonExportWord.Name = "buttonExportWord";
            this.buttonExportWord.Size = new System.Drawing.Size(93, 23);
            this.buttonExportWord.TabIndex = 99;
            this.buttonExportWord.Text = "Export to Word";
            this.buttonExportWord.UseVisualStyleBackColor = true;
            this.buttonExportWord.Click += new System.EventHandler(this.buttonExportWord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1488, 953);
            this.Controls.Add(this.buttonExportWord);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.richTxtResults);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.dgvSoilProperties);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxGammaM);
            this.Controls.Add(this.richTextBoxRBK0);
            this.Controls.Add(this.txtGammaM);
            this.Controls.Add(this.txtA5);
            this.Controls.Add(this.txtA4);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.txtRBk0);
            this.Controls.Add(this.Label30);
            this.Controls.Add(this.Label29);
            this.Controls.Add(this.Label28);
            this.Controls.Add(this.Label27);
            this.Controls.Add(this.Label26);
            this.Controls.Add(this.lblgeotextile);
            this.Controls.Add(this.richTextBoxWeight);
            this.Controls.Add(this.richTextBoxShearStrength);
            this.Controls.Add(this.txtSpecificWeight);
            this.Controls.Add(this.txtEffectivShearStrength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColumnDistance);
            this.Controls.Add(this.lblColumnDistance);
            this.Controls.Add(this.txtPoissonRatio);
            this.Controls.Add(this.lblPoissonRatio);
            this.Controls.Add(this.richTextBoxColumRadius);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.richTextBoxLoad);
            this.Controls.Add(this.txtPowerOhde);
            this.Controls.Add(this.lblPowerOhde);
            this.Controls.Add(this.txtAtmosphericPressure);
            this.Controls.Add(this.lblAtmosphericPressure);
            this.Controls.Add(this.txtElongationStiffness);
            this.Controls.Add(this.lblElongationStiffness);
            this.Controls.Add(this.richTextBoxWideningActivation);
            this.Controls.Add(this.txtWideningActivation);
            this.Controls.Add(this.lblGridSelected);
            this.Controls.Add(this.txtConfigurationName);
            this.Controls.Add(this.lblConfigurationName);
            this.Controls.Add(this.txtColumnRadius);
            this.Controls.Add(this.txtAreaRatio);
            this.Controls.Add(this.lblAreaRatio);
            this.Controls.Add(this.pictureBoxColumnGrid);
            this.Controls.Add(this.lblSystemData);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblColumnGrid);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.comboBoxColumnGrid);
            this.Controls.Add(this.lblInputDataText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoilProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColumnGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblInputDataText;
        private System.Windows.Forms.Label lblColumnGrid;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblSystemData;
        private System.Windows.Forms.PictureBox pictureBoxColumnGrid;
        private System.Windows.Forms.Label lblAreaRatio;
        private System.Windows.Forms.Label lblConfigurationName;
        private System.Windows.Forms.Label lblGridSelected;
        private System.Windows.Forms.RichTextBox richTextBoxWideningActivation;
        private System.Windows.Forms.Label lblElongationStiffness;
        private System.Windows.Forms.Label lblAtmosphericPressure;
        private System.Windows.Forms.Label lblPowerOhde;
        private System.Windows.Forms.RichTextBox richTextBoxLoad;
        private System.Windows.Forms.RichTextBox richTextBoxColumRadius;
        private System.Windows.Forms.Label lblPoissonRatio;
        private System.Windows.Forms.Label lblColumnDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxShearStrength;
        private System.Windows.Forms.RichTextBox richTextBoxWeight;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label lblgeotextile;
        private System.Windows.Forms.RichTextBox richTextBoxRBK0;
        private System.Windows.Forms.RichTextBox richTextBoxGammaM;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Label Label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn layer;
        private System.Windows.Forms.DataGridViewTextBoxColumn refEModulLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveCohesionLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectiveShearStrengthLayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificWeightLayer;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        public System.Windows.Forms.RichTextBox richTxtResults;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonOpenFile;
        public System.Windows.Forms.TextBox txtConfigurationName;
        public System.Windows.Forms.ComboBox comboBoxColumnGrid;
        public System.Windows.Forms.ComboBox comboBoxMethod;
        public System.Windows.Forms.TextBox txtAreaRatio;
        public System.Windows.Forms.TextBox txtColumnRadius;
        public System.Windows.Forms.TextBox txtWideningActivation;
        public System.Windows.Forms.TextBox txtElongationStiffness;
        public System.Windows.Forms.TextBox txtAtmosphericPressure;
        public System.Windows.Forms.TextBox txtPowerOhde;
        public System.Windows.Forms.TextBox txtLoad;
        public System.Windows.Forms.TextBox txtPoissonRatio;
        public System.Windows.Forms.TextBox txtColumnDistance;
        public System.Windows.Forms.TextBox txtSpecificWeight;
        public System.Windows.Forms.TextBox txtEffectivShearStrength;
        public System.Windows.Forms.TextBox txtGammaM;
        public System.Windows.Forms.TextBox txtA5;
        public System.Windows.Forms.TextBox txtA4;
        public System.Windows.Forms.TextBox txtA3;
        public System.Windows.Forms.TextBox txtA2;
        public System.Windows.Forms.TextBox txtA1;
        public System.Windows.Forms.TextBox txtRBk0;
        public System.Windows.Forms.DataGridView dgvSoilProperties;
        public System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Button buttonExportWord;
    }
}

