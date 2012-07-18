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
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
              Schema("SalesLT");
              Table("Customer");
              LazyLoad();
              Id(x => x.CustomerID)
                .Column("CustomerID")
                .CustomType("Int32")
                .Access.Property()
                .CustomSqlType("int")
                .Not.Nullable()
                .Precision(10)                
                .GeneratedBy.Identity();
              Map(x => x.NameStyle)    
                .Column("NameStyle")
                .CustomType("Boolean")
                .Access.Property()
                .Generated.Never()
                .Default("0")
                .CustomSqlType("bit")
                .Not.Nullable();
              Map(x => x.Title)    
                .Column("Title")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(8);
              Map(x => x.FirstName)    
                .Column("FirstName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(50);
              Map(x => x.MiddleName)    
                .Column("MiddleName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(50);
              Map(x => x.LastName)    
                .Column("LastName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Not.Nullable()
                .Length(50);
              Map(x => x.Suffix)    
                .Column("Suffix")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(10);
              Map(x => x.CompanyName)    
                .Column("CompanyName")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(128);
              Map(x => x.SalesPerson)    
                .Column("SalesPerson")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(256);
              Map(x => x.EmailAddress)    
                .Column("EmailAddress")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(50);
              Map(x => x.Phone)    
                .Column("Phone")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("nvarchar")
                .Length(25);
              Map(x => x.PasswordHash)    
                .Column("PasswordHash")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("varchar")
                .Not.Nullable()
                .Length(128);
              Map(x => x.PasswordSalt)    
                .Column("PasswordSalt")
                .CustomType("String")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("varchar")
                .Not.Nullable()
                .Length(10);
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
                .KeyColumns.Add("CustomerID", mapping => mapping.Name("CustomerID")
                                                                     .SqlType("int")
                                                                     .Not.Nullable());
              HasMany<SalesOrderHeader>(x => x.SalesOrderHeaders)
                .Access.Property()
                .AsSet()
                .Cascade.None()
                .LazyLoad()
                // .OptimisticLock.Version() /*bug (or missing feature) in Fluent NHibernate*/
                .Inverse()
                .Not.Generic()
                .KeyColumns.Add("CustomerID", mapping => mapping.Name("CustomerID")
                                                                     .SqlType("int")
                                                                     .Not.Nullable());
        }
    }

}
