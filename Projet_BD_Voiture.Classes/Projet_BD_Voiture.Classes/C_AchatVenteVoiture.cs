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
 public class C_AchatVenteVoiture
 {
  #region Données membres
  private int _idOperation;
  private int _idVoiture;
  private int _idClient;
  private int _prixOperation;
  private DateTime _dateOperation;
  private int _idPaiement;
  private string _typeOperation;
  #endregion
  #region Constructeurs
  public C_AchatVenteVoiture()
  { }
  public C_AchatVenteVoiture(int idVoiture_, int idClient_, int prixOperation_, DateTime dateOperation_, int idPaiement_,string typeOperation_)
  {
   idVoiture = idVoiture_;
   idClient = idClient_;
   prixOperation = prixOperation_;
   dateOperation = dateOperation_;
   idPaiement = idPaiement_;
   typeOperation = typeOperation_;
  }
  public C_AchatVenteVoiture(int idOperation_, int idVoiture_, int idClient_, int prixOperation_, DateTime dateOperation_, int idPaiement_, string typeOperation_)
   : this(idVoiture_, idClient_, prixOperation_, dateOperation_, idPaiement_, typeOperation_)
  {
   idOperation = idOperation_;
  }
  #endregion
  #region Accesseurs
  public int idOperation
  {
   get { return _idOperation; }
   set { _idOperation = value; }
  }
  public int idVoiture
  {
   get { return _idVoiture; }
   set { _idVoiture = value; }
  }
  public int idClient
  {
   get { return _idClient; }
   set { _idClient = value; }
  }
  public int prixOperation
  {
   get { return _prixOperation; }
   set { _prixOperation = value; }
  }
  public DateTime dateOperation
  {
   get { return _dateOperation; }
   set { _dateOperation = value; }
  }
  public int idPaiement
  {
   get { return _idPaiement; }
   set { _idPaiement = value; }
  }

  public string typeOperation
  {
   get { return _typeOperation; }
   set { _typeOperation = value; }
  }
  #endregion
 }
}
