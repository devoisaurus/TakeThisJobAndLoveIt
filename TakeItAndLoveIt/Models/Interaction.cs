using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeItAndLoveIt.Models
{
    public class Interaction
    {
        [Key]
        public int InteractionId { get; set; }

        [Required]
        public DateTime InteractionDate { get; set; }
        public string InteractionType { get; set; }
        public string InteractionNotes { get; set; }
    }
}