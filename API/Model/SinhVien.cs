using System.ComponentModel.DataAnnotations;

namespace API.Model
{
	public class SinhVien
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public int Age { get; set; }
	}
}
