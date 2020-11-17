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
 public class C_PaiementVoiture
 {
  #region Données membres
  private int _idPaiement;
  private string _nomPaiement;
  #endregion
  #region Constructeurs
  public C_PaiementVoiture()
  { }
  public C_PaiementVoiture(string nomPaiement_)
  {
   nomPaiement = nomPaiement_;
  }
  public C_PaiementVoiture(int idPaiement_, string nomPaiement_)
   : this(nomPaiement_)
  {
   idPaiement = idPaiement_;
  }
  #endregion
  #region Accesseurs
  public int idPaiement
  {
   get { return _idPaiement; }
   set { _idPaiement = value; }
  }
  public string nomPaiement
  {
   get { return _nomPaiement; }
   set { _nomPaiement = value; }
  }
  #endregion
 }
}
