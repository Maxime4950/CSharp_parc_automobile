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
    class FactureVente
    {
        #region Initialisaton des variables
        int prixTotalVentes = 0; //Pour les finances
        #endregion

        #region Constructeur Facture Vente
        public FactureVente()
        {

        }
        #endregion

        #region Méthodes

        public void creerFactureVente(TextBox tbIdClientConfirme, TextBox tbIdNomClient, TextBox tbIdPrenomClient,
            TextBox tbIdVoitureConfirme, TextBox tbNomMarque, TextBox tbNomModele, TextBox tbNomCategorie, TextBox tbAnneeFabricationStock
            , TextBox tbNomCarburant, TextBox tbNomCouleur, TextBox tbKilometrage, TextBox tbPrix, DateTimePicker dtpDate, TextBox tbIdPaiement,
           ComboBox cbNomPaiement)
        {
            string nomFichier = tbIdNomClient.Text + "_" + tbIdPrenomClient.Text + "_IDC" + tbIdClientConfirme.Text + "_IDV" + tbIdVoitureConfirme.Text +  "_FactureVente.txt";
            string nomRepertoire = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/Factures_V";

            // If directory does not exist, create it. 

            if (!Directory.Exists(nomRepertoire)) //Si le repertoie n'existe pas on le crée
            {

                Directory.CreateDirectory(nomRepertoire);

                //Ensuite on peut créer la facture

                using (StreamWriter factV = File.CreateText(nomRepertoire + "/" + nomFichier))
                // + 
                {
                    factV.WriteLine("\t\t\t\t[FACTURE VENTE]");
                    factV.WriteLine("\t\t\t\t---------------\n");

                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                            INFORMATIONS DU CLIENT                            |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[ID Client] : " + tbIdClientConfirme.Text
                        + "\t[Nom] : " + tbIdNomClient.Text
                        + "\t\t[Prénom] : " + tbIdPrenomClient.Text
                        + "\n");

                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                           INFORMATIONS DE LA VOITURE                         |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[ID Voiture] : " + tbIdVoitureConfirme.Text
                                    + "\t\t[Marque] : " + tbNomMarque.Text
                                    + "\t\t\t[Modele] : " + tbNomModele.Text
                                    + "\n[Categorie] : " + tbNomCategorie.Text
                                    + "\t[Année de fabrication] : " + tbAnneeFabricationStock.Text
                                    + "\n[Carburant] : " + tbNomCarburant.Text
                                    + "\t[Couleur] : " + tbNomCouleur.Text
                                    + "\n[Kilométrage] : " + tbKilometrage.Text);


                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                           DETAILS DE LA VENTE                                |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[Prix] : " + tbPrix.Text + " €"
                        + "\t\t[Date de vente] : " + dtpDate.Text
                        + "\n[Id Paiement] : " + tbIdPaiement.Text
                        + "\t\t[Nom Paiement] : " + cbNomPaiement.Text
                        + "\n");

                    factV.Close();
                }

            }
            else
            {
                using (StreamWriter factV = File.CreateText(nomRepertoire + "/" + nomFichier))
                // + 
                {
                    factV.WriteLine("\t\t\t\t[FACTURE VENTE]");
                    factV.WriteLine("\t\t\t\t---------------\n");

                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                            INFORMATIONS DU CLIENT                            |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[ID Client] : " + tbIdClientConfirme.Text
                        + "\t[Nom] : " + tbIdNomClient.Text
                        + "\t\t[Prénom] : " + tbIdPrenomClient.Text
                        + "\n");

                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                           INFORMATIONS DE LA VOITURE                         |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[ID Voiture] : " + tbIdVoitureConfirme.Text
                                    + "\t\t[Marque] : " + tbNomMarque.Text
                                    + "\t\t\t[Modele] : " + tbNomModele.Text
                                    + "\n[Categorie] : " + tbNomCategorie.Text
                                    + "\t[Année de fabrication] : " + tbAnneeFabricationStock.Text
                                    + "\n[Carburant] : " + tbNomCarburant.Text
                                    + "\t[Couleur] : " + tbNomCouleur.Text
                                    + "\n[Kilométrage] : " + tbKilometrage.Text);


                    factV.WriteLine(" ______________________________________________________________________________");
                    factV.WriteLine("|                                                                              |");
                    factV.WriteLine("|                           DETAILS DE LA VENTE                                |");
                    factV.WriteLine("|______________________________________________________________________________|\n");

                    factV.WriteLine("\n[Prix] : " + tbPrix.Text + " €"
                        + "\t\t[Date de vente] : " + dtpDate.Text
                        + "\n[Id Paiement] : " + tbIdPaiement.Text
                        + "\t\t[Nom Paiement] : " + cbNomPaiement.Text
                        + "\n");

                    factV.Close();

                    //Pour la gestion des finances
                    prixTotalVentes += int.Parse(tbPrix.Text);
                }
            }
        }
        #endregion
    }
}
