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
 public class C_MarqueVoiture
 {
  #region Données membres
  private int _idMarque;
  private string _nomMarque;
  private string _paysMarque;
  #endregion
  #region Constructeurs
  public C_MarqueVoiture()
  { }
  public C_MarqueVoiture(string nomMarque_, string paysMarque_)
  {
   nomMarque = nomMarque_;
   paysMarque = paysMarque_;
  }
  public C_MarqueVoiture(int idMarque_, string nomMarque_, string paysMarque_)
   : this(nomMarque_, paysMarque_)
  {
   idMarque = idMarque_;
  }
  #endregion
  #region Accesseurs
  public int idMarque
  {
   get { return _idMarque; }
   set { _idMarque = value; }
  }
  public string nomMarque
  {
   get { return _nomMarque; }
   set { _nomMarque = value; }
  }
  public string paysMarque
  {
   get { return _paysMarque; }
   set { _paysMarque = value; }
  }
  #endregion
 }
}
