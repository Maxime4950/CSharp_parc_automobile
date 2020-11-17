#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BD_Voiture.Classes;
using Projet_BD_Voiture.Acces;
#endregion

namespace Projet_BD_Voiture.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_AchatVenteVoiture : G_Base
 {
  #region Constructeurs
  public G_AchatVenteVoiture()
   : base()
  { }
  public G_AchatVenteVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int idVoiture, int idClient, int prixOperation, DateTime dateOperation, int idPaiement,string typeOperation)
  { return new A_AchatVenteVoiture(ChaineConnexion).Ajouter(idVoiture, idClient, prixOperation, dateOperation, idPaiement,typeOperation); }
  public int Modifier(int idOperation, int idVoiture, int idClient, int prixOperation, DateTime dateOperation, int idPaiement, string typeOperation)
  { return new A_AchatVenteVoiture(ChaineConnexion).Modifier(idOperation, idVoiture, idClient, prixOperation, dateOperation, idPaiement, typeOperation); }
  public List<C_AchatVenteVoiture> Lire(string Index)
  { return new A_AchatVenteVoiture(ChaineConnexion).Lire(Index); }
  public C_AchatVenteVoiture Lire_ID(int idOperation)
  { return new A_AchatVenteVoiture(ChaineConnexion).Lire_ID(idOperation); }
  public int Supprimer(int idOperation)
  { return new A_AchatVenteVoiture(ChaineConnexion).Supprimer(idOperation); }
 }
}
