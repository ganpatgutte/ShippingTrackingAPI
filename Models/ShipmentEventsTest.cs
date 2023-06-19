using System;
using System.Collections.Generic;

namespace ShippingTrackingAPI.Models;

public partial class ShipmentEventsTest
{
    public Guid Id { get; set; }

    public Guid Shipmentid { get; set; }

    public Guid? Trackingcodevalueid { get; set; }

    public Guid? Exportid { get; set; }

    public Guid? Containertrackingeventid { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Eventdt { get; set; }

    public DateTime Lastmodified { get; set; }

    public string? City { get; set; }

    public string? Iso { get; set; }

    public string? Eventdesc { get; set; }

    public string? Localevent { get; set; }

    public string? Orgeventdesc { get; set; }

    public Guid? Accountid { get; set; }

    public string? Eventsource { get; set; }

    public string? Eventstate { get; set; }

    public string? Orgeventcode { get; set; }

    public DateTime? Carrierdeliveryestimate { get; set; }
}
