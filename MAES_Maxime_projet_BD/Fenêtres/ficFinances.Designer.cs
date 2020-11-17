namespace MAES_Maxime_projet_BD
{
    partial class EcranFinances
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
            this.lblChiffreHebdo = new System.Windows.Forms.Label();
            this.rtbJournalEvenements = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotVentes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbVentes = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotAchats = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbAchats = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblBeneficePerte = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblChiffreHebdo
            // 
            this.lblChiffreHebdo.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblChiffreHebdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChiffreHebdo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChiffreHebdo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiffreHebdo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChiffreHebdo.Location = new System.Drawing.Point(0, 433);
            this.lblChiffreHebdo.Name = "lblChiffreHebdo";
            this.lblChiffreHebdo.Size = new System.Drawing.Size(1679, 54);
            this.lblChiffreHebdo.TabIndex = 1;
            this.lblChiffreHebdo.Text = "Chiffre d\'affaires d\'une période indiquée";
            this.lblChiffreHebdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbJournalEvenements
            // 
            this.rtbJournalEvenements.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbJournalEvenements.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbJournalEvenements.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbJournalEvenements.Location = new System.Drawing.Point(0, 0);
            this.rtbJournalEvenements.Name = "rtbJournalEvenements";
            this.rtbJournalEvenements.ReadOnly = true;
            this.rtbJournalEvenements.Size = new System.Drawing.Size(1679, 433);
            this.rtbJournalEvenements.TabIndex = 0;
            this.rtbJournalEvenements.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPeriode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpDateFin);
            this.panel1.Controls.Add(this.dtpDateDebut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 626);
            this.panel1.TabIndex = 2;
            // 
            // lblPeriode
            // 
            this.lblPeriode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPeriode.Location = new System.Drawing.Point(12, 359);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(494, 29);
            this.lblPeriode.TabIndex = 16;
            this.lblPeriode.Text = "Période : du .... au ....";
            this.lblPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date de fin de la période souhaitée";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date du début de la periode souhaitée";
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFin.Location = new System.Drawing.Point(16, 234);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(490, 32);
            this.dtpDateFin.TabIndex = 10;
            this.dtpDateFin.ValueChanged += new System.EventHandler(this.dtpDateFin_ValueChanged);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateDebut.Location = new System.Drawing.Point(16, 87);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(490, 32);
            this.dtpDateDebut.TabIndex = 9;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dtpDateDebut_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotVentes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rtbVentes);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(529, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 626);
            this.panel2.TabIndex = 3;
            // 
            // lblTotVentes
            // 
            this.lblTotVentes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotVentes.ForeColor = System.Drawing.Color.Green;
            this.lblTotVentes.Location = new System.Drawing.Point(327, 461);
            this.lblTotVentes.Name = "lblTotVentes";
            this.lblTotVentes.Size = new System.Drawing.Size(281, 125);
            this.lblTotVentes.TabIndex = 14;
            this.lblTotVentes.Text = "0 €";
            this.lblTotVentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(26, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 125);
            this.label3.TabIndex = 13;
            this.label3.Text = "T O T A L  D E S  V E N T E S  : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbVentes
            // 
            this.rtbVentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbVentes.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVentes.Location = new System.Drawing.Point(0, 57);
            this.rtbVentes.Name = "rtbVentes";
            this.rtbVentes.Size = new System.Drawing.Size(672, 352);
            this.rtbVentes.TabIndex = 1;
            this.rtbVentes.Text = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(672, 57);
            this.label4.TabIndex = 0;
            this.label4.Text = "T O T A L   D E S   V E N T E S";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotAchats);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.rtbAchats);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1203, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 626);
            this.panel3.TabIndex = 4;
            // 
            // lblTotAchats
            // 
            this.lblTotAchats.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAchats.ForeColor = System.Drawing.Color.Red;
            this.lblTotAchats.Location = new System.Drawing.Point(292, 461);
            this.lblTotAchats.Name = "lblTotAchats";
            this.lblTotAchats.Size = new System.Drawing.Size(281, 125);
            this.lblTotAchats.TabIndex = 15;
            this.lblTotAchats.Text = "0 €";
            this.lblTotAchats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(21, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 125);
            this.label7.TabIndex = 14;
            this.label7.Text = "T O T A L  D E S  A C H A T S  : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbAchats
            // 
            this.rtbAchats.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbAchats.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAchats.Location = new System.Drawing.Point(0, 57);
            this.rtbAchats.Name = "rtbAchats";
            this.rtbAchats.Size = new System.Drawing.Size(474, 352);
            this.rtbAchats.TabIndex = 2;
            this.rtbAchats.Text = "";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 57);
            this.label5.TabIndex = 1;
            this.label5.Text = "T O T A L   D E S   A C H AT S";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblBeneficePerte);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 1113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1679, 261);
            this.panel4.TabIndex = 17;
            // 
            // lblBeneficePerte
            // 
            this.lblBeneficePerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBeneficePerte.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficePerte.Location = new System.Drawing.Point(0, 0);
            this.lblBeneficePerte.Name = "lblBeneficePerte";
            this.lblBeneficePerte.Size = new System.Drawing.Size(1679, 261);
            this.lblBeneficePerte.TabIndex = 0;
            this.lblBeneficePerte.Text = "B E N E F I C E / P E R T E   H E B D O M A D A I R E :";
            this.lblBeneficePerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EcranFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 1374);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChiffreHebdo);
            this.Controls.Add(this.rtbJournalEvenements);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranFinances";
            this.Text = "ficFinances";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EcranFinances_FormClosed);
            this.Load += new System.EventHandler(this.EcranFinances_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChiffreHebdo;
        public System.Windows.Forms.RichTextBox rtbJournalEvenements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblBeneficePerte;
        private System.Windows.Forms.RichTextBox rtbVentes;
        private System.Windows.Forms.RichTextBox rtbAchats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lblTotVentes;
        private System.Windows.Forms.Label lblTotAchats;
    }
}