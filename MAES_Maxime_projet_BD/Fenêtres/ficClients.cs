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
using MAES_Maxime_projet_BD.DataAccess.DataObject; //Pour les dataobject -> requetes
using System.Text.RegularExpressions;

namespace MAES_Maxime_projet_BD
{
    public partial class EcranClients : Form
    {
        #region Initialisation des variables
        public string sConnex = "";
        Regex regexInt = new Regex("^[0-9]+$"); //Regex int => une fois ou plus un nombre allant de 0 à 9 entouré de ^$ pour traiter toute la ligne
        Regex regexCodePo = new Regex("^[0-9]{4}$");
        Regex regexString = new Regex("^[a-zA-Zéèäâ]+$");
        Regex regexStringAvecEspace = new Regex("^[a-zA-Zéèäâ ô-]+$");
        #endregion

        #region Constructeur EcranClients
        public EcranClients(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            remplirDgvClients();
            pInfo.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes
        //Reset des informations des différents éléments
        private void viderPInfos()
        {
            tbIdentifiant.Text = "";
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbRue.Text = "";
            tbNumero.Text = "";
            tbBoite.Text = "";
            tbCodePostal.Text = "";
            tbLocalite.Text = "";
        }

        //Activation des boutons en fonction des états de la fenêtre
        private void activer(bool actif)
        {
            btnAnnuler.Enabled = actif;
            btnConfirmerAjout.Enabled = actif;
            pInfo.Enabled = actif;
            btnAjouterClient.Enabled = !actif;
            btnEditerClient.Enabled = !actif;
            btnSupprimerClient.Enabled = !actif;
            dgvClients.Enabled = !actif;
        }

        //Actions à la fermeture de la fenêtre
        private void EcranClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Activation des boutons pour permettre de réouvrir la fenêtre plus tard
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionClient.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            //Activation des boutons (retour au tableau de bord)
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Remplissage du DGV Client
        private void remplirDgvClients()
        {
            List<C_ClientsVoiture> lTmp = new G_ClientsVoiture(sConnex).Lire("Nom"); //renvoi une liste de personne

            //Remplir le DGV

            foreach (C_ClientsVoiture p in lTmp)
            {
                dgvClients.Rows.Add(p.idClient, p.nomClient, p.prenomClient, p.rueClient, p.numeroClient, p.boiteClient, p.codePoClient, p.localiteClient);
            }

            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //Permet d'activer les éléments nécessaire à l'ajout d'un client
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            activer(true);
        }

        //Ajoute les informations d'un nouveau client
        private void btnConfirmerAjout_Click(object sender, EventArgs e)
        {
            if (tbNom.Text == "" || tbPrenom.Text == "" || tbRue.Text == "" || tbNumero.Text == "" || tbCodePostal.Text == "" || tbLocalite.Text == "")
                MessageBox.Show("Champ(s) incorrect(s) ou non rempli(s)");
            else
              if (tbIdentifiant.Text == "")
            //Ajout
            {
                if(tbNom.Text == "" || tbPrenom.Text == "" || tbRue.Text == "" || tbNumero.Text == "" || tbCodePostal.Text == "" || tbLocalite.Text == "")
                {
                    MessageBox.Show("Erreur dans le remplissage des champs");
                }
                else
                {
                    if (tbBoite.Text == "")
                    {
                        int iID = new G_ClientsVoiture(sConnex).Ajouter(tbNom.Text, tbPrenom.Text, tbRue.Text,
                                                                       int.Parse(tbNumero.Text), null,
                                                                       int.Parse(tbCodePostal.Text), tbLocalite.Text);
                        tbIdentifiant.Text = iID.ToString();
                        dgvClients.Rows.Add(iID, tbNom.Text, tbPrenom.Text, tbRue.Text, tbNumero.Text, null, tbCodePostal.Text, tbLocalite.Text);
                    }
                    else
                    {
                        int iID = new G_ClientsVoiture(sConnex).Ajouter(tbNom.Text, tbPrenom.Text, tbRue.Text,
                                                                       int.Parse(tbNumero.Text), int.Parse(tbBoite.Text),
                                                                       int.Parse(tbCodePostal.Text), tbLocalite.Text);
                        tbIdentifiant.Text = iID.ToString();
                        dgvClients.Rows.Add(iID, tbNom.Text, tbPrenom.Text, tbRue.Text, tbNumero.Text, tbBoite.Text, tbCodePostal.Text, tbLocalite.Text);
                    }
                }
                


            }
            else
            //Modification
            {
                new G_ClientsVoiture(sConnex).Modifier(int.Parse(tbIdentifiant.Text), tbNom.Text, tbPrenom.Text, tbRue.Text,
                                                            int.Parse(tbNumero.Text), null,
                                                            int.Parse(tbCodePostal.Text), tbLocalite.Text);

                dgvClients.SelectedRows[0].Cells["nom"].Value = tbNom.Text;
                dgvClients.SelectedRows[0].Cells["prenom"].Value = tbPrenom.Text;
                dgvClients.SelectedRows[0].Cells["rue"].Value = tbRue.Text;
                dgvClients.SelectedRows[0].Cells["numero"].Value = tbNumero.Text;
                dgvClients.SelectedRows[0].Cells["boite"].Value = tbBoite.Text;
                dgvClients.SelectedRows[0].Cells["codePo"].Value = tbCodePostal.Text;
                dgvClients.SelectedRows[0].Cells["localite"].Value = tbLocalite.Text;

            }
            activer(false); //rend la main à la partie principale de la fenêtre
            viderPInfos();
        }

        //Suppresion d'un des clients
        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Supprimer l'enregistrement ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idDgv = "";
                    string rel = "";
                    idDgv = dgvClients.SelectedRows[0].Cells["ID"].Value.ToString();

                    //Requête pour éviter de supprimer client qui à une relation
                    AchatVenteFinancesDataContext relationClient = new AchatVenteFinancesDataContext();
                    var requete = from relation in relationClient.AchatVenteVoiture
                                  where relation.idClient.ToString() == idDgv
                                  select relation.typeOperation; //Je choisi le type mais j'aurai pu choisir n'importe quoi d'autre

                    foreach (var aa in requete)
                    {
                        rel = aa.ToString(); //Si il y a quelque chose dans rel alors cela veut dire qu'il y a une relation 
                    }

                    if(rel != "")
                    {
                        MessageBox.Show("Impossible de supprimer ce client car il est associé à un achat ou une vente");
                    }
                    else //Si il n'y a rien dans rel alors cela veut dire qu'il n'y aucune relation donc que je peux supprimer mon client
                    {
                        //supp dans BD
                        int iId = (int)dgvClients.SelectedRows[0].Cells["ID"].Value;
                        new G_ClientsVoiture(sConnex).Supprimer(iId);

                        //supp dans mémoire

                        int index = dgvClients.CurrentRow.Index;
                        dgvClients.Rows.RemoveAt(index);
                        MessageBox.Show("Suppression effectuée", index.ToString());
                    }
                }
            }
            else MessageBox.Show("Sélectionner l'enregistrement à supprimer");
        }

        //Modification des informations d'un client
        private void btnEditerClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                tbIdentifiant.Text = dgvClients.SelectedRows[0].Cells["ID"].Value.ToString();
                C_ClientsVoiture pTmp = new G_ClientsVoiture(sConnex).Lire_ID(int.Parse(tbIdentifiant.Text));

                tbNom.Text = pTmp.nomClient;
                tbPrenom.Text = pTmp.prenomClient;
                tbRue.Text = pTmp.rueClient;
                tbNumero.Text = pTmp.numeroClient.ToString();
                tbBoite.Text = pTmp.boiteClient.ToString();
                tbCodePostal.Text = pTmp.codePoClient.ToString();
                tbLocalite.Text = pTmp.localiteClient;

                activer(true);
            }
            else MessageBox.Show("Sélectionner l'enregistrement à éditer");

        }

        //Annuler ajout ou modification (retour au menu de base de la fenêtre)
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            activer(false);
            viderPInfos();
        }

        //Quitter la fenêtre
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Méthodes sécurité (REGEX)

        //Vérification du nom
        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbNom.Text))
            {
                //true
            }
            else if (tbNom.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbNom.Text = "";
            }
        }

        //Vérification des prénoms

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbPrenom.Text))
            {
                //true
            }
            else if (tbPrenom.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbPrenom.Text = "";
            }
        }

        //Vérification de l'adresse

        private void tbRue_TextChanged(object sender, EventArgs e)
        {
            if (regexStringAvecEspace.IsMatch(tbRue.Text))
            {
                //true
            }
            else if (tbRue.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbRue.Text = "";
            }
        }

        //Vérification du numéro de rue

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            if (regexInt.IsMatch(tbNumero.Text))
            {
                //true
            }
            else if(tbNumero.Text == "")
            {
                
            }
            else
            {
                MessageBox.Show("Saisie de caractère impossible");
                tbNumero.Text = "";
            }  
        }

        //Vérification du chiffre de la boite

        private void tbBoite_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbBoite.Text))
            {
                //true
            }
            else if (tbBoite.Text == "")
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbBoite.Text = "";
            }
        }

        //Dans ce cas j'utilise le leave car je dois vérifier que seulement 4 chiffre soient entrées
        //donc si j'utilise le text changed a chaque fois que je rentre un caractère cela crée une erreur

        private void tbCodePostal_Leave(object sender, EventArgs e)
        {
            if (regexCodePo.IsMatch(tbCodePostal.Text))
            {

            }
            else
            {
                tbCodePostal.Text = "";
                MessageBox.Show("Code postal invalide");
            }
        }

        //Vérification localité

        private void tbLocalite_TextChanged(object sender, EventArgs e)
        {
            if (regexString.IsMatch(tbPrenom.Text))
            {
                //true
            }
            else if (tbPrenom.Text == "") //Pour éviter l'erreur quand on efface le contenu de la textbox
            {

            }
            else
            {
                MessageBox.Show("Saisie incorrecte");
                tbPrenom.Text = "";
            }
        }

        #endregion
    }
}
