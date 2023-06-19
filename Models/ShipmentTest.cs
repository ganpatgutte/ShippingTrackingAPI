using System;
using System.Collections.Generic;

namespace ShippingTrackingAPI.Models;

public partial class ShipmentTest
{
    public Guid Id { get; set; }

    public DateTime? Shipmentdate { get; set; }

    public string? Trackingnumber { get; set; }
}
