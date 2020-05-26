using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Subscription_Records.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }

        [Required(ErrorMessage = "Service subscription date is required")]
        [Display(Name = "Subscription Date")]
        [DataType(DataType.Date)]
        public DateTime SubscriptionDate { get; set; }

        [Required(ErrorMessage = "Service title is required")]
        [Display(Name = "Service")]
        [StringLength(50, ErrorMessage = "Please shorten the service title to 50 characters")]
        public string Service { get; set; }

        [Required(ErrorMessage = "Customer name is required")]
        [Display(Name = "Customer")]
        [StringLength(50, ErrorMessage = "Please shorten the customer name to 50 characters")]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Account number is required")]
        [Display(Name = "Account")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Account number should have positive value")]
        public int Account { get; set; }

        [Required(ErrorMessage = "Service start date is required")]
        [Display(Name = "Service Start Date")]
        [DataType(DataType.Date)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ServiceStartDate { get; set; }

        [Required(ErrorMessage = "Service end date is required")]
        [Display(Name = "Service End Date")]
        [DataType(DataType.Date)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime ServiceEndDate { get; set; }

        [Required(ErrorMessage = "Billing date is required")]
        [Display(Name = "Billing Date")]
        [DataType(DataType.Date)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime BillingDate { get; set; }

        [Required(ErrorMessage = "Payment date is required")]
        [Display(Name = "Payment Date")]
        [DataType(DataType.Date)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Payment due date is required")]
        [Display(Name = "Payment Due Date")]
        [DataType(DataType.Date)]
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime PaymentDueDate { get; set; }

        [Required(ErrorMessage = "Balance is required")]
        [Display(Name = "Balance")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Range(0.00, 999999.99, ErrorMessage = "Balance should have positive value and less than 1M")]
        public double Balance { get; set; }
    }
}

