using System.Collections.Generic;

namespace VideoProject.Dtos
{
	public class RentalDto
	{
		public int CustomerId { get; set; }
		public List<int> MovieIds { get; set; }
	}
}