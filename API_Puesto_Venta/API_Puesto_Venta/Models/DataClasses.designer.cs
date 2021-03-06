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

namespace API_Puesto_Venta.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="examen")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertcategoria(categoria instance);
    partial void Updatecategoria(categoria instance);
    partial void Deletecategoria(categoria instance);
    partial void Insertdeseos(deseos instance);
    partial void Updatedeseos(deseos instance);
    partial void Deletedeseos(deseos instance);
    partial void Insertproducto(producto instance);
    partial void Updateproducto(producto instance);
    partial void Deleteproducto(producto instance);
    partial void Insertusuarios(usuarios instance);
    partial void Updateusuarios(usuarios instance);
    partial void Deleteusuarios(usuarios instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["examenConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<categoria> categoria
		{
			get
			{
				return this.GetTable<categoria>();
			}
		}
		
		public System.Data.Linq.Table<deseos> deseos
		{
			get
			{
				return this.GetTable<deseos>();
			}
		}
		
		public System.Data.Linq.Table<producto> producto
		{
			get
			{
				return this.GetTable<producto>();
			}
		}
		
		public System.Data.Linq.Table<usuarios> usuarios
		{
			get
			{
				return this.GetTable<usuarios>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.delete_carrito")]
		public int delete_carrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_des)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cod_des);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.update_usuario")]
		public int update_usuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string uid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre, apellido, direccion, telefono, correo, pass, uid);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.delete_catalogo")]
		public int delete_catalogo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_cat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cod_cat);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.delete_producto")]
		public int delete_producto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_prod)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cod_prod);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insert_carrito")]
		public int insert_carrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), correo, id_producto, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insert_catalogo")]
		public int insert_catalogo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string categoria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), categoria);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insert_producto")]
		public int insert_producto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_cat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string marca, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), producto, cod_cat, marca, precio, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.insert_usuario")]
		public int insert_usuario([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cedula, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string apellido, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string direccion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> telefono, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string pass, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string uid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cedula, nombre, apellido, direccion, telefono, correo, pass, uid);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.select_categoria")]
		public ISingleResult<select_categoriaResult> select_categoria()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<select_categoriaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.select_producto_categoria")]
		public ISingleResult<select_producto_categoriaResult> select_producto_categoria([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string nombre_cat)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre_cat);
			return ((ISingleResult<select_producto_categoriaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.select_productos")]
		public ISingleResult<select_productosResult> select_productos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<select_productosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.update_carrito")]
		public int update_carrito([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string correo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id_producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), correo, id_producto, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.update_catalogo")]
		public int update_catalogo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_cat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string categoria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cod_cat, categoria);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.update_producto")]
		public int update_producto([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_prod, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string producto, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cod_cat, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string marca, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> precio, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> cantidad)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cod_prod, producto, cod_cat, marca, precio, cantidad);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.select_carrito")]
		public ISingleResult<select_carritoResult> select_carrito()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<select_carritoResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.categoria")]
	public partial class categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cod_cat;
		
		private string _nombre_cat;
		
		private EntitySet<producto> _producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncod_catChanging(int value);
    partial void Oncod_catChanged();
    partial void Onnombre_catChanging(string value);
    partial void Onnombre_catChanged();
    #endregion
		
		public categoria()
		{
			this._producto = new EntitySet<producto>(new Action<producto>(this.attach_producto), new Action<producto>(this.detach_producto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_cat", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cod_cat
		{
			get
			{
				return this._cod_cat;
			}
			set
			{
				if ((this._cod_cat != value))
				{
					this.Oncod_catChanging(value);
					this.SendPropertyChanging();
					this._cod_cat = value;
					this.SendPropertyChanged("cod_cat");
					this.Oncod_catChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_cat", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre_cat
		{
			get
			{
				return this._nombre_cat;
			}
			set
			{
				if ((this._nombre_cat != value))
				{
					this.Onnombre_catChanging(value);
					this.SendPropertyChanging();
					this._nombre_cat = value;
					this.SendPropertyChanged("nombre_cat");
					this.Onnombre_catChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="categoria_producto", Storage="_producto", ThisKey="cod_cat", OtherKey="cod_cat")]
		public EntitySet<producto> producto
		{
			get
			{
				return this._producto;
			}
			set
			{
				this._producto.Assign(value);
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
		
		private void attach_producto(producto entity)
		{
			this.SendPropertyChanging();
			entity.categoria = this;
		}
		
		private void detach_producto(producto entity)
		{
			this.SendPropertyChanging();
			entity.categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.deseos")]
	public partial class deseos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cod_des;
		
		private int _cedula;
		
		private int _cod_prod;
		
		private int _cantidad;
		
		private EntityRef<producto> _producto;
		
		private EntityRef<usuarios> _usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncod_desChanging(int value);
    partial void Oncod_desChanged();
    partial void OncedulaChanging(int value);
    partial void OncedulaChanged();
    partial void Oncod_prodChanging(int value);
    partial void Oncod_prodChanged();
    partial void OncantidadChanging(int value);
    partial void OncantidadChanged();
    #endregion
		
		public deseos()
		{
			this._producto = default(EntityRef<producto>);
			this._usuarios = default(EntityRef<usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_des", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cod_des
		{
			get
			{
				return this._cod_des;
			}
			set
			{
				if ((this._cod_des != value))
				{
					this.Oncod_desChanging(value);
					this.SendPropertyChanging();
					this._cod_des = value;
					this.SendPropertyChanged("cod_des");
					this.Oncod_desChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="Int NOT NULL")]
		public int cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					if (this._usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_prod", DbType="Int NOT NULL")]
		public int cod_prod
		{
			get
			{
				return this._cod_prod;
			}
			set
			{
				if ((this._cod_prod != value))
				{
					if (this._producto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncod_prodChanging(value);
					this.SendPropertyChanging();
					this._cod_prod = value;
					this.SendPropertyChanged("cod_prod");
					this.Oncod_prodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this.OncantidadChanging(value);
					this.SendPropertyChanging();
					this._cantidad = value;
					this.SendPropertyChanged("cantidad");
					this.OncantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producto_deseos", Storage="_producto", ThisKey="cod_prod", OtherKey="cod_prod", IsForeignKey=true)]
		public producto producto
		{
			get
			{
				return this._producto.Entity;
			}
			set
			{
				producto previousValue = this._producto.Entity;
				if (((previousValue != value) 
							|| (this._producto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._producto.Entity = null;
						previousValue.deseos.Remove(this);
					}
					this._producto.Entity = value;
					if ((value != null))
					{
						value.deseos.Add(this);
						this._cod_prod = value.cod_prod;
					}
					else
					{
						this._cod_prod = default(int);
					}
					this.SendPropertyChanged("producto");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuarios_deseos", Storage="_usuarios", ThisKey="cedula", OtherKey="cedula", IsForeignKey=true)]
		public usuarios usuarios
		{
			get
			{
				return this._usuarios.Entity;
			}
			set
			{
				usuarios previousValue = this._usuarios.Entity;
				if (((previousValue != value) 
							|| (this._usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._usuarios.Entity = null;
						previousValue.deseos.Remove(this);
					}
					this._usuarios.Entity = value;
					if ((value != null))
					{
						value.deseos.Add(this);
						this._cedula = value.cedula;
					}
					else
					{
						this._cedula = default(int);
					}
					this.SendPropertyChanged("usuarios");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.producto")]
	public partial class producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cod_prod;
		
		private string _nombreprod;
		
		private int _cod_cat;
		
		private string _marca;
		
		private int _precio;
		
		private int _cantidad;
		
		private EntitySet<deseos> _deseos;
		
		private EntityRef<categoria> _categoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncod_prodChanging(int value);
    partial void Oncod_prodChanged();
    partial void OnnombreprodChanging(string value);
    partial void OnnombreprodChanged();
    partial void Oncod_catChanging(int value);
    partial void Oncod_catChanged();
    partial void OnmarcaChanging(string value);
    partial void OnmarcaChanged();
    partial void OnprecioChanging(int value);
    partial void OnprecioChanged();
    partial void OncantidadChanging(int value);
    partial void OncantidadChanged();
    #endregion
		
		public producto()
		{
			this._deseos = new EntitySet<deseos>(new Action<deseos>(this.attach_deseos), new Action<deseos>(this.detach_deseos));
			this._categoria = default(EntityRef<categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_prod", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cod_prod
		{
			get
			{
				return this._cod_prod;
			}
			set
			{
				if ((this._cod_prod != value))
				{
					this.Oncod_prodChanging(value);
					this.SendPropertyChanging();
					this._cod_prod = value;
					this.SendPropertyChanged("cod_prod");
					this.Oncod_prodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreprod", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreprod
		{
			get
			{
				return this._nombreprod;
			}
			set
			{
				if ((this._nombreprod != value))
				{
					this.OnnombreprodChanging(value);
					this.SendPropertyChanging();
					this._nombreprod = value;
					this.SendPropertyChanged("nombreprod");
					this.OnnombreprodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_cat", DbType="Int NOT NULL")]
		public int cod_cat
		{
			get
			{
				return this._cod_cat;
			}
			set
			{
				if ((this._cod_cat != value))
				{
					if (this._categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncod_catChanging(value);
					this.SendPropertyChanging();
					this._cod_cat = value;
					this.SendPropertyChanged("cod_cat");
					this.Oncod_catChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marca", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string marca
		{
			get
			{
				return this._marca;
			}
			set
			{
				if ((this._marca != value))
				{
					this.OnmarcaChanging(value);
					this.SendPropertyChanging();
					this._marca = value;
					this.SendPropertyChanged("marca");
					this.OnmarcaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Int NOT NULL")]
		public int precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this.OncantidadChanging(value);
					this.SendPropertyChanging();
					this._cantidad = value;
					this.SendPropertyChanged("cantidad");
					this.OncantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producto_deseos", Storage="_deseos", ThisKey="cod_prod", OtherKey="cod_prod")]
		public EntitySet<deseos> deseos
		{
			get
			{
				return this._deseos;
			}
			set
			{
				this._deseos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="categoria_producto", Storage="_categoria", ThisKey="cod_cat", OtherKey="cod_cat", IsForeignKey=true)]
		public categoria categoria
		{
			get
			{
				return this._categoria.Entity;
			}
			set
			{
				categoria previousValue = this._categoria.Entity;
				if (((previousValue != value) 
							|| (this._categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._categoria.Entity = null;
						previousValue.producto.Remove(this);
					}
					this._categoria.Entity = value;
					if ((value != null))
					{
						value.producto.Add(this);
						this._cod_cat = value.cod_cat;
					}
					else
					{
						this._cod_cat = default(int);
					}
					this.SendPropertyChanged("categoria");
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
		
		private void attach_deseos(deseos entity)
		{
			this.SendPropertyChanging();
			entity.producto = this;
		}
		
		private void detach_deseos(deseos entity)
		{
			this.SendPropertyChanging();
			entity.producto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios")]
	public partial class usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cedula;
		
		private string _nombre;
		
		private string _apellido;
		
		private string _direc;
		
		private System.Nullable<int> _telefono;
		
		private string _correo;
		
		private string _contraseña;
		
		private string _uid;
		
		private EntitySet<deseos> _deseos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncedulaChanging(int value);
    partial void OncedulaChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnapellidoChanging(string value);
    partial void OnapellidoChanged();
    partial void OndirecChanging(string value);
    partial void OndirecChanged();
    partial void OntelefonoChanging(System.Nullable<int> value);
    partial void OntelefonoChanged();
    partial void OncorreoChanging(string value);
    partial void OncorreoChanged();
    partial void OncontraseñaChanging(string value);
    partial void OncontraseñaChanged();
    partial void OnuidChanging(string value);
    partial void OnuidChanged();
    #endregion
		
		public usuarios()
		{
			this._deseos = new EntitySet<deseos>(new Action<deseos>(this.attach_deseos), new Action<deseos>(this.detach_deseos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cedula", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int cedula
		{
			get
			{
				return this._cedula;
			}
			set
			{
				if ((this._cedula != value))
				{
					this.OncedulaChanging(value);
					this.SendPropertyChanging();
					this._cedula = value;
					this.SendPropertyChanged("cedula");
					this.OncedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellido", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string apellido
		{
			get
			{
				return this._apellido;
			}
			set
			{
				if ((this._apellido != value))
				{
					this.OnapellidoChanging(value);
					this.SendPropertyChanging();
					this._apellido = value;
					this.SendPropertyChanged("apellido");
					this.OnapellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direc", DbType="VarChar(45)")]
		public string direc
		{
			get
			{
				return this._direc;
			}
			set
			{
				if ((this._direc != value))
				{
					this.OndirecChanging(value);
					this.SendPropertyChanging();
					this._direc = value;
					this.SendPropertyChanged("direc");
					this.OndirecChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="Int")]
		public System.Nullable<int> telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_correo", DbType="VarChar(50)")]
		public string correo
		{
			get
			{
				return this._correo;
			}
			set
			{
				if ((this._correo != value))
				{
					this.OncorreoChanging(value);
					this.SendPropertyChanging();
					this._correo = value;
					this.SendPropertyChanged("correo");
					this.OncorreoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contraseña", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string contraseña
		{
			get
			{
				return this._contraseña;
			}
			set
			{
				if ((this._contraseña != value))
				{
					this.OncontraseñaChanging(value);
					this.SendPropertyChanging();
					this._contraseña = value;
					this.SendPropertyChanged("contraseña");
					this.OncontraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", DbType="VarChar(MAX)")]
		public string uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuarios_deseos", Storage="_deseos", ThisKey="cedula", OtherKey="cedula")]
		public EntitySet<deseos> deseos
		{
			get
			{
				return this._deseos;
			}
			set
			{
				this._deseos.Assign(value);
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
		
		private void attach_deseos(deseos entity)
		{
			this.SendPropertyChanging();
			entity.usuarios = this;
		}
		
		private void detach_deseos(deseos entity)
		{
			this.SendPropertyChanging();
			entity.usuarios = null;
		}
	}
	
	public partial class select_categoriaResult
	{
		
		private string _nombre_cat;
		
		public select_categoriaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_cat", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre_cat
		{
			get
			{
				return this._nombre_cat;
			}
			set
			{
				if ((this._nombre_cat != value))
				{
					this._nombre_cat = value;
				}
			}
		}
	}
	
	public partial class select_producto_categoriaResult
	{
		
		private string _nombreprod;
		
		private string _marca;
		
		private string _nombre_cat;
		
		private int _precio;
		
		public select_producto_categoriaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreprod", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreprod
		{
			get
			{
				return this._nombreprod;
			}
			set
			{
				if ((this._nombreprod != value))
				{
					this._nombreprod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marca", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string marca
		{
			get
			{
				return this._marca;
			}
			set
			{
				if ((this._marca != value))
				{
					this._marca = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_cat", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre_cat
		{
			get
			{
				return this._nombre_cat;
			}
			set
			{
				if ((this._nombre_cat != value))
				{
					this._nombre_cat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Int NOT NULL")]
		public int precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
	}
	
	public partial class select_productosResult
	{
		
		private int _cod_prod;
		
		private string _nombreprod;
		
		private string _marca;
		
		private string _nombre_cat;
		
		private int _precio;
		
		private int _cantidad;
		
		public select_productosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_prod", DbType="Int NOT NULL")]
		public int cod_prod
		{
			get
			{
				return this._cod_prod;
			}
			set
			{
				if ((this._cod_prod != value))
				{
					this._cod_prod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreprod", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreprod
		{
			get
			{
				return this._nombreprod;
			}
			set
			{
				if ((this._nombreprod != value))
				{
					this._nombreprod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marca", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string marca
		{
			get
			{
				return this._marca;
			}
			set
			{
				if ((this._marca != value))
				{
					this._marca = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre_cat", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre_cat
		{
			get
			{
				return this._nombre_cat;
			}
			set
			{
				if ((this._nombre_cat != value))
				{
					this._nombre_cat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Int NOT NULL")]
		public int precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
	}
	
	public partial class select_carritoResult
	{
		
		private int _cod_des;
		
		private int _cod_prod;
		
		private string _nombreprod;
		
		private int _precio;
		
		private int _cantidad;
		
		public select_carritoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_des", DbType="Int NOT NULL")]
		public int cod_des
		{
			get
			{
				return this._cod_des;
			}
			set
			{
				if ((this._cod_des != value))
				{
					this._cod_des = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_prod", DbType="Int NOT NULL")]
		public int cod_prod
		{
			get
			{
				return this._cod_prod;
			}
			set
			{
				if ((this._cod_prod != value))
				{
					this._cod_prod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombreprod", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombreprod
		{
			get
			{
				return this._nombreprod;
			}
			set
			{
				if ((this._nombreprod != value))
				{
					this._nombreprod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Int NOT NULL")]
		public int precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Int NOT NULL")]
		public int cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
