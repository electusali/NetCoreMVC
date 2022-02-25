using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVC.Api.DataAccess
{
	[Table("Customers")]
	public class Customer
	{
		[Column("CustomerId")]
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Required]
		public int CustomerId { get; set; }
		[Column("CustomerName")]
		[Required]
		[StringLength(100)]
		public string FirstName { get; set; }
		[ForeignKey("CustomerId")] 
		public virtual List<Order>Orders { get; set; }

	}
}
