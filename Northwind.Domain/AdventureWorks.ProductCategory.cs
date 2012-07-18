//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 18/07/2012 07:55:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace Northwind.Domain
{

    /// <summary>
    /// High-level product categorization.
    /// </summary>
    public partial class ProductCategory {

        private int _ProductCategoryID;

        private string _Name;

        private System.Guid _Rowguid;

        private System.DateTime _ModifiedDate;

        private Iesi.Collections.ISet _Products;

        private Iesi.Collections.ISet _ProductCategories_ParentProductCategoryID;

        private ProductCategory _ProductCategory_ParentProductCategoryID;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public ProductCategory()
        {
            this._Products = new Iesi.Collections.HashedSet();
            this._ProductCategories_ParentProductCategoryID = new Iesi.Collections.HashedSet();
            OnCreated();
        }

    
        /// <summary>
        /// Primary key for ProductCategory records.
        /// </summary>
        public virtual int ProductCategoryID
        {
            get
            {
                return this._ProductCategoryID;
            }
            set
            {
                this._ProductCategoryID = value;
            }
        }

    
        /// <summary>
        /// Category description.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

    
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
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
        /// There are no comments for Products in the schema.
        /// </summary>
        public virtual Iesi.Collections.ISet Products
        {
            get
            {
                return this._Products;
            }
            set
            {
                this._Products = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ProductCategories_ParentProductCategoryID in the schema.
        /// </summary>
        public virtual Iesi.Collections.ISet ProductCategories_ParentProductCategoryID
        {
            get
            {
                return this._ProductCategories_ParentProductCategoryID;
            }
            set
            {
                this._ProductCategories_ParentProductCategoryID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for ProductCategory_ParentProductCategoryID in the schema.
        /// </summary>
        public virtual ProductCategory ProductCategory_ParentProductCategoryID
        {
            get
            {
                return this._ProductCategory_ParentProductCategoryID;
            }
            set
            {
                this._ProductCategory_ParentProductCategoryID = value;
            }
        }
    }

}
