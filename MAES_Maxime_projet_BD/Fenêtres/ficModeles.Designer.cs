namespace MAES_Maxime_projet_BD
{
    partial class EcranModeles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranModeles));
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterModele = new System.Windows.Forms.Button();
            this.btnQuitterModele = new System.Windows.Forms.Button();
            this.btnAnnulerModele = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.pFond = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pInfoModele = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdentifiantModele = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNomModele = new System.Windows.Forms.TextBox();
            this.pOptionsModele = new System.Windows.Forms.Panel();
            this.btnEditerModele = new System.Windows.Forms.Button();
            this.btnConfirmerModele = new System.Windows.Forms.Button();
            this.btnSupprimerModele = new System.Windows.Forms.Button();
            this.dgvModele = new System.Windows.Forms.DataGridView();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFond.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pInfoModele.SuspendLayout();
            this.pOptionsModele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModele)).BeginInit();
            this.SuspendLayout();
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // nom
            // 
            this.nom.DataPropertyName = "nomMarque";
            this.nom.HeaderText = "Nom Modèle";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idMarque";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // btnAjouterModele
            // 
            this.btnAjouterModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterModele.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAjouterModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterModele.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterModele.Image")));
            this.btnAjouterModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterModele.Location = new System.Drawing.Point(11, 86);
            this.btnAjouterModele.Name = "btnAjouterModele";
            this.btnAjouterModele.Size = new System.Drawing.Size(360, 85);
            this.btnAjouterModele.TabIndex = 59;
            this.btnAjouterModele.Text = "A J O U T ";
            this.btnAjouterModele.UseVisualStyleBackColor = false;
            this.btnAjouterModele.Click += new System.EventHandler(this.btnAjouterModele_Click);
            // 
            // btnQuitterModele
            // 
            this.btnQuitterModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterModele.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterModele.Image")));
            this.btnQuitterModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterModele.Location = new System.Drawing.Point(11, 626);
            this.btnQuitterModele.Name = "btnQuitterModele";
            this.btnQuitterModele.Size = new System.Drawing.Size(360, 85);
            this.btnQuitterModele.TabIndex = 58;
            this.btnQuitterModele.Text = "Q U I T T E R";
            this.btnQuitterModele.UseVisualStyleBackColor = false;
            this.btnQuitterModele.Click += new System.EventHandler(this.btnQuitterModele_Click);
            // 
            // btnAnnulerModele
            // 
            this.btnAnnulerModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerModele.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerModele.Image")));
            this.btnAnnulerModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerModele.Location = new System.Drawing.Point(11, 398);
            this.btnAnnulerModele.Name = "btnAnnulerModele";
            this.btnAnnulerModele.Size = new System.Drawing.Size(360, 85);
            this.btnAnnulerModele.TabIndex = 38;
            this.btnAnnulerModele.Text = "A N N U L E R";
            this.btnAnnulerModele.UseVisualStyleBackColor = false;
            this.btnAnnulerModele.Click += new System.EventHandler(this.btnAnnulerModele_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.SystemColors.Highlight;
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
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvModele);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1707, 1339);
            this.pFond.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfoModele);
            this.panel2.Controls.Add(this.pOptionsModele);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1707, 736);
            this.panel2.TabIndex = 63;
            // 
            // pInfoModele
            // 
            this.pInfoModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoModele.Controls.Add(this.label7);
            this.pInfoModele.Controls.Add(this.label6);
            this.pInfoModele.Controls.Add(this.tbIdentifiantModele);
            this.pInfoModele.Controls.Add(this.lblNom);
            this.pInfoModele.Controls.Add(this.tbNomModele);
            this.pInfoModele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoModele.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoModele.Location = new System.Drawing.Point(394, 0);
            this.pInfoModele.Name = "pInfoModele";
            this.pInfoModele.Size = new System.Drawing.Size(1313, 736);
            this.pInfoModele.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1311, 70);
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
            // tbIdentifiantModele
            // 
            this.tbIdentifiantModele.Location = new System.Drawing.Point(16, 125);
            this.tbIdentifiantModele.Name = "tbIdentifiantModele";
            this.tbIdentifiantModele.ReadOnly = true;
            this.tbIdentifiantModele.Size = new System.Drawing.Size(571, 29);
            this.tbIdentifiantModele.TabIndex = 40;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNom.Location = new System.Drawing.Point(16, 171);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(129, 24);
            this.lblNom.TabIndex = 40;
            this.lblNom.Text = "Nom du modèle";
            // 
            // tbNomModele
            // 
            this.tbNomModele.Location = new System.Drawing.Point(16, 207);
            this.tbNomModele.Name = "tbNomModele";
            this.tbNomModele.Size = new System.Drawing.Size(571, 29);
            this.tbNomModele.TabIndex = 41;
            this.tbNomModele.TextChanged += new System.EventHandler(this.tbNomModele_TextChanged);
            // 
            // pOptionsModele
            // 
            this.pOptionsModele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptionsModele.Controls.Add(this.btnAjouterModele);
            this.pOptionsModele.Controls.Add(this.btnQuitterModele);
            this.pOptionsModele.Controls.Add(this.btnAnnulerModele);
            this.pOptionsModele.Controls.Add(this.lblOptions);
            this.pOptionsModele.Controls.Add(this.btnEditerModele);
            this.pOptionsModele.Controls.Add(this.btnConfirmerModele);
            this.pOptionsModele.Controls.Add(this.btnSupprimerModele);
            this.pOptionsModele.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptionsModele.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptionsModele.Location = new System.Drawing.Point(0, 0);
            this.pOptionsModele.Name = "pOptionsModele";
            this.pOptionsModele.Size = new System.Drawing.Size(394, 736);
            this.pOptionsModele.TabIndex = 63;
            // 
            // btnEditerModele
            // 
            this.btnEditerModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditerModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditerModele.Image = ((System.Drawing.Image)(resources.GetObject("btnEditerModele.Image")));
            this.btnEditerModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditerModele.Location = new System.Drawing.Point(11, 189);
            this.btnEditerModele.Name = "btnEditerModele";
            this.btnEditerModele.Size = new System.Drawing.Size(360, 85);
            this.btnEditerModele.TabIndex = 36;
            this.btnEditerModele.Text = "E D I T E R";
            this.btnEditerModele.UseVisualStyleBackColor = false;
            this.btnEditerModele.Click += new System.EventHandler(this.btnEditerModele_Click);
            // 
            // btnConfirmerModele
            // 
            this.btnConfirmerModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmerModele.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmerModele.Image")));
            this.btnConfirmerModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmerModele.Location = new System.Drawing.Point(11, 512);
            this.btnConfirmerModele.Name = "btnConfirmerModele";
            this.btnConfirmerModele.Size = new System.Drawing.Size(360, 85);
            this.btnConfirmerModele.TabIndex = 39;
            this.btnConfirmerModele.Text = "C O N F I R M E R";
            this.btnConfirmerModele.UseVisualStyleBackColor = false;
            this.btnConfirmerModele.Click += new System.EventHandler(this.btnConfirmerModele_Click);
            // 
            // btnSupprimerModele
            // 
            this.btnSupprimerModele.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerModele.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerModele.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerModele.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerModele.Image")));
            this.btnSupprimerModele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerModele.Location = new System.Drawing.Point(11, 290);
            this.btnSupprimerModele.Name = "btnSupprimerModele";
            this.btnSupprimerModele.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerModele.TabIndex = 37;
            this.btnSupprimerModele.Text = "S U P P R I M E R";
            this.btnSupprimerModele.UseVisualStyleBackColor = false;
            this.btnSupprimerModele.Click += new System.EventHandler(this.btnSupprimerModele_Click);
            // 
            // dgvModele
            // 
            this.dgvModele.AllowUserToAddRows = false;
            this.dgvModele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvModele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvModele.ColumnHeadersHeight = 100;
            this.dgvModele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom});
            this.dgvModele.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvModele.Location = new System.Drawing.Point(0, 0);
            this.dgvModele.Name = "dgvModele";
            this.dgvModele.RowHeadersWidth = 40;
            this.dgvModele.RowTemplate.Height = 28;
            this.dgvModele.Size = new System.Drawing.Size(1707, 603);
            this.dgvModele.TabIndex = 62;
            // 
            // localiteClient
            // 
            this.localiteClient.DataPropertyName = "localiteClient";
            this.localiteClient.HeaderText = "Localité";
            this.localiteClient.Name = "localiteClient";
            this.localiteClient.ReadOnly = true;
            this.localiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EcranModeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 1339);
            this.Controls.Add(this.pFond);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranModeles";
            this.Text = "ficModeles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranModeles_FormClosed);
            this.pFond.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pInfoModele.ResumeLayout(false);
            this.pInfoModele.PerformLayout();
            this.pOptionsModele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btnAjouterModele;
        private System.Windows.Forms.Button btnQuitterModele;
        private System.Windows.Forms.Button btnAnnulerModele;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pInfoModele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdentifiantModele;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNomModele;
        private System.Windows.Forms.Panel pOptionsModele;
        private System.Windows.Forms.Button btnEditerModele;
        private System.Windows.Forms.Button btnConfirmerModele;
        private System.Windows.Forms.Button btnSupprimerModele;
        private System.Windows.Forms.DataGridView dgvModele;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
    }
}