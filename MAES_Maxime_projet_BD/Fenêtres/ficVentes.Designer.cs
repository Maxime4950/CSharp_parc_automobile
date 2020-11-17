namespace MAES_Maxime_projet_BD
{
    partial class EcranVentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranVentes));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdentifiantOperation = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pFond = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pInfoVente = new System.Windows.Forms.Panel();
            this.rtbFactureVente = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPaiement = new System.Windows.Forms.TextBox();
            this.tbIdentifiantVoiture = new System.Windows.Forms.TextBox();
            this.tbIdentifiantClient = new System.Windows.Forms.TextBox();
            this.pOptionsAchat = new System.Windows.Forms.Panel();
            this.btnConsulterFacture = new System.Windows.Forms.Button();
            this.btnQuitterVente = new System.Windows.Forms.Button();
            this.btnAnnulerVente = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnDetailsVente = new System.Windows.Forms.Button();
            this.btnSupprimerVente = new System.Windows.Forms.Button();
            this.dgvVente = new System.Windows.Forms.DataGridView();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFond.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pInfoVente.SuspendLayout();
            this.pOptionsAchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(20, 579);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(589, 29);
            this.dtpDate.TabIndex = 59;
            this.dtpDate.Value = new System.DateTime(2020, 4, 14, 19, 25, 43, 0);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSlateGray;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1518, 70);
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
            // tbIdentifiantOperation
            // 
            this.tbIdentifiantOperation.Location = new System.Drawing.Point(20, 125);
            this.tbIdentifiantOperation.Name = "tbIdentifiantOperation";
            this.tbIdentifiantOperation.ReadOnly = true;
            this.tbIdentifiantOperation.Size = new System.Drawing.Size(592, 29);
            this.tbIdentifiantOperation.TabIndex = 40;
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
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(20, 474);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.ReadOnly = true;
            this.tbPrix.Size = new System.Drawing.Size(194, 29);
            this.tbPrix.TabIndex = 43;
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
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvVente);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1914, 1363);
            this.pFond.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfoVente);
            this.panel2.Controls.Add(this.pOptionsAchat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1914, 760);
            this.panel2.TabIndex = 63;
            // 
            // pInfoVente
            // 
            this.pInfoVente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoVente.Controls.Add(this.rtbFactureVente);
            this.pInfoVente.Controls.Add(this.label3);
            this.pInfoVente.Controls.Add(this.tbPaiement);
            this.pInfoVente.Controls.Add(this.tbIdentifiantVoiture);
            this.pInfoVente.Controls.Add(this.tbIdentifiantClient);
            this.pInfoVente.Controls.Add(this.dtpDate);
            this.pInfoVente.Controls.Add(this.label7);
            this.pInfoVente.Controls.Add(this.label6);
            this.pInfoVente.Controls.Add(this.tbIdentifiantOperation);
            this.pInfoVente.Controls.Add(this.lblPrenom);
            this.pInfoVente.Controls.Add(this.lblNom);
            this.pInfoVente.Controls.Add(this.label1);
            this.pInfoVente.Controls.Add(this.tbPrix);
            this.pInfoVente.Controls.Add(this.label2);
            this.pInfoVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoVente.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoVente.Location = new System.Drawing.Point(394, 0);
            this.pInfoVente.Name = "pInfoVente";
            this.pInfoVente.Size = new System.Drawing.Size(1520, 760);
            this.pInfoVente.TabIndex = 64;
            // 
            // rtbFactureVente
            // 
            this.rtbFactureVente.Location = new System.Drawing.Point(666, 86);
            this.rtbFactureVente.Name = "rtbFactureVente";
            this.rtbFactureVente.ReadOnly = true;
            this.rtbFactureVente.Size = new System.Drawing.Size(825, 615);
            this.rtbFactureVente.TabIndex = 68;
            this.rtbFactureVente.Text = "";
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
            // tbPaiement
            // 
            this.tbPaiement.Location = new System.Drawing.Point(355, 474);
            this.tbPaiement.Name = "tbPaiement";
            this.tbPaiement.ReadOnly = true;
            this.tbPaiement.Size = new System.Drawing.Size(254, 29);
            this.tbPaiement.TabIndex = 67;
            // 
            // tbIdentifiantVoiture
            // 
            this.tbIdentifiantVoiture.Location = new System.Drawing.Point(20, 367);
            this.tbIdentifiantVoiture.Name = "tbIdentifiantVoiture";
            this.tbIdentifiantVoiture.ReadOnly = true;
            this.tbIdentifiantVoiture.Size = new System.Drawing.Size(589, 29);
            this.tbIdentifiantVoiture.TabIndex = 65;
            // 
            // tbIdentifiantClient
            // 
            this.tbIdentifiantClient.Location = new System.Drawing.Point(20, 245);
            this.tbIdentifiantClient.Name = "tbIdentifiantClient";
            this.tbIdentifiantClient.ReadOnly = true;
            this.tbIdentifiantClient.Size = new System.Drawing.Size(589, 29);
            this.tbIdentifiantClient.TabIndex = 63;
            // 
            // pOptionsAchat
            // 
            this.pOptionsAchat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptionsAchat.Controls.Add(this.btnConsulterFacture);
            this.pOptionsAchat.Controls.Add(this.btnQuitterVente);
            this.pOptionsAchat.Controls.Add(this.btnAnnulerVente);
            this.pOptionsAchat.Controls.Add(this.lblOptions);
            this.pOptionsAchat.Controls.Add(this.btnDetailsVente);
            this.pOptionsAchat.Controls.Add(this.btnSupprimerVente);
            this.pOptionsAchat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptionsAchat.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptionsAchat.Location = new System.Drawing.Point(0, 0);
            this.pOptionsAchat.Name = "pOptionsAchat";
            this.pOptionsAchat.Size = new System.Drawing.Size(394, 760);
            this.pOptionsAchat.TabIndex = 63;
            // 
            // btnConsulterFacture
            // 
            this.btnConsulterFacture.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConsulterFacture.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulterFacture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulterFacture.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulterFacture.Image")));
            this.btnConsulterFacture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulterFacture.Location = new System.Drawing.Point(11, 186);
            this.btnConsulterFacture.Name = "btnConsulterFacture";
            this.btnConsulterFacture.Size = new System.Drawing.Size(360, 85);
            this.btnConsulterFacture.TabIndex = 59;
            this.btnConsulterFacture.Text = "C O N S U L T E R\r\nF A C T U R E\r\n";
            this.btnConsulterFacture.UseVisualStyleBackColor = false;
            this.btnConsulterFacture.Click += new System.EventHandler(this.btnConsulterFacture_Click);
            // 
            // btnQuitterVente
            // 
            this.btnQuitterVente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterVente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterVente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterVente.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterVente.Image")));
            this.btnQuitterVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterVente.Location = new System.Drawing.Point(11, 492);
            this.btnQuitterVente.Name = "btnQuitterVente";
            this.btnQuitterVente.Size = new System.Drawing.Size(360, 85);
            this.btnQuitterVente.TabIndex = 58;
            this.btnQuitterVente.Text = "Q U I T T E R";
            this.btnQuitterVente.UseVisualStyleBackColor = false;
            this.btnQuitterVente.Click += new System.EventHandler(this.btnQuitterVente_Click);
            // 
            // btnAnnulerVente
            // 
            this.btnAnnulerVente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerVente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerVente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerVente.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerVente.Image")));
            this.btnAnnulerVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerVente.Location = new System.Drawing.Point(11, 389);
            this.btnAnnulerVente.Name = "btnAnnulerVente";
            this.btnAnnulerVente.Size = new System.Drawing.Size(360, 85);
            this.btnAnnulerVente.TabIndex = 38;
            this.btnAnnulerVente.Text = "A N N U L E R";
            this.btnAnnulerVente.UseVisualStyleBackColor = false;
            this.btnAnnulerVente.Click += new System.EventHandler(this.btnAnnulerVente_Click);
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
            // btnDetailsVente
            // 
            this.btnDetailsVente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetailsVente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsVente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetailsVente.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailsVente.Image")));
            this.btnDetailsVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailsVente.Location = new System.Drawing.Point(11, 86);
            this.btnDetailsVente.Name = "btnDetailsVente";
            this.btnDetailsVente.Size = new System.Drawing.Size(360, 85);
            this.btnDetailsVente.TabIndex = 36;
            this.btnDetailsVente.Text = "D E T A I L S";
            this.btnDetailsVente.UseVisualStyleBackColor = false;
            this.btnDetailsVente.Click += new System.EventHandler(this.btnDetailsVente_Click);
            // 
            // btnSupprimerVente
            // 
            this.btnSupprimerVente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerVente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerVente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerVente.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerVente.Image")));
            this.btnSupprimerVente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerVente.Location = new System.Drawing.Point(11, 287);
            this.btnSupprimerVente.Name = "btnSupprimerVente";
            this.btnSupprimerVente.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerVente.TabIndex = 37;
            this.btnSupprimerVente.Text = "S U P P R I M E R";
            this.btnSupprimerVente.UseVisualStyleBackColor = false;
            this.btnSupprimerVente.Click += new System.EventHandler(this.btnSupprimerVente_Click);
            // 
            // dgvVente
            // 
            this.dgvVente.AllowUserToAddRows = false;
            this.dgvVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvVente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVente.ColumnHeadersHeight = 100;
            this.dgvVente.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVente.Location = new System.Drawing.Point(0, 0);
            this.dgvVente.Name = "dgvVente";
            this.dgvVente.RowHeadersWidth = 40;
            this.dgvVente.RowTemplate.Height = 28;
            this.dgvVente.Size = new System.Drawing.Size(1914, 603);
            this.dgvVente.TabIndex = 62;
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
            // boiteClient
            // 
            this.boiteClient.DataPropertyName = "boiteClient";
            this.boiteClient.HeaderText = "Numéro Boîte";
            this.boiteClient.Name = "boiteClient";
            this.boiteClient.ReadOnly = true;
            this.boiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EcranVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1363);
            this.Controls.Add(this.pFond);
            this.Name = "EcranVentes";
            this.Text = "ficVentes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranVentes_FormClosed);
            this.pFond.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pInfoVente.ResumeLayout(false);
            this.pInfoVente.PerformLayout();
            this.pOptionsAchat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdentifiantOperation;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pInfoVente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPaiement;
        public System.Windows.Forms.TextBox tbIdentifiantVoiture;
        private System.Windows.Forms.TextBox tbIdentifiantClient;
        private System.Windows.Forms.Panel pOptionsAchat;
        private System.Windows.Forms.Button btnQuitterVente;
        private System.Windows.Forms.Button btnAnnulerVente;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnDetailsVente;
        private System.Windows.Forms.Button btnSupprimerVente;
        private System.Windows.Forms.DataGridView dgvVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.Button btnConsulterFacture;
        private System.Windows.Forms.RichTextBox rtbFactureVente;
    }
}