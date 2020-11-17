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
 public class A_CarburantVoiture : ADBase
 {
  #region Constructeurs
  public A_CarburantVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomCarburant)
  {
   CreerCommande("AjouterCarburantVoiture");
   int res = 0;
   Commande.Parameters.Add("idCarburant", SqlDbType.Int);
   Direction("idCarburant", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomCarburant", nomCarburant);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idCarburant"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idCarburant, string nomCarburant)
  {
   CreerCommande("ModifierCarburantVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   Commande.Parameters.AddWithValue("@nomCarburant", nomCarburant);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_CarburantVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerCarburantVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_CarburantVoiture> res = new List<C_CarburantVoiture>();
   while (dr.Read())
   {
    C_CarburantVoiture tmp = new C_CarburantVoiture();
    tmp.idCarburant = int.Parse(dr["idCarburant"].ToString());
    tmp.nomCarburant = dr["nomCarburant"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_CarburantVoiture Lire_ID(int idCarburant)
  {
   CreerCommande("SelectionnerCarburantVoiture_ID");
   Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_CarburantVoiture res = new C_CarburantVoiture();
   while (dr.Read())
   {
    res.idCarburant = int.Parse(dr["idCarburant"].ToString());
    res.nomCarburant = dr["nomCarburant"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idCarburant)
  {
   CreerCommande("SupprimerCarburantVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idCarburant", idCarburant);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
