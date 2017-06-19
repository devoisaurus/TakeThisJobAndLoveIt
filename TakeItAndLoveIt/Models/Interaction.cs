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
        [DataType(DataType.DateTime)]
        public DateTime InteractionDate { get; set; }
        [Required]
        public string InteractionType { get; set; }

        public string InteractionNotes { get; set; }
    }
}