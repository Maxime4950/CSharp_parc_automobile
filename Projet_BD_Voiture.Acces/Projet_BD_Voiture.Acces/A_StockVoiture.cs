#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_BD_Voiture.Classes;
#endregion

namespace Projet_BD_Voiture.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_StockVoiture : ADBase
 {
  #region Constructeurs
  public A_StockVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int idMarque, int idModele, int idCategorie, int? anneeFabrication, int? idCarburant, int? idCouleur, int? kilometrage)
  {
   CreerCommande("AjouterStockVoiture");
   int res = 0;
   Commande.Parameters.Add("idVoiture", SqlDbType.Int);
   Direction("idVoiture", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   Commande.Parameters.AddWithValue("@idModele", idModele);
   Commande.Parameters.AddWithValue("@idCategorie", idCategorie);
   if(anneeFabrication == null) Commande.Parameters.AddWithValue("@anneeFabrication", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@anneeFabrication", anneeFabrication);
   if(idCarburant == null) Commande.Parameters.AddWithValue("@idCarburant", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   if(idCouleur == null) Commande.Parameters.AddWithValue("@idCouleur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   if(kilometrage == null) Commande.Parameters.AddWithValue("@kilometrage", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@kilometrage", kilometrage);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idVoiture"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idVoiture, int idMarque, int idModele, int idCategorie, int? anneeFabrication, int? idCarburant, int? idCouleur, int? kilometrage)
  {
   CreerCommande("ModifierStockVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idVoiture", idVoiture);
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   Commande.Parameters.AddWithValue("@idModele", idModele);
   Commande.Parameters.AddWithValue("@idCategorie", idCategorie);
   if(anneeFabrication == null) Commande.Parameters.AddWithValue("@anneeFabrication", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@anneeFabrication", anneeFabrication);
   if(idCarburant == null) Commande.Parameters.AddWithValue("@idCarburant", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   if(idCouleur == null) Commande.Parameters.AddWithValue("@idCouleur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   if(kilometrage == null) Commande.Parameters.AddWithValue("@kilometrage", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@kilometrage", kilometrage);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_StockVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerStockVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_StockVoiture> res = new List<C_StockVoiture>();
   while (dr.Read())
   {
    C_StockVoiture tmp = new C_StockVoiture();
    tmp.idVoiture = int.Parse(dr["idVoiture"].ToString());
    tmp.idMarque = int.Parse(dr["idMarque"].ToString());
    tmp.idModele = int.Parse(dr["idModele"].ToString());
    tmp.idCategorie = int.Parse(dr["idCategorie"].ToString());
   if(dr["anneeFabrication"] != DBNull.Value) tmp.anneeFabrication = int.Parse(dr["anneeFabrication"].ToString());
   if(dr["idCarburant"] != DBNull.Value) tmp.idCarburant = int.Parse(dr["idCarburant"].ToString());
   if(dr["idCouleur"] != DBNull.Value) tmp.idCouleur = int.Parse(dr["idCouleur"].ToString());
   if(dr["kilometrage"] != DBNull.Value) tmp.kilometrage = int.Parse(dr["kilometrage"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_StockVoiture Lire_ID(int idVoiture)
  {
   CreerCommande("SelectionnerStockVoiture_ID");
   Commande.Parameters.AddWithValue("@idVoiture", idVoiture);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_StockVoiture res = new C_StockVoiture();
   while (dr.Read())
   {
    res.idVoiture = int.Parse(dr["idVoiture"].ToString());
    res.idMarque = int.Parse(dr["idMarque"].ToString());
    res.idModele = int.Parse(dr["idModele"].ToString());
    res.idCategorie = int.Parse(dr["idCategorie"].ToString());
   if(dr["anneeFabrication"] != DBNull.Value) res.anneeFabrication = int.Parse(dr["anneeFabrication"].ToString());
   if(dr["idCarburant"] != DBNull.Value) res.idCarburant = int.Parse(dr["idCarburant"].ToString());
   if(dr["idCouleur"] != DBNull.Value) res.idCouleur = int.Parse(dr["idCouleur"].ToString());
   if(dr["kilometrage"] != DBNull.Value) res.kilometrage = int.Parse(dr["kilometrage"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idVoiture)
  {
   CreerCommande("SupprimerStockVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idVoiture", idVoiture);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
