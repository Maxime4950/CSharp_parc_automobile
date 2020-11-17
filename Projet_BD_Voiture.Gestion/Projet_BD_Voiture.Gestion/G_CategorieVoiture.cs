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
 public class G_CategorieVoiture : G_Base
 {
  #region Constructeurs
  public G_CategorieVoiture()
   : base()
  { }
  public G_CategorieVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomCat)
  { return new A_CategorieVoiture(ChaineConnexion).Ajouter(nomCat); }
  public int Modifier(int idCat, string nomCat)
  { return new A_CategorieVoiture(ChaineConnexion).Modifier(idCat, nomCat); }
  public List<C_CategorieVoiture> Lire(string Index)
  { return new A_CategorieVoiture(ChaineConnexion).Lire(Index); }
  public C_CategorieVoiture Lire_ID(int idCat)
  { return new A_CategorieVoiture(ChaineConnexion).Lire_ID(idCat); }
  public int Supprimer(int idCat)
  { return new A_CategorieVoiture(ChaineConnexion).Supprimer(idCat); }
 }
}
