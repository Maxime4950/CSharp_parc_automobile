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
 public class C_CarburantVoiture
 {
  #region Données membres
  private int _idCarburant;
  private string _nomCarburant;
  #endregion
  #region Constructeurs
  public C_CarburantVoiture()
  { }
  public C_CarburantVoiture(string nomCarburant_)
  {
   nomCarburant = nomCarburant_;
  }
  public C_CarburantVoiture(int idCarburant_, string nomCarburant_)
   : this(nomCarburant_)
  {
   idCarburant = idCarburant_;
  }
  #endregion
  #region Accesseurs
  public int idCarburant
  {
   get { return _idCarburant; }
   set { _idCarburant = value; }
  }
  public string nomCarburant
  {
   get { return _nomCarburant; }
   set { _nomCarburant = value; }
  }
  #endregion
 }
}
