//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 18/07/2012 07:55:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;

namespace Northwind.Domain
{

    /// <summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    /// </summary>
    public partial class ProductModelProductDescription {

        private int _ProductModelID;

        private int _ProductDescriptionID;

        private string _Culture;

        private System.Guid _Rowguid;

        private System.DateTime _ModifiedDate;

        private ProductDescription _ProductDescription;

        private ProductModel _ProductModel;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          ProductModelProductDescription toCompare = obj as ProductModelProductDescription;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.ProductModelID, toCompare.ProductModelID))
            return false;
          if (!Object.Equals(this.ProductDescriptionID, toCompare.ProductDescriptionID))
            return false;
          if (!Object.Equals(this.Culture, toCompare.Culture))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + ProductModelID.GetHashCode();
          hashCode = (hashCode * 7) + ProductDescriptionID.GetHashCode();
          hashCode = (hashCode * 7) + Culture.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public ProductModelProductDescription()
        {
            OnCreated();
        }

    
        /// <summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public virtual int ProductModelID
        {
            get
            {
                return this._ProductModelID;
            }
            set
            {
                this._ProductModelID = value;
            }
        }

    
        /// <summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        /// </summary>
        public virtual int ProductDescriptionID
        {
            get
            {
                return this._ProductDescriptionID;
            }
            set
            {
                this._ProductDescriptionID = value;
            }
        }

    
        /// <summary>
        /// The culture for which the description is written
        /// </summary>
        public virtual string Culture
        {
            get
            {
                return this._Culture;
            }
            set
            {
                this._Culture = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Rowguid in the schema.
        /// </summary>
        public virtual System.Guid Rowguid
        {
            get
            {
                return this._Rowguid;
            }
            set
            {
                this._Rowguid = value;
            }
        }

    
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public virtual System.DateTime ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this._ModifiedDate = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ProductDescription in the schema.
        /// </summary>
        public virtual ProductDescription ProductDescription
        {
            get
            {
                return this._ProductDescription;
            }
            set
            {
                this._ProductDescription = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ProductModel in the schema.
        /// </summary>
        public virtual ProductModel ProductModel
        {
            get
            {
                return this._ProductModel;
            }
            set
            {
                this._ProductModel = value;
            }
        }
    }

}
