#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_BD_Voiture.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_CouleurVoiture
 {
  #region Données membres
  private int _idCouleur;
  private string _nomCouleur;
  #endregion
  #region Constructeurs
  public C_CouleurVoiture()
  { }
  public C_CouleurVoiture(string nomCouleur_)
  {
   nomCouleur = nomCouleur_;
  }
  public C_CouleurVoiture(int idCouleur_, string nomCouleur_)
   : this(nomCouleur_)
  {
   idCouleur = idCouleur_;
  }
  #endregion
  #region Accesseurs
  public int idCouleur
  {
   get { return _idCouleur; }
   set { _idCouleur = value; }
  }
  public string nomCouleur
  {
   get { return _nomCouleur; }
   set { _nomCouleur = value; }
  }
  #endregion
 }
}
