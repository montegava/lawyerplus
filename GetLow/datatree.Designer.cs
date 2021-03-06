﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace GetLow
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class dataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dataEntities object using the connection string found in the 'dataEntities' section of the application configuration file.
        /// </summary>
        public dataEntities() : base("name=dataEntities", "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dataEntities object.
        /// </summary>
        public dataEntities(string connectionString) : base(connectionString, "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dataEntities object.
        /// </summary>
        public dataEntities(EntityConnection connection) : base(connection, "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<data> data
        {
            get
            {
                if ((_data == null))
                {
                    _data = base.CreateObjectSet<data>("data");
                }
                return _data;
            }
        }
        private ObjectSet<data> _data;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the data EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTodata(data data)
        {
            base.AddObject("data", data);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dataModel", Name="data")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class data : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new data object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="position">Initial value of the position property.</param>
        public static data Createdata(global::System.Int64 id, global::System.String name, global::System.Int64 position)
        {
            data data = new data();
            data.id = id;
            data.name = name;
            data.position = position;
            return data;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int64 _id;
        partial void OnidChanging(global::System.Int64 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String site_id
        {
            get
            {
                return _site_id;
            }
            set
            {
                Onsite_idChanging(value);
                ReportPropertyChanging("site_id");
                _site_id = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("site_id");
                Onsite_idChanged();
            }
        }
        private global::System.String _site_id;
        partial void Onsite_idChanging(global::System.String value);
        partial void Onsite_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> parent_id
        {
            get
            {
                return _parent_id;
            }
            set
            {
                Onparent_idChanging(value);
                ReportPropertyChanging("parent_id");
                _parent_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("parent_id");
                Onparent_idChanged();
            }
        }
        private Nullable<global::System.Int64> _parent_id;
        partial void Onparent_idChanging(Nullable<global::System.Int64> value);
        partial void Onparent_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String parent_site_id
        {
            get
            {
                return _parent_site_id;
            }
            set
            {
                Onparent_site_idChanging(value);
                ReportPropertyChanging("parent_site_id");
                _parent_site_id = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("parent_site_id");
                Onparent_site_idChanged();
            }
        }
        private global::System.String _parent_site_id;
        partial void Onparent_site_idChanging(global::System.String value);
        partial void Onparent_site_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String data_text
        {
            get
            {
                return _data_text;
            }
            set
            {
                Ondata_textChanging(value);
                ReportPropertyChanging("data_text");
                _data_text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("data_text");
                Ondata_textChanged();
            }
        }
        private global::System.String _data_text;
        partial void Ondata_textChanging(global::System.String value);
        partial void Ondata_textChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String data_rtf
        {
            get
            {
                return _data_rtf;
            }
            set
            {
                Ondata_rtfChanging(value);
                ReportPropertyChanging("data_rtf");
                _data_rtf = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("data_rtf");
                Ondata_rtfChanged();
            }
        }
        private global::System.String _data_rtf;
        partial void Ondata_rtfChanging(global::System.String value);
        partial void Ondata_rtfChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 position
        {
            get
            {
                return _position;
            }
            set
            {
                OnpositionChanging(value);
                ReportPropertyChanging("position");
                _position = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("position");
                OnpositionChanged();
            }
        }
        private global::System.Int64 _position;
        partial void OnpositionChanging(global::System.Int64 value);
        partial void OnpositionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> is_doc
        {
            get
            {
                return _is_doc;
            }
            set
            {
                Onis_docChanging(value);
                ReportPropertyChanging("is_doc");
                _is_doc = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("is_doc");
                Onis_docChanged();
            }
        }
        private Nullable<global::System.Boolean> _is_doc;
        partial void Onis_docChanging(Nullable<global::System.Boolean> value);
        partial void Onis_docChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> is_loaded
        {
            get
            {
                return _is_loaded;
            }
            set
            {
                Onis_loadedChanging(value);
                ReportPropertyChanging("is_loaded");
                _is_loaded = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("is_loaded");
                Onis_loadedChanged();
            }
        }
        private Nullable<global::System.Boolean> _is_loaded;
        partial void Onis_loadedChanging(Nullable<global::System.Boolean> value);
        partial void Onis_loadedChanged();

        #endregion

    
    }

    #endregion

    
}
