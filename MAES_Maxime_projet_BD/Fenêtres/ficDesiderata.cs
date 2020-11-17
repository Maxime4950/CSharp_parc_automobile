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
using MAES_Maxime_projet_BD.DataAccess.DataObject; //pour remplir les combobox id (endroit ou se trouvent les fichiers)
using System.Text.RegularExpressions;


namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet d'ajouter, modifier, éditer ainsi que consulter les désideratas des clients
    public partial class EcranDesiderata : Form
    {
        #region Initialisation des variables
        public string sConnex = "";
        Regex regexInt = new Regex("^[0-9]+$");
        Regex regexIntAnnee = new Regex("^[0-9]{4}$");
        #endregion

        #region Constructeur EcranDesiderata
        public EcranDesiderata(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            activer(true);
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes

        private void viderPInfos()
        {
            //Partie Client
            tbIdClient.Text = "";
            tbIdNomClient.Text = "";
            tbIdPrenomClient.Text = "";
            tbRue.Text = "";
            tbNumero.Text = "";
            tbBoite.Text = "";
            tbCodePostal.Text = "";
            tbLocalite.Text = "";

            //Partie desiderata
            tbIdDesiderata.Text = "";
            tbIdCli.Text = "";
            tbIdMarque.Text = "1";
            cbNomMarque.ResetText();
            tbIdModele.Text = "1";
            cbNomModele.ResetText();
            tbIdCategorie.Text = "1";
            cbNomCategorie.ResetText();
            tbAnneeFabrication.Text = "";
            tbIdCarburant.Text = "1";
            cbNomCarburant.ResetText();
            tbIdCouleur.Text = "1";
            cbNomCouleur.ResetText();
            tbKilometrage.Text = "";
        }

        //Activation des boutons en fonction des états de la fenêtre
        private void activer(bool actif) //actif = true a début
        {
            pInfosDesiderata.Enabled = actif;
            pInfosDesiderata.Enabled = !actif;
            btnAnnulerDesiderata.Enabled = !actif;
            pInfosClient.Enabled = !actif;
            btnAjouterDesiderata.Enabled = actif;
            btnConsulterDesiderata.Enabled = actif;
            btnEditerDesiderata.Enabled = actif;
            btnSupprimerDesiderata.Enabled = actif;
        }

        //Activation/Désactivation des éléments ajout desiderata
        private void activerElementsAjoutDesiderata(bool actif)
        {
            cbNomMarque.Enabled = actif;
            cbNomModele.Enabled = actif;
            cbNomCategorie.Enabled = actif;
            tbAnneeFabrication.Enabled = actif;
            cbNomCarburant.Enabled = actif;
            cbNomCouleur.Enabled = actif;
            tbKilometrage.Enabled = actif;
            pInfosClient.Enabled = actif;
        }

        //Action à la fermeture de la fenêtre
        private void EcranDesiderata_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionDesiderata.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;


            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }
        
        //Action au démarrage de la fenêtre
        private void EcranDesiderata_Load(object sender, EventArgs e)
        {
            remplirDgvClients();
            remplirDgvDesiderata();
            remplirAllCB();
        }

        //Remplissage du DGV Client
        private void remplirDgvClients()
        {
            List<C_ClientsVoiture> lTmp = new G_ClientsVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_ClientsVoiture p in lTmp)
            {
                dgvClientsDesiderata.Rows.Add(p.idClient, p.nomClient, p.prenomClient, p.rueClient, p.numeroClient, p.boiteClient, p.codePoClient, p.localiteClient);
            }

            dgvClientsDesiderata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Remplissage du DGV Desiderata
        private void remplirDgvDesiderata()
        {
            List<C_DesiterataVoiture> lTmp = new G_DesiterataVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_DesiterataVoiture p in lTmp)
            {
                dgvDesideratas.Rows.Add(p.idDesiterata,p.idClient,p.idMarque,p.idModele,p.idCat,p.kilometrageMax,p.idCouleur,p.idCarburant,p.anneeMin);
            }

            dgvDesideratas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region Remplissage de toutes les combobox et ID (tbId) associé
        private void remplirAllCB()
        {
            remplissageCBMarque();
            remplissageCBModele();
            remplissageCBCategorie();
            remplissageCBCarburant();
            remplissageCBCouleur();
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
            activationBtnConfirmer();

            MarquesAchatDataContext DCmarques = new MarquesAchatDataContext();
            var requete = from marque in DCmarques.MarqueVoiture
                          where marque.nomMarque == cbNomMarque.Text
                          select marque.idMarque;

            foreach (var aa in requete)
            {
                tbIdMarque.Text = aa.ToString();
            }
        }

        //Remplissage ID et CB Modèles

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
            activationBtnConfirmer();

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
            activationBtnConfirmer();

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
            activationBtnConfirmer();

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
            activationBtnConfirmer();

            CouleurAchatDataContext DCCouleur = new CouleurAchatDataContext();
            var requete = from coul in DCCouleur.CouleurVoiture
                          where coul.nomCouleur == cbNomCouleur.Text
                          select coul.idCouleur;

            foreach (var aa in requete)
            {
                tbIdCouleur.Text = aa.ToString();
            }
        }

        #endregion

        #region Partie Ajout desiderata
        //Affichage des données du client au clic dans le dgv
        private void dgvClientsDesiderata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnConfirmerClientDesiderata.Enabled = true;
            tbIdClient.Text = dgvClientsDesiderata.SelectedRows[0].Cells["ID"].Value.ToString();
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

        //Organisation des différentes zone pour l'ajout d'un desiderata
        private void btnAjouterDesiderata_Click(object sender, EventArgs e)
        {
            pInfosClient.Enabled = true;
            btnConsulterDesiderata.Enabled = false;
            btnEditerDesiderata.Enabled = false;
            btnSupprimerDesiderata.Enabled = false;
            btnAnnulerDesiderata.Enabled = true;
            btnAjouterDesiderata.Enabled = false;
        }

        //Pour ne pas permettre de valider quand toutes les données ne sont pas entrées
        private void activationBtnConfirmer()
        {
            if (cbNomMarque.Text != "" && cbNomModele.Text != "" && cbNomCategorie.Text != "" && tbAnneeFabrication.Text != "" && cbNomCarburant.Text != ""
                && cbNomCouleur.Text != "" && tbKilometrage.Text != "")
            {
                btnConfirmerAjoutDesiderata.Enabled = true;
            }
            else
            {
                btnConfirmerAjoutDesiderata.Enabled = false;
            }
        }

        //Confirmer le client pour lequel on enregistrera un desiderata
        private void btnConfirmerClientDesiderata_Click(object sender, EventArgs e)
        {
            pInfosDesiderata.Enabled = true;
            activerElementsAjoutDesiderata(true);
            tbIdCli.Text = tbIdClient.Text;
            pInfosClient.Enabled = false;
        }

        //Confirmer l'ajout du desiderata
        private void btnConfirmerAjoutDesiderata_Click(object sender, EventArgs e)
        {
            if(tbIdDesiderata.Text == "")
            {
                //Ajout à la bd
                int iIdDesiderata = new G_DesiterataVoiture(sConnex).Ajouter(int.Parse(tbIdCli.Text), int.Parse(tbIdMarque.Text), int.Parse(tbIdModele.Text), int.Parse(tbIdCategorie.Text)
                    , int.Parse(tbKilometrage.Text), int.Parse(tbIdCouleur.Text), int.Parse(tbIdCarburant.Text), int.Parse(tbAnneeFabrication.Text));

                //Ajout au dgv
                dgvDesideratas.Rows.Add(iIdDesiderata, int.Parse(tbIdCli.Text), int.Parse(tbIdMarque.Text)
                    , int.Parse(tbIdModele.Text), int.Parse(tbIdCategorie.Text), int.Parse(tbKilometrage.Text), int.Parse(tbIdCouleur.Text)
                    , int.Parse(tbIdCarburant.Text), int.Parse(tbAnneeFabrication.Text));

                dgvDesideratas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                //Modification
                new G_DesiterataVoiture(sConnex).Modifier(int.Parse(tbIdDesiderata.Text),int.Parse(tbIdCli.Text), int.Parse(tbIdMarque.Text), int.Parse(tbIdModele.Text), int.Parse(tbIdCategorie.Text)
                    , int.Parse(tbKilometrage.Text), int.Parse(tbIdCouleur.Text), int.Parse(tbIdCarburant.Text), int.Parse(tbAnneeFabrication.Text));

                dgvDesideratas.SelectedRows[0].Cells["idMarque"].Value = tbIdMarque.Text;
                dgvDesideratas.SelectedRows[0].Cells["idModele"].Value = tbIdModele.Text;
                dgvDesideratas.SelectedRows[0].Cells["idCat"].Value = tbIdCategorie.Text;
                dgvDesideratas.SelectedRows[0].Cells["kilometrageMax"].Value = tbKilometrage.Text;
                dgvDesideratas.SelectedRows[0].Cells["idCouleur"].Value = tbIdCouleur.Text;
                dgvDesideratas.SelectedRows[0].Cells["idCarburant"].Value = tbIdCarburant.Text;
                dgvDesideratas.SelectedRows[0].Cells["AnneeMin"].Value = tbAnneeFabrication.Text;

            }
            activer(true); //Revenir au menu de base
            viderPInfos(); //Vide les infos
        }
        #endregion

        #region Partie Consultation Desiderata
        private void btnConsulterDesiderata_Click(object sender, EventArgs e)
        {
            if (dgvDesideratas.SelectedRows.Count > 0)
            {
                activer(false);
                activerElementsAjoutDesiderata(false);
                btnConfirmerAjoutDesiderata.Visible = false;
                pInfosDesiderata.Enabled = true;

                tbIdDesiderata.Text = dgvDesideratas.SelectedRows[0].Cells["idDesiderata"].Value.ToString();
                C_DesiterataVoiture pTmp = new G_DesiterataVoiture(sConnex).Lire_ID(int.Parse(tbIdDesiderata.Text));

                //Client
                tbIdCli.Text = pTmp.idClient.ToString();

                //Marque
                tbIdMarque.Text = pTmp.idMarque.ToString();
                C_MarqueVoiture MarqueTmp = new G_MarqueVoiture(sConnex).Lire_ID(int.Parse(tbIdMarque.Text));
                cbNomMarque.Text = MarqueTmp.nomMarque;

                //Modele
                tbIdModele.Text = pTmp.idModele.ToString();
                C_ModeleVoiture ModeleTmp = new G_ModeleVoiture(sConnex).Lire_ID(int.Parse(tbIdModele.Text));
                cbNomModele.Text = ModeleTmp.nomModele;

                //Catégorie
                tbIdCategorie.Text = pTmp.idCat.ToString();
                C_CategorieVoiture CatTmp = new G_CategorieVoiture(sConnex).Lire_ID(int.Parse(tbIdCategorie.Text));
                cbNomCategorie.Text = CatTmp.nomCat;

                //Année de fabrication min
                tbAnneeFabrication.Text = pTmp.anneeMin.ToString();

                //Carburant
                tbIdCarburant.Text = pTmp.idCarburant.ToString();
                C_CarburantVoiture CarbTmp = new G_CarburantVoiture(sConnex).Lire_ID(int.Parse(tbIdCarburant.Text));
                cbNomCarburant.Text = CarbTmp.nomCarburant;

                //Couleur
                tbIdCouleur.Text = pTmp.idCouleur.ToString();
                C_CouleurVoiture CoulTmp = new G_CouleurVoiture(sConnex).Lire_ID(int.Parse(tbIdCouleur.Text));
                cbNomCouleur.Text = CoulTmp.nomCouleur;

                //Kilométrage
                tbKilometrage.Text = pTmp.kilometrageMax.ToString();
            }
            else MessageBox.Show("Sélectionner l'enregistrement à consulter");
        }
        #endregion

        #region Partie Editer Desiderata
        private void btnEditerDesiderata_Click(object sender, EventArgs e)
        {
            if (dgvDesideratas.SelectedRows.Count > 0)
            {
                activer(false);
                pInfosClient.Enabled = false;

                tbIdDesiderata.Text = dgvDesideratas.SelectedRows[0].Cells["idDesiderata"].Value.ToString();
                C_DesiterataVoiture pTmp = new G_DesiterataVoiture(sConnex).Lire_ID(int.Parse(tbIdDesiderata.Text));

                //Client
                tbIdCli.Text = pTmp.idClient.ToString();

                //Marque
                tbIdMarque.Text = pTmp.idMarque.ToString();
                C_MarqueVoiture MarqueTmp = new G_MarqueVoiture(sConnex).Lire_ID(int.Parse(tbIdMarque.Text));
                cbNomMarque.Text = MarqueTmp.nomMarque;

                //Modele
                tbIdModele.Text = pTmp.idModele.ToString();
                C_ModeleVoiture ModeleTmp = new G_ModeleVoiture(sConnex).Lire_ID(int.Parse(tbIdModele.Text));
                cbNomModele.Text = ModeleTmp.nomModele;

                //Catégorie
                tbIdCategorie.Text = pTmp.idCat.ToString();
                C_CategorieVoiture CatTmp = new G_CategorieVoiture(sConnex).Lire_ID(int.Parse(tbIdCategorie.Text));
                cbNomCategorie.Text = CatTmp.nomCat;

                //Année de fabrication min
                tbAnneeFabrication.Text = pTmp.anneeMin.ToString();

                //Carburant
                tbIdCarburant.Text = pTmp.idCarburant.ToString();
                C_CarburantVoiture CarbTmp = new G_CarburantVoiture(sConnex).Lire_ID(int.Parse(tbIdCarburant.Text));
                cbNomCarburant.Text = CarbTmp.nomCarburant;

                //Couleur
                tbIdCouleur.Text = pTmp.idCouleur.ToString();
                C_CouleurVoiture CoulTmp = new G_CouleurVoiture(sConnex).Lire_ID(int.Parse(tbIdCouleur.Text));
                cbNomCouleur.Text = CoulTmp.nomCouleur;

                //Kilométrage
                tbKilometrage.Text = pTmp.kilometrageMax.ToString();
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");

        }
        #endregion

        #region Partie Suppression Desiderata
        private void btnSupprimerDesiderata_Click(object sender, EventArgs e)
        {
            if (dgvDesideratas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //supp dans BD
                    int iId = (int)dgvDesideratas.SelectedRows[0].Cells["idDesiderata"].Value;
                    new G_ClientsVoiture(sConnex).Supprimer(iId);

                    //supp dans mémoire

                    int index = dgvDesideratas.CurrentRow.Index;
                    dgvDesideratas.Rows.RemoveAt(index);
                    MessageBox.Show("Suppression effectuée", index.ToString());

                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }
        #endregion

        //Annuler ajout, consultation ou édition
        private void btnAnnulerDesiderata_Click(object sender, EventArgs e)
        {
            viderPInfos();
            activer(true);
            btnConfirmerAjoutDesiderata.Visible = true;
        }

        //Quitter la fenêtre
        private void btnQuitterDesiderata_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Sécurité
        private void tbKilometrage_TextChanged(object sender, EventArgs e)
        {
            activationBtnConfirmer();
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

        private void tbAnneeFabrication_Leave(object sender, EventArgs e)
        {
            if (regexIntAnnee.IsMatch(tbAnneeFabrication.Text))
            {
                //true
            }
            else if (tbAnneeFabrication.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie de caractère impossible");
                tbAnneeFabrication.Text = "";
            }
        }

        private void tbAnneeFabrication_TextChanged(object sender, EventArgs e)
        {
            activationBtnConfirmer();
        }
        #endregion
    }
}
