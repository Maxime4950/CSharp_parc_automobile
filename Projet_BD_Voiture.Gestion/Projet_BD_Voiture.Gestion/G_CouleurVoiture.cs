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
 public class G_CouleurVoiture : G_Base
 {
  #region Constructeurs
  public G_CouleurVoiture()
   : base()
  { }
  public G_CouleurVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomCouleur)
  { return new A_CouleurVoiture(ChaineConnexion).Ajouter(nomCouleur); }
  public int Modifier(int idCouleur, string nomCouleur)
  { return new A_CouleurVoiture(ChaineConnexion).Modifier(idCouleur, nomCouleur); }
  public List<C_CouleurVoiture> Lire(string Index)
  { return new A_CouleurVoiture(ChaineConnexion).Lire(Index); }
  public C_CouleurVoiture Lire_ID(int idCouleur)
  { return new A_CouleurVoiture(ChaineConnexion).Lire_ID(idCouleur); }
  public int Supprimer(int idCouleur)
  { return new A_CouleurVoiture(ChaineConnexion).Supprimer(idCouleur); }
 }
}
