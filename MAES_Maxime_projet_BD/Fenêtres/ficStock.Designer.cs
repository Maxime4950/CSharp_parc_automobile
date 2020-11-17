namespace MAES_Maxime_projet_BD
{
    partial class EcranStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranStock));
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pInfoStock = new System.Windows.Forms.Panel();
            this.tbNomCarburantStock = new System.Windows.Forms.TextBox();
            this.tbIdCarburantStock = new System.Windows.Forms.TextBox();
            this.tbNomCouleurStock = new System.Windows.Forms.TextBox();
            this.tbNomCategorieStock = new System.Windows.Forms.TextBox();
            this.tbNomModeleStock = new System.Windows.Forms.TextBox();
            this.tbNomMarqueStock = new System.Windows.Forms.TextBox();
            this.tbIdMarqueStock = new System.Windows.Forms.TextBox();
            this.tbKilometrageStock = new System.Windows.Forms.TextBox();
            this.tbIdVoitureStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIdCouleurStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdCategorieStock = new System.Windows.Forms.TextBox();
            this.tbAnneeFabricationStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdModeleStock = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.pOptionsStock = new System.Windows.Forms.Panel();
            this.btnQuitterStock = new System.Windows.Forms.Button();
            this.btnAnnulerStock = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnConsulterStock = new System.Windows.Forms.Button();
            this.btnConsulterStockHtml = new System.Windows.Forms.Button();
            this.btnSupprimerStock = new System.Windows.Forms.Button();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFond = new System.Windows.Forms.Panel();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.idVoiture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneFabr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCouleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyHTMLReports1 = new KimToo.EasyHTMLReports(this.components);
            this.panel2.SuspendLayout();
            this.pInfoStock.SuspendLayout();
            this.pOptionsStock.SuspendLayout();
            this.pFond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "nomClient";
            this.nomClient.HeaderText = "Nom";
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1375, 69);
            this.label7.TabIndex = 57;
            this.label7.Text = "I N F O R M A T I O N S";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boiteClient
            // 
            this.boiteClient.DataPropertyName = "boiteClient";
            this.boiteClient.HeaderText = "Numéro Boîte";
            this.boiteClient.Name = "boiteClient";
            this.boiteClient.ReadOnly = true;
            this.boiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfoStock);
            this.panel2.Controls.Add(this.pOptionsStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1771, 708);
            this.panel2.TabIndex = 63;
            // 
            // pInfoStock
            // 
            this.pInfoStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoStock.Controls.Add(this.tbNomCarburantStock);
            this.pInfoStock.Controls.Add(this.tbIdCarburantStock);
            this.pInfoStock.Controls.Add(this.tbNomCouleurStock);
            this.pInfoStock.Controls.Add(this.tbNomCategorieStock);
            this.pInfoStock.Controls.Add(this.tbNomModeleStock);
            this.pInfoStock.Controls.Add(this.tbNomMarqueStock);
            this.pInfoStock.Controls.Add(this.tbIdMarqueStock);
            this.pInfoStock.Controls.Add(this.tbKilometrageStock);
            this.pInfoStock.Controls.Add(this.tbIdVoitureStock);
            this.pInfoStock.Controls.Add(this.label5);
            this.pInfoStock.Controls.Add(this.label8);
            this.pInfoStock.Controls.Add(this.tbIdCouleurStock);
            this.pInfoStock.Controls.Add(this.label1);
            this.pInfoStock.Controls.Add(this.label3);
            this.pInfoStock.Controls.Add(this.tbIdCategorieStock);
            this.pInfoStock.Controls.Add(this.tbAnneeFabricationStock);
            this.pInfoStock.Controls.Add(this.label4);
            this.pInfoStock.Controls.Add(this.tbIdModeleStock);
            this.pInfoStock.Controls.Add(this.label32);
            this.pInfoStock.Controls.Add(this.label6);
            this.pInfoStock.Controls.Add(this.lbl23);
            this.pInfoStock.Controls.Add(this.label7);
            this.pInfoStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoStock.Location = new System.Drawing.Point(394, 0);
            this.pInfoStock.Name = "pInfoStock";
            this.pInfoStock.Size = new System.Drawing.Size(1377, 708);
            this.pInfoStock.TabIndex = 64;
            // 
            // tbNomCarburantStock
            // 
            this.tbNomCarburantStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCarburantStock.Location = new System.Drawing.Point(148, 487);
            this.tbNomCarburantStock.Name = "tbNomCarburantStock";
            this.tbNomCarburantStock.ReadOnly = true;
            this.tbNomCarburantStock.Size = new System.Drawing.Size(141, 29);
            this.tbNomCarburantStock.TabIndex = 120;
            // 
            // tbIdCarburantStock
            // 
            this.tbIdCarburantStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCarburantStock.Location = new System.Drawing.Point(34, 487);
            this.tbIdCarburantStock.Name = "tbIdCarburantStock";
            this.tbIdCarburantStock.ReadOnly = true;
            this.tbIdCarburantStock.Size = new System.Drawing.Size(68, 29);
            this.tbIdCarburantStock.TabIndex = 119;
            // 
            // tbNomCouleurStock
            // 
            this.tbNomCouleurStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCouleurStock.Location = new System.Drawing.Point(162, 618);
            this.tbNomCouleurStock.Name = "tbNomCouleurStock";
            this.tbNomCouleurStock.ReadOnly = true;
            this.tbNomCouleurStock.Size = new System.Drawing.Size(126, 29);
            this.tbNomCouleurStock.TabIndex = 118;
            // 
            // tbNomCategorieStock
            // 
            this.tbNomCategorieStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCategorieStock.Location = new System.Drawing.Point(167, 365);
            this.tbNomCategorieStock.Name = "tbNomCategorieStock";
            this.tbNomCategorieStock.ReadOnly = true;
            this.tbNomCategorieStock.Size = new System.Drawing.Size(121, 29);
            this.tbNomCategorieStock.TabIndex = 117;
            // 
            // tbNomModeleStock
            // 
            this.tbNomModeleStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomModeleStock.Location = new System.Drawing.Point(469, 236);
            this.tbNomModeleStock.Name = "tbNomModeleStock";
            this.tbNomModeleStock.ReadOnly = true;
            this.tbNomModeleStock.Size = new System.Drawing.Size(138, 29);
            this.tbNomModeleStock.TabIndex = 116;
            // 
            // tbNomMarqueStock
            // 
            this.tbNomMarqueStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomMarqueStock.Location = new System.Drawing.Point(140, 235);
            this.tbNomMarqueStock.Name = "tbNomMarqueStock";
            this.tbNomMarqueStock.ReadOnly = true;
            this.tbNomMarqueStock.Size = new System.Drawing.Size(143, 29);
            this.tbNomMarqueStock.TabIndex = 115;
            // 
            // tbIdMarqueStock
            // 
            this.tbIdMarqueStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdMarqueStock.Location = new System.Drawing.Point(29, 236);
            this.tbIdMarqueStock.Name = "tbIdMarqueStock";
            this.tbIdMarqueStock.ReadOnly = true;
            this.tbIdMarqueStock.Size = new System.Drawing.Size(66, 29);
            this.tbIdMarqueStock.TabIndex = 114;
            // 
            // tbKilometrageStock
            // 
            this.tbKilometrageStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilometrageStock.Location = new System.Drawing.Point(345, 618);
            this.tbKilometrageStock.Name = "tbKilometrageStock";
            this.tbKilometrageStock.ReadOnly = true;
            this.tbKilometrageStock.Size = new System.Drawing.Size(158, 29);
            this.tbKilometrageStock.TabIndex = 113;
            // 
            // tbIdVoitureStock
            // 
            this.tbIdVoitureStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdVoitureStock.Location = new System.Drawing.Point(27, 124);
            this.tbIdVoitureStock.Name = "tbIdVoitureStock";
            this.tbIdVoitureStock.ReadOnly = true;
            this.tbIdVoitureStock.Size = new System.Drawing.Size(81, 29);
            this.tbIdVoitureStock.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(341, 566);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 112;
            this.label5.Text = "Kilométrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(30, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 106;
            this.label8.Text = "Carburant";
            // 
            // tbIdCouleurStock
            // 
            this.tbIdCouleurStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCouleurStock.Location = new System.Drawing.Point(32, 618);
            this.tbIdCouleurStock.Name = "tbIdCouleurStock";
            this.tbIdCouleurStock.ReadOnly = true;
            this.tbIdCouleurStock.Size = new System.Drawing.Size(84, 29);
            this.tbIdCouleurStock.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(347, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 105;
            this.label1.Text = "Année de fabrication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(30, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 110;
            this.label3.Text = "Couleur";
            // 
            // tbIdCategorieStock
            // 
            this.tbIdCategorieStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCategorieStock.Location = new System.Drawing.Point(30, 365);
            this.tbIdCategorieStock.Name = "tbIdCategorieStock";
            this.tbIdCategorieStock.ReadOnly = true;
            this.tbIdCategorieStock.Size = new System.Drawing.Size(84, 29);
            this.tbIdCategorieStock.TabIndex = 104;
            // 
            // tbAnneeFabricationStock
            // 
            this.tbAnneeFabricationStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnneeFabricationStock.Location = new System.Drawing.Point(351, 365);
            this.tbAnneeFabricationStock.Name = "tbAnneeFabricationStock";
            this.tbAnneeFabricationStock.ReadOnly = true;
            this.tbAnneeFabricationStock.Size = new System.Drawing.Size(256, 29);
            this.tbAnneeFabricationStock.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(30, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 103;
            this.label4.Text = "Catégorie";
            // 
            // tbIdModeleStock
            // 
            this.tbIdModeleStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdModeleStock.Location = new System.Drawing.Point(351, 236);
            this.tbIdModeleStock.Name = "tbIdModeleStock";
            this.tbIdModeleStock.ReadOnly = true;
            this.tbIdModeleStock.Size = new System.Drawing.Size(68, 29);
            this.tbIdModeleStock.TabIndex = 108;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label32.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(25, 197);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(69, 24);
            this.label32.TabIndex = 101;
            this.label32.Text = "Marque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(27, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 107;
            this.label6.Text = "ID Voiture";
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl23.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl23.Location = new System.Drawing.Point(351, 197);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(68, 24);
            this.lbl23.TabIndex = 100;
            this.lbl23.Text = "Modèle";
            // 
            // pOptionsStock
            // 
            this.pOptionsStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptionsStock.Controls.Add(this.btnQuitterStock);
            this.pOptionsStock.Controls.Add(this.btnAnnulerStock);
            this.pOptionsStock.Controls.Add(this.lblOptions);
            this.pOptionsStock.Controls.Add(this.btnConsulterStock);
            this.pOptionsStock.Controls.Add(this.btnConsulterStockHtml);
            this.pOptionsStock.Controls.Add(this.btnSupprimerStock);
            this.pOptionsStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptionsStock.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptionsStock.Location = new System.Drawing.Point(0, 0);
            this.pOptionsStock.Name = "pOptionsStock";
            this.pOptionsStock.Size = new System.Drawing.Size(394, 708);
            this.pOptionsStock.TabIndex = 63;
            // 
            // btnQuitterStock
            // 
            this.btnQuitterStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterStock.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterStock.Image")));
            this.btnQuitterStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterStock.Location = new System.Drawing.Point(11, 548);
            this.btnQuitterStock.Name = "btnQuitterStock";
            this.btnQuitterStock.Size = new System.Drawing.Size(360, 85);
            this.btnQuitterStock.TabIndex = 58;
            this.btnQuitterStock.Text = "Q U I T T E R";
            this.btnQuitterStock.UseVisualStyleBackColor = false;
            this.btnQuitterStock.Click += new System.EventHandler(this.btnQuitterStock_Click);
            // 
            // btnAnnulerStock
            // 
            this.btnAnnulerStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerStock.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerStock.Image")));
            this.btnAnnulerStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerStock.Location = new System.Drawing.Point(10, 437);
            this.btnAnnulerStock.Name = "btnAnnulerStock";
            this.btnAnnulerStock.Size = new System.Drawing.Size(360, 85);
            this.btnAnnulerStock.TabIndex = 38;
            this.btnAnnulerStock.Text = "A N N U L E R";
            this.btnAnnulerStock.UseVisualStyleBackColor = false;
            this.btnAnnulerStock.Click += new System.EventHandler(this.btnAnnulerStock_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOptions.Location = new System.Drawing.Point(0, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(392, 69);
            this.lblOptions.TabIndex = 57;
            this.lblOptions.Text = "O P T I O N S";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConsulterStock
            // 
            this.btnConsulterStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulterStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulterStock.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterStock.Image")));
            this.btnConsulterStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulterStock.Location = new System.Drawing.Point(11, 86);
            this.btnConsulterStock.Name = "btnConsulterStock";
            this.btnConsulterStock.Size = new System.Drawing.Size(360, 85);
            this.btnConsulterStock.TabIndex = 36;
            this.btnConsulterStock.Text = "C O N S U L T E R";
            this.btnConsulterStock.UseVisualStyleBackColor = false;
            this.btnConsulterStock.Click += new System.EventHandler(this.btnConsulterStock_Click);
            // 
            // btnConsulterStockHtml
            // 
            this.btnConsulterStockHtml.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulterStockHtml.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterStockHtml.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulterStockHtml.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterStockHtml.Image")));
            this.btnConsulterStockHtml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulterStockHtml.Location = new System.Drawing.Point(11, 208);
            this.btnConsulterStockHtml.Name = "btnConsulterStockHtml";
            this.btnConsulterStockHtml.Size = new System.Drawing.Size(359, 85);
            this.btnConsulterStockHtml.TabIndex = 39;
            this.btnConsulterStockHtml.Text = "C O N S U L T E R\r\nH T M L\r\n";
            this.btnConsulterStockHtml.UseVisualStyleBackColor = false;
            this.btnConsulterStockHtml.Click += new System.EventHandler(this.btnConsulterStockHtml_Click);
            // 
            // btnSupprimerStock
            // 
            this.btnSupprimerStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerStock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerStock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerStock.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerStock.Image")));
            this.btnSupprimerStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerStock.Location = new System.Drawing.Point(11, 326);
            this.btnSupprimerStock.Name = "btnSupprimerStock";
            this.btnSupprimerStock.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerStock.TabIndex = 37;
            this.btnSupprimerStock.Text = "S U P P R I M E R";
            this.btnSupprimerStock.UseVisualStyleBackColor = false;
            this.btnSupprimerStock.Click += new System.EventHandler(this.btnSupprimerStock_Click);
            // 
            // prenomClient
            // 
            this.prenomClient.DataPropertyName = "prenomClient";
            this.prenomClient.HeaderText = "Prénom";
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.ReadOnly = true;
            this.prenomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvStock);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1771, 1311);
            this.pFond.TabIndex = 2;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStock.ColumnHeadersHeight = 100;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVoiture,
            this.idMarque,
            this.idModele,
            this.idCategorie,
            this.anneFabr,
            this.idCarburant,
            this.idCouleur,
            this.kilometrage});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStock.Location = new System.Drawing.Point(0, 0);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 40;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(1771, 603);
            this.dgvStock.TabIndex = 62;
            // 
            // idVoiture
            // 
            this.idVoiture.HeaderText = "ID Voiture";
            this.idVoiture.Name = "idVoiture";
            this.idVoiture.ReadOnly = true;
            // 
            // idMarque
            // 
            this.idMarque.HeaderText = "ID Marque";
            this.idMarque.Name = "idMarque";
            this.idMarque.ReadOnly = true;
            // 
            // idModele
            // 
            this.idModele.HeaderText = "ID Modele";
            this.idModele.Name = "idModele";
            this.idModele.ReadOnly = true;
            // 
            // idCategorie
            // 
            this.idCategorie.HeaderText = "ID Categorie";
            this.idCategorie.Name = "idCategorie";
            this.idCategorie.ReadOnly = true;
            // 
            // anneFabr
            // 
            this.anneFabr.HeaderText = "Année de fabrication";
            this.anneFabr.Name = "anneFabr";
            this.anneFabr.ReadOnly = true;
            // 
            // idCarburant
            // 
            this.idCarburant.HeaderText = "ID Carburant";
            this.idCarburant.Name = "idCarburant";
            this.idCarburant.ReadOnly = true;
            // 
            // idCouleur
            // 
            this.idCouleur.HeaderText = "ID Couleur";
            this.idCouleur.Name = "idCouleur";
            this.idCouleur.ReadOnly = true;
            // 
            // kilometrage
            // 
            this.kilometrage.HeaderText = "Kilométrage";
            this.kilometrage.Name = "kilometrage";
            this.kilometrage.ReadOnly = true;
            // 
            // rueClient
            // 
            this.rueClient.DataPropertyName = "rueClient";
            this.rueClient.HeaderText = "Rue";
            this.rueClient.Name = "rueClient";
            this.rueClient.ReadOnly = true;
            this.rueClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // localiteClient
            // 
            this.localiteClient.DataPropertyName = "localiteClient";
            this.localiteClient.HeaderText = "Localité";
            this.localiteClient.Name = "localiteClient";
            this.localiteClient.ReadOnly = true;
            this.localiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numeroClient
            // 
            this.numeroClient.DataPropertyName = "numeroClient";
            this.numeroClient.HeaderText = "Numéro";
            this.numeroClient.Name = "numeroClient";
            this.numeroClient.ReadOnly = true;
            this.numeroClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // codePoClient
            // 
            this.codePoClient.DataPropertyName = "codePoClient";
            this.codePoClient.HeaderText = "Code Postal";
            this.codePoClient.Name = "codePoClient";
            this.codePoClient.ReadOnly = true;
            this.codePoClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // easyHTMLReports1
            // 
            this.easyHTMLReports1.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyHTMLReports1.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.easyHTMLReports1.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyHTMLReports1.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyHTMLReports1.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyHTMLReports1.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // EcranStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1771, 1311);
            this.Controls.Add(this.pFond);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranStock";
            this.Text = "ficStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranStock_FormClosed);
            this.Load += new System.EventHandler(this.EcranStock_Load);
            this.panel2.ResumeLayout(false);
            this.pInfoStock.ResumeLayout(false);
            this.pInfoStock.PerformLayout();
            this.pOptionsStock.ResumeLayout(false);
            this.pFond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pInfoStock;
        private System.Windows.Forms.Panel pOptionsStock;
        private System.Windows.Forms.Button btnQuitterStock;
        private System.Windows.Forms.Button btnAnnulerStock;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnConsulterStockHtml;
        private System.Windows.Forms.Button btnSupprimerStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.Button btnConsulterStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoiture;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneFabr;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCouleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrage;
        private System.Windows.Forms.TextBox tbNomCarburantStock;
        private System.Windows.Forms.TextBox tbIdCarburantStock;
        private System.Windows.Forms.TextBox tbNomCouleurStock;
        private System.Windows.Forms.TextBox tbNomCategorieStock;
        private System.Windows.Forms.TextBox tbNomModeleStock;
        private System.Windows.Forms.TextBox tbNomMarqueStock;
        private System.Windows.Forms.TextBox tbIdMarqueStock;
        private System.Windows.Forms.TextBox tbKilometrageStock;
        private System.Windows.Forms.TextBox tbIdVoitureStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIdCouleurStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdCategorieStock;
        private System.Windows.Forms.TextBox tbAnneeFabricationStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdModeleStock;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl23;
        private KimToo.EasyHTMLReports easyHTMLReports1;
    }
}