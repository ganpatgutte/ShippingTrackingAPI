using System.ComponentModel;

namespace ShippingTrackingAPI.Models
{
    public class ShippingTrackingStatus
    {
        public string? TrackingNumber { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string? ShippingStatus { get; set; }
        public DateTime? StatusDate { get; set; }
    }
}
