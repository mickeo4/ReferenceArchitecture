//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using NHibernate Fluent Mapping template.
// Code is generated on: 18/07/2012 07:55:53
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.Collections;

namespace AdventureWorksLT2008Model
{
    public class SalesOrderHeaderMap : ClassMap<SalesOrderHeader>
    {
        public SalesOrderHeaderMap()
        {
              Schema("SalesLT");
              Table("SalesOrderHeader");
              LazyLoad();
              Id(x => x.SalesOrderID)
                .Column("SalesOrderID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("int")
                .Not.Nullable()
                .Precision(10)                
                .GeneratedBy.Identity();
              Map(x => x.RevisionNumber)    
                .Column("RevisionNumber")
                .CustomType("Byte")
                .Access.Property()
                .Generated.Never()
                .Default("0")
                .CustomSqlType("tinyint")
                .Not.Nullable()
                .Precision(3);
              Map(x => x.OrderDate)    
                .Column("OrderDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .Default("getdate()")
                .CustomSqlType("datetime")
                .Not.Nullable();
              Map(x => x.DueDate)    
                .Column("DueDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("datetime")
                .Not.Nullable();
              Map(x => x.ShipDate)    
                .Column("ShipDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("datetime");
              Map(x => x.Status)    
                .Column("Status")
                .CustomType("Byte")
                .Access.Property()
                .Generated.Never()
                .Default("1")
                .CustomSqlType("tinyint")
                .Not.Nullable()
                .Precision(3);
              Map(x => x.OnlineOrderFlag)    
                .Column("OnlineOrderFlag")
                .CustomType("Boolean")
                .Access.Property()
                .Generated.Never()
                .Default("1")
                .CustomSqlType("bit")
                .Not.Nullable();
              Map(x => x.SalesOrderNumber)    
                .Column("SalesOrderNumber")
                .CustomType("String")
                .Access.Property()
                .Generated.Always()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(25)
                .Unique();
              Map(x => x.PurchaseOrderNumber)    
                .Column("PurchaseOrderNumber")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(25);
              Map(x => x.AccountNumber)    
                .Column("AccountNumber")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(15);
              Map(x => x.ShipMethod)    
                .Column("ShipMethod")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(50);
              Map(x => x.CreditCardApprovalCode)    
                .Column("CreditCardApprovalCode")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("varchar")
                .Length(15);
              Map(x => x.SubTotal)    
                .Column("SubTotal")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .Default("0.00")
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.TaxAmt)    
                .Column("TaxAmt")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .Default("0.00")
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.Freight)    
                .Column("Freight")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .Default("0.00")
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.TotalDue)    
                .Column("TotalDue")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Always()
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.Comment)    
                .Column("Comment")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar");
              Map(x => x.Rowguid)    
                .Column("rowguid")
                .CustomType("Guid")
                .Access.Property()
                .Generated.Never()
                .Default("newid()")
                .CustomSqlType("uniqueidentifier")
                .Not.Nullable()
                .Unique();
              Map(x => x.ModifiedDate)    
                .Column("ModifiedDate")
                .CustomType("DateTime")
                .Access.Property()
                .Generated.Never()
                .Default("getdate()")
                .CustomSqlType("datetime")
                .Not.Nullable();
              HasMany<SalesOrderDetail>(x => x.SalesOrderDetails)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Not.Generic()
                .KeyColumns.Add("SalesOrderID", mapping => mapping.Name("SalesOrderID")
                                                                     .SqlType("int")
                                                                     .Not.Nullable());
              References(x => x.Customer)
                .Class<Customer>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("CustomerID");
              References(x => x.Address_ShipToAddressID)
                .Class<Address>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("ShipToAddressID");
              References(x => x.Address_BillToAddressID)
                .Class<Address>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("BillToAddressID");
        }
    }

}
