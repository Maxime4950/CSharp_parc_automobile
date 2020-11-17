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
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using MAES_Maxime_projet_BD.DataAccess.DataObject; //Pour requete linq

namespace MAES_Maxime_projet_BD
{
    //Cette fenêtre permet de gérer les marques -> ajout | modification | suppression | consultation
    public partial class ficMarques : Form
    {
        #region Initialisation des variables
        public string sConnex = "";
        Regex regexString = new Regex("^[a-zA-Zéèäâ-]+$");
        #endregion

        #region Constructeur EcranMarques
        public ficMarques(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            RemplirDGVMarque();
            activer(false);
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes

        //Actions à la fermetures de la fenêtre
        private void ficMarques_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionMarques.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Reset des textbox
        private void viderPInfos()
        {
            tbIdentifiantMarque.Text = "";
            tbNomMarque.Text = "";
            tbPaysMarque.Text = "";
        }

        //Activation/désactivation des boutons
        private void activer(bool actif)
        {
            btnAnnulerMarque.Enabled = actif;
            btnConfirmerMarque.Enabled = actif;
            pInfoMarque.Enabled = actif;
            btnAjouterMarque.Enabled = !actif;
            btnEditerMarque.Enabled = !actif;
            btnSupprimerMarque.Enabled = !actif;
            dgvMarque.Enabled = !actif;
        }

        //Remplissage du DGV Maruqe
        private void RemplirDGVMarque()
        {

            List<C_MarqueVoiture> lTmp = new G_MarqueVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            foreach (C_MarqueVoiture p in lTmp)
            {
                dgvMarque.Rows.Add(p.idMarque, p.nomMarque, p.paysMarque);
            }

            dgvMarque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Partie Clicks sur boutons

        //Active les éléments nécessaires à l'ajout d'une marque
        private void btnAjouterMarque_Click(object sender, EventArgs e)
        {
            activer(true);
        }

        //Code + Confirmation de l'ajout d'une marque
        private void btnConfirmerMarque_Click(object sender, EventArgs e)
        {
            if (tbNomMarque.Text == "" || tbPaysMarque.Text == "")
                MessageBox.Show("Champ(s) incorrect(s) ou non rempli(s)");
            else
             if (tbIdentifiantMarque.Text == "")
            //Ajout
            {
                int iID = new G_MarqueVoiture(sConnex).Ajouter(tbNomMarque.Text, tbPaysMarque.Text);
                tbIdentifiantMarque.Text = iID.ToString();
                dgvMarque.Rows.Add(iID, tbNomMarque.Text, tbPaysMarque.Text);
            }
            else
            //Modification
            {
                new G_MarqueVoiture(sConnex).Modifier(int.Parse(tbIdentifiantMarque.Text), tbNomMarque.Text, tbPaysMarque.Text);

                dgvMarque.SelectedRows[0].Cells["ID"].Value = tbIdentifiantMarque.Text;
                dgvMarque.SelectedRows[0].Cells["nom"].Value = tbNomMarque.Text;
                dgvMarque.SelectedRows[0].Cells["pays"].Value = tbPaysMarque.Text;
            }
            activer(false); //rend la main à la partie principale de la fenêtre
            viderPInfos();
        }

        //Modification d'une marque
        private void btnEditerMarque_Click(object sender, EventArgs e)
        {
            if (dgvMarque.SelectedRows.Count > 0)
            {
                tbIdentifiantMarque.Text = dgvMarque.SelectedRows[0].Cells["ID"].Value.ToString();
                C_MarqueVoiture pTmp = new G_MarqueVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiantMarque.Text));

                tbIdentifiantMarque.Text = pTmp.idMarque.ToString();
                tbNomMarque.Text = pTmp.nomMarque;
                tbPaysMarque.Text = pTmp.paysMarque;

                activer(true);
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");

        }

        //Suppression d'une marque
        private void btnSupprimerMarque_Click(object sender, EventArgs e)
        {
            if (dgvMarque.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idDgv = "";
                    string rel = "";
                    idDgv = dgvMarque.SelectedRows[0].Cells["ID"].Value.ToString();

                    //Requête pour éviter de supprimer client qui à une relation
                    StockVoitureDataContext relationMarque = new StockVoitureDataContext();
                    var requete = from relation in relationMarque.StockVoiture
                                  where relation.idMarque.ToString() == idDgv
                                  select relation.idMarque; 

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
                        int iId = (int)dgvMarque.SelectedRows[0].Cells["ID"].Value;
                        new G_MarqueVoiture(sConnex).Supprimer(iId);

                        //supp dans mémoire

                        int index = dgvMarque.CurrentRow.Index;
                        dgvMarque.Rows.RemoveAt(index);
                        MessageBox.Show("Suppression effectuée", index.ToString());
                    }
                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }

        //Annuler ajout ou modification
        private void btnAnnulerMarque_Click(object sender, EventArgs e)
        {
            activer(false);
            viderPInfos();
        }

        //Quitter la fenêtre Marque
        private void btnQuitterMarque_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Sécurité
        private void tbNomMarque_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbNomMarque.Text))
            {
                //true
            }
            else if (tbNomMarque.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbNomMarque.Text = "";
            }
        }

        private void tbPaysMarque_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbPaysMarque.Text))
            {
                //true
            }
            else if (tbPaysMarque.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbPaysMarque.Text = "";
            }
        }
        #endregion
    }
}
