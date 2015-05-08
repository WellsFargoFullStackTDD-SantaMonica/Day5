using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdventureWorksDAL
{
    [Table("Production.Product")]
    public class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Color { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        public decimal CalculateSalesTax()
        {
            if (this.ListPrice < 0) 
                throw new System.ArgumentOutOfRangeException();
            return this.ListPrice * .10M;
        }

        public virtual string ToTimeZoneTime(System.DateTime dateTime,
            string timeZoneId = "Pacific Standard Time")
        {
            TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, tzi).ToString();
        }
    }
}