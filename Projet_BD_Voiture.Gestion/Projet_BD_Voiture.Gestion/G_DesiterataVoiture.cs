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
 public class G_DesiterataVoiture : G_Base
 {
  #region Constructeurs
  public G_DesiterataVoiture()
   : base()
  { }
  public G_DesiterataVoiture(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int idClient, int idMarque, int? idModele, int? idCat, int? kilometrageMax, int? idCouleur, int? idCarburant, int? anneeMin)
  { return new A_DesiterataVoiture(ChaineConnexion).Ajouter(idClient, idMarque, idModele, idCat, kilometrageMax, idCouleur, idCarburant, anneeMin); }
  public int Modifier(int idDesiterata, int idClient, int idMarque, int? idModele, int? idCat, int? kilometrageMax, int? idCouleur, int? idCarburant, int? anneeMin)
  { return new A_DesiterataVoiture(ChaineConnexion).Modifier(idDesiterata, idClient, idMarque, idModele, idCat, kilometrageMax, idCouleur, idCarburant, anneeMin); }
  public List<C_DesiterataVoiture> Lire(string Index)
  { return new A_DesiterataVoiture(ChaineConnexion).Lire(Index); }
  public C_DesiterataVoiture Lire_ID(int idDesiterata)
  { return new A_DesiterataVoiture(ChaineConnexion).Lire_ID(idDesiterata); }
  public int Supprimer(int idDesiterata)
  { return new A_DesiterataVoiture(ChaineConnexion).Supprimer(idDesiterata); }
 }
}
