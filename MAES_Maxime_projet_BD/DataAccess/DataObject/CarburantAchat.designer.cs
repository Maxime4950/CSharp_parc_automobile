﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MAES_Maxime_projet_BD.DataAccess.DataObject
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BD_Voiture")]
	public partial class CarburantAchatDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertCarburantVoiture(CarburantVoiture instance);
    partial void UpdateCarburantVoiture(CarburantVoiture instance);
    partial void DeleteCarburantVoiture(CarburantVoiture instance);
    #endregion
		
		public CarburantAchatDataContext() : 
				base(global::MAES_Maxime_projet_BD.Properties.Settings.Default.BD_VoitureConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public CarburantAchatDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarburantAchatDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarburantAchatDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CarburantAchatDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CarburantVoiture> CarburantVoiture
		{
			get
			{
				return this.GetTable<CarburantVoiture>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CarburantVoiture")]
	public partial class CarburantVoiture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _idCarburant;
		
		private string _nomCarburant;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidCarburantChanging(int value);
    partial void OnidCarburantChanged();
    partial void OnnomCarburantChanging(string value);
    partial void OnnomCarburantChanged();
    #endregion
		
		public CarburantVoiture()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idCarburant", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int idCarburant
		{
			get
			{
				return this._idCarburant;
			}
			set
			{
				if ((this._idCarburant != value))
				{
					this.OnidCarburantChanging(value);
					this.SendPropertyChanging();
					this._idCarburant = value;
					this.SendPropertyChanged("idCarburant");
					this.OnidCarburantChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomCarburant", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nomCarburant
		{
			get
			{
				return this._nomCarburant;
			}
			set
			{
				if ((this._nomCarburant != value))
				{
					this.OnnomCarburantChanging(value);
					this.SendPropertyChanging();
					this._nomCarburant = value;
					this.SendPropertyChanged("nomCarburant");
					this.OnnomCarburantChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
