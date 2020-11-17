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
using System.IO; //fichier

namespace MAES_Maxime_projet_BD
{
    public partial class EcranVentes : Form
    {
        #region Initialisation des variales
        DataTable DT_Vente;
        BindingSource BS_Vente;
        FactureVente factV = new FactureVente();
        JournalEvenements journal = new JournalEvenements();
        DateTime d = DateTime.Today;
        public string sConnex = "";
        #endregion

        #region Constructeur EcranVentes
        public EcranVentes(string Sconnexion)
        {
            InitializeComponent();
            sConnex = Sconnexion;
            remplirDgvVente();
            activer(true);
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes

        //Reset des informations (textbox, datetimepicker,richtextbox)
        private void viderPInfos()
        {
            tbIdentifiantOperation.Text = "";
            tbIdentifiantClient.Text = "";
            tbIdentifiantVoiture.Text = "";
            tbPrix.Text = "";
            tbPaiement.Text = "";
            dtpDate.Text = d.ToLongDateString().ToUpper();
            rtbFactureVente.Clear();
        }

        //Activation/désactivation des divers boutons, panel
        private void activer(bool actif)
        {
            btnDetailsVente.Enabled = actif;
            btnConsulterFacture.Enabled = actif;
            btnSupprimerVente.Enabled = actif;
            btnAnnulerVente.Enabled = !actif;
            btnConsulterFacture.Enabled = !actif;
            btnQuitterVente.Enabled = actif;
            pInfoVente.Enabled = !actif;
            dgvVente.Enabled = actif;
        }

        //Remplissage du DGV Vente
        public void remplirDgvVente()
        {
            DT_Vente = new DataTable();

            DT_Vente.Columns.Add(new DataColumn("ID Opération", System.Type.GetType("System.Int32")));
            DT_Vente.Columns.Add("ID Voiture");
            DT_Vente.Columns.Add("ID Client");
            DT_Vente.Columns.Add("Prix");
            DT_Vente.Columns.Add("Date Opération");
            DT_Vente.Columns.Add("ID Paiement");
            DT_Vente.Columns.Add("Type Opération");

            List<C_AchatVenteVoiture> lTmp = new G_AchatVenteVoiture(sConnex).Lire("ID Vente"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_AchatVenteVoiture p in lTmp)
            {
                if (p.typeOperation == "vente")
                    DT_Vente.Rows.Add(p.idOperation, p.idVoiture, p.idClient, p.prixOperation, p.dateOperation, p.idPaiement, p.typeOperation);
            }

            BS_Vente = new BindingSource();
            BS_Vente.DataSource = DT_Vente;
            dgvVente.DataSource = BS_Vente;

            dgvVente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Actions à la fermeture du programme
        private void EcranVentes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionVente.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Affichage des informations concernant la vente sélécetionné dans le DGV
        private void btnDetailsVente_Click(object sender, EventArgs e)
        {
            dtpDate.Enabled = false;
            if (dgvVente.SelectedRows.Count > 0)
            {
                tbIdentifiantOperation.Text = dgvVente.SelectedRows[0].Cells["ID Opération"].Value.ToString();
                C_AchatVenteVoiture pTmp = new G_AchatVenteVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantOperation.Text));

                tbIdentifiantOperation.Text = pTmp.idOperation.ToString();
                tbIdentifiantClient.Text = pTmp.idClient.ToString();
                tbIdentifiantVoiture.Text = pTmp.idVoiture.ToString();
                tbPrix.Text = pTmp.prixOperation.ToString();
                tbPaiement.Text = pTmp.idPaiement.ToString();
                dtpDate.Text = pTmp.dateOperation.ToString();

                activer(false);
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        //Consultation de la facture de la vente selectionnée (affichage dans une richtextbox)
        private void btnConsulterFacture_Click(object sender, EventArgs e)
        {
            rtbFactureVente.Clear();

            C_ClientsVoiture clTmp = new G_ClientsVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantClient.Text));
            C_StockVoiture voitTmp = new G_StockVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantVoiture.Text));

            string nomFichier = clTmp.nomClient + "_" + clTmp.prenomClient + "_IDC" + tbIdentifiantClient.Text + "_IDV" + tbIdentifiantVoiture.Text + "_FactureVente.txt";
            string nomRepertoire = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/Factures_V";

            if (System.IO.File.Exists(nomRepertoire + "/" + nomFichier))
            {
                string[] lines = System.IO.File.ReadAllLines(nomRepertoire + "/" + nomFichier);

                for (int i = 0; i < lines.Length; i++)
                {
                    rtbFactureVente.AppendText(lines[i] + "\n");
                }
            }
            else
            {
                rtbFactureVente.AppendText("La facture n'est pas disponible.");
            }
        }

        //Annuler consulation, retour au menu de base de la fenêtre
        private void btnAnnulerVente_Click(object sender, EventArgs e)
        {
            activer(true);
            viderPInfos();
        }

        //Suppression d'une vente
        private void btnSupprimerVente_Click(object sender, EventArgs e)
        {
            if (dgvVente.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Iid = int.Parse(dgvVente.SelectedRows[0].Cells["ID Client"].Value.ToString());
                    C_ClientsVoiture clTmp = new G_ClientsVoiture(sConnex).Lire_ID(Iid);
                    int IidVoit = int.Parse(dgvVente.SelectedRows[0].Cells["ID Voiture"].Value.ToString());


                    //Suppression de la facture associée à la vente dans le dossier
                    string nomFichier = clTmp.nomClient + "_" + clTmp.prenomClient + "_IDC" + Iid.ToString() + "_IDV" + IidVoit.ToString() + "_FactureVente.txt";
                    string nomRepertoire = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/Factures_V";
                    string path =  nomRepertoire + "/" + nomFichier;
                    if(File.Exists(path))
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
                    int IidMarque = int.Parse(dgvVente.SelectedRows[0].Cells["ID Marque"].Value.ToString());
                    C_MarqueVoiture tmpMarque = new G_MarqueVoiture(sConnex).Lire_ID(IidMarque);

                    //Modèle
                    int IidModele = int.Parse(dgvVente.SelectedRows[0].Cells["ID Modele"].Value.ToString());
                    C_ModeleVoiture tmpModele = new G_ModeleVoiture(sConnex).Lire_ID(IidModele);

                    //Date + prix
                    int iId = (int)dgvVente.SelectedRows[0].Cells["ID Opération"].Value; //ID opération
                    C_AchatVenteVoiture tmpAchat = new G_AchatVenteVoiture(sConnex).Lire_ID(iId);

                    //Ajout évenements au journal de modif
                    journal.AjoutSuppressionAchatJournal(IidVoit, tmpMarque.nomMarque, tmpModele.nomModele, Iid, clTmp.nomClient, clTmp.prenomClient, tmpAchat.dateOperation, tmpAchat.prixOperation);


                    //supp dans BD
                    
                    new G_AchatVenteVoiture(sConnex).Supprimer(iId);

                    //supp dans mémoire

                    int index = dgvVente.CurrentRow.Index;
                    dgvVente.Rows.RemoveAt(index);
                    MessageBox.Show("Suppression effectuée", index.ToString());
                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }

        //Quitter la fenêtre de vente
        private void btnQuitterVente_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
