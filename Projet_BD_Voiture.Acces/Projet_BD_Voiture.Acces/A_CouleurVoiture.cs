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
 public class A_CouleurVoiture : ADBase
 {
  #region Constructeurs
  public A_CouleurVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomCouleur)
  {
   CreerCommande("AjouterCouleurVoiture");
   int res = 0;
   Commande.Parameters.Add("idCouleur", SqlDbType.Int);
   Direction("idCouleur", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomCouleur", nomCouleur);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idCouleur"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idCouleur, string nomCouleur)
  {
   CreerCommande("ModifierCouleurVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   Commande.Parameters.AddWithValue("@nomCouleur", nomCouleur);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_CouleurVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerCouleurVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_CouleurVoiture> res = new List<C_CouleurVoiture>();
   while (dr.Read())
   {
    C_CouleurVoiture tmp = new C_CouleurVoiture();
    tmp.idCouleur = int.Parse(dr["idCouleur"].ToString());
    tmp.nomCouleur = dr["nomCouleur"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_CouleurVoiture Lire_ID(int idCouleur)
  {
   CreerCommande("SelectionnerCouleurVoiture_ID");
   Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_CouleurVoiture res = new C_CouleurVoiture();
   while (dr.Read())
   {
    res.idCouleur = int.Parse(dr["idCouleur"].ToString());
    res.nomCouleur = dr["nomCouleur"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idCouleur)
  {
   CreerCommande("SupprimerCouleurVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idCouleur", idCouleur);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
