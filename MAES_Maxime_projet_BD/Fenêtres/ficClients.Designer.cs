namespace MAES_Maxime_projet_BD
{
    partial class EcranClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranClients));
            this.label3 = new System.Windows.Forms.Label();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnEditerClient = new System.Windows.Forms.Button();
            this.btnConfirmerAjout = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbBoite = new System.Windows.Forms.TextBox();
            this.boite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.pFond = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLocalite = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.pFond.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(332, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Boite (*)";
            // 
            // pOptions
            // 
            this.pOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptions.Controls.Add(this.btnAjouterClient);
            this.pOptions.Controls.Add(this.btnQuitter);
            this.pOptions.Controls.Add(this.btnAnnuler);
            this.pOptions.Controls.Add(this.lblOptions);
            this.pOptions.Controls.Add(this.btnEditerClient);
            this.pOptions.Controls.Add(this.btnConfirmerAjout);
            this.pOptions.Controls.Add(this.btnSupprimerClient);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptions.Location = new System.Drawing.Point(0, 0);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(394, 766);
            this.pOptions.TabIndex = 63;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAjouterClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterClient.Image")));
            this.btnAjouterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterClient.Location = new System.Drawing.Point(10, 86);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(360, 85);
            this.btnAjouterClient.TabIndex = 59;
            this.btnAjouterClient.Text = "A J O U T ";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(10, 626);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(360, 85);
            this.btnQuitter.TabIndex = 58;
            this.btnQuitter.Text = "Q U I T T E R";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(10, 398);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(360, 85);
            this.btnAnnuler.TabIndex = 38;
            this.btnAnnuler.Text = "A N N U L E R";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
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
            // btnEditerClient
            // 
            this.btnEditerClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditerClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditerClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEditerClient.Image")));
            this.btnEditerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditerClient.Location = new System.Drawing.Point(10, 189);
            this.btnEditerClient.Name = "btnEditerClient";
            this.btnEditerClient.Size = new System.Drawing.Size(360, 85);
            this.btnEditerClient.TabIndex = 36;
            this.btnEditerClient.Text = "E D I T E R";
            this.btnEditerClient.UseVisualStyleBackColor = false;
            this.btnEditerClient.Click += new System.EventHandler(this.btnEditerClient_Click);
            // 
            // btnConfirmerAjout
            // 
            this.btnConfirmerAjout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerAjout.Enabled = false;
            this.btnConfirmerAjout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerAjout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmerAjout.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmerAjout.Image")));
            this.btnConfirmerAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmerAjout.Location = new System.Drawing.Point(10, 512);
            this.btnConfirmerAjout.Name = "btnConfirmerAjout";
            this.btnConfirmerAjout.Size = new System.Drawing.Size(360, 85);
            this.btnConfirmerAjout.TabIndex = 39;
            this.btnConfirmerAjout.Text = "C O N F I R M E R";
            this.btnConfirmerAjout.UseVisualStyleBackColor = false;
            this.btnConfirmerAjout.Click += new System.EventHandler(this.btnConfirmerAjout_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerClient.Image")));
            this.btnSupprimerClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerClient.Location = new System.Drawing.Point(10, 289);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerClient.TabIndex = 37;
            this.btnSupprimerClient.Text = "S U P P R I M E R";
            this.btnSupprimerClient.UseVisualStyleBackColor = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // tbBoite
            // 
            this.tbBoite.Location = new System.Drawing.Point(330, 468);
            this.tbBoite.Name = "tbBoite";
            this.tbBoite.Size = new System.Drawing.Size(258, 29);
            this.tbBoite.TabIndex = 45;
            this.tbBoite.TextChanged += new System.EventHandler(this.tbBoite_TextChanged);
            // 
            // boite
            // 
            this.boite.DataPropertyName = "boiteClient";
            this.boite.HeaderText = "Boîte (*)";
            this.boite.Name = "boite";
            this.boite.ReadOnly = true;
            // 
            // localite
            // 
            this.localite.DataPropertyName = "localiteClient";
            this.localite.HeaderText = "Localité";
            this.localite.Name = "localite";
            this.localite.ReadOnly = true;
            // 
            // localiteClient
            // 
            this.localiteClient.DataPropertyName = "localiteClient";
            this.localiteClient.HeaderText = "Localité";
            this.localiteClient.Name = "localiteClient";
            this.localiteClient.ReadOnly = true;
            this.localiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // codePoClient
            // 
            this.codePoClient.DataPropertyName = "codePoClient";
            this.codePoClient.HeaderText = "Code Postal";
            this.codePoClient.Name = "codePoClient";
            this.codePoClient.ReadOnly = true;
            this.codePoClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // numeroClient
            // 
            this.numeroClient.DataPropertyName = "numeroClient";
            this.numeroClient.HeaderText = "Numéro";
            this.numeroClient.Name = "numeroClient";
            this.numeroClient.ReadOnly = true;
            this.numeroClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rueClient
            // 
            this.rueClient.DataPropertyName = "rueClient";
            this.rueClient.HeaderText = "Rue";
            this.rueClient.Name = "rueClient";
            this.rueClient.ReadOnly = true;
            this.rueClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prenomClient
            // 
            this.prenomClient.DataPropertyName = "prenomClient";
            this.prenomClient.HeaderText = "Prénom";
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.ReadOnly = true;
            this.prenomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "nomClient";
            this.nomClient.HeaderText = "Nom";
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // codePo
            // 
            this.codePo.DataPropertyName = "codePoClient";
            this.codePo.HeaderText = "Code Postal";
            this.codePo.Name = "codePo";
            this.codePo.ReadOnly = true;
            // 
            // boiteClient
            // 
            this.boiteClient.DataPropertyName = "boiteClient";
            this.boiteClient.HeaderText = "Numéro Boîte";
            this.boiteClient.Name = "boiteClient";
            this.boiteClient.ReadOnly = true;
            this.boiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvClients.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClients.ColumnHeadersHeight = 100;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.prenom,
            this.rue,
            this.numero,
            this.boite,
            this.codePo,
            this.localite});
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvClients.Location = new System.Drawing.Point(0, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 40;
            this.dgvClients.RowTemplate.Height = 28;
            this.dgvClients.Size = new System.Drawing.Size(1910, 603);
            this.dgvClients.TabIndex = 62;
            // 
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvClients);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1910, 1369);
            this.pFond.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfo);
            this.panel2.Controls.Add(this.pOptions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1910, 766);
            this.panel2.TabIndex = 63;
            // 
            // pInfo
            // 
            this.pInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfo.Controls.Add(this.label7);
            this.pInfo.Controls.Add(this.label6);
            this.pInfo.Controls.Add(this.tbIdentifiant);
            this.pInfo.Controls.Add(this.lblPrenom);
            this.pInfo.Controls.Add(this.tbPrenom);
            this.pInfo.Controls.Add(this.lblNom);
            this.pInfo.Controls.Add(this.tbNom);
            this.pInfo.Controls.Add(this.label1);
            this.pInfo.Controls.Add(this.tbLocalite);
            this.pInfo.Controls.Add(this.tbRue);
            this.pInfo.Controls.Add(this.label5);
            this.pInfo.Controls.Add(this.label2);
            this.pInfo.Controls.Add(this.tbCodePostal);
            this.pInfo.Controls.Add(this.tbNumero);
            this.pInfo.Controls.Add(this.label4);
            this.pInfo.Controls.Add(this.label3);
            this.pInfo.Controls.Add(this.tbBoite);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfo.Location = new System.Drawing.Point(394, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(1516, 766);
            this.pInfo.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1514, 69);
            this.label7.TabIndex = 57;
            this.label7.Text = "I N F O R M A T I O N S";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(16, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Identifiant";
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.Location = new System.Drawing.Point(16, 125);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.ReadOnly = true;
            this.tbIdentifiant.Size = new System.Drawing.Size(571, 29);
            this.tbIdentifiant.TabIndex = 40;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrenom.Location = new System.Drawing.Point(16, 252);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(69, 24);
            this.lblPrenom.TabIndex = 38;
            this.lblPrenom.Text = "Prénom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(16, 289);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(571, 29);
            this.tbPrenom.TabIndex = 42;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(16, 171);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(48, 24);
            this.lblNom.TabIndex = 40;
            this.lblNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(16, 208);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(571, 29);
            this.tbNom.TabIndex = 41;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(20, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Rue";
            // 
            // tbLocalite
            // 
            this.tbLocalite.Location = new System.Drawing.Point(20, 646);
            this.tbLocalite.Name = "tbLocalite";
            this.tbLocalite.Size = new System.Drawing.Size(568, 29);
            this.tbLocalite.TabIndex = 47;
            this.tbLocalite.TextChanged += new System.EventHandler(this.tbLocalite_TextChanged);
            // 
            // tbRue
            // 
            this.tbRue.Location = new System.Drawing.Point(20, 382);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(568, 29);
            this.tbRue.TabIndex = 43;
            this.tbRue.TextChanged += new System.EventHandler(this.tbRue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(20, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Localité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(20, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "N°";
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Location = new System.Drawing.Point(20, 555);
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(568, 29);
            this.tbCodePostal.TabIndex = 46;
            this.tbCodePostal.Leave += new System.EventHandler(this.tbCodePostal_Leave);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(20, 468);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(242, 29);
            this.tbNumero.TabIndex = 44;
            this.tbNumero.TextChanged += new System.EventHandler(this.tbNumero_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(20, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Code Postal";
            // 
            // EcranClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1369);
            this.Controls.Add(this.pFond);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranClients";
            this.Text = "Partie Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranClients_FormClosed);
            this.pOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pFond.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnEditerClient;
        private System.Windows.Forms.Button btnConfirmerAjout;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.TextBox tbBoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn boite;
        private System.Windows.Forms.DataGridViewTextBoxColumn localite;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePo;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocalite;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label4;
    }
}