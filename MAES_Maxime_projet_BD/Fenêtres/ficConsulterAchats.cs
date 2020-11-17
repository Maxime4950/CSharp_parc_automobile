using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_BD_Voiture.Classes;
using Projet_BD_Voiture.Gestion;
using System.IO; //Gestion Fichier


namespace MAES_Maxime_projet_BD
{ 
    //Cette fenêtre permet de consulter les informations des achats effectuées ainsi que la possibilité de suppression de ceux-ci
    public partial class EcranConsulterAchats : Form
    {
        #region Initialisation des variables
        DataTable DT_Achat;
        BindingSource BS_Achat;
        FactureAchat factA = new FactureAchat();
        JournalEvenements journal = new JournalEvenements();
        DateTime d = DateTime.Today;
        public string sConnex = "";
        #endregion

        #region Constructeur 
        public EcranConsulterAchats(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            remplirDgvAchat();
            activer(true);
        }
        #endregion

        #region Méthodes

        //Actions à la fermeture de la fenêtre
        private void EcranConsulterAchats_FormClosed(object sender, FormClosedEventArgs e)
        {
            //On rétablit les boutons à l'état vrai pour permettre de retourner sur la fenêtre
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionAchat.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }

        //Reset des différents éléments de la fenêtre
        private void viderPInfos()
        {
            tbIdentifiantOperationAchat.Text = "";
            tbIdentifiantClientAchat.Text = "";
            tbIdentifiantVoitureAchat.Text = "";
            tbPrixAchat.Text = "";
            tbPaiementAchat.Text = "";
            dtpDateAchat.Text = d.ToLongDateString().ToUpper();
            rtbFactureAchat.Clear();
        }

        //Activation des boutons en fonction des actions faite dans la fenêtre
        private void activer(bool actif)
        {
            btnDetailsAchat.Enabled = actif;
            btnConsulterFactureAchat.Enabled = actif;
            btnSupprimerAchat.Enabled = actif;
            btnAnnulerAchat.Enabled = !actif;
            btnConsulterFactureAchat.Enabled = !actif;
            btnQuitterAchat.Enabled = actif;
            pInfoAchat.Enabled = !actif;
            dgvAchat.Enabled = actif;
        }

