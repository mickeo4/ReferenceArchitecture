//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate template.
// Code is generated on: 18/07/2012 07:55:54
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

namespace AdventureWorks.Domain
{

    /// <summary>
    /// General sales order information.
    /// </summary>
    public partial class SalesOrderHeader {

        private int _SalesOrderID;

        private byte _RevisionNumber;

        private System.DateTime _OrderDate;

        private System.DateTime _DueDate;

        private System.Nullable<System.DateTime> _ShipDate;

        private byte _Status;

        private bool _OnlineOrderFlag;

        private string _SalesOrderNumber;

        private string _PurchaseOrderNumber;

        private string _AccountNumber;

        private string _ShipMethod;

        private string _CreditCardApprovalCode;

        private decimal _SubTotal;

        private decimal _TaxAmt;

        private decimal _Freight;

        private decimal _TotalDue;

        private string _Comment;

        private System.Guid _Rowguid;

        private System.DateTime _ModifiedDate;

        private Iesi.Collections.ISet _SalesOrderDetails;

        private Customer _Customer;

        private Address _Address_ShipToAddressID;

        private Address _Address_BillToAddressID;
    
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public SalesOrderHeader()
        {
            this._SalesOrderDetails = new Iesi.Collections.HashedSet();
            OnCreated();
        }

    
        /// <summary>
        /// Primary key.
        /// </summary>
        public virtual int SalesOrderID
        {
            get
            {
                return this._SalesOrderID;
            }
            set
            {
                this._SalesOrderID = value;
            }
        }

    
        /// <summary>
        /// Incremental number to track changes to the sales order over time.
        /// </summary>
        public virtual byte RevisionNumber
        {
            get
            {
                return this._RevisionNumber;
            }
            set
            {
                this._RevisionNumber = value;
            }
        }

    
        /// <summary>
        /// Dates the sales order was created.
        /// </summary>
        public virtual System.DateTime OrderDate
        {
            get
            {
                return this._OrderDate;
            }
            set
            {
                this._OrderDate = value;
            }
        }

    
        /// <summary>
        /// Date the order is due to the customer.
        /// </summary>
        public virtual System.DateTime DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this._DueDate = value;
            }
        }

    
        /// <summary>
        /// Date the order was shipped to the customer.
        /// </summary>
        public virtual System.Nullable<System.DateTime> ShipDate
        {
            get
            {
                return this._ShipDate;
            }
            set
            {
                this._ShipDate = value;
            }
        }

    
        /// <summary>
        /// Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        /// </summary>
        public virtual byte Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this._Status = value;
            }
        }

    
        /// <summary>
        /// 0 = Order placed by sales person. 1 = Order placed online by customer.
        /// </summary>
        public virtual bool OnlineOrderFlag
        {
            get
            {
                return this._OnlineOrderFlag;
            }
            set
            {
                this._OnlineOrderFlag = value;
            }
        }

    
        /// <summary>
        /// Unique sales order identification number.
        /// </summary>
        public virtual string SalesOrderNumber
        {
            get
            {
                return this._SalesOrderNumber;
            }
            set
            {
                this._SalesOrderNumber = value;
            }
        }

    
        /// <summary>
        /// Customer purchase order number reference. 
        /// </summary>
        public virtual string PurchaseOrderNumber
        {
            get
            {
                return this._PurchaseOrderNumber;
            }
            set
            {
                this._PurchaseOrderNumber = value;
            }
        }

    
        /// <summary>
        /// Financial accounting number reference.
        /// </summary>
        public virtual string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this._AccountNumber = value;
            }
        }

    
        /// <summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        /// </summary>
        public virtual string ShipMethod
        {
            get
            {
                return this._ShipMethod;
            }
            set
            {
                this._ShipMethod = value;
            }
        }

    
        /// <summary>
        /// Approval code provided by the credit card company.
        /// </summary>
        public virtual string CreditCardApprovalCode
        {
            get
            {
                return this._CreditCardApprovalCode;
            }
            set
            {
                this._CreditCardApprovalCode = value;
            }
        }

    
        /// <summary>
        /// Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        /// </summary>
        public virtual decimal SubTotal
        {
            get
            {
                return this._SubTotal;
            }
            set
            {
                this._SubTotal = value;
            }
        }

    
        /// <summary>
        /// Tax amount.
        /// </summary>
        public virtual decimal TaxAmt
        {
            get
            {
                return this._TaxAmt;
            }
            set
            {
                this._TaxAmt = value;
            }
        }

    
        /// <summary>
        /// Shipping cost.
        /// </summary>
        public virtual decimal Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this._Freight = value;
            }
        }

    
        /// <summary>
        /// Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        /// </summary>
        public virtual decimal TotalDue
        {
            get
            {
                return this._TotalDue;
            }
            set
            {
                this._TotalDue = value;
            }
        }

    
        /// <summary>
        /// Sales representative comments.
        /// </summary>
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this._Comment = value;
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
        /// There are no comments for SalesOrderDetails in the schema.
        /// </summary>
        public virtual Iesi.Collections.ISet SalesOrderDetails
        {
            get
            {
                return this._SalesOrderDetails;
            }
            set
            {
                this._SalesOrderDetails = value;
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
        /// There are no comments for Address_ShipToAddressID in the schema.
        /// </summary>
        public virtual Address Address_ShipToAddressID
        {
            get
            {
                return this._Address_ShipToAddressID;
            }
            set
            {
                this._Address_ShipToAddressID = value;
            }
        }

    
        /// <summary>
        /// There are no comments for Address_BillToAddressID in the schema.
        /// </summary>
        public virtual Address Address_BillToAddressID
        {
            get
            {
                return this._Address_BillToAddressID;
            }
            set
            {
                this._Address_BillToAddressID = value;
            }
        }
    }

}
