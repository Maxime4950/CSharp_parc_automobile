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
 public class G_ModeleVoiture : G_Base
 {
  #region Constructeurs
  public G_ModeleVoiture()
   : base()
  { }
  public G_ModeleVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomModele)
  { return new A_ModeleVoiture(ChaineConnexion).Ajouter(nomModele); }
  public int Modifier(int idModele, string nomModele)
  { return new A_ModeleVoiture(ChaineConnexion).Modifier(idModele, nomModele); }
  public List<C_ModeleVoiture> Lire(string Index)
  { return new A_ModeleVoiture(ChaineConnexion).Lire(Index); }
  public C_ModeleVoiture Lire_ID(int idModele)
  { return new A_ModeleVoiture(ChaineConnexion).Lire_ID(idModele); }
  public int Supprimer(int idModele)
  { return new A_ModeleVoiture(ChaineConnexion).Supprimer(idModele); }
 }
}