        //Remplissage du DGV Achat
        public void remplirDgvAchat()
        {
            DT_Achat = new DataTable();

            DT_Achat.Columns.Add(new DataColumn("ID Opération", System.Type.GetType("System.Int32")));
            DT_Achat.Columns.Add("ID Voiture");
            DT_Achat.Columns.Add("ID Client");
            DT_Achat.Columns.Add("Prix");
            DT_Achat.Columns.Add("Date Opération");
            DT_Achat.Columns.Add("ID Paiement");
            DT_Achat.Columns.Add("Type Opération");

            List<C_AchatVenteVoiture> lTmp = new G_AchatVenteVoiture(sConnex).Lire("ID Achat"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_AchatVenteVoiture p in lTmp)
            {
                if (p.typeOperation == "achat")
                    DT_Achat.Rows.Add(p.idOperation, p.idVoiture, p.idClient, p.prixOperation, p.dateOperation, p.idPaiement, p.typeOperation);
            }

            BS_Achat = new BindingSource();
            BS_Achat.DataSource = DT_Achat;
            dgvAchat.DataSource = BS_Achat;

            dgvAchat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Affichage des informations de l'achat sélectionné dans le dgv
        private void btnDetailsAchat_Click(object sender, EventArgs e)
        {
            dtpDateAchat.Enabled = false;
            if (dgvAchat.SelectedRows.Count > 0)
            {
                tbIdentifiantOperationAchat.Text = dgvAchat.SelectedRows[0].Cells["ID Opération"].Value.ToString();
                C_AchatVenteVoiture pTmp = new G_AchatVenteVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantOperationAchat.Text));

                tbIdentifiantOperationAchat.Text = pTmp.idOperation.ToString();
                tbIdentifiantClientAchat.Text = pTmp.idClient.ToString();
                tbIdentifiantVoitureAchat.Text = pTmp.idVoiture.ToString();
                tbPrixAchat.Text = pTmp.prixOperation.ToString();
                tbPaiementAchat.Text = pTmp.idPaiement.ToString();
                dtpDateAchat.Text = pTmp.dateOperation.ToString();

                activer(false);
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        //Suppression de l'achat sélectionné dans le dgv
        private void btnSupprimerAchat_Click(object sender, EventArgs e)
        {
            if (dgvAchat.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Iid = int.Parse(dgvAchat.SelectedRows[0].Cells["ID Client"].Value.ToString());
                    C_ClientsVoiture clTmp = new G_ClientsVoiture(sConnex).Lire_ID(Iid);
                    int IidVoit = int.Parse(dgvAchat.SelectedRows[0].Cells["ID Voiture"].Value.ToString());

                    //Suppression de la facture associée à la vente dans le dossier
                    string nomFichier = clTmp.nomClient + "_" + clTmp.prenomClient + "_IDC" + Iid.ToString() + "_IDV" + IidVoit.ToString() + "_FactureAchat.txt";
                    string nomRepertoire = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/Factures_A";
                    string path = nomRepertoire + "/" + nomFichier;
                    if (File.Exists(path))
                    {
                        MessageBox.Show("Suppression du fichier texte associé");
                        File.Delete(path);
                    }
                    else
                    {
                        MessageBox.Show("Fichier texte introuvable");
                    }

                    //Pour récuperer les données afin de signaler la suppression au journal des évenements
                    //Marque
                    C_StockVoiture tmpStock = new G_StockVoiture(sConnex).Lire_ID(IidVoit); //On va voir dans le stock pour
                    int IidMarque = tmpStock.idMarque;
                    C_MarqueVoiture tmpMarque = new G_MarqueVoiture(sConnex).Lire_ID(IidMarque);

                    //Modèle

                    int IidModele = tmpStock.idModele;
                    C_ModeleVoiture tmpModele = new G_ModeleVoiture(sConnex).Lire_ID(IidModele);

                    //Date + prix
                    int iId = (int)dgvAchat.SelectedRows[0].Cells["ID Opération"].Value; //ID opération
                    C_AchatVenteVoiture tmpAchat = new G_AchatVenteVoiture(sConnex).Lire_ID(iId);

                    //Ajout évenements au journal de modif
                    journal.AjoutSuppressionAchatJournal(IidVoit,tmpMarque.nomMarque,tmpModele.nomModele,Iid,clTmp.nomClient,clTmp.prenomClient,tmpAchat.dateOperation,tmpAchat.prixOperation);

                    //supp de l'achat dans BD avec id opération
                    
                    new G_AchatVenteVoiture(sConnex).Supprimer(iId);

                    //supp de la voiture achetée du stock
                    new G_StockVoiture(sConnex).Supprimer(IidVoit);

                    //supp dans mémoire

                    int index = dgvAchat.CurrentRow.Index;
                    dgvAchat.Rows.RemoveAt(index);
                    MessageBox.Show("Suppression effectuée", index.ToString());

                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }

        //Consultation de la facture (fichier txt) dans un richtextbox
        private void btnConsulterFactureAchat_Click(object sender, EventArgs e)
        {
            rtbFactureAchat.Clear();

            C_ClientsVoiture clTmp = new G_ClientsVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantClientAchat.Text));
            C_StockVoiture voitTmp = new G_StockVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantVoitureAchat.Text));

            string nomFichier = clTmp.nomClient + "_" + clTmp.prenomClient + "_IDC" + tbIdentifiantClientAchat.Text + "_IDV" + tbIdentifiantVoitureAchat.Text + "_FactureAchat.txt";
            string nomRepertoire = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/Factures_A";

            if (System.IO.File.Exists(nomRepertoire + "/" + nomFichier))
            {
                string[] lines = System.IO.File.ReadAllLines(nomRepertoire + "/" + nomFichier);

                for (int i = 0; i < lines.Length; i++)
                {
                    rtbFactureAchat.AppendText(lines[i] + "\n");
                }
            }
            else
            {
                rtbFactureAchat.AppendText("La facture n'est pas disponible.");
            }
        }

        //Annuler/Retour au menu de base de la fenêtre
        private void btnAnnulerAchat_Click(object sender, EventArgs e)
        {
            activer(true);
            viderPInfos();
        }

        //Quitter l'application
        private void btnQuitterAchat_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
