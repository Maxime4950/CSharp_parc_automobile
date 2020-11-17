namespace MAES_Maxime_projet_BD
{
    partial class EcranConsulterAchats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranConsulterAchats));
            this.pOptionsAchat = new System.Windows.Forms.Panel();
            this.btnConsulterFactureAchat = new System.Windows.Forms.Button();
            this.btnQuitterAchat = new System.Windows.Forms.Button();
            this.btnAnnulerAchat = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnDetailsAchat = new System.Windows.Forms.Button();
            this.btnSupprimerAchat = new System.Windows.Forms.Button();
            this.rtbFactureAchat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPaiementAchat = new System.Windows.Forms.TextBox();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIdentifiantVoitureAchat = new System.Windows.Forms.TextBox();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInfoAchat = new System.Windows.Forms.Panel();
            this.tbIdentifiantClientAchat = new System.Windows.Forms.TextBox();
            this.dtpDateAchat = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdentifiantOperationAchat = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrixAchat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pFond = new System.Windows.Forms.Panel();
            this.dgvAchat = new System.Windows.Forms.DataGridView();
            this.pOptionsAchat.SuspendLayout();
            this.pInfoAchat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pFond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // pOptionsAchat
            // 
            this.pOptionsAchat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptionsAchat.Controls.Add(this.btnConsulterFactureAchat);
            this.pOptionsAchat.Controls.Add(this.btnQuitterAchat);
            this.pOptionsAchat.Controls.Add(this.btnAnnulerAchat);
            this.pOptionsAchat.Controls.Add(this.lblOptions);
            this.pOptionsAchat.Controls.Add(this.btnDetailsAchat);
            this.pOptionsAchat.Controls.Add(this.btnSupprimerAchat);
            this.pOptionsAchat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptionsAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptionsAchat.Location = new System.Drawing.Point(0, 0);
            this.pOptionsAchat.Name = "pOptionsAchat";
            this.pOptionsAchat.Size = new System.Drawing.Size(394, 683);
            this.pOptionsAchat.TabIndex = 63;
            // 
            // btnConsulterFactureAchat
            // 
            this.btnConsulterFactureAchat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulterFactureAchat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterFactureAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulterFactureAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterFactureAchat.Image")));
            this.btnConsulterFactureAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulterFactureAchat.Location = new System.Drawing.Point(11, 186);
            this.btnConsulterFactureAchat.Name = "btnConsulterFactureAchat";
            this.btnConsulterFactureAchat.Size = new System.Drawing.Size(360, 85);
            this.btnConsulterFactureAchat.TabIndex = 59;
            this.btnConsulterFactureAchat.Text = "C O N S U L T E R\r\nF A C T U R E\r\n";
            this.btnConsulterFactureAchat.UseVisualStyleBackColor = false;
            this.btnConsulterFactureAchat.Click += new System.EventHandler(this.btnConsulterFactureAchat_Click);
            // 
            // btnQuitterAchat
            // 
            this.btnQuitterAchat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterAchat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterAchat.Image")));
            this.btnQuitterAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterAchat.Location = new System.Drawing.Point(11, 492);
            this.btnQuitterAchat.Name = "btnQuitterAchat";
            this.btnQuitterAchat.Size = new System.Drawing.Size(360, 85);
            this.btnQuitterAchat.TabIndex = 58;
            this.btnQuitterAchat.Text = "Q U I T T E R";
            this.btnQuitterAchat.UseVisualStyleBackColor = false;
            this.btnQuitterAchat.Click += new System.EventHandler(this.btnQuitterAchat_Click);
            // 
            // btnAnnulerAchat
            // 
            this.btnAnnulerAchat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerAchat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerAchat.Image")));
            this.btnAnnulerAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerAchat.Location = new System.Drawing.Point(11, 389);
            this.btnAnnulerAchat.Name = "btnAnnulerAchat";
            this.btnAnnulerAchat.Size = new System.Drawing.Size(360, 85);
            this.btnAnnulerAchat.TabIndex = 38;
            this.btnAnnulerAchat.Text = "A N N U L E R";
            this.btnAnnulerAchat.UseVisualStyleBackColor = false;
            this.btnAnnulerAchat.Click += new System.EventHandler(this.btnAnnulerAchat_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOptions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOptions.Location = new System.Drawing.Point(0, 0);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(392, 70);
            this.lblOptions.TabIndex = 57;
            this.lblOptions.Text = "O P T I O N S";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetailsAchat
            // 
            this.btnDetailsAchat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetailsAchat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetailsAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailsAchat.Image")));
            this.btnDetailsAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailsAchat.Location = new System.Drawing.Point(11, 86);
            this.btnDetailsAchat.Name = "btnDetailsAchat";
            this.btnDetailsAchat.Size = new System.Drawing.Size(360, 85);
            this.btnDetailsAchat.TabIndex = 36;
            this.btnDetailsAchat.Text = "D E T A I L S";
            this.btnDetailsAchat.UseVisualStyleBackColor = false;
            this.btnDetailsAchat.Click += new System.EventHandler(this.btnDetailsAchat_Click);
            // 
            // btnSupprimerAchat
            // 
            this.btnSupprimerAchat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerAchat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerAchat.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerAchat.Image")));
            this.btnSupprimerAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerAchat.Location = new System.Drawing.Point(11, 287);
            this.btnSupprimerAchat.Name = "btnSupprimerAchat";
            this.btnSupprimerAchat.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerAchat.TabIndex = 37;
            this.btnSupprimerAchat.Text = "S U P P R I M E R";
            this.btnSupprimerAchat.UseVisualStyleBackColor = false;
            this.btnSupprimerAchat.Click += new System.EventHandler(this.btnSupprimerAchat_Click);
            // 
            // rtbFactureAchat
            // 
            this.rtbFactureAchat.Location = new System.Drawing.Point(666, 86);
            this.rtbFactureAchat.Name = "rtbFactureAchat";
            this.rtbFactureAchat.ReadOnly = true;
            this.rtbFactureAchat.Size = new System.Drawing.Size(825, 615);
            this.rtbFactureAchat.TabIndex = 68;
            this.rtbFactureAchat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(355, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 66;
            this.label3.Text = "Type Paiement";
            // 
            // tbPaiementAchat
            // 
            this.tbPaiementAchat.Location = new System.Drawing.Point(355, 474);
            this.tbPaiementAchat.Name = "tbPaiementAchat";
            this.tbPaiementAchat.ReadOnly = true;
            this.tbPaiementAchat.Size = new System.Drawing.Size(254, 29);
            this.tbPaiementAchat.TabIndex = 67;
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
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tbIdentifiantVoitureAchat
            // 
            this.tbIdentifiantVoitureAchat.Location = new System.Drawing.Point(20, 367);
            this.tbIdentifiantVoitureAchat.Name = "tbIdentifiantVoitureAchat";
            this.tbIdentifiantVoitureAchat.ReadOnly = true;
            this.tbIdentifiantVoitureAchat.Size = new System.Drawing.Size(589, 29);
            this.tbIdentifiantVoitureAchat.TabIndex = 65;
            // 
            // boiteClient
            // 
            this.boiteClient.DataPropertyName = "boiteClient";
            this.boiteClient.HeaderText = "Numéro Boîte";
            this.boiteClient.Name = "boiteClient";
            this.boiteClient.ReadOnly = true;
            this.boiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pInfoAchat
            // 
            this.pInfoAchat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoAchat.Controls.Add(this.rtbFactureAchat);
            this.pInfoAchat.Controls.Add(this.label3);
            this.pInfoAchat.Controls.Add(this.tbPaiementAchat);
            this.pInfoAchat.Controls.Add(this.tbIdentifiantVoitureAchat);
            this.pInfoAchat.Controls.Add(this.tbIdentifiantClientAchat);
            this.pInfoAchat.Controls.Add(this.dtpDateAchat);
            this.pInfoAchat.Controls.Add(this.label7);
            this.pInfoAchat.Controls.Add(this.label6);
            this.pInfoAchat.Controls.Add(this.tbIdentifiantOperationAchat);
            this.pInfoAchat.Controls.Add(this.lblPrenom);
            this.pInfoAchat.Controls.Add(this.lblNom);
            this.pInfoAchat.Controls.Add(this.label1);
            this.pInfoAchat.Controls.Add(this.tbPrixAchat);
            this.pInfoAchat.Controls.Add(this.label2);
            this.pInfoAchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoAchat.Location = new System.Drawing.Point(394, 0);
            this.pInfoAchat.Name = "pInfoAchat";
            this.pInfoAchat.Size = new System.Drawing.Size(1176, 683);
            this.pInfoAchat.TabIndex = 64;
            // 
            // tbIdentifiantClientAchat
            // 
            this.tbIdentifiantClientAchat.Location = new System.Drawing.Point(20, 245);
            this.tbIdentifiantClientAchat.Name = "tbIdentifiantClientAchat";
            this.tbIdentifiantClientAchat.ReadOnly = true;
            this.tbIdentifiantClientAchat.Size = new System.Drawing.Size(589, 29);
            this.tbIdentifiantClientAchat.TabIndex = 63;
            // 
            // dtpDateAchat
            // 
            this.dtpDateAchat.Location = new System.Drawing.Point(20, 579);
            this.dtpDateAchat.Name = "dtpDateAchat";
            this.dtpDateAchat.Size = new System.Drawing.Size(589, 29);
            this.dtpDateAchat.TabIndex = 59;
            this.dtpDateAchat.Value = new System.DateTime(2020, 4, 14, 19, 25, 43, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1174, 70);
            this.label7.TabIndex = 57;
            this.label7.Text = "I N F O R M A T I O N S";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Identifiant de l\'opération";
            // 
            // tbIdentifiantOperationAchat
            // 
            this.tbIdentifiantOperationAchat.Location = new System.Drawing.Point(20, 125);
            this.tbIdentifiantOperationAchat.Name = "tbIdentifiantOperationAchat";
            this.tbIdentifiantOperationAchat.ReadOnly = true;
            this.tbIdentifiantOperationAchat.Size = new System.Drawing.Size(592, 29);
            this.tbIdentifiantOperationAchat.TabIndex = 40;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrenom.Location = new System.Drawing.Point(20, 189);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(278, 24);
            this.lblPrenom.TabIndex = 38;
            this.lblPrenom.Text = "Identifiant du client associé à l\'achat";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(20, 311);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(240, 24);
            this.lblNom.TabIndex = 40;
            this.lblNom.Text = "Identifiant de la voiture vendue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(20, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Prix";
            // 
            // tbPrixAchat
            // 
            this.tbPrixAchat.Location = new System.Drawing.Point(20, 474);
            this.tbPrixAchat.Name = "tbPrixAchat";
            this.tbPrixAchat.ReadOnly = true;
            this.tbPrixAchat.Size = new System.Drawing.Size(194, 29);
            this.tbPrixAchat.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(20, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfoAchat);
            this.panel2.Controls.Add(this.pOptionsAchat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1570, 683);
            this.panel2.TabIndex = 63;
            // 
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvAchat);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1570, 1286);
            this.pFond.TabIndex = 3;
            // 
            // dgvAchat
            // 
            this.dgvAchat.AllowUserToAddRows = false;
            this.dgvAchat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAchat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvAchat.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAchat.ColumnHeadersHeight = 100;
            this.dgvAchat.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAchat.Location = new System.Drawing.Point(0, 0);
            this.dgvAchat.Name = "dgvAchat";
            this.dgvAchat.ReadOnly = true;
            this.dgvAchat.RowHeadersWidth = 40;
            this.dgvAchat.RowTemplate.Height = 28;
            this.dgvAchat.Size = new System.Drawing.Size(1570, 603);
            this.dgvAchat.TabIndex = 62;
            // 
            // EcranConsulterAchats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 1286);
            this.Controls.Add(this.pFond);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranConsulterAchats";
            this.Text = "ficAchats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranConsulterAchats_FormClosed);
            this.pOptionsAchat.ResumeLayout(false);
            this.pInfoAchat.ResumeLayout(false);
            this.pInfoAchat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pFond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAchat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOptionsAchat;
        private System.Windows.Forms.Button btnConsulterFactureAchat;
        private System.Windows.Forms.Button btnQuitterAchat;
        private System.Windows.Forms.Button btnAnnulerAchat;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnDetailsAchat;
        private System.Windows.Forms.Button btnSupprimerAchat;
        private System.Windows.Forms.RichTextBox rtbFactureAchat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPaiementAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        public System.Windows.Forms.TextBox tbIdentifiantVoitureAchat;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        public System.Windows.Forms.Panel pInfoAchat;
        private System.Windows.Forms.TextBox tbIdentifiantClientAchat;
        private System.Windows.Forms.DateTimePicker dtpDateAchat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdentifiantOperationAchat;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrixAchat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.DataGridView dgvAchat;
    }
}