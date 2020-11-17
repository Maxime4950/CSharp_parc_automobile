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


namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet de consulter le stock actuel ainsi qu'une consultation des infos en HTML
    public partial class EcranStock : Form
    {
        #region Initialisation des variables
        public string sConnex = "";
        #endregion

        #region Constructeur Ecran Stock
        public EcranStock(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            remplirDgvStock(); //AllowUserToAdd -> pour supprimer ligne blanche finale
            activer(false);
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes

        //Vérification au lancement
        private void EcranStock_Load(object sender, EventArgs e)
        {
            if (dgvStock.RowCount > 0)
            {
                btnConsulterStockHtml.Enabled = true;
            }
            else
            {
                btnConsulterStockHtml.Enabled = false;
            }
        }

        //Remplissage du DGV Stock
        private void remplirDgvStock()
        {

            List<C_StockVoiture> lTmp = new G_StockVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_StockVoiture p in lTmp)
            {
                dgvStock.Rows.Add(p.idVoiture, p.idMarque, p.idModele, p.idCategorie, p.anneeFabrication, p.idCarburant, p.idCouleur, p.kilometrage);
            }

            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Reset des textBoxs
        private void viderPInfos()
        {
            tbIdVoitureStock.Text = "";
            tbIdMarqueStock.Text = "";
            tbNomMarqueStock.Text = "";
            tbIdModeleStock.Text = "";
            tbNomModeleStock.Text = "";
            tbIdCategorieStock.Text = "";
            tbNomCategorieStock.Text = "";
            tbAnneeFabricationStock.Text = "";
            tbIdCarburantStock.Text = "";
            tbNomCarburantStock.Text = "";
            tbIdCouleurStock.Text = "";
            tbNomCouleurStock.Text = "";
            tbKilometrageStock.Text = "";
        }

        //Permet d'activer/désactiver les boutons
        private void activer(bool actif)
        {
            btnAnnulerStock.Enabled = actif;
            pInfoStock.Enabled = actif;
            btnConsulterStock.Enabled = !actif;
            btnSupprimerStock.Enabled = !actif;
            btnConsulterStockHtml.Enabled = !actif;
            dgvStock.Enabled = !actif;
        }

        //Actions à la fermeture de la fenêtre
        private void EcranStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionStock.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Permet de consulter les informations de la voiture en stock
        private void btnConsulterStock_Click(object sender, EventArgs e)
        {

            if (dgvStock.SelectedRows.Count > 0)
            {
                activer(true);

                tbIdVoitureStock.Text = dgvStock.SelectedRows[0].Cells["idVoiture"].Value.ToString();
                C_StockVoiture pTmp = new G_StockVoiture(sConnex).Lire_ID(int.Parse(tbIdVoitureStock.Text));

                //Marque

                tbIdMarqueStock.Text = pTmp.idMarque.ToString();
                C_MarqueVoiture MarqueTmp = new G_MarqueVoiture(sConnex).Lire_ID(int.Parse(tbIdMarqueStock.Text));
                tbNomMarqueStock.Text = MarqueTmp.nomMarque;

                //Modele

                tbIdModeleStock.Text = pTmp.idModele.ToString();
                C_ModeleVoiture ModeleTmp = new G_ModeleVoiture(sConnex).Lire_ID(int.Parse(tbIdModeleStock.Text));
                tbNomModeleStock.Text = ModeleTmp.nomModele;

                //Catégorie

                tbIdCategorieStock.Text = pTmp.idCategorie.ToString();
                C_CategorieVoiture CatTmp = new G_CategorieVoiture(sConnex).Lire_ID(int.Parse(tbIdCategorieStock.Text));
                tbNomCategorieStock.Text = CatTmp.nomCat;

                //Année de fabrication

                tbAnneeFabricationStock.Text = pTmp.anneeFabrication.ToString();

                //Carburant

                tbIdCarburantStock.Text = pTmp.idCarburant.ToString();
                C_CarburantVoiture CarbTmp = new G_CarburantVoiture(sConnex).Lire_ID(int.Parse(tbIdCarburantStock.Text));
                tbNomCarburantStock.Text = CarbTmp.nomCarburant;

                //Couleur

                tbIdCouleurStock.Text = pTmp.idCouleur.ToString();
                C_CouleurVoiture CoulTmp = new G_CouleurVoiture(sConnex).Lire_ID(int.Parse(tbIdCouleurStock.Text));
                tbNomCouleurStock.Text = CoulTmp.nomCouleur;

                //Kilométrage

                tbKilometrageStock.Text = pTmp.kilometrage.ToString();
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        //Permet la consultation des informations en HTML
        private void btnConsulterStockHtml_Click(object sender, EventArgs e) //Il est possible d'enregistrer le fichier en pdf (ctrl+p => microsoft to pdf)
        {
            //Utilisation du package EasyHTMLReports dans les packages NuGet

            easyHTMLReports1.AddString("<U><center><h1>Visualitation HTML du stock</h1></center></U>");

            easyHTMLReports1.AddLineBreak(); //Ligne d'espace

            easyHTMLReports1.AddDatagridView(dgvStock);

            List<C_StockVoiture> lTmp = new G_StockVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_StockVoiture p in lTmp)
            {
                easyHTMLReports1.NewPage();

                easyHTMLReports1.AddString("<h1>Informations de la voiture ID :" + p.idVoiture + "</h1>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Marque
                C_MarqueVoiture MarqueTmp = new G_MarqueVoiture(sConnex).Lire_ID(p.idMarque);
                string nomMarque = MarqueTmp.nomMarque.ToString();
                easyHTMLReports1.AddString("<p>Marque de la voiture: " + nomMarque + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Modèle
                C_ModeleVoiture ModeleTmp = new G_ModeleVoiture(sConnex).Lire_ID(p.idModele);
                string nomModele = ModeleTmp.nomModele.ToString();
                easyHTMLReports1.AddString("<p>Modèle de la voiture: " + nomModele + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Catégorie
                C_CategorieVoiture CatTmp = new G_CategorieVoiture(sConnex).Lire_ID(p.idCategorie);
                string nomCat = CatTmp.nomCat.ToString();
                easyHTMLReports1.AddString("<p>Catégorie de la voiture: " + nomCat + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Année fabrication

                string anneeFabr = p.anneeFabrication.ToString();
                easyHTMLReports1.AddString("<p>Année de fabrication de la voiture: " + anneeFabr + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Carburant
                C_CarburantVoiture CarbTmp = new G_CarburantVoiture(sConnex).Lire_ID(int.Parse(p.idCarburant.ToString()));
                string nomCarb = CarbTmp.nomCarburant.ToString();
                easyHTMLReports1.AddString("<p>Carburant de la voiture: " + nomCarb + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Couleur

                C_CouleurVoiture CoulTmp = new G_CouleurVoiture(sConnex).Lire_ID(int.Parse(p.idCouleur.ToString()));
                string nomCoul = CoulTmp.nomCouleur.ToString();
                easyHTMLReports1.AddString("<p>Couleur de la voiture: " + nomCoul + "</p>");

                easyHTMLReports1.AddLineBreak(); //Ligne d'espace

                //Kilométrage


                string kilometrage = p.kilometrage.ToString();
                easyHTMLReports1.AddString("<p>Kilométrage de la voiture: " + kilometrage + " km(s)</p>");


                easyHTMLReports1.AddLineBreak(); //Ligne d'espace
            }


            easyHTMLReports1.ShowPrintPreviewDialog(); //Pour écrire toutes les infos
        }

        //Permet de supprimer une voiture du stock
        private void btnSupprimerStock_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //supp dans BD
                    int iId = (int)dgvStock.SelectedRows[0].Cells["idVoiture"].Value;
                    new G_StockVoiture(sConnex).Supprimer(iId);

                    //supp dans mémoire

                    int index = dgvStock.CurrentRow.Index;
                    dgvStock.Rows.RemoveAt(index);
                    MessageBox.Show("Suppression effectuée", index.ToString());

                    viderPInfos();
                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }

        //Permet d'annuler/quitter la consultation des infos
        private void btnAnnulerStock_Click(object sender, EventArgs e)
        {
            activer(false);
            viderPInfos();
        }

        //Permet de quitter la fenêtre stock
        private void btnQuitterStock_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
