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
 public class C_StockVoiture
 {
  #region Données membres
  private int _idVoiture;
  private int _idMarque;
  private int _idModele;
  private int _idCategorie;
  private int? _anneeFabrication;
  private int? _idCarburant;
  private int? _idCouleur;
  private int? _kilometrage;
  #endregion
  #region Constructeurs
  public C_StockVoiture()
  { }
  public C_StockVoiture(int idMarque_, int idModele_, int idCategorie_, int? anneeFabrication_, int? idCarburant_, int? idCouleur_, int? kilometrage_)
  {
   idMarque = idMarque_;
   idModele = idModele_;
   idCategorie = idCategorie_;
   anneeFabrication = anneeFabrication_;
   idCarburant = idCarburant_;
   idCouleur = idCouleur_;
   kilometrage = kilometrage_;
  }
  public C_StockVoiture(int idVoiture_, int idMarque_, int idModele_, int idCategorie_, int? anneeFabrication_, int? idCarburant_, int? idCouleur_, int? kilometrage_)
   : this(idMarque_, idModele_, idCategorie_, anneeFabrication_, idCarburant_, idCouleur_, kilometrage_)
  {
   idVoiture = idVoiture_;
  }
  #endregion
  #region Accesseurs
  public int idVoiture
  {
   get { return _idVoiture; }
   set { _idVoiture = value; }
  }
  public int idMarque
  {
   get { return _idMarque; }
   set { _idMarque = value; }
  }
  public int idModele
  {
   get { return _idModele; }
   set { _idModele = value; }
  }
  public int idCategorie
  {
   get { return _idCategorie; }
   set { _idCategorie = value; }
  }
  public int? anneeFabrication
  {
   get { return _anneeFabrication; }
   set { _anneeFabrication = value; }
  }
  public int? idCarburant
  {
   get { return _idCarburant; }
   set { _idCarburant = value; }
  }
  public int? idCouleur
  {
   get { return _idCouleur; }
   set { _idCouleur = value; }
  }
  public int? kilometrage
  {
   get { return _kilometrage; }
   set { _kilometrage = value; }
  }
  #endregion
 }
}
