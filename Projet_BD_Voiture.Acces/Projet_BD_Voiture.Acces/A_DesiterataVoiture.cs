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
 public class A_DesiterataVoiture : ADBase
 {
  #region Constructeurs
  public A_DesiterataVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int idClient, int idMarque, int? idModele, int? idCat, int? kilometrageMax, int? idCouleur, int? idCarburant, int? anneeMin)
  {
   CreerCommande("AjouterDesiterataVoiture");
   int res = 0;
   Commande.Parameters.Add("idDesiterata", SqlDbType.Int);
   Direction("idDesiterata", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@idClient", idClient);
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   if(idModele == null) Commande.Parameters.AddWithValue("@idModele", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idModele", idModele);
   if(idCat == null) Commande.Parameters.AddWithValue("@idCat", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCat", idCat);
   if(kilometrageMax == null) Commande.Parameters.AddWithValue("@kilometrageMax", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@kilometrageMax", kilometrageMax);
   if(idCouleur == null) Commande.Parameters.AddWithValue("@idCouleur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   if(idCarburant == null) Commande.Parameters.AddWithValue("@idCarburant", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   if(anneeMin == null) Commande.Parameters.AddWithValue("@anneeMin", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@anneeMin", anneeMin);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idDesiterata"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idDesiterata, int idClient, int idMarque, int? idModele, int? idCat, int? kilometrageMax, int? idCouleur, int? idCarburant, int? anneeMin)
  {
   CreerCommande("ModifierDesiterataVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idDesiterata", idDesiterata);
   Commande.Parameters.AddWithValue("@idClient", idClient);
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   if(idModele == null) Commande.Parameters.AddWithValue("@idModele", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idModele", idModele);
   if(idCat == null) Commande.Parameters.AddWithValue("@idCat", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCat", idCat);
   if(kilometrageMax == null) Commande.Parameters.AddWithValue("@kilometrageMax", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@kilometrageMax", kilometrageMax);
   if(idCouleur == null) Commande.Parameters.AddWithValue("@idCouleur", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   if(idCarburant == null) Commande.Parameters.AddWithValue("@idCarburant", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   if(anneeMin == null) Commande.Parameters.AddWithValue("@anneeMin", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@anneeMin", anneeMin);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_DesiterataVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerDesiterataVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_DesiterataVoiture> res = new List<C_DesiterataVoiture>();
   while (dr.Read())
   {
    C_DesiterataVoiture tmp = new C_DesiterataVoiture();
    tmp.idDesiterata = int.Parse(dr["idDesiterata"].ToString());
    tmp.idClient = int.Parse(dr["idClient"].ToString());
    tmp.idMarque = int.Parse(dr["idMarque"].ToString());
   if(dr["idModele"] != DBNull.Value) tmp.idModele = int.Parse(dr["idModele"].ToString());
   if(dr["idCat"] != DBNull.Value) tmp.idCat = int.Parse(dr["idCat"].ToString());
   if(dr["kilometrageMax"] != DBNull.Value) tmp.kilometrageMax = int.Parse(dr["kilometrageMax"].ToString());
   if(dr["idCouleur"] != DBNull.Value) tmp.idCouleur = int.Parse(dr["idCouleur"].ToString());
   if(dr["idCarburant"] != DBNull.Value) tmp.idCarburant = int.Parse(dr["idCarburant"].ToString());
   if(dr["anneeMin"] != DBNull.Value) tmp.anneeMin = int.Parse(dr["anneeMin"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_DesiterataVoiture Lire_ID(int idDesiterata)
  {
   CreerCommande("SelectionnerDesiterataVoiture_ID");
   Commande.Parameters.AddWithValue("@idDesiterata", idDesiterata);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_DesiterataVoiture res = new C_DesiterataVoiture();
   while (dr.Read())
   {
    res.idDesiterata = int.Parse(dr["idDesiterata"].ToString());
    res.idClient = int.Parse(dr["idClient"].ToString());
    res.idMarque = int.Parse(dr["idMarque"].ToString());
   if(dr["idModele"] != DBNull.Value) res.idModele = int.Parse(dr["idModele"].ToString());
   if(dr["idCat"] != DBNull.Value) res.idCat = int.Parse(dr["idCat"].ToString());
   if(dr["kilometrageMax"] != DBNull.Value) res.kilometrageMax = int.Parse(dr["kilometrageMax"].ToString());
   if(dr["idCouleur"] != DBNull.Value) res.idCouleur = int.Parse(dr["idCouleur"].ToString());
   if(dr["idCarburant"] != DBNull.Value) res.idCarburant = int.Parse(dr["idCarburant"].ToString());
   if(dr["anneeMin"] != DBNull.Value) res.anneeMin = int.Parse(dr["anneeMin"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idDesiterata)
  {
   CreerCommande("SupprimerDesiterataVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idDesiterata", idDesiterata);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
