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
    /// Cross-reference table mapping customers to their address(es).
    /// </summary>
    public partial class CustomerAddress {

        private int _CustomerID;

        private int _AddressID;

        private string _AddressType;

        private System.Guid _Rowguid;

        private System.DateTime _ModifiedDate;

        private Customer _Customer;

        private Address _Address;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();

        public override bool Equals(object obj)
        {
          CustomerAddress toCompare = obj as CustomerAddress;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.CustomerID, toCompare.CustomerID))
            return false;
          if (!Object.Equals(this.AddressID, toCompare.AddressID))
            return false;
          
          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + CustomerID.GetHashCode();
          hashCode = (hashCode * 7) + AddressID.GetHashCode();
          return hashCode;
        }
        
        #endregion

        public CustomerAddress()
        {
            OnCreated();
        }

    
        /// <summary>
        /// Primary key. Foreign key to Customer.CustomerID.
        /// </summary>
        public virtual int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }

    
        /// <summary>
        /// Primary key. Foreign key to Address.AddressID.
        /// </summary>
        public virtual int AddressID
        {
            get
            {
                return this._AddressID;
            }
            set
            {
                this._AddressID = value;
            }
        }

    
        /// <summary>
        /// The kind of Address. One of: Archive, Billing, Home, Main Office, Primary, Shipping
        /// </summary>
        public virtual string AddressType
        {
            get
            {
                return this._AddressType;
            }
            set
            {
                this._AddressType = value;
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
        /// There are no comments for Customer in the schema.
        /// </summary>
        public virtual Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this._Customer = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Address in the schema.
        /// </summary>
        public virtual Address Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                this._Address = value;
            }
        }
    }

}
