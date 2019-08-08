using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    public class Book : IValidatableObject
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}は必須です。")]
        [StringLength(100)]
        [DisplayName("書名")]
        public string Title { get; set; }

        [Range(0, 5000, ErrorMessage = "{0}は{1}～{2}円以内で入力してください。")]
        [DisplayName("価格")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [StringLength(100)]
        [DisplayName("出版社")]
        public string Publisher { get; set; }

        [DisplayName("配布サンプル")]
        public bool Sample { get; set; }

        [Range(1900, 2100)]
        [DisplayName("出版年")]
        public int PublishYear { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Publisher == "フリー文庫" && this.Price > 0)
            {
                yield return new ValidationResult("フリー文庫の価格は0円でなければなりません。", new[] { "Price" });
            }
        }
    }
}
