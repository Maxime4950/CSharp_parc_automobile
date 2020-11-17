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
 public class C_CategorieVoiture
 {
  #region Données membres
  private int _idCat;
  private string _nomCat;
  #endregion
  #region Constructeurs
  public C_CategorieVoiture()
  { }
  public C_CategorieVoiture(string nomCat_)
  {
   nomCat = nomCat_;
  }
  public C_CategorieVoiture(int idCat_, string nomCat_)
   : this(nomCat_)
  {
   idCat = idCat_;
  }
  #endregion
  #region Accesseurs
  public int idCat
  {
   get { return _idCat; }
   set { _idCat = value; }
  }
  public string nomCat
  {
   get { return _nomCat; }
   set { _nomCat = value; }
  }
  #endregion
 }
}
