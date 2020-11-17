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
using System.Data.Linq;
using System.Data.Linq.Mapping;
using MAES_Maxime_projet_BD.DataAccess.DataObject; //pour remplir les combobox id
using System.Text.RegularExpressions;

namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet l'ajout d'un achat d'un véhicule
    public partial class EcranAchats : Form
    {
        #region Initialisation des variables
        DataTable DT_Clients, DT_Stock, DT_Achat;
        BindingSource BS_Clients, BS_Stock, BS_Achat;
        FactureAchat factA = new FactureAchat();
        JournalEvenements journal = new JournalEvenements();
        public string sConnex = "";
        DateTime d = DateTime.Today;
        Regex regexInt = new Regex("^[0-9]+$");
        Regex regexIntAnnee = new Regex("^[0-9]{4}$");
        #endregion

        #region Constructeur EcranAchats
        public EcranAchats(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            remplirDgvClients();
            remplirDgvStock();
            remplirDgvAchat();
        }

        #endregion

        #region Méthodes

        //Actions à la fermeture de la fenêtre
        private void EcranAchats_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Réactivation des boutons pour pouvoir reouvrir la fenêtre plus tard
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionAchat.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            //Désactivation du panel fenetresAppli pour revenir au tableau de bord
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            //Désactivation du bouton tableau de bord afin de montrer que l'on est bien sur celui-ci
            //+ Replacement de la barre de navigation
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;

            //Evite d'enregistrer la voiture si l'utilisateur ferme la fenêtre pendant la confirmation -> suppression du véhicule car pas acheté
            if (pInfosAchat.Enabled == true)
            {
                new G_StockVoiture(sConnex).Supprimer(int.Parse(tbIdVoitureConfirme.Text));
            }
        }

        //Action au lancement de la page
        private void EcranAchats_Load(object sender, EventArgs e)
        {
            remplirAllCB();
        }

        #region Partie Client

        //Remplissage du DGV client
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

            List<C_ClientsVoiture> lTmp = new G_ClientsVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

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

        //Ajout des informations du client dans la fenêtre quand on cliques sur la ligne du dgv
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIdClient.Text = dgvClients.SelectedRows[0].Cells["ID"].Value.ToString();
            C_ClientsVoiture pTmp = new G_ClientsVoiture(sConnex).Lire_ID(int.Parse(tbIdClient.Text));

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

        #region Partie Stock

        //Remplissage du DGV stock
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

            List<C_StockVoiture> lTmp = new G_StockVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

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
        #endregion

        #region Partie Achat (Contient le remplissage des combobox)

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

            List<C_AchatVenteVoiture> lTmp = new G_AchatVenteVoiture(sConnex).Lire("ID Opération"); //renvoi une liste de personne

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
       
        //Confirmation des données du client et de la voiture
        private void btnConfirmerClientVoiture_Click(object sender, EventArgs e)
        {
            pInfos.Enabled = false;
            pInfosAchat.Enabled = true;
            dgvClients.Enabled = true;

            tbIdClientConfirme.Text = tbIdClient.Text;

            //Ajout de la voiture dans le stock de la BD

            int iIDVoit = new G_StockVoiture(sConnex).Ajouter(int.Parse(tbIdMarque.Text), int.Parse(tbIdModele.Text), int.Parse(tbIdCategorie.Text)
                , int.Parse(tbAnneeFabricationStock.Text), int.Parse(tbIdCarburant.Text), int.Parse(tbIdCouleur.Text), int.Parse(tbKilometrage.Text));

            tbIdVoitureConfirme.Text = iIDVoit.ToString();
        }

        //Annulation de l'achat
        private void btnAnnulerConfirmation_Click(object sender, EventArgs e)
        {
            //Supprime la voiture qui avait été ajoutée précédement au stock si on annule car par encore achetée.

            new G_StockVoiture(sConnex).Supprimer(int.Parse(tbIdVoitureConfirme.Text));

            pInfosAchat.Enabled = false;
            pInfos.Enabled = true;
            dgvClients.Enabled = true;
        }

        //Confirmation de l'achat
        private void btnConfirmerAchat_Click(object sender, EventArgs e)
        {
            pInfosAchat.Enabled = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;

            int iIdOpe = new G_AchatVenteVoiture(sConnex).Ajouter(int.Parse(tbIdVoitureConfirme.Text), int.Parse(tbIdClient.Text)
                , int.Parse(tbPrix.Text), DateTime.Parse(dtpDate.Text), int.Parse(tbIdPaiement.Text),"achat");

            DT_Achat.Rows.Add(iIdOpe, int.Parse(tbIdVoitureConfirme.Text), int.Parse(tbIdClient.Text)
                , int.Parse(tbPrix.Text), DateTime.Parse(dtpDate.Text), int.Parse(tbIdPaiement.Text),"achat");

            //BS_Achat.DataSource = DT_Achat;
            //dgvAchat.DataSource = BS_Achat;

            //Ajout de la voiture au stock (partie dgv)

            DT_Stock.Rows.Add(int.Parse(tbIdVoitureConfirme.Text),int.Parse(tbIdMarque.Text),int.Parse(tbIdModele.Text),int.Parse(tbIdCategorie.Text)
                ,int.Parse(tbAnneeFabricationStock.Text),int.Parse(tbIdCarburant.Text),int.Parse(tbIdCouleur.Text),int.Parse(tbKilometrage.Text));

            //BS_Stock.DataSource = DT_Stock;
            //dgvStock.DataSource = BS_Stock;

            C_ClientsVoiture tmp = new G_ClientsVoiture(sConnex).Lire_ID(int.Parse(tbIdClientConfirme.Text));

            factA.creerFactureAchat(tbIdClientConfirme, tbIdNomClient, tbIdPrenomClient, tbIdVoitureConfirme, cbNomMarque, cbNomModele
                , cbNomCategorie, tbAnneeFabricationStock, cbNomCarburant, cbNomCouleur, tbKilometrage, tbPrix, dtpDate, tbIdPaiement, cbNomPaiement);

            //Ajout au journal des évenements
            journal.AjoutAchatJournal(tbIdVoitureConfirme,cbNomMarque,cbNomModele,tbIdClientConfirme,tmp.nomClient,tmp.prenomClient,dtpDate,tbPrix);

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).dgvStock.Refresh();
        }

        //Pour éviter de confirmer sans avoir tout rempli

        private void activeBtnConfirmer()
        {
            if (tbIdClient.Text != "" && tbIdNomClient.Text != "" && tbIdPrenomClient.Text != "" && tbRue.Text != ""
               && tbNumero.Text != "" && tbCodePostal.Text != "" && tbLocalite.Text != ""
               && tbIdMarque.Text != "" && tbIdModele.Text != "" && tbIdCategorie.Text != ""
               && tbAnneeFabricationStock.Text != "" && tbIdCarburant.Text != "" && tbIdCouleur.Text != ""
               && tbKilometrage.Text != "")
            {
                btnConfirmerClientVoiture.Enabled = true;
            }
            else
            {
                btnConfirmerClientVoiture.Enabled = false;
            }
        }

        #region Remplissage des ID et des COMBOBOX AVEC LINQ SQL

       //Remplissage de toutes les combobox
        private void remplirAllCB()
        {
            remplissageCBMarque();
            remplissageCBModele();
            remplissageCBCategorie();
            remplissageCBCarburant();
            remplissageCBCouleur();
            remplissageCBPaiement();
        }

        //Remplissage ID et CB Marque

        private void remplissageCBMarque()
        {
            cbNomMarque.Items.Clear();
            MarquesAchatDataContext DCmarques = new MarquesAchatDataContext();
            var requete = from marque in DCmarques.MarqueVoiture
                          select marque.nomMarque;

            foreach (var aa in requete)
            {
                cbNomMarque.Items.Add(aa.ToString());
            }
        }

        private void cbNomMarque_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();

            MarquesAchatDataContext DCmarques = new MarquesAchatDataContext();
            var requete = from marque in DCmarques.MarqueVoiture
                          where marque.nomMarque == cbNomMarque.Text
                          select marque.idMarque;

            foreach(var aa in requete)
            {
                tbIdMarque.Text = aa.ToString();
            }                
        }

        //Remplissage ID et CB Modele

        private void remplissageCBModele()
        {
            cbNomModele.Items.Clear();
            ModelesAchatDataContext DCmodeles = new ModelesAchatDataContext();
            var requete = from modele in DCmodeles.ModeleVoiture
                          select modele.nomModele;

            foreach (var aa in requete)
            {
                cbNomModele.Items.Add(aa.ToString());
            }
        }

        private void cbNomModele_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();

            ModelesAchatDataContext DCmodeles = new ModelesAchatDataContext();
            var requete = from modele in DCmodeles.ModeleVoiture
                          where modele.nomModele == cbNomModele.Text
                          select modele.idModele;

            foreach (var aa in requete)
            {
                tbIdModele.Text = aa.ToString();
            }
        }

        //Remplissage ID et CB Catégorie

        private void remplissageCBCategorie()
        {
            cbNomCategorie.Items.Clear();
            CategorieAchatDataContext DCCat = new CategorieAchatDataContext();
            var requete = from cat in DCCat.CategorieVoiture
                          select cat.nomCat;

            foreach (var aa in requete)
            {
                cbNomCategorie.Items.Add(aa.ToString());
            }
        }

        private void cbNomCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();

            CategorieAchatDataContext DCCat = new CategorieAchatDataContext();
            var requete = from cat in DCCat.CategorieVoiture
                          where cat.nomCat == cbNomCategorie.Text
                          select cat.idCat;

            foreach (var aa in requete)
            {
                tbIdCategorie.Text = aa.ToString();
            }
        }

        //Remplissage ID et CB Carburant

        private void remplissageCBCarburant()
        {
            cbNomCarburant.Items.Clear();
            CarburantAchatDataContext DCCarb = new CarburantAchatDataContext();
            var requete = from carb in DCCarb.CarburantVoiture
                          select carb.nomCarburant;

            foreach (var aa in requete)
            {
                cbNomCarburant.Items.Add(aa.ToString());
            }
        }

        private void cbNomCarburant_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();

            CarburantAchatDataContext DCCarb = new CarburantAchatDataContext();
            var requete = from carb in DCCarb.CarburantVoiture
                          where carb.nomCarburant == cbNomCarburant.Text
                          select carb.idCarburant;

            foreach (var aa in requete)
            {
                tbIdCarburant.Text = aa.ToString();
            }
        }

        //Remplissage ID et CB Couleur
        private void remplissageCBCouleur()
        {
            CouleurAchatDataContext DCCouleur = new CouleurAchatDataContext();
            var requete = from coul in DCCouleur.CouleurVoiture
                          select coul.nomCouleur;

            foreach (var aa in requete)
            {
                cbNomCouleur.Items.Add(aa.ToString());
            }
        }
        private void cbNomCouleur_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();

            CouleurAchatDataContext DCCouleur = new CouleurAchatDataContext();
            var requete = from coul in DCCouleur.CouleurVoiture
                          where coul.nomCouleur == cbNomCouleur.Text
                          select coul.idCouleur;

            foreach (var aa in requete)
            {
                tbIdCouleur.Text = aa.ToString();
            }
        }

        //Remplissage ID et CB Paiement
        private void remplissageCBPaiement()
        {
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
            activeBtnConfirmer();

            PaiementAchatDataContext DCPaiement = new PaiementAchatDataContext();
            var requete = from paiement in DCPaiement.PaiementVoiture
                          where paiement.nomPaiement == cbNomPaiement.Text
                          select paiement.idPaiement;

            foreach (var aa in requete)
            {
                tbIdPaiement.Text = aa.ToString();
            }
        }

        #endregion

        #endregion

        #region Sécurité
        //V&rification année de fabrication
        private void tbAnneeFabricationStock_TextChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();
        }

        private void tbAnneeFabricationStock_Leave(object sender, EventArgs e)
        {
            if (regexIntAnnee.IsMatch(tbAnneeFabricationStock.Text))
            {
                //true
            }
            else if (tbAnneeFabricationStock.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie de caractère impossible");
                tbAnneeFabricationStock.Text = "";
            }
        }

        //Vérification kilométrage
        private void tbKilometrage_TextChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();
            if (regexInt.IsMatch(tbKilometrage.Text))
            {
                //true
            }
            else if (tbKilometrage.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie de caractère impossible");
                tbKilometrage.Text = "";
            }
        }

        //Vérifiction du prix
        private void tbPrix_TextChanged(object sender, EventArgs e)
        {
            activeBtnConfirmer();
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
        #endregion
    }

    #endregion
}
