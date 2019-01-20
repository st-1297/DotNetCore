using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
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
        [DisplayName("書名")]
        public string Title { get; set; }

        [Range(0, 10000)]
        [DisplayName("価格")]
        public int Price { get; set; }

        [StringLength(100)]
        [DisplayName("出版社")]
        public string Publisher { get; set; }

        [DisplayName("配布サンプル")]
        public bool Sample { get; set; }

        [Range(1900, 2100)]
        [DisplayName("出版年")]
        public int PublishYear { get; set; }
    }
}
