namespace MAES_Maxime_projet_BD
{
    partial class ficMarques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ficMarques));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdentifiantMarque = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbPaysMarque = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNomMarque = new System.Windows.Forms.TextBox();
            this.pInfoMarque = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pOptionsMarque = new System.Windows.Forms.Panel();
            this.btnAjouterMarque = new System.Windows.Forms.Button();
            this.btnQuitterMarque = new System.Windows.Forms.Button();
            this.btnAnnulerMarque = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.btnEditerMarque = new System.Windows.Forms.Button();
            this.btnConfirmerMarque = new System.Windows.Forms.Button();
            this.btnSupprimerMarque = new System.Windows.Forms.Button();
            this.pFond = new System.Windows.Forms.Panel();
            this.dgvMarque = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePoClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localiteClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pInfoMarque.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pOptionsMarque.SuspendLayout();
            this.pFond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarque)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1458, 69);
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
            // tbIdentifiantMarque
            // 
            this.tbIdentifiantMarque.Location = new System.Drawing.Point(16, 125);
            this.tbIdentifiantMarque.Name = "tbIdentifiantMarque";
            this.tbIdentifiantMarque.ReadOnly = true;
            this.tbIdentifiantMarque.Size = new System.Drawing.Size(571, 29);
            this.tbIdentifiantMarque.TabIndex = 40;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrenom.Location = new System.Drawing.Point(16, 252);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(112, 24);
            this.lblPrenom.TabIndex = 38;
            this.lblPrenom.Text = "Pays d\'origine";
            // 
            // tbPaysMarque
            // 
            this.tbPaysMarque.Location = new System.Drawing.Point(16, 289);
            this.tbPaysMarque.Name = "tbPaysMarque";
            this.tbPaysMarque.Size = new System.Drawing.Size(571, 29);
            this.tbPaysMarque.TabIndex = 42;
            this.tbPaysMarque.TextChanged += new System.EventHandler(this.tbPaysMarque_TextChanged);
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
            // tbNomMarque
            // 
            this.tbNomMarque.Location = new System.Drawing.Point(16, 208);
            this.tbNomMarque.Name = "tbNomMarque";
            this.tbNomMarque.Size = new System.Drawing.Size(571, 29);
            this.tbNomMarque.TabIndex = 41;
            this.tbNomMarque.TextChanged += new System.EventHandler(this.tbNomMarque_TextChanged);
            // 
            // pInfoMarque
            // 
            this.pInfoMarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInfoMarque.Controls.Add(this.label7);
            this.pInfoMarque.Controls.Add(this.label6);
            this.pInfoMarque.Controls.Add(this.tbIdentifiantMarque);
            this.pInfoMarque.Controls.Add(this.lblPrenom);
            this.pInfoMarque.Controls.Add(this.tbPaysMarque);
            this.pInfoMarque.Controls.Add(this.lblNom);
            this.pInfoMarque.Controls.Add(this.tbNomMarque);
            this.pInfoMarque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInfoMarque.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoMarque.Location = new System.Drawing.Point(394, 0);
            this.pInfoMarque.Name = "pInfoMarque";
            this.pInfoMarque.Size = new System.Drawing.Size(1460, 726);
            this.pInfoMarque.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pInfoMarque);
            this.panel2.Controls.Add(this.pOptionsMarque);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1854, 726);
            this.panel2.TabIndex = 63;
            // 
            // pOptionsMarque
            // 
            this.pOptionsMarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pOptionsMarque.Controls.Add(this.btnAjouterMarque);
            this.pOptionsMarque.Controls.Add(this.btnQuitterMarque);
            this.pOptionsMarque.Controls.Add(this.btnAnnulerMarque);
            this.pOptionsMarque.Controls.Add(this.lblOptions);
            this.pOptionsMarque.Controls.Add(this.btnEditerMarque);
            this.pOptionsMarque.Controls.Add(this.btnConfirmerMarque);
            this.pOptionsMarque.Controls.Add(this.btnSupprimerMarque);
            this.pOptionsMarque.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptionsMarque.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOptionsMarque.Location = new System.Drawing.Point(0, 0);
            this.pOptionsMarque.Name = "pOptionsMarque";
            this.pOptionsMarque.Size = new System.Drawing.Size(394, 726);
            this.pOptionsMarque.TabIndex = 63;
            // 
            // btnAjouterMarque
            // 
            this.btnAjouterMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAjouterMarque.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAjouterMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAjouterMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterMarque.Image")));
            this.btnAjouterMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterMarque.Location = new System.Drawing.Point(10, 86);
            this.btnAjouterMarque.Name = "btnAjouterMarque";
            this.btnAjouterMarque.Size = new System.Drawing.Size(360, 85);
            this.btnAjouterMarque.TabIndex = 59;
            this.btnAjouterMarque.Text = "A J O U T ";
            this.btnAjouterMarque.UseVisualStyleBackColor = false;
            this.btnAjouterMarque.Click += new System.EventHandler(this.btnAjouterMarque_Click);
            // 
            // btnQuitterMarque
            // 
            this.btnQuitterMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnQuitterMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitterMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitterMarque.Image")));
            this.btnQuitterMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitterMarque.Location = new System.Drawing.Point(10, 626);
            this.btnQuitterMarque.Name = "btnQuitterMarque";
            this.btnQuitterMarque.Size = new System.Drawing.Size(360, 85);
            this.btnQuitterMarque.TabIndex = 58;
            this.btnQuitterMarque.Text = "Q U I T T E R";
            this.btnQuitterMarque.UseVisualStyleBackColor = false;
            this.btnQuitterMarque.Click += new System.EventHandler(this.btnQuitterMarque_Click);
            // 
            // btnAnnulerMarque
            // 
            this.btnAnnulerMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAnnulerMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnulerMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerMarque.Image")));
            this.btnAnnulerMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerMarque.Location = new System.Drawing.Point(10, 398);
            this.btnAnnulerMarque.Name = "btnAnnulerMarque";
            this.btnAnnulerMarque.Size = new System.Drawing.Size(360, 85);
            this.btnAnnulerMarque.TabIndex = 38;
            this.btnAnnulerMarque.Text = "A N N U L E R";
            this.btnAnnulerMarque.UseVisualStyleBackColor = false;
            this.btnAnnulerMarque.Click += new System.EventHandler(this.btnAnnulerMarque_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.BackColor = System.Drawing.SystemColors.Highlight;
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
            // btnEditerMarque
            // 
            this.btnEditerMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditerMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditerMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditerMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnEditerMarque.Image")));
            this.btnEditerMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditerMarque.Location = new System.Drawing.Point(10, 189);
            this.btnEditerMarque.Name = "btnEditerMarque";
            this.btnEditerMarque.Size = new System.Drawing.Size(360, 85);
            this.btnEditerMarque.TabIndex = 36;
            this.btnEditerMarque.Text = "E D I T E R";
            this.btnEditerMarque.UseVisualStyleBackColor = false;
            this.btnEditerMarque.Click += new System.EventHandler(this.btnEditerMarque_Click);
            // 
            // btnConfirmerMarque
            // 
            this.btnConfirmerMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmerMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmerMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmerMarque.Image")));
            this.btnConfirmerMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmerMarque.Location = new System.Drawing.Point(10, 512);
            this.btnConfirmerMarque.Name = "btnConfirmerMarque";
            this.btnConfirmerMarque.Size = new System.Drawing.Size(360, 85);
            this.btnConfirmerMarque.TabIndex = 39;
            this.btnConfirmerMarque.Text = "C O N F I R M E R";
            this.btnConfirmerMarque.UseVisualStyleBackColor = false;
            this.btnConfirmerMarque.Click += new System.EventHandler(this.btnConfirmerMarque_Click);
            // 
            // btnSupprimerMarque
            // 
            this.btnSupprimerMarque.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSupprimerMarque.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerMarque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimerMarque.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimerMarque.Image")));
            this.btnSupprimerMarque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimerMarque.Location = new System.Drawing.Point(10, 289);
            this.btnSupprimerMarque.Name = "btnSupprimerMarque";
            this.btnSupprimerMarque.Size = new System.Drawing.Size(360, 85);
            this.btnSupprimerMarque.TabIndex = 37;
            this.btnSupprimerMarque.Text = "S U P P R I M E R";
            this.btnSupprimerMarque.UseVisualStyleBackColor = false;
            this.btnSupprimerMarque.Click += new System.EventHandler(this.btnSupprimerMarque_Click);
            // 
            // pFond
            // 
            this.pFond.Controls.Add(this.panel2);
            this.pFond.Controls.Add(this.dgvMarque);
            this.pFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFond.Location = new System.Drawing.Point(0, 0);
            this.pFond.Name = "pFond";
            this.pFond.Size = new System.Drawing.Size(1854, 1329);
            this.pFond.TabIndex = 2;
            // 
            // dgvMarque
            // 
            this.dgvMarque.AllowUserToAddRows = false;
            this.dgvMarque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMarque.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMarque.ColumnHeadersHeight = 100;
            this.dgvMarque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.pays});
            this.dgvMarque.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMarque.Location = new System.Drawing.Point(0, 0);
            this.dgvMarque.Name = "dgvMarque";
            this.dgvMarque.RowHeadersWidth = 40;
            this.dgvMarque.RowTemplate.Height = 28;
            this.dgvMarque.Size = new System.Drawing.Size(1854, 603);
            this.dgvMarque.TabIndex = 62;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idMarque";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "nomMarque";
            this.nom.HeaderText = "Nom Marque";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // pays
            // 
            this.pays.DataPropertyName = "paysMarque";
            this.pays.HeaderText = "Pays d\'origine";
            this.pays.Name = "pays";
            this.pays.ReadOnly = true;
            // 
            // boiteClient
            // 
            this.boiteClient.DataPropertyName = "boiteClient";
            this.boiteClient.HeaderText = "Numéro Boîte";
            this.boiteClient.Name = "boiteClient";
            this.boiteClient.ReadOnly = true;
            this.boiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nomClient
            // 
            this.nomClient.DataPropertyName = "nomClient";
            this.nomClient.HeaderText = "Nom";
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prenomClient
            // 
            this.prenomClient.DataPropertyName = "prenomClient";
            this.prenomClient.HeaderText = "Prénom";
            this.prenomClient.Name = "prenomClient";
            this.prenomClient.ReadOnly = true;
            this.prenomClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rueClient
            // 
            this.rueClient.DataPropertyName = "rueClient";
            this.rueClient.HeaderText = "Rue";
            this.rueClient.Name = "rueClient";
            this.rueClient.ReadOnly = true;
            this.rueClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // localiteClient
            // 
            this.localiteClient.DataPropertyName = "localiteClient";
            this.localiteClient.HeaderText = "Localité";
            this.localiteClient.Name = "localiteClient";
            this.localiteClient.ReadOnly = true;
            this.localiteClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idClient
            // 
            this.idClient.DataPropertyName = "idClient";
            this.idClient.HeaderText = "ID";
            this.idClient.Name = "idClient";
            this.idClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ficMarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1329);
            this.Controls.Add(this.pFond);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ficMarques";
            this.Text = "ficMarques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ficMarques_FormClosed);
            this.pInfoMarque.ResumeLayout(false);
            this.pInfoMarque.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pOptionsMarque.ResumeLayout(false);
            this.pFond.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdentifiantMarque;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbPaysMarque;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNomMarque;
        private System.Windows.Forms.Panel pInfoMarque;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pOptionsMarque;
        private System.Windows.Forms.Button btnAjouterMarque;
        private System.Windows.Forms.Button btnQuitterMarque;
        private System.Windows.Forms.Button btnAnnulerMarque;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnEditerMarque;
        private System.Windows.Forms.Button btnConfirmerMarque;
        private System.Windows.Forms.Button btnSupprimerMarque;
        private System.Windows.Forms.Panel pFond;
        private System.Windows.Forms.DataGridView dgvMarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn boiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePoClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn localiteClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn pays;
    }
}