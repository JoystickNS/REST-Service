﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab4
{
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
	using System;

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BlogDB")]
	public partial class WCFServiceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertPostType(PostType instance);
    partial void UpdatePostType(PostType instance);
    partial void DeletePostType(PostType instance);
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    #endregion
		
		public WCFServiceDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BlogDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WCFServiceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WCFServiceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WCFServiceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WCFServiceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<PostType> PostType
		{
			get
			{
				return this.GetTable<PostType>();
			}
		}
		
		public System.Data.Linq.Table<Post> Post
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
	}

	[global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.PostType")]
	public partial class PostType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _PostTypeID;
		
		private string _PostTypeName;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostTypeIDChanging(short value);
    partial void OnPostTypeIDChanged();
    partial void OnPostTypeNameChanging(string value);
    partial void OnPostTypeNameChanged();
    #endregion
		
		public PostType()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeID", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short PostTypeID
		{
			get
			{
				return this._PostTypeID;
			}
			set
			{
				if ((this._PostTypeID != value))
				{
					this.OnPostTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PostTypeID = value;
					this.SendPropertyChanged("PostTypeID");
					this.OnPostTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PostTypeName
		{
			get
			{
				return this._PostTypeName;
			}
			set
			{
				if ((this._PostTypeName != value))
				{
					this.OnPostTypeNameChanging(value);
					this.SendPropertyChanging();
					this._PostTypeName = value;
					this.SendPropertyChanged("PostTypeName");
					this.OnPostTypeNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Post")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PostID;
		
		private string _PostHeader;
		
		private string _PostText;
		
		private short _PostTypeID;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPostIDChanging(int value);
    partial void OnPostIDChanged();
    partial void OnPostHeaderChanging(string value);
    partial void OnPostHeaderChanged();
    partial void OnPostTextChanging(string value);
    partial void OnPostTextChanged();
    partial void OnPostTypeIDChanging(short value);
    partial void OnPostTypeIDChanged();
    #endregion
		
		public Post()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PostID
		{
			get
			{
				return this._PostID;
			}
			set
			{
				if ((this._PostID != value))
				{
					this.OnPostIDChanging(value);
					this.SendPropertyChanging();
					this._PostID = value;
					this.SendPropertyChanged("PostID");
					this.OnPostIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostHeader", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string PostHeader
		{
			get
			{
				return this._PostHeader;
			}
			set
			{
				if ((this._PostHeader != value))
				{
					this.OnPostHeaderChanging(value);
					this.SendPropertyChanging();
					this._PostHeader = value;
					this.SendPropertyChanged("PostHeader");
					this.OnPostHeaderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostText", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PostText
		{
			get
			{
				return this._PostText;
			}
			set
			{
				if ((this._PostText != value))
				{
					this.OnPostTextChanging(value);
					this.SendPropertyChanging();
					this._PostText = value;
					this.SendPropertyChanged("PostText");
					this.OnPostTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostTypeID", DbType="SmallInt NOT NULL")]
		public short PostTypeID
		{
			get
			{
				return this._PostTypeID;
			}
			set
			{
				if ((this._PostTypeID != value))
				{
					this.OnPostTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PostTypeID = value;
					this.SendPropertyChanged("PostTypeID");
					this.OnPostTypeIDChanged();
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