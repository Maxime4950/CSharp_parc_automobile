namespace MAES_Maxime_projet_BD
{
    partial class EcranDesiderata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranDesiderata));
            this.label10 = new System.Windows.Forms.Label();
            this.cbNomCouleur = new System.Windows.Forms.ComboBox();
            this.cbNomCarburant = new System.Windows.Forms.ComboBox();
            this.cbNomCategorie = new System.Windows.Forms.ComboBox();
            this.btnConfirmerClientDesiderata = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbNomModele = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbIdClient = new System.Windows.Forms.TextBox();
            this.tbIdPrenomClient = new System.Windows.Forms.TextBox();
            this.pInfosClient = new System.Windows.Forms.Panel();
            this.dgvClientsDesiderata = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLocalite = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbBoite = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbIdNomClient = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.cbNomMarque = new System.Windows.Forms.ComboBox();
            this.tbIdCarburant = new System.Windows.Forms.TextBox();
            this.tbIdMarque = new System.Windows.Forms.TextBox();
            this.tbKilometrage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbIdCouleur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdCategorie = new System.Windows.Forms.TextBox();
            this.tbAnneeFabrication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdModele = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.tbIdCli = new System.Windows.Forms.TextBox();
            this.lblIdClient = new System.Windows.Forms.Label();
            this.lblIdDesiderata = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pInfosDesiderata = new System.Windows.Forms.Panel();
            this.btnConfirmerAjoutDesiderata = new System.Windows.Forms.Button();
            this.tbIdDesiderata = new System.Windows.Forms.TextBox();
            this.btnQuitterDesiderata = new System.Windows.Forms.Button();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btnEditerDesiderata = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnAjouterDesiderata = new System.Windows.Forms.Button();
            this.btnAnnulerDesiderata = new System.Windows.Forms.Button();
            this.btnConsulterDesiderata = new System.Windows.Forms.Button();
            this.btnSupprimerDesiderata = new System.Windows.Forms.Button();
            this.dgvDesideratas = new System.Windows.Forms.DataGridView();
            this.idDesiderata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometrageMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCouleur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarburant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnneeMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInfosClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsDesiderata)).BeginInit();
            this.pInfosDesiderata.SuspendLayout();
            this.pOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesideratas)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(44, 363);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 116;
            this.label10.Text = "ID Client";
            // 
            // cbNomCouleur
            // 
            this.cbNomCouleur.DisplayMember = "nomCouleur";
            this.cbNomCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomCouleur.FormattingEnabled = true;
            this.cbNomCouleur.Location = new System.Drawing.Point(334, 498);
            this.cbNomCouleur.Name = "cbNomCouleur";
            this.cbNomCouleur.Size = new System.Drawing.Size(130, 28);
            this.cbNomCouleur.TabIndex = 177;
            this.cbNomCouleur.ValueMember = "nomCouleur";
            this.cbNomCouleur.SelectedIndexChanged += new System.EventHandler(this.cbNomCouleur_SelectedIndexChanged);
            // 
            // cbNomCarburant
            // 
            this.cbNomCarburant.DisplayMember = "nomCarburant";
            this.cbNomCarburant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomCarburant.FormattingEnabled = true;
            this.cbNomCarburant.Location = new System.Drawing.Point(110, 501);
            this.cbNomCarburant.Name = "cbNomCarburant";
            this.cbNomCarburant.Size = new System.Drawing.Size(130, 28);
            this.cbNomCarburant.TabIndex = 176;
            this.cbNomCarburant.ValueMember = "nomCarburant";
            this.cbNomCarburant.SelectedIndexChanged += new System.EventHandler(this.cbNomCarburant_SelectedIndexChanged);
            // 
            // cbNomCategorie
            // 
            this.cbNomCategorie.DisplayMember = "nomCat";
            this.cbNomCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomCategorie.FormattingEnabled = true;
            this.cbNomCategorie.Location = new System.Drawing.Point(106, 371);
            this.cbNomCategorie.Name = "cbNomCategorie";
            this.cbNomCategorie.Size = new System.Drawing.Size(125, 28);
            this.cbNomCategorie.TabIndex = 175;
            this.cbNomCategorie.ValueMember = "nomCat";
            this.cbNomCategorie.SelectedIndexChanged += new System.EventHandler(this.cbNomCategorie_SelectedIndexChanged);
            // 
            // btnConfirmerClientDesiderata
            // 
            this.btnConfirmerClientDesiderata.AutoSize = true;
            this.btnConfirmerClientDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerClientDesiderata.Enabled = false;
            this.btnConfirmerClientDesiderata.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnConfirmerClientDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerClientDesiderata.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmerClientDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmerClientDesiderata.Image")));
            this.btnConfirmerClientDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmerClientDesiderata.Location = new System.Drawing.Point(44, 758);
            this.btnConfirmerClientDesiderata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmerClientDesiderata.Name = "btnConfirmerClientDesiderata";
            this.btnConfirmerClientDesiderata.Size = new System.Drawing.Size(642, 97);
            this.btnConfirmerClientDesiderata.TabIndex = 132;
            this.btnConfirmerClientDesiderata.Text = "C O N F I R M E R";
            this.btnConfirmerClientDesiderata.UseVisualStyleBackColor = false;
            this.btnConfirmerClientDesiderata.Click += new System.EventHandler(this.btnConfirmerClientDesiderata_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(44, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 24);
            this.label15.TabIndex = 122;
            this.label15.Text = "Rue";
            // 
            // cbNomModele
            // 
            this.cbNomModele.DisplayMember = "nomModele";
            this.cbNomModele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomModele.FormattingEnabled = true;
            this.cbNomModele.Location = new System.Drawing.Point(349, 258);
            this.cbNomModele.Name = "cbNomModele";
            this.cbNomModele.Size = new System.Drawing.Size(130, 28);
            this.cbNomModele.TabIndex = 174;
            this.cbNomModele.ValueMember = "nomMarque";
            this.cbNomModele.SelectedIndexChanged += new System.EventHandler(this.cbNomModele_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.GrayText;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(710, 70);
            this.label13.TabIndex = 133;
            this.label13.Text = "C L I E N T";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIdClient
            // 
            this.tbIdClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdClient.Location = new System.Drawing.Point(44, 400);
            this.tbIdClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdClient.Name = "tbIdClient";
            this.tbIdClient.ReadOnly = true;
            this.tbIdClient.Size = new System.Drawing.Size(81, 31);
            this.tbIdClient.TabIndex = 117;
            // 
            // tbIdPrenomClient
            // 
            this.tbIdPrenomClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPrenomClient.Location = new System.Drawing.Point(512, 400);
            this.tbIdPrenomClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdPrenomClient.Name = "tbIdPrenomClient";
            this.tbIdPrenomClient.ReadOnly = true;
            this.tbIdPrenomClient.Size = new System.Drawing.Size(125, 31);
            this.tbIdPrenomClient.TabIndex = 121;
            // 
            // pInfosClient
            // 
            this.pInfosClient.Controls.Add(this.dgvClientsDesiderata);
            this.pInfosClient.Controls.Add(this.label13);
            this.pInfosClient.Controls.Add(this.btnConfirmerClientDesiderata);
            this.pInfosClient.Controls.Add(this.label10);
            this.pInfosClient.Controls.Add(this.label15);
            this.pInfosClient.Controls.Add(this.tbIdClient);
            this.pInfosClient.Controls.Add(this.tbLocalite);
            this.pInfosClient.Controls.Add(this.label11);
            this.pInfosClient.Controls.Add(this.tbRue);
            this.pInfosClient.Controls.Add(this.tbBoite);
            this.pInfosClient.Controls.Add(this.label16);
            this.pInfosClient.Controls.Add(this.tbIdNomClient);
            this.pInfosClient.Controls.Add(this.label17);
            this.pInfosClient.Controls.Add(this.label19);
            this.pInfosClient.Controls.Add(this.tbIdPrenomClient);
            this.pInfosClient.Controls.Add(this.label18);
            this.pInfosClient.Controls.Add(this.tbCodePostal);
            this.pInfosClient.Controls.Add(this.label12);
            this.pInfosClient.Controls.Add(this.tbNumero);
            this.pInfosClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.pInfosClient.Location = new System.Drawing.Point(394, 377);
            this.pInfosClient.Name = "pInfosClient";
            this.pInfosClient.Size = new System.Drawing.Size(710, 933);
            this.pInfosClient.TabIndex = 138;
            // 
            // dgvClientsDesiderata
            // 
            this.dgvClientsDesiderata.AllowUserToAddRows = false;
            this.dgvClientsDesiderata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsDesiderata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvClientsDesiderata.ColumnHeadersHeight = 100;
            this.dgvClientsDesiderata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.prenom,
            this.rue,
            this.numero,
            this.boite,
            this.codePo,
            this.localite});
            this.dgvClientsDesiderata.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClientsDesiderata.Location = new System.Drawing.Point(0, 70);
            this.dgvClientsDesiderata.Name = "dgvClientsDesiderata";
            this.dgvClientsDesiderata.RowHeadersWidth = 40;
            this.dgvClientsDesiderata.RowTemplate.Height = 28;
            this.dgvClientsDesiderata.Size = new System.Drawing.Size(710, 270);
            this.dgvClientsDesiderata.TabIndex = 137;
            this.dgvClientsDesiderata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientsDesiderata_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idClient";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nomClient";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "prenomClient";
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // rue
            // 
            this.rue.DataPropertyName = "rueClient";
            this.rue.HeaderText = "Rue";
            this.rue.Name = "rue";
            this.rue.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numeroClient";
            this.numero.HeaderText = "Numéro";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // boite
            // 
            this.boite.DataPropertyName = "boiteClient";
            this.boite.HeaderText = "Boîte (*)";
            this.boite.Name = "boite";
            this.boite.ReadOnly = true;
            // 
            // codePo
            // 
            this.codePo.DataPropertyName = "codePoClient";
            this.codePo.HeaderText = "Code Postal";
            this.codePo.Name = "codePo";
            this.codePo.ReadOnly = true;
            // 
            // localite
            // 
            this.localite.DataPropertyName = "localiteClient";
            this.localite.HeaderText = "Localité";
            this.localite.Name = "localite";
            this.localite.ReadOnly = true;
            // 
            // tbLocalite
            // 
            this.tbLocalite.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalite.Location = new System.Drawing.Point(258, 619);
            this.tbLocalite.Name = "tbLocalite";
            this.tbLocalite.ReadOnly = true;
            this.tbLocalite.Size = new System.Drawing.Size(178, 31);
            this.tbLocalite.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(258, 363);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 24);
            this.label11.TabIndex = 118;
            this.label11.Text = "Nom Client";
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRue.Location = new System.Drawing.Point(44, 506);
            this.tbRue.Name = "tbRue";
            this.tbRue.ReadOnly = true;
            this.tbRue.Size = new System.Drawing.Size(178, 31);
            this.tbRue.TabIndex = 123;
            // 
            // tbBoite
            // 
            this.tbBoite.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoite.Location = new System.Drawing.Point(512, 503);
            this.tbBoite.Name = "tbBoite";
            this.tbBoite.ReadOnly = true;
            this.tbBoite.Size = new System.Drawing.Size(125, 31);
            this.tbBoite.TabIndex = 126;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(258, 585);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 24);
            this.label16.TabIndex = 131;
            this.label16.Text = "Localité";
            // 
            // tbIdNomClient
            // 
            this.tbIdNomClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdNomClient.Location = new System.Drawing.Point(259, 400);
            this.tbIdNomClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIdNomClient.Name = "tbIdNomClient";
            this.tbIdNomClient.ReadOnly = true;
            this.tbIdNomClient.Size = new System.Drawing.Size(177, 31);
            this.tbIdNomClient.TabIndex = 119;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(258, 469);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 24);
            this.label17.TabIndex = 124;
            this.label17.Text = "N°";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(508, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 24);
            this.label19.TabIndex = 128;
            this.label19.Text = "Boite (*)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(44, 585);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 24);
            this.label18.TabIndex = 130;
            this.label18.Text = "Code Postal";
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(48, 619);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.ReadOnly = true;
            this.tbCodePostal.Size = new System.Drawing.Size(128, 31);
            this.tbCodePostal.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(508, 363);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 24);
            this.label12.TabIndex = 120;
            this.label12.Text = "Prénom Client";
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(258, 503);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.ReadOnly = true;
            this.tbNumero.Size = new System.Drawing.Size(185, 31);
            this.tbNumero.TabIndex = 125;
            // 
            // cbNomMarque
            // 
            this.cbNomMarque.DisplayMember = "nomMarque";
            this.cbNomMarque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomMarque.FormattingEnabled = true;
            this.cbNomMarque.Location = new System.Drawing.Point(102, 261);
            this.cbNomMarque.Name = "cbNomMarque";
            this.cbNomMarque.Size = new System.Drawing.Size(130, 28);
            this.cbNomMarque.TabIndex = 173;
            this.cbNomMarque.ValueMember = "nomMarque";
            this.cbNomMarque.SelectedIndexChanged += new System.EventHandler(this.cbNomMarque_SelectedIndexChanged);
            // 
            // tbIdCarburant
            // 
            this.tbIdCarburant.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCarburant.Location = new System.Drawing.Point(54, 501);
            this.tbIdCarburant.Name = "tbIdCarburant";
            this.tbIdCarburant.ReadOnly = true;
            this.tbIdCarburant.Size = new System.Drawing.Size(27, 31);
            this.tbIdCarburant.TabIndex = 171;
            this.tbIdCarburant.Text = "1";
            // 
            // tbIdMarque
            // 
            this.tbIdMarque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdMarque.Location = new System.Drawing.Point(54, 263);
            this.tbIdMarque.Name = "tbIdMarque";
            this.tbIdMarque.ReadOnly = true;
            this.tbIdMarque.Size = new System.Drawing.Size(32, 31);
            this.tbIdMarque.TabIndex = 170;
            this.tbIdMarque.Text = "1";
            // 
            // tbKilometrage
            // 
            this.tbKilometrage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKilometrage.Location = new System.Drawing.Point(54, 622);
            this.tbKilometrage.Name = "tbKilometrage";
            this.tbKilometrage.Size = new System.Drawing.Size(158, 31);
            this.tbKilometrage.TabIndex = 169;
            this.tbKilometrage.TextChanged += new System.EventHandler(this.tbKilometrage_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(50, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 168;
            this.label5.Text = "Kilométrage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(50, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 163;
            this.label8.Text = "Carburant";
            // 
            // tbIdCouleur
            // 
            this.tbIdCouleur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCouleur.Location = new System.Drawing.Point(293, 498);
            this.tbIdCouleur.Name = "tbIdCouleur";
            this.tbIdCouleur.ReadOnly = true;
            this.tbIdCouleur.Size = new System.Drawing.Size(24, 31);
            this.tbIdCouleur.TabIndex = 167;
            this.tbIdCouleur.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(297, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 24);
            this.label7.TabIndex = 162;
            this.label7.Text = "Année de fabrication min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(297, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 166;
            this.label3.Text = "Couleur";
            // 
            // tbIdCategorie
            // 
            this.tbIdCategorie.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCategorie.Location = new System.Drawing.Point(54, 371);
            this.tbIdCategorie.Name = "tbIdCategorie";
            this.tbIdCategorie.ReadOnly = true;
            this.tbIdCategorie.Size = new System.Drawing.Size(30, 31);
            this.tbIdCategorie.TabIndex = 161;
            this.tbIdCategorie.Text = "1";
            // 
            // tbAnneeFabrication
            // 
            this.tbAnneeFabrication.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnneeFabrication.Location = new System.Drawing.Point(298, 367);
            this.tbAnneeFabrication.Name = "tbAnneeFabrication";
            this.tbAnneeFabrication.Size = new System.Drawing.Size(158, 31);
            this.tbAnneeFabrication.TabIndex = 165;
            this.tbAnneeFabrication.TextChanged += new System.EventHandler(this.tbAnneeFabrication_TextChanged);
            this.tbAnneeFabrication.Leave += new System.EventHandler(this.tbAnneeFabrication_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(50, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 160;
            this.label6.Text = "Catégorie";
            // 
            // tbIdModele
            // 
            this.tbIdModele.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdModele.Location = new System.Drawing.Point(301, 258);
            this.tbIdModele.Name = "tbIdModele";
            this.tbIdModele.ReadOnly = true;
            this.tbIdModele.Size = new System.Drawing.Size(32, 31);
            this.tbIdModele.TabIndex = 164;
            this.tbIdModele.Text = "1";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label32.Location = new System.Drawing.Point(50, 224);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 24);
            this.label32.TabIndex = 159;
            this.label32.Text = "Marque";
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl23.Location = new System.Drawing.Point(297, 224);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(74, 24);
            this.lbl23.TabIndex = 158;
            this.lbl23.Text = "Modèle";
            // 
            // tbIdCli
            // 
            this.tbIdCli.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCli.Location = new System.Drawing.Point(298, 136);
            this.tbIdCli.Name = "tbIdCli";
            this.tbIdCli.ReadOnly = true;
            this.tbIdCli.Size = new System.Drawing.Size(178, 31);
            this.tbIdCli.TabIndex = 153;
            // 
            // lblIdClient
            // 
            this.lblIdClient.AutoSize = true;
            this.lblIdClient.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIdClient.Location = new System.Drawing.Point(294, 103);
            this.lblIdClient.Name = "lblIdClient";
            this.lblIdClient.Size = new System.Drawing.Size(70, 20);
            this.lblIdClient.TabIndex = 152;
            this.lblIdClient.Text = "ID Client";
            // 
            // lblIdDesiderata
            // 
            this.lblIdDesiderata.AutoSize = true;
            this.lblIdDesiderata.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIdDesiderata.Location = new System.Drawing.Point(50, 103);
            this.lblIdDesiderata.Name = "lblIdDesiderata";
            this.lblIdDesiderata.Size = new System.Drawing.Size(108, 20);
            this.lblIdDesiderata.TabIndex = 150;
            this.lblIdDesiderata.Text = "ID Desiderata";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(733, 70);
            this.label2.TabIndex = 118;
            this.label2.Text = "D E S I D E R A T A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInfosDesiderata
            // 
            this.pInfosDesiderata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfosDesiderata.Controls.Add(this.btnConfirmerAjoutDesiderata);
            this.pInfosDesiderata.Controls.Add(this.cbNomCouleur);
            this.pInfosDesiderata.Controls.Add(this.cbNomCarburant);
            this.pInfosDesiderata.Controls.Add(this.cbNomCategorie);
            this.pInfosDesiderata.Controls.Add(this.cbNomModele);
            this.pInfosDesiderata.Controls.Add(this.cbNomMarque);
            this.pInfosDesiderata.Controls.Add(this.tbIdCarburant);
            this.pInfosDesiderata.Controls.Add(this.tbIdMarque);
            this.pInfosDesiderata.Controls.Add(this.tbKilometrage);
            this.pInfosDesiderata.Controls.Add(this.label5);
            this.pInfosDesiderata.Controls.Add(this.label8);
            this.pInfosDesiderata.Controls.Add(this.tbIdCouleur);
            this.pInfosDesiderata.Controls.Add(this.label7);
            this.pInfosDesiderata.Controls.Add(this.label3);
            this.pInfosDesiderata.Controls.Add(this.tbIdCategorie);
            this.pInfosDesiderata.Controls.Add(this.tbAnneeFabrication);
            this.pInfosDesiderata.Controls.Add(this.label6);
            this.pInfosDesiderata.Controls.Add(this.tbIdModele);
            this.pInfosDesiderata.Controls.Add(this.label32);
            this.pInfosDesiderata.Controls.Add(this.lbl23);
            this.pInfosDesiderata.Controls.Add(this.tbIdCli);
            this.pInfosDesiderata.Controls.Add(this.lblIdClient);
            this.pInfosDesiderata.Controls.Add(this.tbIdDesiderata);
            this.pInfosDesiderata.Controls.Add(this.lblIdDesiderata);
            this.pInfosDesiderata.Controls.Add(this.label2);
            this.pInfosDesiderata.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfosDesiderata.Location = new System.Drawing.Point(1104, 377);
            this.pInfosDesiderata.Name = "pInfosDesiderata";
            this.pInfosDesiderata.Size = new System.Drawing.Size(735, 978);
            this.pInfosDesiderata.TabIndex = 139;
            // 
            // btnConfirmerAjoutDesiderata
            // 
            this.btnConfirmerAjoutDesiderata.AutoSize = true;
            this.btnConfirmerAjoutDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerAjoutDesiderata.Enabled = false;
            this.btnConfirmerAjoutDesiderata.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.btnConfirmerAjoutDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerAjoutDesiderata.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnConfirmerAjoutDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmerAjoutDesiderata.Image")));
            this.btnConfirmerAjoutDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmerAjoutDesiderata.Location = new System.Drawing.Point(79, 757);
            this.btnConfirmerAjoutDesiderata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmerAjoutDesiderata.Name = "btnConfirmerAjoutDesiderata";
            this.btnConfirmerAjoutDesiderata.Size = new System.Drawing.Size(642, 97);
            this.btnConfirmerAjoutDesiderata.TabIndex = 178;
            this.btnConfirmerAjoutDesiderata.Text = "C O N F I R M E R";
            this.btnConfirmerAjoutDesiderata.UseVisualStyleBackColor = false;
            this.btnConfirmerAjoutDesiderata.Click += new System.EventHandler(this.btnConfirmerAjoutDesiderata_Click);
            // 
            // tbIdDesiderata
            // 
            this.tbIdDesiderata.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdDesiderata.Location = new System.Drawing.Point(54, 136);
            this.tbIdDesiderata.Name = "tbIdDesiderata";
            this.tbIdDesiderata.ReadOnly = true;
            this.tbIdDesiderata.Size = new System.Drawing.Size(178, 31);
            this.tbIdDesiderata.TabIndex = 151;
            // 
            // btnQuitterDesiderata
            // 
            this.btnQuitterDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterDesiderata.Image")));
            this.btnQuitterDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterDesiderata.Location = new System.Drawing.Point(40, 757);
            this.btnQuitterDesiderata.Name = "btnQuitterDesiderata";
            this.btnQuitterDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnQuitterDesiderata.TabIndex = 134;
            this.btnQuitterDesiderata.Text = "Q U I T T E R";
            this.btnQuitterDesiderata.UseVisualStyleBackColor = false;
            this.btnQuitterDesiderata.Click += new System.EventHandler(this.btnQuitterDesiderata_Click);
            // 
            // pOptions
            // 
            this.pOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptions.Controls.Add(this.btnEditerDesiderata);
            this.pOptions.Controls.Add(this.btnQuitterDesiderata);
            this.pOptions.Controls.Add(this.lblOptions);
            this.pOptions.Controls.Add(this.btnAjouterDesiderata);
            this.pOptions.Controls.Add(this.btnAnnulerDesiderata);
            this.pOptions.Controls.Add(this.btnConsulterDesiderata);
            this.pOptions.Controls.Add(this.btnSupprimerDesiderata);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptions.Location = new System.Drawing.Point(0, 377);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(394, 933);
            this.pOptions.TabIndex = 136;
            // 
            // btnEditerDesiderata
            // 
            this.btnEditerDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditerDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditerDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnEditerDesiderata.Image")));
            this.btnEditerDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditerDesiderata.Location = new System.Drawing.Point(40, 368);
            this.btnEditerDesiderata.Name = "btnEditerDesiderata";
            this.btnEditerDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnEditerDesiderata.TabIndex = 135;
            this.btnEditerDesiderata.Text = "E D I T E R";
            this.btnEditerDesiderata.UseVisualStyleBackColor = false;
            this.btnEditerDesiderata.Click += new System.EventHandler(this.btnEditerDesiderata_Click);
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
            // btnAjouterDesiderata
            // 
            this.btnAjouterDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterDesiderata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAjouterDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterDesiderata.Image")));
            this.btnAjouterDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDesiderata.Location = new System.Drawing.Point(40, 103);
            this.btnAjouterDesiderata.Name = "btnAjouterDesiderata";
            this.btnAjouterDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnAjouterDesiderata.TabIndex = 130;
            this.btnAjouterDesiderata.Text = "A J O U T ";
            this.btnAjouterDesiderata.UseVisualStyleBackColor = false;
            this.btnAjouterDesiderata.Click += new System.EventHandler(this.btnAjouterDesiderata_Click);
            // 
            // btnAnnulerDesiderata
            // 
            this.btnAnnulerDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerDesiderata.Image")));
            this.btnAnnulerDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerDesiderata.Location = new System.Drawing.Point(40, 624);
            this.btnAnnulerDesiderata.Name = "btnAnnulerDesiderata";
            this.btnAnnulerDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnAnnulerDesiderata.TabIndex = 133;
            this.btnAnnulerDesiderata.Text = "A N N U L E R";
            this.btnAnnulerDesiderata.UseVisualStyleBackColor = false;
            this.btnAnnulerDesiderata.Click += new System.EventHandler(this.btnAnnulerDesiderata_Click);
            // 
            // btnConsulterDesiderata
            // 
            this.btnConsulterDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulterDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulterDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterDesiderata.Image")));
            this.btnConsulterDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulterDesiderata.Location = new System.Drawing.Point(40, 234);
            this.btnConsulterDesiderata.Name = "btnConsulterDesiderata";
            this.btnConsulterDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnConsulterDesiderata.TabIndex = 131;
            this.btnConsulterDesiderata.Text = "C O N S U L T E R";
            this.btnConsulterDesiderata.UseVisualStyleBackColor = false;
            this.btnConsulterDesiderata.Click += new System.EventHandler(this.btnConsulterDesiderata_Click);
            // 
            // btnSupprimerDesiderata
            // 
            this.btnSupprimerDesiderata.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerDesiderata.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerDesiderata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerDesiderata.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerDesiderata.Image")));
            this.btnSupprimerDesiderata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerDesiderata.Location = new System.Drawing.Point(40, 497);
            this.btnSupprimerDesiderata.Name = "btnSupprimerDesiderata";
            this.btnSupprimerDesiderata.Size = new System.Drawing.Size(314, 97);
            this.btnSupprimerDesiderata.TabIndex = 132;
            this.btnSupprimerDesiderata.Text = "S U P P R I M E R";
            this.btnSupprimerDesiderata.UseVisualStyleBackColor = false;
            this.btnSupprimerDesiderata.Click += new System.EventHandler(this.btnSupprimerDesiderata_Click);
            // 
            // dgvDesideratas
            // 
            this.dgvDesideratas.AllowUserToAddRows = false;
            this.dgvDesideratas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesideratas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDesideratas.ColumnHeadersHeight = 100;
            this.dgvDesideratas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDesiderata,
            this.idClient,
            this.idMarque,
            this.idModele,
            this.idCat,
            this.kilometrageMax,
            this.idCouleur,
            this.idCarburant,
            this.AnneeMin});
            this.dgvDesideratas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDesideratas.Location = new System.Drawing.Point(0, 0);
            this.dgvDesideratas.Name = "dgvDesideratas";
            this.dgvDesideratas.RowHeadersWidth = 40;
            this.dgvDesideratas.RowTemplate.Height = 28;
            this.dgvDesideratas.Size = new System.Drawing.Size(1839, 377);
            this.dgvDesideratas.TabIndex = 140;
            // 
            // idDesiderata
            // 
            this.idDesiderata.HeaderText = "ID Desiderata";
            this.idDesiderata.Name = "idDesiderata";
            this.idDesiderata.ReadOnly = true;
            // 
            // idClient
            // 
            this.idClient.HeaderText = "ID Client";
            this.idClient.Name = "idClient";
            this.idClient.ReadOnly = true;
            // 
            // idMarque
            // 
            this.idMarque.HeaderText = "ID Marque";
            this.idMarque.Name = "idMarque";
            this.idMarque.ReadOnly = true;
            // 
            // idModele
            // 
            this.idModele.HeaderText = "ID Modèle";
            this.idModele.Name = "idModele";
            this.idModele.ReadOnly = true;
            // 
            // idCat
            // 
            this.idCat.HeaderText = "ID Catégorie";
            this.idCat.Name = "idCat";
            this.idCat.ReadOnly = true;
            // 
            // kilometrageMax
            // 
            this.kilometrageMax.HeaderText = "Kilométrage Max";
            this.kilometrageMax.Name = "kilometrageMax";
            this.kilometrageMax.ReadOnly = true;
            // 
            // idCouleur
            // 
            this.idCouleur.HeaderText = "ID Couleur";
            this.idCouleur.Name = "idCouleur";
            this.idCouleur.ReadOnly = true;
            // 
            // idCarburant
            // 
            this.idCarburant.HeaderText = "ID Carburant";
            this.idCarburant.Name = "idCarburant";
            this.idCarburant.ReadOnly = true;
            // 
            // AnneeMin
            // 
            this.AnneeMin.HeaderText = "Année de fabrication minimum";
            this.AnneeMin.Name = "AnneeMin";
            this.AnneeMin.ReadOnly = true;
            // 
            // EcranDesiderata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 1310);
            this.Controls.Add(this.pInfosDesiderata);
            this.Controls.Add(this.pInfosClient);
            this.Controls.Add(this.pOptions);
            this.Controls.Add(this.dgvDesideratas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranDesiderata";
            this.Text = "ficDesiderata";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranDesiderata_FormClosed);
            this.Load += new System.EventHandler(this.EcranDesiderata_Load);
            this.pInfosClient.ResumeLayout(false);
            this.pInfosClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsDesiderata)).EndInit();
            this.pInfosDesiderata.ResumeLayout(false);
            this.pInfosDesiderata.PerformLayout();
            this.pOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesideratas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbNomCouleur;
        private System.Windows.Forms.ComboBox cbNomCarburant;
        private System.Windows.Forms.ComboBox cbNomCategorie;
        private System.Windows.Forms.Button btnConfirmerClientDesiderata;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbNomModele;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbIdClient;
        private System.Windows.Forms.TextBox tbIdPrenomClient;
        private System.Windows.Forms.Panel pInfosClient;
        private System.Windows.Forms.TextBox tbLocalite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbBoite;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbIdNomClient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.ComboBox cbNomMarque;
        private System.Windows.Forms.TextBox tbIdCarburant;
        private System.Windows.Forms.TextBox tbIdMarque;
        private System.Windows.Forms.TextBox tbKilometrage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbIdCouleur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdCategorie;
        private System.Windows.Forms.TextBox tbAnneeFabrication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdModele;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.TextBox tbIdCli;
        private System.Windows.Forms.Label lblIdClient;
        private System.Windows.Forms.Label lblIdDesiderata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pInfosDesiderata;
        private System.Windows.Forms.TextBox tbIdDesiderata;
        private System.Windows.Forms.Button btnQuitterDesiderata;
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Button btnEditerDesiderata;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnAjouterDesiderata;
        private System.Windows.Forms.Button btnAnnulerDesiderata;
        private System.Windows.Forms.Button btnConsulterDesiderata;
        private System.Windows.Forms.Button btnSupprimerDesiderata;
        private System.Windows.Forms.DataGridView dgvClientsDesiderata;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn boite;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePo;
        private System.Windows.Forms.DataGridViewTextBoxColumn localite;
        private System.Windows.Forms.DataGridView dgvDesideratas;
        private System.Windows.Forms.Button btnConfirmerAjoutDesiderata;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDesiderata;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometrageMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCouleur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarburant;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnneeMin;
    }
}