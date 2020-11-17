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
 public class A_PaiementVoiture : ADBase
 {
  #region Constructeurs
  public A_PaiementVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomPaiement)
  {
   CreerCommande("AjouterPaiementVoiture");
   int res = 0;
   Commande.Parameters.Add("idPaiement", SqlDbType.Int);
   Direction("idPaiement", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomPaiement", nomPaiement);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idPaiement"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idPaiement, string nomPaiement)
  {
   CreerCommande("ModifierPaiementVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idPaiement", idPaiement);
   Commande.Parameters.AddWithValue("@nomPaiement", nomPaiement);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_PaiementVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerPaiementVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_PaiementVoiture> res = new List<C_PaiementVoiture>();
   while (dr.Read())
   {
    C_PaiementVoiture tmp = new C_PaiementVoiture();
    tmp.idPaiement = int.Parse(dr["idPaiement"].ToString());
    tmp.nomPaiement = dr["nomPaiement"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_PaiementVoiture Lire_ID(int idPaiement)
  {
   CreerCommande("SelectionnerPaiementVoiture_ID");
   Commande.Parameters.AddWithValue("@idPaiement", idPaiement);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_PaiementVoiture res = new C_PaiementVoiture();
   while (dr.Read())
   {
    res.idPaiement = int.Parse(dr["idPaiement"].ToString());
    res.nomPaiement = dr["nomPaiement"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idPaiement)
  {
   CreerCommande("SupprimerPaiementVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idPaiement", idPaiement);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
