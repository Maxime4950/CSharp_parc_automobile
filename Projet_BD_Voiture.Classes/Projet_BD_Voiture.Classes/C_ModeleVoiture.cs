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
 public class C_ModeleVoiture
 {
  #region Données membres
  private int _idModele;
  private string _nomModele;
  #endregion
  #region Constructeurs
  public C_ModeleVoiture()
  { }
  public C_ModeleVoiture(string nomModele_)
  {
   nomModele = nomModele_;
  }
  public C_ModeleVoiture(int idModele_, string nomModele_)
   : this(nomModele_)
  {
   idModele = idModele_;
  }
  #endregion
  #region Accesseurs
  public int idModele
  {
   get { return _idModele; }
   set { _idModele = value; }
  }
  public string nomModele
  {
   get { return _nomModele; }
   set { _nomModele = value; }
  }
  #endregion
 }
}
