using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("Order")]
    public class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public  string OrderNo { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]               // specifying the format of date
        public DateTime OrderDate { get; set; }

        [Required]
        public string Items { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime ShipmentDate { get; set; }

        [Required]
        public int CustomerID { get; set; }

        public virtual Customer Customers { get; set; }
    }

}
