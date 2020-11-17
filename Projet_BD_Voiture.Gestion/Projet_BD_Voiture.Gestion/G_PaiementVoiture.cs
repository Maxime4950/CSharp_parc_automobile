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
 public class G_PaiementVoiture : G_Base
 {
  #region Constructeurs
  public G_PaiementVoiture()
   : base()
  { }
  public G_PaiementVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string nomPaiement)
  { return new A_PaiementVoiture(ChaineConnexion).Ajouter(nomPaiement); }
  public int Modifier(int idPaiement, string nomPaiement)
  { return new A_PaiementVoiture(ChaineConnexion).Modifier(idPaiement, nomPaiement); }
  public List<C_PaiementVoiture> Lire(string Index)
  { return new A_PaiementVoiture(ChaineConnexion).Lire(Index); }
  public C_PaiementVoiture Lire_ID(int idPaiement)
  { return new A_PaiementVoiture(ChaineConnexion).Lire_ID(idPaiement); }
  public int Supprimer(int idPaiement)
  { return new A_PaiementVoiture(ChaineConnexion).Supprimer(idPaiement); }
 }
}
