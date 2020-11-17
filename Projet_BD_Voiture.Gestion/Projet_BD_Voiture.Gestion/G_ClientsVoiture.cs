#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BD_Voiture.Classes;
using Projet_BD_Voiture.Acces;
#endregion

namespace Projet_BD_Voiture.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_ClientsVoiture : G_Base
 {
  #region Constructeurs
  public G_ClientsVoiture()
   : base()
  { }
  public G_ClientsVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomClient, string prenomClient, string rueClient, int numeroClient, int? boiteClient, int codePoClient, string localiteClient)
  { return new A_ClientsVoiture(ChaineConnexion).Ajouter(nomClient, prenomClient, rueClient, numeroClient, boiteClient, codePoClient, localiteClient); }
  public int Modifier(int idClient, string nomClient, string prenomClient, string rueClient, int numeroClient, int? boiteClient, int codePoClient, string localiteClient)
  { return new A_ClientsVoiture(ChaineConnexion).Modifier(idClient, nomClient, prenomClient, rueClient, numeroClient, boiteClient, codePoClient, localiteClient); }
  public List<C_ClientsVoiture> Lire(string Index)
  { return new A_ClientsVoiture(ChaineConnexion).Lire(Index); }
  public C_ClientsVoiture Lire_ID(int idClient)
  { return new A_ClientsVoiture(ChaineConnexion).Lire_ID(idClient); }
  public int Supprimer(int idClient)
  { return new A_ClientsVoiture(ChaineConnexion).Supprimer(idClient); }
 }
}
