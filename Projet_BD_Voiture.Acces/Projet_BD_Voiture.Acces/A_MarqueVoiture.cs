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
 public class A_MarqueVoiture : ADBase
 {
  #region Constructeurs
  public A_MarqueVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomMarque, string paysMarque)
  {
   CreerCommande("AjouterMarqueVoiture");
   int res = 0;
   Commande.Parameters.Add("idMarque", SqlDbType.Int);
   Direction("idMarque", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomMarque", nomMarque);
   Commande.Parameters.AddWithValue("@paysMarque", paysMarque);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idMarque"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idMarque, string nomMarque, string paysMarque)
  {
   CreerCommande("ModifierMarqueVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   Commande.Parameters.AddWithValue("@nomMarque", nomMarque);
   Commande.Parameters.AddWithValue("@paysMarque", paysMarque);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_MarqueVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerMarqueVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_MarqueVoiture> res = new List<C_MarqueVoiture>();
   while (dr.Read())
   {
    C_MarqueVoiture tmp = new C_MarqueVoiture();
    tmp.idMarque = int.Parse(dr["idMarque"].ToString());
    tmp.nomMarque = dr["nomMarque"].ToString();
    tmp.paysMarque = dr["paysMarque"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_MarqueVoiture Lire_ID(int idMarque)
  {
   CreerCommande("SelectionnerMarqueVoiture_ID");
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_MarqueVoiture res = new C_MarqueVoiture();
   while (dr.Read())
   {
    res.idMarque = int.Parse(dr["idMarque"].ToString());
    res.nomMarque = dr["nomMarque"].ToString();
    res.paysMarque = dr["paysMarque"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idMarque)
  {
   CreerCommande("SupprimerMarqueVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idMarque", idMarque);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
