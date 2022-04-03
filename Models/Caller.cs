using System;
using System.ComponentModel.DataAnnotations;

namespace MariaAndSonsInsLtd.Models
{
    public class Caller
    {
        [Key]
        //[ScaffoldColumn(false)]
        [StringLength(8)]
        [Display(Name = "Caller ID")]
        public string CallerId { get; set; }
        [Required]
        [Display(Name = "Call Date & Time")]
        public DateTime CallDate { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Caller Name")]
        public string CallerName { get; set; }
        [Required]
        [Display(Name = "Call Duration")]
        public double CallDuration { get; set; }
        [Required]
        [Display(Name = "Call Destination Number")]
        public string CallDestinationNumber { get; set; }
        [Required]
        [Display(Name = "Call Cost")]
        public double CallCost { get; set; }
        [Required]
        [Display(Name = "Call Type")]
        public string CallType { get; set; }
        [Required]
        [Display(Name = "Call Plan")]
        public string CallPlan { get; set; }
    }
}
