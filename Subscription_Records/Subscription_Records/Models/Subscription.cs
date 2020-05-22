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
        public int SubscriptionId { get; set; }

        [Required(ErrorMessage = "Subscription Date is required")]
        [Display(Name = "Subscription Date")]
        [DataType(DataType.Date)]
        public DateTime SubscriptionDate { get; set; }

     }
}

