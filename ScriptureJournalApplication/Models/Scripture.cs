using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournalApplication.Models
{
    
        public class Scripture
        {
            public int ID { get; set; }

            [StringLength(60, MinimumLength = 3)]
            [Required]
            public string Book { get; set; }

            [Range(1, 200)]
            [Required]
            public int Chapter { get; set; }

            
            [Range(1, 200)]
            [Required]
             public int Verse { get; set; }

            [StringLength(200, MinimumLength = 1)]
            [Required]
             public string Content { get; set;}

            [StringLength(200, MinimumLength = 1)]
            [Required]
            public string Note { get; set; }

            [DataType(DataType.Date)]
            [Required]
            public string Date { get; set; }
    }
}
