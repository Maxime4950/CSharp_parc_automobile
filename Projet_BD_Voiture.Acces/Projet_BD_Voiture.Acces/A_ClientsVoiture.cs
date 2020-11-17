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
 public class A_ClientsVoiture : ADBase
 {
  #region Constructeurs
  public A_ClientsVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomClient, string prenomClient, string rueClient, int numeroClient, int? boiteClient, int codePoClient, string localiteClient)
  {
   CreerCommande("AjouterClientsVoiture");
   int res = 0;
   Commande.Parameters.Add("idClient", SqlDbType.Int);
   Direction("idClient", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomClient", nomClient);
   Commande.Parameters.AddWithValue("@prenomClient", prenomClient);
   Commande.Parameters.AddWithValue("@rueClient", rueClient);
   Commande.Parameters.AddWithValue("@numeroClient", numeroClient);
   if(boiteClient == null) Commande.Parameters.AddWithValue("@boiteClient", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@boiteClient", boiteClient);
   Commande.Parameters.AddWithValue("@codePoClient", codePoClient);
   Commande.Parameters.AddWithValue("@localiteClient", localiteClient);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idClient"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idClient, string nomClient, string prenomClient, string rueClient, int numeroClient, int? boiteClient, int codePoClient, string localiteClient)
  {
   CreerCommande("ModifierClientsVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idClient", idClient);
   Commande.Parameters.AddWithValue("@nomClient", nomClient);
   Commande.Parameters.AddWithValue("@prenomClient", prenomClient);
   Commande.Parameters.AddWithValue("@rueClient", rueClient);
   Commande.Parameters.AddWithValue("@numeroClient", numeroClient);
   if(boiteClient == null) Commande.Parameters.AddWithValue("@boiteClient", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@boiteClient", boiteClient);
   Commande.Parameters.AddWithValue("@codePoClient", codePoClient);
   Commande.Parameters.AddWithValue("@localiteClient", localiteClient);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_ClientsVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerClientsVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_ClientsVoiture> res = new List<C_ClientsVoiture>();
   while (dr.Read())
   {
    C_ClientsVoiture tmp = new C_ClientsVoiture();
    tmp.idClient = int.Parse(dr["idClient"].ToString());
    tmp.nomClient = dr["nomClient"].ToString();
    tmp.prenomClient = dr["prenomClient"].ToString();
    tmp.rueClient = dr["rueClient"].ToString();
    tmp.numeroClient = int.Parse(dr["numeroClient"].ToString());
   if(dr["boiteClient"] != DBNull.Value) tmp.boiteClient = int.Parse(dr["boiteClient"].ToString());
    tmp.codePoClient = int.Parse(dr["codePoClient"].ToString());
    tmp.localiteClient = dr["localiteClient"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_ClientsVoiture Lire_ID(int idClient)
  {
   CreerCommande("SelectionnerClientsVoiture_ID");
   Commande.Parameters.AddWithValue("@idClient", idClient);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_ClientsVoiture res = new C_ClientsVoiture();
   while (dr.Read())
   {
    res.idClient = int.Parse(dr["idClient"].ToString());
    res.nomClient = dr["nomClient"].ToString();
    res.prenomClient = dr["prenomClient"].ToString();
    res.rueClient = dr["rueClient"].ToString();
    res.numeroClient = int.Parse(dr["numeroClient"].ToString());
   if(dr["boiteClient"] != DBNull.Value) res.boiteClient = int.Parse(dr["boiteClient"].ToString());
    res.codePoClient = int.Parse(dr["codePoClient"].ToString());
    res.localiteClient = dr["localiteClient"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idClient)
  {
   CreerCommande("SupprimerClientsVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idClient", idClient);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
