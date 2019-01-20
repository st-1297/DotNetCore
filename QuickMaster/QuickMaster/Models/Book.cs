using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    public class Book
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int Price { get; set; }

        public string Publisher { get; set; }

        public bool Sample { get; set; }

        [Range(1900, 2100)]
        public int PublishYear { get; set; }
    }
}
