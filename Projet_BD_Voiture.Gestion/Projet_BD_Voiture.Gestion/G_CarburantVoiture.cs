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
 public class G_CarburantVoiture : G_Base
 {
  #region Constructeurs
  public G_CarburantVoiture()
   : base()
  { }
  public G_CarburantVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomCarburant)
  { return new A_CarburantVoiture(ChaineConnexion).Ajouter(nomCarburant); }
  public int Modifier(int idCarburant, string nomCarburant)
  { return new A_CarburantVoiture(ChaineConnexion).Modifier(idCarburant, nomCarburant); }
  public List<C_CarburantVoiture> Lire(string Index)
  { return new A_CarburantVoiture(ChaineConnexion).Lire(Index); }
  public C_CarburantVoiture Lire_ID(int idCarburant)
  { return new A_CarburantVoiture(ChaineConnexion).Lire_ID(idCarburant); }
  public int Supprimer(int idCarburant)
  { return new A_CarburantVoiture(ChaineConnexion).Supprimer(idCarburant); }
 }
}
