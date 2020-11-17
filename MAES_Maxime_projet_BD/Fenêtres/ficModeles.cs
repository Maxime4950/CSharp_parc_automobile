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
using System.Text.RegularExpressions;
using MAES_Maxime_projet_BD.DataAccess.DataObject;

namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet de gérer les marques -> ajout | modification | suppression | consultation
    public partial class EcranModeles : Form
    {
        #region Initialisation des variables
        public string sConnex = "";
        Regex regexString = new Regex("^[a-zA-Zéèäâ-]+$");
        #endregion

        #region Constructeur EcranModeles
        public EcranModeles(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            RemplirDGVModele();
            activer(false);
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes
        private void EcranModeles_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionModeles.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Reset des textbox
        private void viderPInfos()
        {
            tbIdentifiantModele.Text = "";
            tbNomModele.Text = "";
        }

        //Permet d'activer/désactiver les boutons 
        private void activer(bool actif)
        {
            btnAnnulerModele.Enabled = actif;
            btnConfirmerModele.Enabled = actif;
            pInfoModele.Enabled = actif;
            btnAjouterModele.Enabled = !actif;
            btnEditerModele.Enabled = !actif;
            btnSupprimerModele.Enabled = !actif;
            dgvModele.Enabled = !actif;
        }

        //Remplissage du DGV Modèle
        private void RemplirDGVModele()
        {

            List<C_ModeleVoiture> lTmp = new G_ModeleVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //remplir dgvModele

            foreach (C_ModeleVoiture p in lTmp)
            {
                dgvModele.Rows.Add(p.idModele, p.nomModele);
            }

            dgvModele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Activer les éléments nécessaires à l'ajout
        private void btnAjouterModele_Click(object sender, EventArgs e)
        {
            activer(true);
        }

        //Code + confirmation de l'ajout d'un modèle
        private void btnConfirmerModele_Click(object sender, EventArgs e)
        {
            if (tbNomModele.Text == "")
                MessageBox.Show("Champ incorrect ou non rempli");
            else
               if (tbIdentifiantModele.Text == "")
            //Ajout
            {
                int iID = new G_ModeleVoiture(sConnex).Ajouter(tbNomModele.Text);
                tbIdentifiantModele.Text = iID.ToString();
                dgvModele.Rows.Add(iID, tbNomModele.Text);
            }
            else
            //Modification
            {
                new G_ModeleVoiture(sConnex).Modifier(int.Parse(tbIdentifiantModele.Text), tbNomModele.Text);

                dgvModele.SelectedRows[0].Cells["ID"].Value = tbIdentifiantModele.Text;
                dgvModele.SelectedRows[0].Cells["nom"].Value = tbNomModele.Text;
            }
            activer(false); //rend la main à la partie principale de la fenêtre
            viderPInfos();
        }

        //Modification des modèles
        private void btnEditerModele_Click(object sender, EventArgs e)
        {
            if (dgvModele.SelectedRows.Count > 0)
            {
                tbIdentifiantModele.Text = dgvModele.SelectedRows[0].Cells["ID"].Value.ToString();
                C_ModeleVoiture pTmp = new G_ModeleVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantModele.Text));

                tbIdentifiantModele.Text = pTmp.idModele.ToString();
                tbNomModele.Text = pTmp.nomModele;

                activer(true);
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");
        }

        //Suppression des modèles
        private void btnSupprimerModele_Click(object sender, EventArgs e)
        {
            if (dgvModele.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idDgv = "";
                    string rel = "";
                    idDgv = dgvModele.SelectedRows[0].Cells["ID"].Value.ToString();

                    //Requête pour éviter de supprimer client qui à une relation
                    StockVoitureDataContext relationMarque = new StockVoitureDataContext();
                    var requete = from relation in relationMarque.StockVoiture
                                  where relation.idModele.ToString() == idDgv
                                  select relation.idModele;

                    foreach (var aa in requete)
                    {
                        rel = aa.ToString(); //Si il y a quelque chose dans rel alors cela veut dire qu'il y a une relation 
                    }

                    if (rel != "")
                    {
                        MessageBox.Show("Impossible de supprimer cette marque car elle est associée à un achat/vente/désiderata");
                    }
                    else //Si il n'y a rien dans rel alors cela veut dire qu'il n'y aucune relation donc que je peux supprimer mon client
                    {
                        //supp dans BD
                        int iId = (int)dgvModele.SelectedRows[0].Cells["ID"].Value;
                        new G_ModeleVoiture(sConnex).Supprimer(iId);

                        //supp dans mémoire

                        int index = dgvModele.CurrentRow.Index;
                        dgvModele.Rows.RemoveAt(index);
                        MessageBox.Show("Suppression effectuée", index.ToString());
                    }
                }
                else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
            }
        }


        //Annuler modification ou consultation des infos
        private void btnAnnulerModele_Click(object sender, EventArgs e)
        {
            activer(false);
            viderPInfos();
        }

       //Quitter la fenêtre
        private void btnQuitterModele_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Sécurité (REGEX)
        private void tbNomModele_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbNomModele.Text))
            {
                //true
            }
            else if (tbNomModele.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbNomModele.Text = "";
            }
        }
        #endregion
    }
}
