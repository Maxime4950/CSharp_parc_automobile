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
using MAES_Maxime_projet_BD.DataAccess.DataObject;
using System.Text.RegularExpressions;

namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet de gérer le tableau de bord (réalisation d'une vente d'un véhicule)
    //ainsi que la gestion de l'ouverture des différentes fenêtres via le menu
    public partial class EcranAccueil : Form
    {
        #region Initialisation des variables
        FactureVente factV = new FactureVente();
        JournalEvenements journal = new JournalEvenements();
        DataTable DT_Clients, DT_Stock, DT_Vente;
        BindingSource BS_Clients, BS_Stock, BS_Vente;
        DateTime d = DateTime.Today;
        public string sConnexion = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maesm\Desktop\MAES_Maxime_projet_BD_V2\BD\BD_Voiture.mdf;Integrated Security = True; Connect Timeout = 30";
        Regex regexInt = new Regex("^[0-9]+$");
        Regex regexString = new Regex("^[a-zA-Zéèäâ]+$");
        #endregion

        #region Constructeur EcranAccueil
        public EcranAccueil()
        {
            //AllowUserToAddRows à false dans les datagrids pour enlever ligne blanche vide inutile
            InitializeComponent();
            pInfosStock.Enabled = false;
            lblDate.Text = d.ToLongDateString().ToUpper();
        }
        #endregion

        #region Méthodes

        //Chargement de l'écran
        private void EcranAccueil_Load(object sender, EventArgs e)
        {
            remplirAllDgv();
            remplissageCBPaiement();
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }

        //Remplissage de tout les datagridsview
        private void remplirAllDgv()
        {
            remplirDgvClients();
            remplirDgvStock();
            remplirDgvVente();
        }

        //Rétablir données par défaut de la page
        private void resetPage()
        {
            dgvClients.Enabled = true;
            dgvStock.Enabled = true;
            pInfos.Enabled = true;
            pInfosStock.Enabled = false;

            //Partie client

            tbIdClient.Text = "";
            tbIdNomClient.Text = "";
            tbIdPrenomClient.Text = "";
            tbRue.Text = "";
            tbNumero.Text = "";
            tbBoite.Text = "";
            tbCodePostal.Text = "";
            tbLocalite.Text = "";

            //Partie Voiture

            tbIdVoiture.Text = "";
            tbIdMarque.Text = "";
            tbNomMarque.Text = "";
            tbIdModele.Text = "";
            tbNomModele.Text = "";
            tbIdCategorie.Text = "";
            tbNomCategorie.Text = "";
            tbAnneeFabricationStock.Text = "";
            tbIdCarburant.Text = "";
            tbNomCarburant.Text = "";
            tbIdCouleur.Text = "";
            tbNomCouleur.Text = "";
            tbKilometrage.Text = "";

            //Partie confirmation

            tbIdClientConfirme.Text = "";
            tbIdVoitureConfirme.Text = "";
            tbPrix.Text = "";
            dtpDate.Text = d.ToLongDateString().ToUpper();
            tbIdPaiement.Text = "";
            cbNomPaiement.Text = "";

        }

        //Bouton pour fermer l'application
        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Pour actualiser les dgv a chaque fois que l'on revient sur la page
        private void btnTableauBord_EnabledChanged(object sender, EventArgs e)
        {
            remplirAllDgv();
            remplissageCBPaiement();
        }

        #region Partie Tableau de bord
        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            //Désactivation du bouton TableauBord quand il est activé
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
            btnTableauBord.Enabled = false;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;
            btnConsulterAchat.Visible = false;

            //Reset du panel qui pourrait contenir des fenêtres type clients,achats,modèles)
            pFenetresAppli.Controls.Clear();
            //On désactive la visibilité du panel afin de voir le panel accueil contenant les données du tableau de bord
            pFenetresAppli.Visible = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnTableauBord.Height;
            pBarreNav.Top = btnTableauBord.Top;

            //Titre
            lblTitrePrincipal.Text = "T A B L E A U   D E   B O R D";
        }
        #endregion

        #region Partie Client + Fenêtre gestion Client

        //Fenêtre client
        private void btnGestionClient_Click(object sender, EventArgs e)
        {
            //Désactivation du bouton client une fois celui-ci activé
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = false;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();

            //Ouverture de la fenêtre client
            EcranClients f = new EcranClients(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionClient.Height;
            pBarreNav.Top = btnGestionClient.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   C L I E N T S";
        }

        //Données clients sur le tableau de bord
        private void remplirDgvClients()
        {
            DT_Clients = new DataTable();


            DT_Clients.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Clients.Columns.Add("Nom");
            DT_Clients.Columns.Add("Prénom");
            DT_Clients.Columns.Add("Rue");
            DT_Clients.Columns.Add("Numéro");
            DT_Clients.Columns.Add("Boite");
            DT_Clients.Columns.Add("Code Postal");
            DT_Clients.Columns.Add("Localité");

            List<C_ClientsVoiture> lTmp = new G_ClientsVoiture(sConnexion).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_ClientsVoiture p in lTmp)
            {
                DT_Clients.Rows.Add(p.idClient, p.nomClient, p.prenomClient, p.rueClient, p.numeroClient, p.boiteClient, p.codePoClient, p.localiteClient);
            }

            BS_Clients = new BindingSource();
            BS_Clients.DataSource = DT_Clients;
            dgvClients.DataSource = BS_Clients;

            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Affichage des données du client au click dans le dgv
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 1 && dgvClients.SelectedRows.Count == 1)
            {
                btnConfirmerClientVoiture.Enabled = true;
            }
            else
            {
                btnConfirmerClientVoiture.Enabled = false;
            }

            tbIdClient.Text = dgvClients.SelectedRows[0].Cells["ID"].Value.ToString();
            C_ClientsVoiture pTmp = new G_ClientsVoiture(sConnexion).Lire_ID(int.Parse(tbIdClient.Text));

            //Nom

            tbIdNomClient.Text = pTmp.nomClient.ToString();

            //Prénom

            tbIdPrenomClient.Text = pTmp.prenomClient.ToString();


            //Rue

            tbRue.Text = pTmp.rueClient.ToString();

            //Numéro

            tbNumero.Text = pTmp.numeroClient.ToString();

            //Boite?

            tbBoite.Text = pTmp.boiteClient.ToString();

            //Code postal

            tbCodePostal.Text = pTmp.codePoClient.ToString();

            //Localité

            tbLocalite.Text = pTmp.localiteClient.ToString();
        }


        #endregion

        #region Partie Stock  + Fenêtre gestion Stock
        private void remplirDgvStock()
        {

            DT_Stock = new DataTable();

            DT_Stock.Columns.Add(new DataColumn("ID Voiture", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add(new DataColumn("ID Marque", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add(new DataColumn("ID Modele", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add(new DataColumn("ID Catégorie", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add("Année Fabrication");
            DT_Stock.Columns.Add(new DataColumn("ID Carburant", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add(new DataColumn("ID Couleur", System.Type.GetType("System.Int32")));
            DT_Stock.Columns.Add("Kilométrage");

            List<C_StockVoiture> lTmp = new G_StockVoiture(sConnexion).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_StockVoiture p in lTmp)
            {
                DT_Stock.Rows.Add(p.idVoiture, p.idMarque, p.idModele, p.idCategorie, p.anneeFabrication, p.idCarburant, p.idCouleur, p.kilometrage);
            }

            BS_Stock = new BindingSource();
            BS_Stock.DataSource = DT_Stock;
            dgvStock.DataSource = BS_Stock;

            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cbIdPaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_PaiementVoiture paiementTmp = new G_PaiementVoiture(sConnexion).Lire_ID(int.Parse(tbIdPaiement.Text));
            cbNomPaiement.Text = paiementTmp.nomPaiement;
        }

        private void btnAnnulerConfirmation_Click(object sender, EventArgs e)
        {
            pInfos.Enabled = true;
            dgvStock.Enabled = true;
            dgvClients.Enabled = true;
            pInfosStock.Enabled = false;
            tbIdClientConfirme.Text = "";
            tbIdVoitureConfirme.Text = "";
            tbPrix.Text = "";
            dtpDate.Text = d.ToLongDateString();
            tbIdPaiement.Text = "";
            cbNomPaiement.Text = "";
        }

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvStock.SelectedRows.Count == 1 && dgvClients.SelectedRows.Count == 1)
            {
                btnConfirmerClientVoiture.Enabled = true;
            }
            else
            {
                btnConfirmerClientVoiture.Enabled = false;
            }

            tbIdVoiture.Text = dgvStock.SelectedRows[0].Cells["ID Voiture"].Value.ToString();
            C_StockVoiture pTmp = new G_StockVoiture(sConnexion).Lire_ID(int.Parse(tbIdVoiture.Text));

            //Marque

            tbIdMarque.Text = pTmp.idMarque.ToString();
            C_MarqueVoiture MarqueTmp = new G_MarqueVoiture(sConnexion).Lire_ID(int.Parse(tbIdMarque.Text));
            tbNomMarque.Text = MarqueTmp.nomMarque;

            //Modele

            tbIdModele.Text = pTmp.idModele.ToString();
            C_ModeleVoiture ModeleTmp = new G_ModeleVoiture(sConnexion).Lire_ID(int.Parse(tbIdModele.Text));
            tbNomModele.Text = ModeleTmp.nomModele;

            //Catégorie

            tbIdCategorie.Text = pTmp.idCategorie.ToString();
            C_CategorieVoiture CatTmp = new G_CategorieVoiture(sConnexion).Lire_ID(int.Parse(tbIdCategorie.Text));
            tbNomCategorie.Text = CatTmp.nomCat;

            //Année de fabrication

            tbAnneeFabricationStock.Text = pTmp.anneeFabrication.ToString();

            //Carburant

            tbIdCarburant.Text = pTmp.idCarburant.ToString();
            C_CarburantVoiture CarbTmp = new G_CarburantVoiture(sConnexion).Lire_ID(int.Parse(tbIdCarburant.Text));
            tbNomCarburant.Text = CarbTmp.nomCarburant;

            //Couleur

            tbIdCouleur.Text = pTmp.idCouleur.ToString();
            C_CouleurVoiture CoulTmp = new G_CouleurVoiture(sConnexion).Lire_ID(int.Parse(tbIdCouleur.Text));
            tbNomCouleur.Text = CoulTmp.nomCouleur;

            //Kilométrage

            tbKilometrage.Text = pTmp.kilometrage.ToString();

        } //Pour afficher les données de la voiture

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = false;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();


            EcranStock f = new EcranStock(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            btnGestionStock.Enabled = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionStock.Height;
            pBarreNav.Top = btnGestionStock.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   S T O C K S";
        }

        #endregion

        #region Partie Vente  + Fenêtre gestion Vente

        //Gestion fenêtre vente
        //---------------------
        private void btnGestionVente_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = false;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();

            //Ouverture de la fenêtre ventes
            EcranVentes f = new EcranVentes(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            btnGestionVente.Enabled = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionVente.Height;
            pBarreNav.Top = btnGestionVente.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   V E N T E S";
        }

        //Vente dans le tableau de bord
        //-----------------------------
        private void remplirDgvVente()
        {
            DT_Vente = new DataTable();

            DT_Vente.Columns.Add(new DataColumn("ID Opération", System.Type.GetType("System.Int32")));
            DT_Vente.Columns.Add("ID Voiture");
            DT_Vente.Columns.Add("ID Client");
            DT_Vente.Columns.Add("Prix");
            DT_Vente.Columns.Add("Date Opération");
            DT_Vente.Columns.Add("ID Paiement");
            DT_Vente.Columns.Add("Type Opération");

            List<C_AchatVenteVoiture> lTmp = new G_AchatVenteVoiture(sConnexion).Lire("ID Vente"); //renvoi une liste de personne

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

        //Selection du type de paiement

        private void remplissageCBPaiement()
        {
            cbNomPaiement.Items.Clear();

            PaiementAchatDataContext DCPaiement = new PaiementAchatDataContext();
            var requete = from paiement in DCPaiement.PaiementVoiture
                          select paiement.nomPaiement;

            foreach (var aa in requete)
            {
                cbNomPaiement.Items.Add(aa.ToString());
            }
        }

        private void cbNomPaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaiementAchatDataContext DCPaiement = new PaiementAchatDataContext();
            var requete = from paiementV in DCPaiement.PaiementVoiture
                          where paiementV.nomPaiement == cbNomPaiement.Text
                          select paiementV.idPaiement;

            foreach (var aa in requete)
            {
                tbIdPaiement.Text = aa.ToString();
            }
        }

        //Confirmation des informations de la vente
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            pInfosStock.Enabled = true;
            dgvClients.Enabled = false;
            dgvStock.Enabled = false;
            pInfos.Enabled = false;
            tbIdClientConfirme.Text = tbIdClient.Text;
            tbIdVoitureConfirme.Text = tbIdVoiture.Text;
        }

        //Confirmation de la vente
        private void btnConfirmerVente_Click(object sender, EventArgs e)
        {
            int iID = new G_AchatVenteVoiture(sConnexion).Ajouter(int.Parse(tbIdVoitureConfirme.Text), int.Parse(tbIdClientConfirme.Text), int.Parse(tbPrix.Text)
                , DateTime.Parse(dtpDate.Text), int.Parse(tbIdPaiement.Text), "vente");

            DT_Vente.Rows.Add(iID, tbIdVoitureConfirme.Text, tbIdClientConfirme.Text, tbPrix.Text, dtpDate.Text, tbIdPaiement.Text, "vente");
            BS_Vente.DataSource = DT_Vente;
            dgvVente.DataSource = BS_Vente;

            //supp dans BD

            new G_StockVoiture(sConnexion).Supprimer(int.Parse(tbIdVoitureConfirme.Text));

            //supp dans mémoire

            int index = dgvStock.CurrentRow.Index;

            dgvStock.Rows.RemoveAt(index);
            MessageBox.Show("Suppression de : " + tbIdVoitureConfirme.Text.ToString() + "effectuée");

            //Création de la facture Vente

            factV.creerFactureVente(tbIdClientConfirme, tbIdNomClient, tbIdPrenomClient, tbIdVoitureConfirme, tbNomMarque, tbNomModele,
                tbNomCategorie, tbAnneeFabricationStock, tbNomCarburant, tbNomCouleur, tbKilometrage, tbPrix, dtpDate, tbIdPaiement, cbNomPaiement);

            C_ClientsVoiture tmp = new G_ClientsVoiture(sConnexion).Lire_ID(int.Parse(tbIdClientConfirme.Text));

            journal.AjoutVenteJournal(tbIdVoitureConfirme, tbNomMarque, tbNomModele, tbIdClientConfirme, tmp.nomClient, tmp.prenomClient, dtpDate, tbPrix);

            resetPage();
        }

        #endregion

        #region Fenêtres Achat
        //Ouverture Fenêtre Ajout d'un achat
        private void btnGestionAchat_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = false;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();

            EcranAchats f = new EcranAchats(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            btnGestionAchat.Enabled = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionAchat.Height;
            pBarreNav.Top = btnGestionAchat.Top;

            //Titre
            lblTitrePrincipal.Text = "S A I S I E   D E S   A C H A T S";

            //Fenetre gestion Achat
            btnConsulterAchat.Visible = true;
        }

        //Ouverture Fenêtre Consultation des divers achat
        private void btnConsulterAchat_Click(object sender, EventArgs e)
        {
            EcranConsulterAchats f = new EcranConsulterAchats(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            f.Show();

            btnConsulterAchat.Enabled = false;
        }




        #endregion

        #region Fenêtre Marques
        private void btnGestionMarques_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = false;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();

            btnGestionMarques.Enabled = false;
            ficMarques f = new ficMarques(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionMarques.Height;
            pBarreNav.Top = btnGestionMarques.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   M A R Q U E S";
        }

        #endregion

        #region Fenêtre Desiterata

        private void btnGestionDesiterata_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = false;
            btnGestionFinances.Enabled = true;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionDesiderata.Height;
            pBarreNav.Top = btnGestionDesiderata.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   D E S I D E R A T A S";

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();


            EcranDesiderata f = new EcranDesiderata(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

        }


        #endregion

        #region Fenêtre Finances

        private void btnGestionFinances_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = true;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionFinances.Height;
            pBarreNav.Top = btnGestionFinances.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   F I N A N C E S";

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();


            EcranFinances f = new EcranFinances(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();
        }

        #endregion

        #region Fenêtre Modèles
        private void btnGestionModeles_Click(object sender, EventArgs e)
        {
            //Pour permettre la navigation entre boutons dans le menu
            btnTableauBord.Enabled = true;
            btnGestionClient.Enabled = true;
            btnGestionAchat.Enabled = true;
            btnGestionVente.Enabled = true;
            btnGestionMarques.Enabled = true;
            btnGestionModeles.Enabled = false;
            btnGestionStock.Enabled = true;
            btnGestionDesiderata.Enabled = true;
            btnGestionFinances.Enabled = true;

            //Vide le panel pour éviter plusieurs fenêtres ouvertes
            pFenetresAppli.Controls.Clear();


            EcranModeles f = new EcranModeles(sConnexion);
            f.TopLevel = false;
            pFenetresAppli.Controls.Add(f);
            pFenetresAppli.Visible = true;
            f.Show();

            btnGestionModeles.Enabled = false;

            //Barre de navigation
            pBarreNav.Visible = true;
            pBarreNav.Height = btnGestionModeles.Height;
            pBarreNav.Top = btnGestionModeles.Top;

            //Titre
            lblTitrePrincipal.Text = "G E S T I O N   D E S   M O D E L E S";


        }
        #endregion

        #endregion

        #region Sécurité (REGEX)

        //Vérification du prix
        private void tbPrix_TextChanged(object sender, EventArgs e)
        {
            if (regexInt.IsMatch(tbPrix.Text))
            {
                //true
            }
            else if (tbPrix.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie de caractère impossible");
                tbPrix.Text = "";

            }
        }

        //Vérification nom paiement

        private void cbNomPaiement_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(cbNomPaiement.Text))
            {
                //true
            }
            else if (cbNomPaiement.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                cbNomPaiement.Text = "";
            }
        } //DropDrownStyle -> list pour éviter de pouvoir entrer des données
        #endregion
    }
}
