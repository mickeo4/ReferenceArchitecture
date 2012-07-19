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
using AdventureWorks.Domain;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.Collections;

namespace AdventureWorks.Repository
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
              Schema("SalesLT");
              Table("Address");
              LazyLoad();
              Id(x => x.AddressID)
                .Column("AddressID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("int")
                .Not.Nullable()
                .Precision(10)                
                .GeneratedBy.Identity();
              Map(x => x.AddressLine1)    
                .Column("AddressLine1")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(60);
              Map(x => x.AddressLine2)    
                .Column("AddressLine2")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(60);
              Map(x => x.City)    
                .Column("City")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(30);
              Map(x => x.StateProvince)    
                .Column("StateProvince")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(50);
              Map(x => x.CountryRegion)    
                .Column("CountryRegion")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(50);
              Map(x => x.PostalCode)    
                .Column("PostalCode")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(15);
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
              HasMany<CustomerAddress>(x => x.CustomerAddresses)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Not.Generic()
                .KeyColumns.Add("AddressID", mapping => mapping.Name("AddressID")
                                                                     .SqlType("int")
                                                                     .Not.Nullable());
              HasMany<SalesOrderHeader>(x => x.SalesOrderHeaders_ShipToAddressID)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Not.Generic()
                .KeyColumns.Add("ShipToAddressID", mapping => mapping.Name("ShipToAddressID")
                                                                     .SqlType("int")
                                                                     .Nullable());
              HasMany<SalesOrderHeader>(x => x.SalesOrderHeaders_BillToAddressID)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Not.Generic()
                .KeyColumns.Add("BillToAddressID", mapping => mapping.Name("BillToAddressID")
                                                                     .SqlType("int")
                                                                     .Nullable());
        }
    }

}