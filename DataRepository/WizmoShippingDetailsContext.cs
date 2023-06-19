using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShippingTrackingAPI.Models;

namespace ShippingTrackingAPI.DataRepository;

public partial class WizmoShippingDetailsContext : DbContext
{
    public WizmoShippingDetailsContext()
    {
    }

    public WizmoShippingDetailsContext(DbContextOptions<WizmoShippingDetailsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ShipmentEventsTest> ShipmentEventsTests { get; set; }

    public virtual DbSet<ShipmentTest> ShipmentTests { get; set; }

    public virtual DbSet<Trackingcodevalue> Trackingcodevalues { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<ShipmentEventsTest>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("ShipmentEvents_Test");

    //        entity.Property(e => e.Accountid).HasColumnName("accountid");
    //        entity.Property(e => e.Carrierdeliveryestimate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("carrierdeliveryestimate");
    //        entity.Property(e => e.City)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("city");
    //        entity.Property(e => e.Containertrackingeventid).HasColumnName("containertrackingeventid");
    //        entity.Property(e => e.Created)
    //            .HasColumnType("datetime")
    //            .HasColumnName("created");
    //        entity.Property(e => e.Eventdesc)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("eventdesc");
    //        entity.Property(e => e.Eventdt)
    //            .HasColumnType("datetime")
    //            .HasColumnName("eventdt");
    //        entity.Property(e => e.Eventsource)
    //            .HasMaxLength(10)
    //            .IsUnicode(false)
    //            .HasColumnName("eventsource");
    //        entity.Property(e => e.Eventstate)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("eventstate");
    //        entity.Property(e => e.Exportid).HasColumnName("exportid");
    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.Iso)
    //            .HasMaxLength(2)
    //            .IsUnicode(false)
    //            .HasColumnName("iso");
    //        entity.Property(e => e.Lastmodified)
    //            .HasColumnType("datetime")
    //            .HasColumnName("lastmodified");
    //        entity.Property(e => e.Localevent)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("localevent");
    //        entity.Property(e => e.Orgeventcode)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("orgeventcode");
    //        entity.Property(e => e.Orgeventdesc)
    //            .HasMaxLength(150)
    //            .IsUnicode(false)
    //            .HasColumnName("orgeventdesc");
    //        entity.Property(e => e.Shipmentid).HasColumnName("shipmentid");
    //        entity.Property(e => e.Trackingcodevalueid).HasColumnName("trackingcodevalueid");
    //    });

    //    modelBuilder.Entity<ShipmentTest>(entity =>
    //    {
    //        entity
    //            .HasNoKey()
    //            .ToTable("Shipment_Test");

    //        entity.Property(e => e.Id).HasColumnName("id");
    //        entity.Property(e => e.Shipmentdate)
    //            .HasColumnType("datetime")
    //            .HasColumnName("shipmentdate");
    //        entity.Property(e => e.Trackingnumber)
    //            .HasMaxLength(50)
    //            .IsUnicode(false)
    //            .HasColumnName("trackingnumber");
    //    });

    //    modelBuilder.Entity<Trackingcodevalue>(entity =>
    //    {
    //        entity.ToTable("trackingcodevalue");

    //        entity.Property(e => e.Id)
    //            .HasDefaultValueSql("(newsequentialid())")
    //            .HasColumnName("id");
    //        entity.Property(e => e.Carrierscanevent)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("carrierscanevent");
    //        entity.Property(e => e.Code)
    //            .HasMaxLength(100)
    //            .IsUnicode(false)
    //            .HasColumnName("code");
    //        entity.Property(e => e.Comment)
    //            .IsUnicode(false)
    //            .HasColumnName("comment");
    //        entity.Property(e => e.Created)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("created");
    //        entity.Property(e => e.Delconfirm)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("delconfirm");
    //        entity.Property(e => e.Delivered)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("delivered");
    //        entity.Property(e => e.Delsuccess)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("delsuccess");
    //        entity.Property(e => e.Event)
    //            .HasMaxLength(250)
    //            .IsUnicode(false)
    //            .HasColumnName("event");
    //        entity.Property(e => e.Lastmodified)
    //            .HasDefaultValueSql("(getdate())")
    //            .HasColumnType("datetime")
    //            .HasColumnName("lastmodified");
    //        entity.Property(e => e.Milestone).HasColumnName("milestone");
    //        entity.Property(e => e.Sharewithcustomer)
    //            .HasMaxLength(1)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("sharewithcustomer");
    //        entity.Property(e => e.Shipenginestatus)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("shipenginestatus");
    //        entity.Property(e => e.Shipenginestatuscode)
    //            .HasMaxLength(2)
    //            .IsUnicode(false)
    //            .IsFixedLength()
    //            .HasColumnName("shipenginestatuscode");
    //        entity.Property(e => e.Trackingcode)
    //            .HasMaxLength(25)
    //            .IsUnicode(false)
    //            .HasColumnName("trackingcode");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
