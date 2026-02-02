using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class RefundViewModel
    {
        [Display(Name = "Tracking number")]
        public long TrackingNumber { get; set; }
    }
}
