using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Projet_BD_Voiture.Classes;
using Projet_BD_Voiture.Gestion;
using MAES_Maxime_projet_BD.DataAccess.DataObject; //pour remplir les combobox id


namespace MAES_Maxime_projet_BD
{
    public partial class EcranFinances : Form
    {
        #region Initialisation des variables
        JournalEvenements journal = new JournalEvenements();
        public string sConnex = "";
        #endregion

        #region Constructeur EcranFinances
        public EcranFinances(string sConnexion)
        {
            InitializeComponent();
            sConnex = sConnexion;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Visible = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnConsulterAchat.Enabled = true;
        }
        #endregion

        #region Méthodes

        private void EcranFinances_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnGestionFinances.Enabled = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pFenetresAppli.Visible = false;

            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Enabled = false;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Visible = true;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Height = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Height;
            ((EcranAccueil)Application.OpenForms["EcranAccueil"]).pBarreNav.Top = ((EcranAccueil)Application.OpenForms["EcranAccueil"]).btnTableauBord.Top;
        }

        //Actions au chargement de la fenêtre
        private void EcranFinances_Load(object sender, EventArgs e)
        {
            journal.LireContenuJournal(rtbJournalEvenements);
            dtpDateFin.Value = DateTime.Today;
        }

        //Fonction qui permet d'afficher les différent(e)s achats/ventes selon une période déterminée
        public void afficherDonneesFinances()
        {
            rtbAchats.Clear();
            rtbVentes.Clear();
            DateTime dateDebut = Convert.ToDateTime(dtpDateDebut.Value);
            DateTime dateFin = Convert.ToDateTime(dtpDateFin.Value);

            lblPeriode.Text = "Période du : " + dateDebut.ToLongDateString() + " au " + dateFin.ToLongDateString();
            int totAchat = 0;
            int totVentes = 0;
            AchatVenteFinancesDataContext DCFinances = new AchatVenteFinancesDataContext();
            //Requete pour l'achat
            var requete = from finances in DCFinances.AchatVenteVoiture
                          where DateTime.Compare(finances.dateOperation, dateDebut) >= 0 
                          && DateTime.Compare(finances.dateOperation, dateFin) <= 0  //Si la date est plus grand ou égale à la date de début et plus petite ou égale à la date de fin
                          && finances.typeOperation == "achat"
                          select finances.prixOperation;

            //Requete pour la vente
            var requete2 = from finances in DCFinances.AchatVenteVoiture
                          where DateTime.Compare(finances.dateOperation, dateDebut) >= 0
                          && DateTime.Compare(finances.dateOperation, dateFin) <= 0  //Si la date est plus grand ou égale à la date de début et plus petite ou égale à la date de fin
                          && finances.typeOperation == "vente"
                          select finances.prixOperation;


            foreach (var aa in requete)
            {
                rtbAchats.AppendText("- " + aa.ToString() + "€\n");
                totAchat += int.Parse(aa.ToString());
            }

            foreach (var aa in requete2)
            {
                rtbVentes.AppendText("+ " + aa.ToString() + "€\n");
                totVentes += int.Parse(aa.ToString());
            }

            lblTotAchats.Text = totAchat.ToString() + " €";
            lblTotVentes.Text = totVentes.ToString() + " €";

            if(totAchat < totVentes)
            {
                int benefice = totVentes - totAchat;
                lblBeneficePerte.Text = ("B E N E F I C E  D E : " + benefice + " €\n" +
                    "Sur la période du " + dateDebut.ToLongDateString() + "  au  " + dateFin.ToLongDateString());
            }
            else if(totAchat > totVentes)
            {
                int perte = totVentes - totAchat;
                lblBeneficePerte.Text = ("P E R T E  D E : " + perte + " €\n" +
                    "Sur la période du " + dateDebut.ToLongDateString() + "  au  " + dateFin.ToLongDateString());
            }
            else
            {
                lblBeneficePerte.Text = ("B E N E F I C E / P E R T E  D E : 0 €\n" +
                   "Sur la période du " + dateDebut.ToLongDateString() + "  au  " + dateFin.ToLongDateString());
            }
        
        }
        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            EmpecherDepassementDateFinDebut();
            afficherDonneesFinances();
        }

        private void dtpDateFin_ValueChanged(object sender, EventArgs e)
        {
            EmpecherDepassementDateFinDebut();
            afficherDonneesFinances();
        }

        private void EmpecherDepassementDateFinDebut()
        {
            DateTime dateDebut = Convert.ToDateTime(dtpDateDebut.Value);
            DateTime dateFin = Convert.ToDateTime(dtpDateFin.Value);
            
            if (DateTime.Compare(dateDebut, dateFin) >= 0) //Si la date de début est plus grande que la date de fin alors on doit adapter
            {
                dtpDateDebut.Value = DateTime.Today.AddDays(-1);
                dtpDateFin.Value = DateTime.Today;
            }
            else if(DateTime.Compare(dateFin, DateTime.Today) >= 0) //Pour empecher d'aller plus loin que la date du jour car de toute facon aucun chiffre
            {
                dtpDateFin.Value = DateTime.Today;
            }
        }
        #endregion
    }
}
