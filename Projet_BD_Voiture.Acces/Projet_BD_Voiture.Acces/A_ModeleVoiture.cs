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
 public class A_ModeleVoiture : ADBase
 {
  #region Constructeurs
  public A_ModeleVoiture(string sChaineConnexion)
  	: base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomModele)
  {
   CreerCommande("AjouterModeleVoiture");
   int res = 0;
   Commande.Parameters.Add("idModele", SqlDbType.Int);
   Direction("idModele", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@nomModele", nomModele);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("idModele"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int idModele, string nomModele)
  {
   CreerCommande("ModifierModeleVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idModele", idModele);
   Commande.Parameters.AddWithValue("@nomModele", nomModele);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_ModeleVoiture> Lire(string Index)
  {
   CreerCommande("SelectionnerModeleVoiture");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_ModeleVoiture> res = new List<C_ModeleVoiture>();
   while (dr.Read())
   {
    C_ModeleVoiture tmp = new C_ModeleVoiture();
    tmp.idModele = int.Parse(dr["idModele"].ToString());
    tmp.nomModele = dr["nomModele"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_ModeleVoiture Lire_ID(int idModele)
  {
   CreerCommande("SelectionnerModeleVoiture_ID");
   Commande.Parameters.AddWithValue("@idModele", idModele);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_ModeleVoiture res = new C_ModeleVoiture();
   while (dr.Read())
   {
    res.idModele = int.Parse(dr["idModele"].ToString());
    res.nomModele = dr["nomModele"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int idModele)
  {
   CreerCommande("SupprimerModeleVoiture");
   int res = 0;
   Commande.Parameters.AddWithValue("@idModele", idModele);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
