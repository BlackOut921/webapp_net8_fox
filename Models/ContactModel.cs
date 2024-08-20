using System.ComponentModel.DataAnnotations;

namespace webapp_net8_fox.Models
{
	public class ContactModel
	{
		[Key]
		public int Id { get; set; }

		[Required, Display(Name="Name")]
		public string Name { get; set; } = string.Empty;

		[Required, Display(Name="Email")]
		public string Email { get; set; } = string.Empty;

		[Display(Name = "Project Details")]
		public string ProjectDetails { get; set; } = string.Empty;

		[Display(Name = "Project Budget")]
		public int ProjectBudget { get; set; } = 0;

		[Display(Name = "Project Date")]
		public DateTime ProjectDate { get; set; } = DateTime.Now;
	}
}
