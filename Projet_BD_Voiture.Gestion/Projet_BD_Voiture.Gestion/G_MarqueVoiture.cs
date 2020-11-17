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
 public class G_MarqueVoiture : G_Base
 {
  #region Constructeurs
  public G_MarqueVoiture()
   : base()
  { }
  public G_MarqueVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomMarque, string paysMarque)
  { return new A_MarqueVoiture(ChaineConnexion).Ajouter(nomMarque, paysMarque); }
  public int Modifier(int idMarque, string nomMarque, string paysMarque)
  { return new A_MarqueVoiture(ChaineConnexion).Modifier(idMarque, nomMarque, paysMarque); }
  public List<C_MarqueVoiture> Lire(string Index)
  { return new A_MarqueVoiture(ChaineConnexion).Lire(Index); }
  public C_MarqueVoiture Lire_ID(int idMarque)
  { return new A_MarqueVoiture(ChaineConnexion).Lire_ID(idMarque); }
  public int Supprimer(int idMarque)
  { return new A_MarqueVoiture(ChaineConnexion).Supprimer(idMarque); }
 }
}
