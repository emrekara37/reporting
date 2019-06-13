using System.ComponentModel.DataAnnotations;

namespace Reporting.Business.Models
{
    public enum WaitingReason : short
    {
        [Display(Name = "Mola")]
        Break = 1,
        [Display(Name = "Arıza")]
        Fault = 2,
        [Display(Name = "Setup")]
        Setup = 3,
        [Display(Name = "Arge")]
        Rad = 4,

    }
}