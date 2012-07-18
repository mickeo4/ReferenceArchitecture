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
    public class SalesOrderDetailMap : ClassMap<SalesOrderDetail>
    {
        public SalesOrderDetailMap()
        {
              Schema("SalesLT");
              Table("SalesOrderDetail");
              LazyLoad();
              CompositeId()
                .KeyProperty(x => x.SalesOrderID, set => {
                    set.Type("Int32");
                    set.ColumnName("SalesOrderID");
                    set.Access.Property(); } )
                .KeyProperty(x => x.SalesOrderDetailID, set => {
                    set.Type("Int32");
                    set.ColumnName("SalesOrderDetailID");
                    set.Access.Property(); } );
              Map(x => x.OrderQty)    
                .Column("OrderQty")
                .CustomType("Int16")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("smallint")
                .Not.Nullable()
                .Precision(5);
              Map(x => x.UnitPrice)    
                .Column("UnitPrice")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.UnitPriceDiscount)    
                .Column("UnitPriceDiscount")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Never()
                .Default("0.0")
                .CustomSqlType("money")
                .Not.Nullable()
                .Precision(19)
                .Scale(4);
              Map(x => x.LineTotal)    
                .Column("LineTotal")
                .CustomType("Decimal")
                .Access.Property()
                .Generated.Always()
                .CustomSqlType("numeric")
                .Not.Nullable()
                .Precision(38)
                .Scale(6);
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
              References(x => x.SalesOrderHeader)
                .Class<SalesOrderHeader>()
                .Access.Property()
                .Cascade.Delete()
                .LazyLoad()
                .Columns("SalesOrderID");
              References(x => x.Product)
                .Class<Product>()
                .Access.Property()
                .Cascade.None()
                .LazyLoad()
                .Columns("ProductID");
        }
    }

}
