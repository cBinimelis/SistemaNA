﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bd_nanahi")]
public partial class BDConxDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Definiciones de métodos de extensibilidad
  partial void OnCreated();
  partial void InsertUsuarios(Usuarios instance);
  partial void UpdateUsuarios(Usuarios instance);
  partial void DeleteUsuarios(Usuarios instance);
  partial void InsertEstadoUsuario(EstadoUsuario instance);
  partial void UpdateEstadoUsuario(EstadoUsuario instance);
  partial void DeleteEstadoUsuario(EstadoUsuario instance);
  partial void InsertTipoUsuario(TipoUsuario instance);
  partial void UpdateTipoUsuario(TipoUsuario instance);
  partial void DeleteTipoUsuario(TipoUsuario instance);
  #endregion
	
	public BDConxDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["bd_nanahiConS"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public BDConxDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BDConxDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BDConxDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public BDConxDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Usuarios> Usuarios
	{
		get
		{
			return this.GetTable<Usuarios>();
		}
	}
	
	public System.Data.Linq.Table<EstadoUsuario> EstadoUsuario
	{
		get
		{
			return this.GetTable<EstadoUsuario>();
		}
	}
	
	public System.Data.Linq.Table<TipoUsuario> TipoUsuario
	{
		get
		{
			return this.GetTable<TipoUsuario>();
		}
	}
	
	public System.Data.Linq.Table<vUsuarios> vUsuarios
	{
		get
		{
			return this.GetTable<vUsuarios>();
		}
	}
	
	public System.Data.Linq.Table<vProductos> vProductos
	{
		get
		{
			return this.GetTable<vProductos>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _IdUsuario;
	
	private string _Nombre;
	
	private string _Apellido;
	
	private string _Correo;
	
	private string _Password;
	
	private int _IdEstadoUsuario;
	
	private int _IdTipoUsuario;
	
	private EntityRef<EstadoUsuario> _EstadoUsuario;
	
	private EntityRef<TipoUsuario> _TipoUsuario;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUsuarioChanging(int value);
    partial void OnIdUsuarioChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnApellidoChanging(string value);
    partial void OnApellidoChanged();
    partial void OnCorreoChanging(string value);
    partial void OnCorreoChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnIdEstadoUsuarioChanging(int value);
    partial void OnIdEstadoUsuarioChanged();
    partial void OnIdTipoUsuarioChanging(int value);
    partial void OnIdTipoUsuarioChanged();
    #endregion
	
	public Usuarios()
	{
		this._EstadoUsuario = default(EntityRef<EstadoUsuario>);
		this._TipoUsuario = default(EntityRef<TipoUsuario>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int IdUsuario
	{
		get
		{
			return this._IdUsuario;
		}
		set
		{
			if ((this._IdUsuario != value))
			{
				this.OnIdUsuarioChanging(value);
				this.SendPropertyChanging();
				this._IdUsuario = value;
				this.SendPropertyChanged("IdUsuario");
				this.OnIdUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this.OnNombreChanging(value);
				this.SendPropertyChanging();
				this._Nombre = value;
				this.SendPropertyChanged("Nombre");
				this.OnNombreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Apellido
	{
		get
		{
			return this._Apellido;
		}
		set
		{
			if ((this._Apellido != value))
			{
				this.OnApellidoChanging(value);
				this.SendPropertyChanging();
				this._Apellido = value;
				this.SendPropertyChanged("Apellido");
				this.OnApellidoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
	public string Correo
	{
		get
		{
			return this._Correo;
		}
		set
		{
			if ((this._Correo != value))
			{
				this.OnCorreoChanging(value);
				this.SendPropertyChanging();
				this._Correo = value;
				this.SendPropertyChanged("Correo");
				this.OnCorreoChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstadoUsuario", DbType="Int NOT NULL")]
	public int IdEstadoUsuario
	{
		get
		{
			return this._IdEstadoUsuario;
		}
		set
		{
			if ((this._IdEstadoUsuario != value))
			{
				if (this._EstadoUsuario.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIdEstadoUsuarioChanging(value);
				this.SendPropertyChanging();
				this._IdEstadoUsuario = value;
				this.SendPropertyChanged("IdEstadoUsuario");
				this.OnIdEstadoUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoUsuario", DbType="Int NOT NULL")]
	public int IdTipoUsuario
	{
		get
		{
			return this._IdTipoUsuario;
		}
		set
		{
			if ((this._IdTipoUsuario != value))
			{
				if (this._TipoUsuario.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIdTipoUsuarioChanging(value);
				this.SendPropertyChanging();
				this._IdTipoUsuario = value;
				this.SendPropertyChanged("IdTipoUsuario");
				this.OnIdTipoUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EstadoUsuario_Usuarios", Storage="_EstadoUsuario", ThisKey="IdEstadoUsuario", OtherKey="IdEstadoUsuario", IsForeignKey=true)]
	public EstadoUsuario EstadoUsuario
	{
		get
		{
			return this._EstadoUsuario.Entity;
		}
		set
		{
			EstadoUsuario previousValue = this._EstadoUsuario.Entity;
			if (((previousValue != value) 
						|| (this._EstadoUsuario.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._EstadoUsuario.Entity = null;
					previousValue.Usuarios.Remove(this);
				}
				this._EstadoUsuario.Entity = value;
				if ((value != null))
				{
					value.Usuarios.Add(this);
					this._IdEstadoUsuario = value.IdEstadoUsuario;
				}
				else
				{
					this._IdEstadoUsuario = default(int);
				}
				this.SendPropertyChanged("EstadoUsuario");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoUsuario_Usuarios", Storage="_TipoUsuario", ThisKey="IdTipoUsuario", OtherKey="IdTipoUsuario", IsForeignKey=true)]
	public TipoUsuario TipoUsuario
	{
		get
		{
			return this._TipoUsuario.Entity;
		}
		set
		{
			TipoUsuario previousValue = this._TipoUsuario.Entity;
			if (((previousValue != value) 
						|| (this._TipoUsuario.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._TipoUsuario.Entity = null;
					previousValue.Usuarios.Remove(this);
				}
				this._TipoUsuario.Entity = value;
				if ((value != null))
				{
					value.Usuarios.Add(this);
					this._IdTipoUsuario = value.IdTipoUsuario;
				}
				else
				{
					this._IdTipoUsuario = default(int);
				}
				this.SendPropertyChanged("TipoUsuario");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EstadoUsuario")]
public partial class EstadoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _IdEstadoUsuario;
	
	private string _Descripcion;
	
	private EntitySet<Usuarios> _Usuarios;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdEstadoUsuarioChanging(int value);
    partial void OnIdEstadoUsuarioChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
	
	public EstadoUsuario()
	{
		this._Usuarios = new EntitySet<Usuarios>(new Action<Usuarios>(this.attach_Usuarios), new Action<Usuarios>(this.detach_Usuarios));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstadoUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int IdEstadoUsuario
	{
		get
		{
			return this._IdEstadoUsuario;
		}
		set
		{
			if ((this._IdEstadoUsuario != value))
			{
				this.OnIdEstadoUsuarioChanging(value);
				this.SendPropertyChanging();
				this._IdEstadoUsuario = value;
				this.SendPropertyChanged("IdEstadoUsuario");
				this.OnIdEstadoUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Descripcion
	{
		get
		{
			return this._Descripcion;
		}
		set
		{
			if ((this._Descripcion != value))
			{
				this.OnDescripcionChanging(value);
				this.SendPropertyChanging();
				this._Descripcion = value;
				this.SendPropertyChanged("Descripcion");
				this.OnDescripcionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="EstadoUsuario_Usuarios", Storage="_Usuarios", ThisKey="IdEstadoUsuario", OtherKey="IdEstadoUsuario")]
	public EntitySet<Usuarios> Usuarios
	{
		get
		{
			return this._Usuarios;
		}
		set
		{
			this._Usuarios.Assign(value);
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
	
	private void attach_Usuarios(Usuarios entity)
	{
		this.SendPropertyChanging();
		entity.EstadoUsuario = this;
	}
	
	private void detach_Usuarios(Usuarios entity)
	{
		this.SendPropertyChanging();
		entity.EstadoUsuario = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TipoUsuario")]
public partial class TipoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _IdTipoUsuario;
	
	private string _Descripcion;
	
	private EntitySet<Usuarios> _Usuarios;
	
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTipoUsuarioChanging(int value);
    partial void OnIdTipoUsuarioChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    #endregion
	
	public TipoUsuario()
	{
		this._Usuarios = new EntitySet<Usuarios>(new Action<Usuarios>(this.attach_Usuarios), new Action<Usuarios>(this.detach_Usuarios));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoUsuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int IdTipoUsuario
	{
		get
		{
			return this._IdTipoUsuario;
		}
		set
		{
			if ((this._IdTipoUsuario != value))
			{
				this.OnIdTipoUsuarioChanging(value);
				this.SendPropertyChanging();
				this._IdTipoUsuario = value;
				this.SendPropertyChanged("IdTipoUsuario");
				this.OnIdTipoUsuarioChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Descripcion
	{
		get
		{
			return this._Descripcion;
		}
		set
		{
			if ((this._Descripcion != value))
			{
				this.OnDescripcionChanging(value);
				this.SendPropertyChanging();
				this._Descripcion = value;
				this.SendPropertyChanged("Descripcion");
				this.OnDescripcionChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TipoUsuario_Usuarios", Storage="_Usuarios", ThisKey="IdTipoUsuario", OtherKey="IdTipoUsuario")]
	public EntitySet<Usuarios> Usuarios
	{
		get
		{
			return this._Usuarios;
		}
		set
		{
			this._Usuarios.Assign(value);
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
	
	private void attach_Usuarios(Usuarios entity)
	{
		this.SendPropertyChanging();
		entity.TipoUsuario = this;
	}
	
	private void detach_Usuarios(Usuarios entity)
	{
		this.SendPropertyChanging();
		entity.TipoUsuario = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vUsuarios")]
public partial class vUsuarios
{
	
	private int _IdUsuario;
	
	private string _Nombre;
	
	private string _Apellido;
	
	private string _Correo;
	
	private string _Password;
	
	private int _IdEstadoUsuario;
	
	private string _DescEstado;
	
	private int _IdTipoUsuario;
	
	private string _DescTipo;
	
	public vUsuarios()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="Int NOT NULL")]
	public int IdUsuario
	{
		get
		{
			return this._IdUsuario;
		}
		set
		{
			if ((this._IdUsuario != value))
			{
				this._IdUsuario = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Nombre
	{
		get
		{
			return this._Nombre;
		}
		set
		{
			if ((this._Nombre != value))
			{
				this._Nombre = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Apellido", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Apellido
	{
		get
		{
			return this._Apellido;
		}
		set
		{
			if ((this._Apellido != value))
			{
				this._Apellido = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correo", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
	public string Correo
	{
		get
		{
			return this._Correo;
		}
		set
		{
			if ((this._Correo != value))
			{
				this._Correo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this._Password = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEstadoUsuario", DbType="Int NOT NULL")]
	public int IdEstadoUsuario
	{
		get
		{
			return this._IdEstadoUsuario;
		}
		set
		{
			if ((this._IdEstadoUsuario != value))
			{
				this._IdEstadoUsuario = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescEstado", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string DescEstado
	{
		get
		{
			return this._DescEstado;
		}
		set
		{
			if ((this._DescEstado != value))
			{
				this._DescEstado = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTipoUsuario", DbType="Int NOT NULL")]
	public int IdTipoUsuario
	{
		get
		{
			return this._IdTipoUsuario;
		}
		set
		{
			if ((this._IdTipoUsuario != value))
			{
				this._IdTipoUsuario = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescTipo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string DescTipo
	{
		get
		{
			return this._DescTipo;
		}
		set
		{
			if ((this._DescTipo != value))
			{
				this._DescTipo = value;
			}
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vProductos")]
public partial class vProductos
{
	
	private int _IdProducto;
	
	private string _CodBarra;
	
	private string _Descripcion;
	
	private int _Precio;
	
	private System.Nullable<System.DateTime> _Fecha_Creacion;
	
	private string _Tipo;
	
	private string _Estado;
	
	private string _Usuario;
	
	public vProductos()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdProducto", DbType="Int NOT NULL")]
	public int IdProducto
	{
		get
		{
			return this._IdProducto;
		}
		set
		{
			if ((this._IdProducto != value))
			{
				this._IdProducto = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodBarra", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string CodBarra
	{
		get
		{
			return this._CodBarra;
		}
		set
		{
			if ((this._CodBarra != value))
			{
				this._CodBarra = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
	public string Descripcion
	{
		get
		{
			return this._Descripcion;
		}
		set
		{
			if ((this._Descripcion != value))
			{
				this._Descripcion = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Precio", DbType="Int NOT NULL")]
	public int Precio
	{
		get
		{
			return this._Precio;
		}
		set
		{
			if ((this._Precio != value))
			{
				this._Precio = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Fecha Creacion]", Storage="_Fecha_Creacion", DbType="Date")]
	public System.Nullable<System.DateTime> Fecha_Creacion
	{
		get
		{
			return this._Fecha_Creacion;
		}
		set
		{
			if ((this._Fecha_Creacion != value))
			{
				this._Fecha_Creacion = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tipo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Tipo
	{
		get
		{
			return this._Tipo;
		}
		set
		{
			if ((this._Tipo != value))
			{
				this._Tipo = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Estado", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Estado
	{
		get
		{
			return this._Estado;
		}
		set
		{
			if ((this._Estado != value))
			{
				this._Estado = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(52)")]
	public string Usuario
	{
		get
		{
			return this._Usuario;
		}
		set
		{
			if ((this._Usuario != value))
			{
				this._Usuario = value;
			}
		}
	}
}
#pragma warning restore 1591
