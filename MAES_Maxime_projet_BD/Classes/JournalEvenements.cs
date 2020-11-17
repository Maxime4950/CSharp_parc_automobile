using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MAES_Maxime_projet_BD
{
    class JournalEvenements
    {
        #region Initialisaton des variables
        #endregion

        #region Constructeur JournalEvenements
        public JournalEvenements()
        {

        }
        #endregion

        #region Méthodes
        public void AjoutAchatJournal(TextBox tbIdVoiture, ComboBox cbNomMarque, ComboBox cbNomModele, TextBox tbIdClient, string nomClient, string prenomClient, DateTimePicker date, TextBox prix)
        {
            string fichier = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/JournalEvenements.txt";
            if (File.Exists(fichier))
            {
                using (StreamWriter jEven = File.AppendText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("ACHAT D'UN VEHICULE\t[" + date.Text + "] => : " + cbNomMarque.Text + " " + cbNomModele.Text + " (ID :  " + tbIdVoiture.Text
                       + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + tbIdClient.Text + ")" + "\t POUR LE PRIX DE : " + prix.Text + "€");
                    jEven.Close();
                }
            }
            else
            {
                using(StreamWriter jEven = File.CreateText(fichier))
            {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\tJ O U R N A L   D E S   E V E N E M E N T S");
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("ACHAT D'UN VEHICULE\t[" + date.Text + "] => : " + cbNomMarque.Text + " " + cbNomModele.Text + " (ID :  " + tbIdVoiture.Text
                        + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + tbIdClient.Text + ")" + "\t POUR LE PRIX DE : " + prix.Text + "€");
                    jEven.Close();
                }
            }
        }

        public void AjoutSuppressionAchatJournal(int IdVoiture, string NomMarque, string NomModele, int IdClient, string nomClient, string prenomClient, DateTime date, int prix)
        {
            string fichier = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/JournalEvenements.txt";
            if (File.Exists(fichier))
            {
                using (StreamWriter jEven = File.AppendText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("SUPPRESSION ACHAT D'UN VEHICULE\t[" + date.ToLongDateString() + "] => : " + NomMarque + " " + NomModele + " (ID :  " + IdVoiture.ToString()
                       + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + IdClient.ToString() + ")" + "\t POUR LE PRIX DE : " + prix.ToString() + "€");
                    jEven.Close();
                }
            }
            else
            {
                using (StreamWriter jEven = File.CreateText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\tJ O U R N A L   D E S   E V E N E M E N T S");
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("SUPPRESSION ACHAT D'UN VEHICULE\t[" + date.ToLongDateString() + "] => : " + NomMarque + " " + NomModele + " (ID :  " + IdVoiture.ToString()
                        + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + IdClient.ToString() + ")" + "\t POUR LE PRIX DE : " + prix.ToString() + "€");
                    jEven.Close();
                }
            }
        }

        public void AjoutVenteJournal(TextBox tbIdVoiture, TextBox tbNomMarque, TextBox tbNomModele, TextBox tbIdClient, string nomClient, string prenomClient, DateTimePicker date, TextBox prix)
        {
            string fichier = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/JournalEvenements.txt";
            if (File.Exists(fichier))
            {
                using (StreamWriter jEven = File.AppendText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("VENTE D'UN VEHICULE\t[" + date.Text + "]: " + tbNomMarque.Text + " " + tbNomModele.Text + " (ID :  " + tbIdVoiture.Text
                       + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + tbIdClient.Text + ")" + "\t POUR LE PRIX DE : " + prix.Text + "€");
                    jEven.Close();
                }
            }
            else
            {
                using (StreamWriter jEven = File.CreateText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\tJ O U R N A L   D E S   E V E N E M E N T S");
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("VENTE D'UN VEHICULE\t[" + date.Text + "]: " + tbNomMarque.Text + " " + tbNomModele.Text + " (ID :  " + tbIdVoiture.Text
                        + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + tbIdClient.Text + ")" + "\t POUR LE PRIX DE : " + prix.Text + "€");
                    jEven.Close();
                }
            }
        }

        public void AjoutSuppressionVenteJournal(int IdVoiture, string NomMarque, string NomModele, int IdClient, string nomClient, string prenomClient, DateTime date, int prix)
        {
            string fichier = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/JournalEvenements.txt";
            if (File.Exists(fichier))
            {
                using (StreamWriter jEven = File.AppendText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("SUPPRESSION VENTE D'UN VEHICULE\t[" + date.ToLongDateString() + "]: " + NomMarque.ToString() + " " + NomModele.ToString() + " (ID :  " + IdVoiture.ToString()
                       + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + IdClient.ToString() + ")" + "\t POUR LE PRIX DE : " + prix.ToString() + "€");
                    jEven.Close();
                }
            }
            else
            {
                using (StreamWriter jEven = File.CreateText(fichier))
                {
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\tJ O U R N A L   D E S   E V E N E M E N T S");
                    jEven.WriteLine("\t\t\t\t\t\t\t\t\t\t\t_________________________________________\n\n\n");
                    jEven.WriteLine("SUPPRESSION VENTE D'UN VEHICULE\t[" + date.ToLongDateString() + "]: " + NomMarque.ToString() + " " + NomModele.ToString() + " (ID :  " + IdVoiture.ToString()
                        + ")  \tAU CLIENT : " + nomClient + " " + prenomClient + "(ID : " + IdClient.ToString() + ")" + "\t POUR LE PRIX DE : " + prix.ToString() + "€");
                    jEven.Close();
                }
            }
        }

        public void LireContenuJournal(RichTextBox rtbJournal)
        {
            rtbJournal.Clear();

            string fichier = @"C:/Users/Maesm/Desktop/MAES_Maxime_projet_BD_V2/JournalEvenements.txt";

            if (System.IO.File.Exists(fichier))
            {
                string[] lines = System.IO.File.ReadAllLines(fichier);

                for (int i = 0; i < lines.Length; i++)
                {
                    rtbJournal.AppendText(lines[i] + "\n");
                }
            }
            else
            {
                rtbJournal.AppendText("\t\t\t\t\t\t\t\t\t\t\tJournal des évenements indisponible");
            }
        }
        #endregion
    }
}
