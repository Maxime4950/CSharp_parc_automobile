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
 public class C_ClientsVoiture
 {
  #region Données membres
  private int _idClient;
  private string _nomClient;
  private string _prenomClient;
  private string _rueClient;
  private int _numeroClient;
  private int? _boiteClient;
  private int _codePoClient;
  private string _localiteClient;
  #endregion
  #region Constructeurs
  public C_ClientsVoiture()
  { }
  public C_ClientsVoiture(string nomClient_, string prenomClient_, string rueClient_, int numeroClient_, int? boiteClient_, int codePoClient_, string localiteClient_)
  {
   nomClient = nomClient_;
   prenomClient = prenomClient_;
   rueClient = rueClient_;
   numeroClient = numeroClient_;
   boiteClient = boiteClient_;
   codePoClient = codePoClient_;
   localiteClient = localiteClient_;
  }
  public C_ClientsVoiture(int idClient_, string nomClient_, string prenomClient_, string rueClient_, int numeroClient_, int? boiteClient_, int codePoClient_, string localiteClient_)
   : this(nomClient_, prenomClient_, rueClient_, numeroClient_, boiteClient_, codePoClient_, localiteClient_)
  {
   idClient = idClient_;
  }
  #endregion
  #region Accesseurs
  public int idClient
  {
   get { return _idClient; }
   set { _idClient = value; }
  }
  public string nomClient
  {
   get { return _nomClient; }
   set { _nomClient = value; }
  }
  public string prenomClient
  {
   get { return _prenomClient; }
   set { _prenomClient = value; }
  }
  public string rueClient
  {
   get { return _rueClient; }
   set { _rueClient = value; }
  }
  public int numeroClient
  {
   get { return _numeroClient; }
   set { _numeroClient = value; }
  }
  public int? boiteClient
  {
   get { return _boiteClient; }
   set { _boiteClient = value; }
  }
  public int codePoClient
  {
   get { return _codePoClient; }
   set { _codePoClient = value; }
  }
  public string localiteClient
  {
   get { return _localiteClient; }
   set { _localiteClient = value; }
  }
  #endregion
 }
}
