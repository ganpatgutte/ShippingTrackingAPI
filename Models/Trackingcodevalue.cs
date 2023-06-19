using System;
using System.Collections.Generic;

namespace ShippingTrackingAPI.Models;

public partial class Trackingcodevalue
{
    public Guid Id { get; set; }

    public Guid? Milestone { get; set; }

    public DateTime? Created { get; set; }

    public string? Event { get; set; }

    public string? Trackingcode { get; set; }

    public string? Comment { get; set; }

    public string? Sharewithcustomer { get; set; }

    public string? Code { get; set; }

    public string? Delivered { get; set; }

    public DateTime Lastmodified { get; set; }

    public string? Carrierscanevent { get; set; }

    public string? Delconfirm { get; set; }

    public string? Delsuccess { get; set; }

    public string? Shipenginestatuscode { get; set; }

    public string? Shipenginestatus { get; set; }
}
