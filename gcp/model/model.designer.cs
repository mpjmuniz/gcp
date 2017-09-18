﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcp.model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dadoscp")]
	public partial class modelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFuncionario(Funcionario instance);
    partial void UpdateFuncionario(Funcionario instance);
    partial void DeleteFuncionario(Funcionario instance);
    partial void InsertSexo(Sexo instance);
    partial void UpdateSexo(Sexo instance);
    partial void DeleteSexo(Sexo instance);
    partial void InsertInstrucao(Instrucao instance);
    partial void UpdateInstrucao(Instrucao instance);
    partial void DeleteInstrucao(Instrucao instance);
    #endregion
		
		public modelDataContext() : 
				base(global::gcp.Properties.Settings.Default.dadoscpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public modelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public modelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Funcionario> Funcionarios
		{
			get
			{
				return this.GetTable<Funcionario>();
			}
		}
		
		public System.Data.Linq.Table<Sexo> Sexos
		{
			get
			{
				return this.GetTable<Sexo>();
			}
		}
		
		public System.Data.Linq.Table<Instrucao> Instrucaos
		{
			get
			{
				return this.GetTable<Instrucao>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Funcionario")]
	public partial class Funcionario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private System.Nullable<char> _sexo;
		
		private System.Nullable<System.DateTime> _data_ingresso;
		
		private System.Nullable<System.DateTime> _data_nascimento;
		
		private string _RG;
		
		private string _CPF;
		
		private string _titulo;
		
		private string _carteira_de_trabalho;
		
		private string _endereco;
		
		private string _telefone;
		
		private System.Nullable<int> _instrucao;
		
		private EntityRef<Sexo> _Sexo1;
		
		private EntityRef<Instrucao> _Instrucao1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnsexoChanging(System.Nullable<char> value);
    partial void OnsexoChanged();
    partial void Ondata_ingressoChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_ingressoChanged();
    partial void Ondata_nascimentoChanging(System.Nullable<System.DateTime> value);
    partial void Ondata_nascimentoChanged();
    partial void OnRGChanging(string value);
    partial void OnRGChanged();
    partial void OnCPFChanging(string value);
    partial void OnCPFChanged();
    partial void OntituloChanging(string value);
    partial void OntituloChanged();
    partial void Oncarteira_de_trabalhoChanging(string value);
    partial void Oncarteira_de_trabalhoChanged();
    partial void OnenderecoChanging(string value);
    partial void OnenderecoChanged();
    partial void OntelefoneChanging(string value);
    partial void OntelefoneChanged();
    partial void OninstrucaoChanging(System.Nullable<int> value);
    partial void OninstrucaoChanged();
    #endregion
		
		public Funcionario()
		{
			this._Sexo1 = default(EntityRef<Sexo>);
			this._Instrucao1 = default(EntityRef<Instrucao>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="NVarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sexo", DbType="NChar(1)")]
		public System.Nullable<char> sexo
		{
			get
			{
				return this._sexo;
			}
			set
			{
				if ((this._sexo != value))
				{
					if (this._Sexo1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnsexoChanging(value);
					this.SendPropertyChanging();
					this._sexo = value;
					this.SendPropertyChanged("sexo");
					this.OnsexoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_ingresso", DbType="Date")]
		public System.Nullable<System.DateTime> data_ingresso
		{
			get
			{
				return this._data_ingresso;
			}
			set
			{
				if ((this._data_ingresso != value))
				{
					this.Ondata_ingressoChanging(value);
					this.SendPropertyChanging();
					this._data_ingresso = value;
					this.SendPropertyChanged("data_ingresso");
					this.Ondata_ingressoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_data_nascimento", DbType="Date")]
		public System.Nullable<System.DateTime> data_nascimento
		{
			get
			{
				return this._data_nascimento;
			}
			set
			{
				if ((this._data_nascimento != value))
				{
					this.Ondata_nascimentoChanging(value);
					this.SendPropertyChanging();
					this._data_nascimento = value;
					this.SendPropertyChanged("data_nascimento");
					this.Ondata_nascimentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RG", DbType="NChar(9)")]
		public string RG
		{
			get
			{
				return this._RG;
			}
			set
			{
				if ((this._RG != value))
				{
					this.OnRGChanging(value);
					this.SendPropertyChanging();
					this._RG = value;
					this.SendPropertyChanged("RG");
					this.OnRGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CPF", DbType="NChar(11)")]
		public string CPF
		{
			get
			{
				return this._CPF;
			}
			set
			{
				if ((this._CPF != value))
				{
					this.OnCPFChanging(value);
					this.SendPropertyChanging();
					this._CPF = value;
					this.SendPropertyChanged("CPF");
					this.OnCPFChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulo", DbType="NChar(12)")]
		public string titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if ((this._titulo != value))
				{
					this.OntituloChanging(value);
					this.SendPropertyChanging();
					this._titulo = value;
					this.SendPropertyChanged("titulo");
					this.OntituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carteira_de_trabalho", DbType="NVarChar(50)")]
		public string carteira_de_trabalho
		{
			get
			{
				return this._carteira_de_trabalho;
			}
			set
			{
				if ((this._carteira_de_trabalho != value))
				{
					this.Oncarteira_de_trabalhoChanging(value);
					this.SendPropertyChanging();
					this._carteira_de_trabalho = value;
					this.SendPropertyChanged("carteira_de_trabalho");
					this.Oncarteira_de_trabalhoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endereco", DbType="NVarChar(100)")]
		public string endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				if ((this._endereco != value))
				{
					this.OnenderecoChanging(value);
					this.SendPropertyChanging();
					this._endereco = value;
					this.SendPropertyChanged("endereco");
					this.OnenderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefone", DbType="NVarChar(11)")]
		public string telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if ((this._telefone != value))
				{
					this.OntelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("telefone");
					this.OntelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_instrucao", DbType="Int")]
		public System.Nullable<int> instrucao
		{
			get
			{
				return this._instrucao;
			}
			set
			{
				if ((this._instrucao != value))
				{
					if (this._Instrucao1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OninstrucaoChanging(value);
					this.SendPropertyChanging();
					this._instrucao = value;
					this.SendPropertyChanged("instrucao");
					this.OninstrucaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Funcionario", Storage="_Sexo1", ThisKey="sexo", OtherKey="abreviacao", IsForeignKey=true)]
		public Sexo Sexo1
		{
			get
			{
				return this._Sexo1.Entity;
			}
			set
			{
				Sexo previousValue = this._Sexo1.Entity;
				if (((previousValue != value) 
							|| (this._Sexo1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sexo1.Entity = null;
						previousValue.Funcionarios.Remove(this);
					}
					this._Sexo1.Entity = value;
					if ((value != null))
					{
						value.Funcionarios.Add(this);
						this._sexo = value.abreviacao;
					}
					else
					{
						this._sexo = default(Nullable<char>);
					}
					this.SendPropertyChanged("Sexo1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Instrucao_Funcionario", Storage="_Instrucao1", ThisKey="instrucao", OtherKey="id", IsForeignKey=true)]
		public Instrucao Instrucao1
		{
			get
			{
				return this._Instrucao1.Entity;
			}
			set
			{
				Instrucao previousValue = this._Instrucao1.Entity;
				if (((previousValue != value) 
							|| (this._Instrucao1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Instrucao1.Entity = null;
						previousValue.Funcionarios.Remove(this);
					}
					this._Instrucao1.Entity = value;
					if ((value != null))
					{
						value.Funcionarios.Add(this);
						this._instrucao = value.id;
					}
					else
					{
						this._instrucao = default(Nullable<int>);
					}
					this.SendPropertyChanged("Instrucao1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sexo")]
	public partial class Sexo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _nome;
		
		private char _abreviacao;
		
		private EntitySet<Funcionario> _Funcionarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnabreviacaoChanging(char value);
    partial void OnabreviacaoChanged();
    #endregion
		
		public Sexo()
		{
			this._Funcionarios = new EntitySet<Funcionario>(new Action<Funcionario>(this.attach_Funcionarios), new Action<Funcionario>(this.detach_Funcionarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_abreviacao", DbType="NChar(1) NOT NULL", IsPrimaryKey=true)]
		public char abreviacao
		{
			get
			{
				return this._abreviacao;
			}
			set
			{
				if ((this._abreviacao != value))
				{
					this.OnabreviacaoChanging(value);
					this.SendPropertyChanging();
					this._abreviacao = value;
					this.SendPropertyChanged("abreviacao");
					this.OnabreviacaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sexo_Funcionario", Storage="_Funcionarios", ThisKey="abreviacao", OtherKey="sexo")]
		public EntitySet<Funcionario> Funcionarios
		{
			get
			{
				return this._Funcionarios;
			}
			set
			{
				this._Funcionarios.Assign(value);
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
		
		private void attach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo1 = this;
		}
		
		private void detach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Sexo1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instrucao")]
	public partial class Instrucao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _nome;
		
		private int _id;
		
		private EntitySet<Funcionario> _Funcionarios;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    #endregion
		
		public Instrucao()
		{
			this._Funcionarios = new EntitySet<Funcionario>(new Action<Funcionario>(this.attach_Funcionarios), new Action<Funcionario>(this.detach_Funcionarios));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="NVarChar(50)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Instrucao_Funcionario", Storage="_Funcionarios", ThisKey="id", OtherKey="instrucao")]
		public EntitySet<Funcionario> Funcionarios
		{
			get
			{
				return this._Funcionarios;
			}
			set
			{
				this._Funcionarios.Assign(value);
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
		
		private void attach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Instrucao1 = this;
		}
		
		private void detach_Funcionarios(Funcionario entity)
		{
			this.SendPropertyChanging();
			entity.Instrucao1 = null;
		}
	}
}
#pragma warning restore 1591
