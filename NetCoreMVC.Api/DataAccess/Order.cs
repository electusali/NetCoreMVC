using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Api.DataAccess
{
	public class Order
	{
		[Column("OrderId")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required]
		public int OrderId { get; set; }
		[Column("OrderDate")]
		[Required]
		public DateTime OrderDate { get; set; }
		[Required]
		public int CustomerId { get; set; }
	}
}
